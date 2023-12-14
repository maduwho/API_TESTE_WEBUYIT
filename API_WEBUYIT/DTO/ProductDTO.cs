namespace API_WEBUYIT.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double OriginalPrice { get; set; }
        public double CurrentPrice { get; set; }
        public double Discount { get; set; }
        public int Buyers { get; set; }
    }
}
