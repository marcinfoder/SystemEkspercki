using System.Windows.Forms;

namespace SystemEkspercki
{
    public interface IPresenter
    {
        void AddCheckBoxs(TableLayoutPanel panel);
        void StartInferenceModule(TableLayoutPanel panel, RichTextBox logContainer);
        void UpdateRuleLabel(ComboBox comboBox, Label label);

        void AddFact(ComboBox comboBox, ListBox listBox, ComboBox ruleCreatingFact, ListBox elementsListBox);
        void RemoveFact(ComboBox comboBox, int index);
        void UpdateFact(ComboBox comboBox, int index);

        void LoadKnowledgeEditorModule(ComboBox comboBox, ComboBox cbRules, ListBox lbAllFacts, ComboBox rulesCreatingFact, ListBox lbFactElement, ComboBox cbElements);
        void ChangeSelectedRule(ComboBox rules, CheckedListBox arguments, TextBox questionContent, ComboBox ruleCreatingFact, ListBox lbFacts);

        void AddToArgumentList(ListBox listBox, bool value, CheckedListBox checkedListBox);
        void RemoveFromArgumentList(ListBox listBox, CheckedListBox checkedListBox);
        bool CheckIfFactIsCreatedByAnyRule(ComboBox comboBox);

        void AddRule(ComboBox rules, CheckedListBox arguments, TextBox question, ComboBox creatingFact);
        void DeleteRule(ComboBox rules, CheckedListBox arguments, ListBox listBox, TextBox question);

        void AddElement(ComboBox cbElements, CheckedListBox clbFactsAboutElements);
        void DeleteElement(ComboBox cbElements, ListBox lbFactsElements, CheckedListBox clbFactsAboutElements);

        void MoveArguments(ComboBox comboBox, ListBox listbox, CheckedListBox checkedListBox);
    }
}