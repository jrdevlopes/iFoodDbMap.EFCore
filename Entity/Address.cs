
namespace iFoodDbMap.EFCore.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Alias { get; set; }

        public Client Client { get; set; }
    }
}
