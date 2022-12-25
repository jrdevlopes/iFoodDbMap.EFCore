namespace iFoodDbMap.EFCore.Customer
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public IList<Address> Address { get; set; }

        public Client(string name, string cpf, string cellphonenumber, string email)
        {
            Name = name;
            Cpf = cpf;
            CellphoneNumber = cellphonenumber;
            Email = email;
            Address = new List<Address>();
        }

        public override string ToString()
        {
            return $"{Name} - {Cpf} : {CellphoneNumber} : {Email}";
        }
    }
}
