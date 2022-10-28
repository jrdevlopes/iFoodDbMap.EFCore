namespace iFoodDbMap.EFCore.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public string? Cpf { get; set; } = null;
        public string? CellphoneNumber { get; set; } = null;
        public string? Email { get; set; } = null;
        public IList<Address> Address { get; set; }

        public Client()
        {
            Address = new List<Address>();
        }

        public override string ToString()
        {
            return $"{Name} - {Cpf} : {CellphoneNumber} : {Email}";
        }
    }
}
