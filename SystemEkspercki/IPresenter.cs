using System.Windows.Forms;

namespace SystemEkspercki
{
    public interface IPresenter
    {
        void AddCheckBoxs(TableLayoutPanel panel);
        void LoadKnowledgeEditorModule(ComboBox comboBox);
        void StartInferenceModule(TableLayoutPanel panel, RichTextBox logContainer);
        void UpdateRuleLabel(ComboBox comboBox, Label label);

        void AddFact(TextBox textBox, ComboBox comboBox);
        void RemoveFact(ComboBox comboBox, int index);
        void UpdateFact(ComboBox comboBox, int index);
    }
}