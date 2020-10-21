namespace TribalWars.Core.Model
{
    public class Village
    {
        public Village(Troops troops)
        {
            Troops = troops;
        }

        public int VillageId { get; set; }
        public int Points { get; private set; }
        public string Name { get; set; }
        public Troops Troops { get; set; }
    }    
}
