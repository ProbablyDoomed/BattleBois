using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    public class CEnvironment
    {
        public static readonly String DEFAULT_NAME = "Unnamed";
        public static readonly String DEFAULT_TYPE = "Untyped";

        private static readonly String FAKE_TYPE_ARCHER = "Archers";

        public String Name { get; set; } = DEFAULT_NAME;
        public String Type { get; set; } = DEFAULT_TYPE;

        public Dictionary<String, Dictionary<String, int>> Modifiers { get; set; }
            = new Dictionary<String, Dictionary<String, int>>()
        {
            [CUnit.TYPE_LIGHT_INFANTRY] = new Dictionary<String, int>(),
            [CUnit.TYPE_HEAVY_INFANTRY] = new Dictionary<String, int>(),
            [CUnit.TYPE_LIGHT_CAVALRY]  = new Dictionary<String, int>(),
            [CUnit.TYPE_HEAVY_CAVALRY]  = new Dictionary<String, int>(),
            [CUnit.TYPE_SIEGE_WEAPON]   = new Dictionary<String, int>(),
            [FAKE_TYPE_ARCHER]          = new Dictionary<String, int>()
        };

        public int GetUnitStatModifier(CUnit unit, String stat)
        {
            String type;
            if( Modifiers[FAKE_TYPE_ARCHER].Count > 0
                && unit.Traits.Keys.Contains(TraitReference.TRAIT_RANGED) )
            {
                type = FAKE_TYPE_ARCHER;
            }
            else
            {
                type = unit.Type;
            }

            if( Modifiers[type] != null 
                && Modifiers[type].Keys.Contains(stat) )
            {
                return Modifiers[type][stat];
            }
            else
            {
                return 0;
            }
            
        }
    }
}
