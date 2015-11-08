using System;
using System.Windows.Forms;

namespace SystemEkspercki
{
    /// <summary>
    /// Main window
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Presenter
        /// </summary>
        private readonly IPresenter presenter;

        private int lastSelectedFactIndex = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="presenter"></param>
        public MainWindow(IPresenter presenter)
        {
            InitializeComponent();

            this.Text = "System ekspercki - Marcin Foder, listopad 2015";
            this.presenter = presenter;
            presenter.AddCheckBoxs(inferenceModulePanel);
            presenter.LoadKnowledgeEditorModule(cbFacts, cbRules, lbAllFacts, cbRuleCreatingFact);
        }

        /// <summary>
        /// Click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            endOfInferencingLbl.Visible = false;
            presenter.StartInferenceModule(inferenceModulePanel, inferenceRevisionRtb);
            endOfInferencingLbl.Visible = true;
        }

        /// <summary>
        /// Click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFact_Click(object sender, EventArgs e)
        {
            if (cbFacts.SelectedIndex == -1)
            {
                presenter.AddFact(cbFacts, lbAllFacts, cbRuleCreatingFact);
            }
            else
            {
                MessageBox.Show("Fakt już istnieje.");
            }
        }

        /// <summary>
        /// remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveFact_Click(object sender, EventArgs e)
        {
            presenter.RemoveFact(cbFacts, lastSelectedFactIndex);
        }

        /// <summary>
        /// edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFact_Click(object sender, EventArgs e)
        {
            presenter.UpdateFact(cbFacts, lastSelectedFactIndex);
            lbAllFacts.Refresh();
        }

        /// <summary>
        /// Selected index change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboxBox = sender as ComboBox;

            if (comboxBox.SelectedIndex != -1)
            {
                lastSelectedFactIndex = comboxBox.SelectedIndex;
                presenter.UpdateRuleLabel(comboxBox, lblFactRule);
            }
        }

        private void cbRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ChangeSelectedRule(cbRules, clbRuleArguments, tbQuestionContent, cbRuleCreatingFact);
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            presenter.AddRule(cbRules, clbRuleArguments, tbQuestionContent, cbRuleCreatingFact);
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// btnMoveFactWithTrue_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveFactWithTrue_Click(object sender, EventArgs e)
        {
            presenter.AddToArgumentList(lbAllFacts, true, clbRuleArguments);
        }

        /// <summary>
        /// btnMoveFactWithFalse_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveFactWithFalse_Click(object sender, EventArgs e)
        {
            presenter.AddToArgumentList(lbAllFacts, false, clbRuleArguments);
        }

        /// <summary>
        /// btnRemoveFactFromRuleArgs_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveFactFromRuleArgs_Click(object sender, EventArgs e)
        {
            presenter.RemoveFromArgumentList(lbAllFacts, clbRuleArguments);
        }

        /// <summary>
        /// cbRuleCreatingFact_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRuleCreatingFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presenter.CheckIfFactIsCreatedByAnyRule(cbRuleCreatingFact))
            {
                MessageBox.Show("Ten fakt jest już tworzony przez inną regułę.");
            }
        }

        private void btnElementAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnElementEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnElementDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFactABoutElementTrue_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFactAboutElementFalse_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFactAboutElement_Click(object sender, EventArgs e)
        {

        }
    }
}