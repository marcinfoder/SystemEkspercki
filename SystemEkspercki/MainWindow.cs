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
            presenter.LoadKnowledgeEditorModule(cbFacts);
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
            presenter.AddFact(tbNewFact, cbFacts);
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
    }
}