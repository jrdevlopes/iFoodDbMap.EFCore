namespace iFoodDbMap.EFCore.Restaurant
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public IList<string>? Avaliacoes { get; set; }






        public Restaurant()
        {
            Avaliacoes = new List<string>();
        }


    }
}
