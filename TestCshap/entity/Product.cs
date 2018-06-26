namespace TestCshap.entity
{
    public class Product
    {
        private string _productID;
        private string _productName;
        private string _price;

        public Product()
        {
        }

        public Product(string productId, string productName, string price)
        {
            _productID = productId;
            _productName = productName;
            _price = price;
        }

        public string ProductId
        {
            get => _productID;
            set => _productID = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public string Price
        {
            get => _price;
            set => _price = value;
        }
    }
}