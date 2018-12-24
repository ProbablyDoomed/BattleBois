using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    class CCommander
    {
        public static readonly String DEFAULT_NAME = "Unnamed";

        public String Name { get; set; } = DEFAULT_NAME;
        public Dictionary<String, int> Stats { get; set; } = new Dictionary<string, int>();
    }
}
