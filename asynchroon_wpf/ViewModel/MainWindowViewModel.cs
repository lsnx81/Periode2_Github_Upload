using asynchroon_wpf.Infrastructuur;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace asynchroon_wpf.ViewModel
{
    public class MainWindowViewModel : IDisposable
    {
        private bool delay10Enabled = true;
        private bool delay15Enabled = true;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private bool disposedValue;

        public bool Delay10Enabled 
        { 
            get => delay10Enabled;
            set
            {
                delay10Enabled = value;
                ButtonOneCommand10.RaiseCanExecuteChanged();
            }
        }
        public bool Delay15Enabled 
        { 
            get => delay15Enabled;
            set
            {
                delay15Enabled = value;
                ButtonOneCommand15.RaiseCanExecuteChanged();
            }
        }
        public MainWindowViewModel()
        {
            ButtonOneCommand = new DelegateCommand(OnOeCommandClick);
            ButtonOneCommand10 = new DelegateCommand(OnOeCommandClick10, () => Delay10Enabled);
            ButtonOneCommand15 = new DelegateCommand(OnOeCommandClick15, () => Delay15Enabled);
        }



        private void OnOeCommandClick()
        {
            Thread.Sleep(5000);
            MessageBox.Show("5 seconden Beeldscherm bevroren.", "TITEL 5sec", MessageBoxButton.OK, MessageBoxImage.Stop);


        }
        private async void OnOeCommandClick10()
        {
            Delay10Enabled = false;

            await Task.Delay(10000);
            Delay10Enabled = true;
            MessageBox.Show("10 seconden gewacht", "TITEL 10sec", MessageBoxButton.OK, MessageBoxImage.Stop);


        }
        private async void OnOeCommandClick15()
        {

            var task1 = DoeIets(4000,"Thread_1");
            var task2 = DoeIets(4000,"Thread_2");
            var task3 = DoeIets(4000,"Thread_3");
            var task4 = DoeIets(4000,"Thread_4");
            var task5 = DoeIets(4000,"Thread_5");
            var task6 = DoeIets(4000,"Thread_6");
            await Task.WhenAll(task1, task2, task3, task4, task5, task6);
            Melding.Add("Klaar met wachten");

        }


        private async Task DoeIets(int tijdOmTeWachten, string naam)
        {
            await Task.Delay(tijdOmTeWachten, cancellationTokenSource.Token);
            Melding.Add($"{naam} :  {tijdOmTeWachten}");
            
        }
        public ObservableCollection<string> Melding { get; } = new();

        public DelegateCommand ButtonOneCommand { get; }
        public DelegateCommand ButtonOneCommand10 { get; }
        public DelegateCommand ButtonOneCommand15 { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   
                }
                cancellationTokenSource.Cancel();
                cancellationTokenSource.Dispose();

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~MainWindowViewModel()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
