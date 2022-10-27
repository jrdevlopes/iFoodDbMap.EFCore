namespace iFoodDbMap.EFCore.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }          
        
        public IList<Address>? Address { get; set; }
                
    }
}
