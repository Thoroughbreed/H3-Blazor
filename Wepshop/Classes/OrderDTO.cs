using System.Collections.Generic;

namespace Wepshop.Classes
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int Product { get; set; }
        public int Amount { get; set; }
        public int CustomerId { get; set; }
        public double LinePrice { get; set; }
        public List<OrderItemsDTO> Items { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}