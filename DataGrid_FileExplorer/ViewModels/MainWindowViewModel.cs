using DataGrid_FileExplorer.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataGrid_FileExplorer.ViewModels
{
    public class MainWindowViewModel : ObervableClass
    {
        class Command : ICommand
        {
            private readonly Action action;

            public Command(Action action)
            {
                this.action = action;
            }
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                action.Invoke();
            }
        }

        private DataManager _dataManager = new();
        private Book? _selectedBook;
        private Store? selectedStore;
        private string _ordernummer;
        private int _quantity;
        private string _paymentTerms;

        public MainWindowViewModel()
        {
            AvailableBooks = _dataManager.GetBooks();
            RegisteredStores = _dataManager.GetStores();
            AddBook = new Command(OnAddBook);
        }

        private void OnAddBook()
        {
            if (SelectedBook is null || SelectedStore is null)
            {
                return;
            }
            var sale = new Sale(book: SelectedBook, ordNum: Ordernummer, payTerms: PaymentTerms, quantity: Quantity, ordDatum: DateTime.Now);
            sale.StoreId = SelectedStore.StoreID;
            SelectedStore.AddSale(sale);
            SelectedBook = null;
            Ordernummer = string.Empty;
            PaymentTerms = String.Empty;
            Quantity = 0;
        }
        public ObservableCollection<Book> AvailableBooks { get; }
        public ObservableCollection<Store> RegisteredStores { get; }
        public string Ordernummer 
        { 
            get => _ordernummer; 
            set => SetProperty(ref _ordernummer, value); 
        
        }
        public int Quantity 
        { 
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }
        public string PaymentTerms 
        { 
            get => _paymentTerms;
            set => SetProperty(ref _paymentTerms,value); 
        }
        public Book? SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }

        public ICommand AddBook { get; }
        public Store? SelectedStore
        {
            get => selectedStore;
            set => selectedStore = value;
        }




    }
}
