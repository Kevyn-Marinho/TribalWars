using System.Collections.Generic;

namespace TribalWars.Core.Model
{
    public class PlayerWorld
    {
        public Tribe Tribe { get; set; }
        public double Points { get; set; }
        public IEnumerable<Village> Villages { get; set; }
    }
}
