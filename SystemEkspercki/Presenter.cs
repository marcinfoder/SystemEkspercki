using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    /// <summary>
    /// Presenter class.
    /// </summary>
    public class Presenter : IPresenter
    {
        /// <summary>
        /// Inference module
        /// </summary>
        private readonly IInferenceModule inferenceModule;

        private readonly IDataAccessLayer dataAccessLayer;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inferenceModule">Inference module</param>
        /// <param name="dataAccessLayer">Data access layer</param>
        public Presenter(IInferenceModule inferenceModule, IDataAccessLayer dataAccessLayer)
        {
            this.inferenceModule = inferenceModule;
            this.dataAccessLayer = dataAccessLayer;
        }

        /// <summary>
        /// Adds checkbox to panel
        /// </summary>
        /// <param name="panel">Panel</param>
        public void AddCheckBoxs(TableLayoutPanel panel)
        {
            var questions = inferenceModule.Questions;
            var checkBoxs = questions.Select(question => new ThreeStateCheckBox(question.Id, question.Content)).ToArray();

            foreach (ThreeStateCheckBox checkBox in checkBoxs)
            {
                RowStyle style = new RowStyle(SizeType.Absolute, 25);
                panel.RowStyles.Add(style);
                int index = panel.RowCount;
                panel.Controls.Add(checkBox, 0, index);
                panel.RowCount++;
            }
        }

        /// <summary>
        /// Start the inference module
        /// </summary>
        /// <param name="panel">Panel</param>
        /// <param name="logContainer">Panel</param>
        public void StartInferenceModule(TableLayoutPanel panel, RichTextBox logContainer)
        {
            var answers = InterpretCheckBoxs(panel);
            string log = string.Empty;
            inferenceModule.InferenceProces(answers, out log);
            logContainer.Text = log;
        }

        /// <summary>
        /// Load knowledge editor
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="cbRules"></param>
        /// <param name="lbAllFacts"></param>
        /// <param name="rulesCreatingFact"></param>
        /// <param name="lbFactElement"></param>
        public void LoadKnowledgeEditorModule(ComboBox comboBox, ComboBox cbRules, ListBox lbAllFacts, ComboBox rulesCreatingFact, ListBox lbFactElement)
        {
            foreach (Fact fact in inferenceModule.Facts)
            {
                FactComboBoxItem factComboBoxItem = new FactComboBoxItem
                {
                    Id = fact.Id,
                    Name = fact.Name
                };

                comboBox.Items.Add(factComboBoxItem);
                rulesCreatingFact.Items.Add(factComboBoxItem);
                lbAllFacts.Items.Add(factComboBoxItem);
                lbFactElement.Items.Add(factComboBoxItem);
            }

            inferenceModule.Questions.ForEach(q => cbRules.Items.Add(new RuleComboBoxItem
            {
                Id = q.Rule.Id,
                Name = q.Rule.Name,
            }));
        }

        /// <summary>
        /// Interpret the chechbox
        /// </summary>
        /// <param name="panel">Panel</param>
        /// <returns>Anserws which was marked on panel</returns>
        public List<Answer> InterpretCheckBoxs(TableLayoutPanel panel)
        {
            List<ThreeStateCheckBox> checkBoxs =  panel.Controls.OfType<ThreeStateCheckBox>().ToList();
            return checkBoxs.Select(c => new Answer
            {
                QuestionId = c.QuestionId,
                Value = c.Value
            }).ToList();
        }

        /// <summary>
        /// Add new fact to database
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="listBox"></param>
        /// <param name="ruleCreatingFact"></param>
        public void AddFact(ComboBox comboBox, ListBox listBox, ComboBox ruleCreatingFact)
        {
            string name = comboBox.Text;

            Guid guid = dataAccessLayer.InsertFact(name);
            FactComboBoxItem factComboBoxItem = new FactComboBoxItem
            {
                Id = guid,
                Name = name
            };

            comboBox.Items.Add(factComboBoxItem);
            listBox.Items.Add(factComboBoxItem);
            ruleCreatingFact.Items.Add(factComboBoxItem);
            comboBox.SelectedItem = factComboBoxItem;

            inferenceModule.Facts.Add(new Fact
            {
                Id = guid,
                Name = name
            });
        }

        /// <summary>
        /// Remove fact
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="index"></param>
        public void RemoveFact(ComboBox comboBox, int index)
        {
            FactComboBoxItem factComboBoxItem = comboBox.Items[index] as FactComboBoxItem;
            comboBox.Items.Remove(factComboBoxItem);
            comboBox.SelectedIndex = 0;
            Guid guid = factComboBoxItem.Id;

            dataAccessLayer.DeleteFact(factComboBoxItem.Id);
            inferenceModule.Facts.RemoveAll(f => f.Id == guid);
        }

        /// <summary>
        /// Update fact
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="index"></param>
        public void UpdateFact(ComboBox comboBox, int index)
        {
            FactComboBoxItem factComboBoxItem = comboBox.Items[index] as FactComboBoxItem;
            comboBox.Items.RemoveAt(index);

            factComboBoxItem.Name = comboBox.Text;
            int addedIndex = comboBox.Items.Add(factComboBoxItem);
            comboBox.SelectedIndex = addedIndex;

            Guid guid = factComboBoxItem.Id;
            dataAccessLayer.UpdateFact(guid, factComboBoxItem.Name);
            inferenceModule.Facts.Find(f => f.Id == guid).Name = factComboBoxItem.Name;
        }

        /// <summary>
        /// Update label
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="label"></param>
        public void UpdateRuleLabel(ComboBox comboBox, Label label)
        {
            FactComboBoxItem factComboBoxItem = comboBox.SelectedItem as FactComboBoxItem;

            Question quesion = inferenceModule.Questions.Find(q => q.Rule.Target.Id == factComboBoxItem.Id);

            if (quesion == null)
            {
                label.Text = "BRAK!";
            }
            else
            {
                label.Text = quesion.Rule.Name;
            }
        }

        /// <summary>
        /// change selected rule
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="arguments"></param>
        /// <param name="questionContent"></param>
        /// <param name="ruleCreatingFact"></param>
        public void ChangeSelectedRule(ComboBox rules, CheckedListBox arguments, TextBox questionContent, ComboBox ruleCreatingFact)
        {
            RuleComboBoxItem ruleComboBoxItem = rules.SelectedItem as RuleComboBoxItem ?? new RuleComboBoxItem();
            Question question = inferenceModule.Questions.Find(q => q.Rule.Id == ruleComboBoxItem.Id);
            Rule rule = question.Rule;

            foreach (var item in ruleCreatingFact.Items)
            {
                FactComboBoxItem factComboBoxItem = item as FactComboBoxItem;
                if (factComboBoxItem.Id == rule.Target.Id)
                {
                    ruleCreatingFact.SelectedItem = item;
                    break;
                }
            }

            questionContent.Text = question.Content;
            arguments.Items.Clear();

            foreach (RuleArgument ruleArgument in rule.Arguments)
            {
                Fact fact = inferenceModule.Facts.Find(f => f.Id == ruleArgument.Id);
                arguments.Items.Add(new RuleArgumentListBoxItem
                {
                    Id = fact.Id,
                    Name = fact.Name,
                    Value = ruleArgument.RequiredValue
                });
            }
        }

        /// <summary>
        /// AddToArgumentList
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="value"></param>
        /// <param name="checkedListBox"></param>
        public void AddToArgumentList(ListBox listBox, bool value, CheckedListBox checkedListBox)
        {
            FactComboBoxItem factComboBoxItem = listBox.SelectedItem as FactComboBoxItem;

            if (factComboBoxItem == null)
            {
                return;
            }

            listBox.Items.Remove(factComboBoxItem);
            checkedListBox.Items.Add(new RuleArgumentListBoxItem
            {
                Id = factComboBoxItem.Id,
                Name = factComboBoxItem.Name,
                Value = value
            }, value);
        }

        /// <summary>
        /// RemoveFromArgumentList
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="checkedListBox"></param>
        public void RemoveFromArgumentList(ListBox listBox, CheckedListBox checkedListBox)
        {
            RuleArgumentListBoxItem ruleArgumentListBoxItem = checkedListBox.SelectedItem as RuleArgumentListBoxItem;

            if (ruleArgumentListBoxItem == null)
            {
                return;
            }

            checkedListBox.Items.Remove(ruleArgumentListBoxItem);
            FactComboBoxItem factComboBoxItem = new FactComboBoxItem
            {
                Id = ruleArgumentListBoxItem.Id,
                Name = ruleArgumentListBoxItem.Name
            };

            listBox.Items.Add(factComboBoxItem);
        }

        /// <summary>
        /// CheckIfFactIsCreatedByAnyRule
        /// </summary>
        /// <param name="comboBox"></param>
        public bool CheckIfFactIsCreatedByAnyRule(ComboBox comboBox)
        {
            FactComboBoxItem factComboBoxItem = comboBox.SelectedItem as FactComboBoxItem;
            return inferenceModule.Questions.Any(q => q.Rule.Target.Id == factComboBoxItem.Id);
        }

        /// <summary>
        /// AddRule
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="arguments"></param>
        /// <param name="question"></param>
        /// <param name="creatingFact"></param>
        public void AddRule(ComboBox rules, CheckedListBox arguments, TextBox question, ComboBox creatingFact)
        {
            string questionContent = question.Text;
            string ruleName = rules.Text;
            Guid target = (creatingFact.SelectedItem as FactComboBoxItem).Id;
            Dictionary<Guid, bool> ruleArguments = new Dictionary<Guid, bool>();

            foreach (var argument in arguments.Items)
            {
                RuleArgumentListBoxItem argumentListBoxItem = argument as RuleArgumentListBoxItem;
                ruleArguments.Add(argumentListBoxItem.Id, argumentListBoxItem.Value);
            }

            Guid[] returnGuids = dataAccessLayer.InsertRule(questionContent, ruleName, target, ruleArguments);

            inferenceModule.Questions.Add(new Question
            {
                Content = questionContent,
                Id = returnGuids[1],
                Rule = new Rule
                {
                    Id = returnGuids[0],
                    Arguments = ruleArguments.Select(ra => new RuleArgument
                    {
                        Id = ra.Key,
                        RequiredValue = ra.Value
                    }).ToList(),
                    Name = ruleName,
                    Target = inferenceModule.Facts.Find(f => f.Id == target)
                }
            });
        }

        /// <summary>
        /// add new element
        /// </summary>
        /// <param name="cbElements"></param>
        /// <param name="clbFactsAboutElements"></param>
        public void AddElement(ComboBox cbElements, CheckedListBox clbFactsAboutElements)
        {
            string elementName = cbElements.Text;
            Dictionary<Guid, bool> factsAboutElement = new Dictionary<Guid, bool>();

            foreach (var item in clbFactsAboutElements.Items)
            {
                RuleArgumentListBoxItem factAboutElement = item as RuleArgumentListBoxItem;
                factsAboutElement.Add(factAboutElement.Id, factAboutElement.Value);
            }

            Guid elementId = dataAccessLayer.InsertElement(elementName, factsAboutElement);
        }
    }
}