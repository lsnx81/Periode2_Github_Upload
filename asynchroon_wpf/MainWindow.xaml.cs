using System.Windows;

namespace asynchroon_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ViewModel.MainWindowViewModel();
            InitializeComponent();
        }


    }
}
