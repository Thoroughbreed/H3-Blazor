namespace Wepshop.Classes
{
    public class ProductDTO
    {
        public ProductDTO(string sku)
        {
            SKU = sku + ".png";
        }

        public string Name { get; set; }
        public string Vendor { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; }
        public int Id { get; set; }
    }
}