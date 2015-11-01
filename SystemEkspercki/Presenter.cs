using System.Linq;
using System.Windows.Forms;

namespace SystemEkspercki
{
    public class Presenter : IPresenter
    {
        private readonly IInferenceModule inferenceModule;

        public Presenter(IInferenceModule inferenceModule)
        {
            this.inferenceModule = inferenceModule;
        }

        public void AddCheckBoxs(TableLayoutPanel panel)
        {
            var questions = inferenceModule.Questions;
            var checkBoxs = questions.Select(question => new ThreeStateCheckBox(question.Id, question.Content)).ToArray();

            foreach (ThreeStateCheckBox checkBox in checkBoxs)
            {
                RowStyle style = new RowStyle(SizeType.AutoSize);
                panel.RowStyles.Add(style);
                int index = panel.RowCount++;
                panel.Controls.Add(checkBox, 0, index);
            }
        }
    }
}
