using System.Collections.Generic;

namespace TribalWars.Core.Model
{
    public class Player
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<PlayerWorld> ActiveWorlds { get; set; }

    }
}
