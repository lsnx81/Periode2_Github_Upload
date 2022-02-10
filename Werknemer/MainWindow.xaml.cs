using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Werknemer
{
    public class Personeel
    {
        public string Achternaam { get; set; }
        public string Voornaam { get; set; }
        public double Verdiensten { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ObservableCollection<Personeel> BestaandeMedewerkers { get; } = new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(inputVerdiensten.Text, out double verdiensten) == false)
            {
                MessageBox.Show("Input moet een getal zijn", "Ongeldige input", MessageBoxButton.OK, MessageBoxImage.Stop);
                inputVerdiensten.Text = String.Empty;
                return;
            }
            BestaandeMedewerkers.Add(new Personeel()
            {
                Achternaam = inputAchternaam.Text,
                Voornaam = inputAchternaam.Text,
                Verdiensten = verdiensten
            }
            );
            inputAchternaam.Text = String.Empty;
            inputVoornaam.Text = String.Empty;
            inputVerdiensten.Text=String.Empty;

        }
    }
}
