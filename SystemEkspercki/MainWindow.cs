using System;
using System.Linq;
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="presenter"></param>
        public MainWindow(IPresenter presenter)
        {
            InitializeComponent();

            this.presenter = presenter;
            presenter.AddCheckBoxs(inferenceModulePanel);
        }

        /// <summary>
        /// Click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            var kontrolki = inferenceModulePanel.Controls.OfType<ThreeStateCheckBox>().ToList();
            MessageBox.Show(kontrolki.Count.ToString());
        }
    }
}