using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    public class CCommander
    {
        public static readonly String DEFAULT_NAME = "Unnamed";
        public static readonly int DEFAULT_STAT = 0;
        public static readonly int DEFAULT_PROF = 0;
        public static readonly int NOBODY_STAT = -3;
        public static readonly int NOBODY_PROF = 0;

        public static readonly String STAT_INT = "Intelligence";
        public static readonly String STAT_WIS = "Wisdom";
        public static readonly String STAT_CHA = "Charisma";
        public static readonly String STAT_LAND_WAR = "Land Warfare";
        public static readonly String STAT_MARITIME = "Maritime Tactics";

        public static readonly CCommander NO_COMMANDER = new CCommander()
        {
            Name = "No Active Commander",
            Stats = new Dictionary<string, int>()
            {
                [STAT_INT] = NOBODY_STAT,
                [STAT_WIS] = NOBODY_STAT,
                [STAT_CHA] = NOBODY_STAT,
                [STAT_LAND_WAR] = NOBODY_PROF,
                [STAT_MARITIME] = NOBODY_PROF,
            }
        };

        public String Name { get; set; } = DEFAULT_NAME;
        public Dictionary<String, int> Stats { get; set; } = new Dictionary<string, int>()
        {
            [STAT_INT] = DEFAULT_STAT,
            [STAT_WIS] = DEFAULT_STAT,
            [STAT_CHA] = DEFAULT_STAT,
            [STAT_LAND_WAR] = DEFAULT_PROF,
            [STAT_MARITIME] = DEFAULT_PROF,
        };
    }
}
