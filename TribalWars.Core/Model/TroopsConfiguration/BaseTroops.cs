using System;
using System.Collections.Generic;

namespace TribalWars.Core.Model.TroopsConfiguration
{
    public abstract class BaseTroops
    {
        public Costs Costs { get; set; }
        public int Population { get; set; }
        public int Speed { get; set; }
        public int CarryingCapacity { get; set; }
        public int Offensive { get; set; }
        public int Defensive { get; set; }
        public Dictionary<int, TimeSpan> TimeToProduce { get; set; }
    }
}
