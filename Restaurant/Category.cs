using iFoodDbMap.EFCore.Entity.Order;

namespace iFoodDbMap.EFCore.Restaurant
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public IList<Item> Items { get; set; }

        public Category()
        {
            Items = new List<Item>();
        }
    }
}
