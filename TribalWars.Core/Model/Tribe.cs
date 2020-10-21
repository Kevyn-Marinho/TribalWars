using System.Collections.Generic;

namespace TribalWars.Core.Model
{
    public class Tribe
    {
        public double Points { get; set; }
        public double FouthyBestPlayersPoints { get; set; }
        public IEnumerable<Player> Members { get; set; }
    }
}
