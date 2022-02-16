namespace DataGrid_FileExplorer.Model
{
    public class Book : ObervableClass
    {
        private double _price;
        private string _pubId;
        private string _title;
        private string _titleID;
        private string _type;

        public Book(double price, string pubId, string title, string titleId, string type)
        {
            _price = price;
            _pubId = pubId;
            _title = title;
            _titleID = titleId;
            _type = type;
        }

        public double Price { get => _price; set => SetProperty(ref _price, value); }
        public string PubId { get => _pubId; set => SetProperty(ref _pubId, value); }
        public string Title { get => _title; set => SetProperty(ref _title, value); }
        public string TitleID { get => _titleID; set => SetProperty(ref _titleID, value); }
        public string Type { get => _type; set => SetProperty(ref _type, value); }


        public override string ToString()
        {
            return $"{Title} {Price}";
        }


    }
}
