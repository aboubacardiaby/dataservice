namespace dataservice.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public static List<Product> Products()
        {
            var list = new List<Product>();
            list.Add(new Product { ProductId = 1, Price = 25, ProductName = "Orange", Quantity = 1, });
            list.Add(new Product { Price = 20, ProductId = 2, ProductName = "Mango", Quantity = 45 });
            return list;
        }
    }
}
