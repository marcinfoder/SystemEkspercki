using System.Linq;
using System.Windows.Forms;

namespace SystemEkspercki
{
    public partial class MainWindow : Form
    {
        private readonly IPresenter presenter;

        public MainWindow(IPresenter presenter)
        {
            InitializeComponent();

            this.presenter = presenter;
            presenter.AddCheckBoxs(inferenceModulePanel);
        }
    }
}
