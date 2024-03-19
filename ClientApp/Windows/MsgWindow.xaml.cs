using ClientApp.VM;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientApp.Windows
{
    /// <summary>
    /// Interaction logic for NameWindow.xaml
    /// </summary>
    public partial class MsgWindow : Window
    {
        public MsgWindowViewModel VM { get; set; }

        public MsgWindow()
        {
            InitializeComponent();
            VM = new MsgWindowViewModel(this);
            this.DataContext = VM;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (VM.EnteredName == null || VM.EnteredName == "")
            {
                e.Cancel = true;
            }
        }
    }
}
