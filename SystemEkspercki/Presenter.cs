using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inferenceModule">Inference module</param>
        public Presenter(IInferenceModule inferenceModule)
        {
            this.inferenceModule = inferenceModule;
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
    }
}