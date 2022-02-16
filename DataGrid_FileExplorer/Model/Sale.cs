using System;
using System.ComponentModel;

namespace DataGrid_FileExplorer.Model
{
    public class Sale : ObervableClass, IDisposable
    {
        private Book _book;
        private string _ordNum;
        private string _payTerms;
        private int _quantity;
        private DateTime _ordDatum;
        private bool disposedValue;
        private int _storeId;


        public Sale()
        {

        }
        public Sale(Book book,

            string ordNum,
            string payTerms,
            int quantity,
            DateTime ordDatum
            )
        {
            _book = book;
            _book.PropertyChanged += Fire_BookPriceChanged;
            _ordNum = ordNum;
            _payTerms = payTerms;
            _quantity = quantity;
            _ordDatum = ordDatum;
        }

        public int StoreId
        {
            get => _storeId;
            set
            {
                SetProperty(ref _storeId, value);
            }
        }

        public double SubTotal() => _book.Price * _quantity;


        public Book Book
        {
            get => _book;
            set
            {
                _book.PropertyChanged -= Fire_BookPriceChanged;

                if (SetProperty(ref _book, value))
                {
                    NotifyPropertyChanged(nameof(TussenTotaal));
                }
                _book.PropertyChanged += Fire_BookPriceChanged;
            }
        }

        private void Fire_BookPriceChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (nameof(Book.Price) == e.PropertyName)
            {
                NotifyPropertyChanged(nameof(TussenTotaal));
            }
        }


        
        
        public string TussenTotaal => $"{(_book.Price * _quantity):C2}";
        public string OrdNum { get => _ordNum; set => SetProperty(ref _ordNum, value); }
        public string PayTerms { get => _payTerms; set => SetProperty(ref _payTerms, value); }
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (SetProperty(ref _quantity, value))
                {
                    NotifyPropertyChanged(nameof(TussenTotaal));
                }
            }
        }
        public DateTime OrdDatum { get => _ordDatum; set => SetProperty(ref _ordDatum, value); }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }
                _book.PropertyChanged -= Fire_BookPriceChanged;



                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Sale()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
