namespace TribalWars.Infrastructure.Database.TroopsConfiguration
{
    public abstract class TroopConfig
    {
        public Costs Costs { get; set; }
        public int Population { get; set; }
        public int Speed { get; set; }
        public int CarryingCapacity { get; set; }
        public int Offensive { get; set; }
        public int Defensive { get; set; }
    }
}
