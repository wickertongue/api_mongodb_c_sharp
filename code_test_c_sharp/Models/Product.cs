namespace ProductApi.Models
{
    public class Product
    {
        public long Id { get; set; }
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
