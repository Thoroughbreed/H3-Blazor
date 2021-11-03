namespace Wepshop.Classes
{
    public class OrderItemsDTO
    {
        public int id { get; set; }
        public int product { get; set; }
        public int amount { get; set; }
        public int customerID { get; set; }
        public double linePrice { get; set; }

        public OrderItemsDTO()
        {
        }
    }
}