using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_FileExplorer.Model
{
    public class Store : ObervableClass
    {
        private string _city;
        private string _state;
        private string _storeAddress;
        private int _storeID;
        private string _zip;

        public string City { get => _city; set => SetProperty(ref _city, value); }
        public string Details
        { 
            get => $"{StoreAddress} {Environment.NewLine}{City}{Environment.NewLine}totaal : {FormattedTotaal}"; 
        }
        public string FormattedTotaal { get => Totaal().ToString("C2"); }
        public ObservableCollection<Sale> LijstSale { get; } = new ObservableCollection<Sale>();

        public string State { get=> _state; set => SetProperty(ref _state, value);}
        public string StoreAddress { get=> _storeAddress; set => SetProperty(ref _storeAddress, value);}
        public int StoreID { get=> _storeID; set => SetProperty(ref _storeID, value);}
        public string Zip { get=> _zip; set => SetProperty(ref _zip, value);}
        public double Totaal() => LijstSale.Sum(s => s.Quantity * s.Book.Price);

        public void AddSale(Sale newsale)
        {
            if (newsale is null)
            {
                throw new ArgumentNullException(nameof(newsale));
            }

            LijstSale.Add(newsale);
            newsale.PropertyChanged += UpdateTotals;
            base.NotifyPropertyChanged(nameof(FormattedTotaal));
            base.NotifyPropertyChanged(nameof(Details));
        }

        private void UpdateTotals(object? sender, PropertyChangedEventArgs e)
        {
            base.NotifyPropertyChanged(nameof(FormattedTotaal));
            base.NotifyPropertyChanged(nameof(Details));
        }

        public override string ToString()
        {
            return $"{StoreAddress} {City}";
        }


    }
}
