namespace iFoodDbMap.EFCore.Customer
{
    public class Address
    {
        public short Id { get; set; }
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public int Number { get; set; }
        public string State { get; set; } = "";
        public string? Complement { get; set; } = null;
        public string? Alias { get; set; } = null;

        public Client? Client { get; set; }

        public override string ToString()
        {
            var location = $"({Alias}) {Id} - {Street}, {Number} - {City}-{State} ({Complement})";
            return location;
        }
    }
}
