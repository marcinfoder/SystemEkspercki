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
        /// loads knowlegde editor
        /// </summary>
        /// <param name="comboBox"></param>
        public void LoadKnowledgeEditorModule(ComboBox comboBox)
        {
            inferenceModule.Facts.ForEach(f => comboBox.Items.Add(new FactComboBoxItem
            {
                Id = f.Id,
                Name = f.Name
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
        /// <param name="textBox"></param>
        /// <param name="comboBox"></param>
        public void AddFact(TextBox textBox, ComboBox comboBox)
        {
            string name = textBox.Text;
            textBox.Clear();

            Guid guid = dataAccessLayer.InsertFact(name);
            FactComboBoxItem factComboBoxItem = new FactComboBoxItem
            {
                Id = guid,
                Name = name
            };

            comboBox.Items.Add(factComboBoxItem);
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
    }
}