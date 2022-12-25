namespace iFoodDbMap.EFCore.Entity.Order
{
    public class Order
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public IList<Item> Items { get; set; }

        public Order(Restaurant restaurant)
        {
            Restaurant = restaurant;
            Items = new List<Item>();
        }

    }
}
