using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    public class CBattle
    {
        public List<CArmy> Armies { get; set; } = new List<CArmy>();
        public List<CEnvironment> EnvironmentalConditions { get; set; } = new List<CEnvironment>();

    }
}
