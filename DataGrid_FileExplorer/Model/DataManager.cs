using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DataGrid_FileExplorer.Model
{
    internal class DataManager 
    {
        List<Book> _books = new(); 
        List<Store> _stores = new();
        public DataManager()
        {
            
            _books.Add(new Book(price:10,pubId:"205-225-400",title:"Verhaal van de Dag", titleId: "1", type:"Documentaire"));
            _books.Add(new Book(price:20,pubId:"325-225-500",title:"Verhaal van Gisteren", titleId: "2", type:"Documentaire"));
            _books.Add(new Book(price:30,pubId:"425-225-600",title:"Verhaal van Morgen", titleId: "3", type:"Documentaire"));
            _books.Add(new Book(price:40,pubId:"525-225-700",title:"Verhaal van Volgend Jaar", titleId: "4", type:"Documentaire"));
            _stores.Add(new Store() { City = "Brussel", StoreAddress = "NieuwStraat 4", StoreID = 1, Zip = "1000" });
            _stores.Add(new Store() { City = "Gent", StoreAddress = "Gentstestraat 54", StoreID = 2, Zip = "9000" });
            _stores.Add(new Store() { City = "Antwerpen", StoreAddress = "AntwerpseBaan 44", StoreID = 3, Zip = "3000" });
            _stores[0].AddSale(new(_books[0], "1001", "Contante betaling", 1, DateTime.Now.AddMinutes(-10)) { StoreId=1});
            _stores[0].AddSale(new(_books[3], "1002", "Contante betaling", 1, DateTime.Now) { StoreId=1});
            
        }
        public Book? GetbookByBookId(string titleId) 
        { 
            throw new NotImplementedException();
        }
        public ObservableCollection <Book> GetBooks()
        {   //to-do : iedere keer nieuwe collectie raak ik BookCollectionChanged kwijt.
            //to-do:  IReadonlyCollection ?

            var collection = new ObservableCollection<Book>(_books);
            collection.CollectionChanged += BookCollectionChanged;
            return collection;
        }

        


        private void BookCollectionChanged(object? sender,NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    break;
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                default:throw new NotImplementedException();
                    
            }

            throw new NotImplementedException();
        }

        public ObservableCollection<Sale> GetSalesByStoreID(int storeId)
        {   //to-do : iedere keer nieuwe collectie raak ik BookCollectionChanged kwijt.
            //to-do:  IReadonlyCollection ?

            var collection = new ObservableCollection<Sale>();
            return collection;
        }

        public ObservableCollection<Store> GetStores()
        {   //to-do : iedere keer nieuwe collectie raak ik BookCollectionChanged kwijt.
            //to-do:  IReadonlyCollection ?

            var collection = new ObservableCollection<Store>(_stores);
            
            
            
            return collection;
        }
    }
}
