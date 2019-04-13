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

        public static readonly String STAT_INT = "Intelligence";
        public static readonly String STAT_WIS = "Wisdom";
        public static readonly String STAT_CHA = "Charisma";
        public static readonly String STAT_LAND_WAR = "Land Warfare";
        public static readonly String STAT_MARITIME = "Maritime Tactics";

        public String Name { get; set; } = DEFAULT_NAME;
        public Dictionary<String, int> Stats { get; set; } = new Dictionary<string, int>();
    }
}
