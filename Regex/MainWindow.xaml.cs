using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Regex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        const string regexByteTest = @"^[1-9][0-9]?$|^255$";
        const string regexIPAddress = @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)|
((\A([0-9a-f]{1,4}:){1,1}(:[0-9a-f]{1,4}){1,6}\Z)|
(\A([0-9a-f]{1,4}:){1,2}(:[0-9a-f]{1,4}){1,5}\Z)|
(\A([0-9a-f]{1,4}:){1,3}(:[0-9a-f]{1,4}){1,4}\Z)|
(\A([0-9a-f]{1,4}:){1,4}(:[0-9a-f]{1,4}){1,3}\Z)|
(\A([0-9a-f]{1,4}:){1,5}(:[0-9a-f]{1,4}){1,2}\Z)|
(\A([0-9a-f]{1,4}:){1,6}(:[0-9a-f]{1,4}){1,1}\Z)|
(\A(([0-9a-f]{1,4}:){1,7}|:):\Z)|
(\A:(:[0-9a-f]{1,4}){1,7}\Z)|
(\A((([0-9a-f]{1,4}:){6})(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3})\Z)|
(\A(([0-9a-f]{1,4}:){5}[0-9a-f]{1,4}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3})\Z)|
(\A([0-9a-f]{1,4}:){5}:[0-9a-f]{1,4}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A([0-9a-f]{1,4}:){1,1}(:[0-9a-f]{1,4}){1,4}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A([0-9a-f]{1,4}:){1,2}(:[0-9a-f]{1,4}){1,3}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A([0-9a-f]{1,4}:){1,3}(:[0-9a-f]{1,4}){1,2}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A([0-9a-f]{1,4}:){1,4}(:[0-9a-f]{1,4}){1,1}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A(([0-9a-f]{1,4}:){1,5}|:):(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)|
(\A:(:[0-9a-f]{1,4}){1,5}:(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\Z)
)";
        const string regexPol = @"pol";
        private string bitTest;
        private string iPTest;
        private string stringTest;
        private string bitTestResult;
        private string iPTestResult;

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        public string BitTest { get => bitTest; set => SetProperty(ref bitTest, value); }
        public string IPTest { get => iPTest; set => SetProperty(ref iPTest, value); }
        public string StringTest { get => stringTest; set => SetProperty(ref stringTest, value); }
        public string BitTestResult { get => bitTestResult; set => SetProperty(ref bitTestResult, value); }
        public string IPTestResult { get => iPTestResult; set => SetProperty(ref iPTestResult, value); }
        public string StringTestResult { get => iPTestResult;set => SetProperty(ref iPTestResult,value); }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private void OnBitTestClick(object sender, RoutedEventArgs e)
        {

            var regex = new System.Text.RegularExpressions.Regex(regexByteTest);

            BitTestResult = $"is '{BitTest}' a valid byte: {regex.IsMatch(BitTest)}";



        }

        private void OnValidateIPAddress(object sender, RoutedEventArgs e)
        {
            var regex = new System.Text.RegularExpressions.Regex(regexIPAddress);

            IPTestResult = $"is '{IPTest}' a valid byte: {regex.IsMatch(IPTest)}";
        }

        private void OnValidateStringTest(object sender, RoutedEventArgs e)
        {
            var regex = new System.Text.RegularExpressions.Regex(regexPol);

            StringTestResult= $"Contains '{StringTest}' the letters 'pol': {regex.IsMatch(StringTest)}"; 
        }
    }
}
