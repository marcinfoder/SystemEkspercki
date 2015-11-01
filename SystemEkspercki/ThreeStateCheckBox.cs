using System;
using System.Windows.Forms;

namespace SystemEkspercki
{
    /// <summary>
    /// ThreeStateCheckBox class.
    /// </summary>
    public class ThreeStateCheckBox : CheckBox
    {
        /// <summary>
        /// Gets and sets question GUID
        /// </summary>
        public Guid QuestionId { get; set; }

        /// <summary>
        /// Gets the boolean-nullable value of check state
        /// </summary>
        public bool? Value
        {
            get
            {
                switch (CheckState)
                {
                    case CheckState.Checked:
                        return true;
                    case CheckState.Indeterminate:
                        return null;
                    case CheckState.Unchecked:
                        return false;
                }

                throw new Exception("This line should never been reached");
            }
        }

        /// <summary>
        /// Prevent default instance creation
        /// </summary>
        private ThreeStateCheckBox()
        {
        }

        /// <summary>
        /// Constructor, sets Text property, question GUID and ThreeState to true
        /// </summary>
        /// <param name="questionGuid">Question GUID</param>
        /// <param name="text">Text property value</param>
        public ThreeStateCheckBox(Guid questionGuid, string text)
        {
            ThreeState = true;
            CheckState = CheckState.Indeterminate;
            QuestionId = questionGuid;
            Text = text;
        }

        /// <summary>
        /// Ensure that it is the most derived type in the inheritance hierarchy
        /// </summary>
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
    }
}