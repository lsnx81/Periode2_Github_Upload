using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BerekenOmtrek
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

        private void StartRekenen(object sender, RoutedEventArgs e)
        {
            var straal = double.Parse(tbStraal.Text);
            lblOmtrek.Content= (straal*2*Math.PI).ToString("N2");
            lblOppervlakte.Content = (straal*straal*Math.PI).ToString("N2");
           
           
        }

        

    }
}
