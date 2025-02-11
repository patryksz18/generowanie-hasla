using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string haslo = "";
        int dlugosc = 0;
        string litery = "abcdefghijklmnoprtuwxyzABCDEFGHIJKLMNOPRSTUWXYZ";
        string znaki_specjlane = "!@#$%^&*<>?";
        string cyfry = "0123456789";
        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}