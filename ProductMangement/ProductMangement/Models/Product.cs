namespace ProductMangement.Models
{
    public class Product
    {
        //product Model
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Create_date { get; set; }
        public bool IsActive { get; set; }
    }
}
