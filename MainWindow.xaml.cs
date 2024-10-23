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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            text1.Clear();
            text2.Clear();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close(); // Закрывает приложение
        }
    }
}