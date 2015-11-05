using System.Windows.Forms;

namespace SystemEkspercki
{
    public interface IPresenter
    {
        void AddCheckBoxs(TableLayoutPanel panel);
        void StartInferenceModule(TableLayoutPanel panel, RichTextBox logContainer);
    }
}