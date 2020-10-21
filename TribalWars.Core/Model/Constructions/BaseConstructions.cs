using System.Collections.Generic;

namespace TribalWars.Core.Model.Constructions
{
    public abstract class BaseConstructions
    {
        public string Name { get; set; }
        public Dictionary <int, Costs> CostsPerLevel { get; set; }
        

    }
}
