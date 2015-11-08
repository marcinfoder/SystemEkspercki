using System.Windows.Forms;

namespace SystemEkspercki
{
    public interface IPresenter
    {
        void AddCheckBoxs(TableLayoutPanel panel);
        void StartInferenceModule(TableLayoutPanel panel, RichTextBox logContainer);
        void UpdateRuleLabel(ComboBox comboBox, Label label);

        void AddFact(ComboBox comboBox, ListBox listBox, ComboBox ruleCreatingFact);
        void RemoveFact(ComboBox comboBox, int index);
        void UpdateFact(ComboBox comboBox, int index);

        void LoadKnowledgeEditorModule(ComboBox comboBox, ComboBox cbRules, ListBox lbAllFacts, ComboBox rulesCreatingFact);
        void ChangeSelectedRule(ComboBox rules, CheckedListBox arguments, TextBox questionContent, ComboBox ruleCreatingFact);

        void AddToArgumentList(ListBox listBox, bool value, CheckedListBox checkedListBox);
        void RemoveFromArgumentList(ListBox listBox, CheckedListBox checkedListBox);
        bool CheckIfFactIsCreatedByAnyRule(ComboBox comboBox);

        void AddRule(ComboBox rules, CheckedListBox arguments, TextBox question, ComboBox creatingFact);
    }
}