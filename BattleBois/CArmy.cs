using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    public class CArmy
    {

        public static readonly String DEFAULT_NAME = "Unnamed";
        public static readonly int DEFAULT_COMMANDER_INDEX = 1;

        private readonly string MISSING_GUARD_PAIR_MESSAGE = "Guard pairing GUID not found.";

        public String Name { get; set; } = DEFAULT_NAME;
        public List<CDivision> Divisions { get; set; } = new List<CDivision>();
        public List<CCommander> Commanders { get; set; } = new List<CCommander>();

        public int ActiveCommanderIndex { get; set; } = DEFAULT_COMMANDER_INDEX;

        public int GetTotalSize()
        {        
            int totalSize = 0;
            foreach (CDivision division in Divisions)
            {
                totalSize += division.CurrentSize;
            }
            return totalSize;
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (CDivision division in Divisions)
            {
                totalCost += (division.CurrentSize * division.UnitType.Stats[CUnit.STAT_RECRUITMENT]);
            }
            return totalCost;
        }

        public double GetTotalUpkeep()
        {
            double totalUpkeep = 0;
            foreach (CDivision division in Divisions)
            {
                totalUpkeep += (division.CurrentSize * division.UnitType.Stats[CUnit.STAT_MAINTENANCE]);
            }
            return totalUpkeep;
        }

        public int GetTotalLosses()
        {
            int totalLosses = 0;
            foreach (CDivision division in Divisions)
            {
                totalLosses += (division.StartingSize - division.CurrentSize);
            }
            return totalLosses;
        }

        public void ClearGuarding(CDivision division)
        {
            if (division.GuardPairing != Guid.Empty)
            {
                CDivision other = Divisions.Find(i => i.GuardPairing == division.ID);
                division.GuardPairing = Guid.Empty;
                if (other != null)
                {
                    other.GuardPairing = Guid.Empty;
                }
                else
                {
                    throw new Exception(MISSING_GUARD_PAIR_MESSAGE);
                }
            }
        }

        public void SetGuarding(CDivision guardian, CDivision guarded)
        {
            ClearGuarding(guardian);
            ClearGuarding(guarded);
            guardian.GuardPairing = guarded.ID;
            guarded.GuardPairing = guardian.ID;
        }

        public int CheckDefensiveStrength(CDivision division)
        {
            int defense = 0;
            if (division.GuardPairing == Guid.Empty)
            {
                defense = (int)(division.UnitType.Stats[CUnit.STAT_DEFENSE]);
            }
            else
            {
                CDivision other = Divisions.Find(i => i.GuardPairing == division.ID);
                if (other != null)
                {
                    defense = (int)(other.UnitType.Stats[CUnit.STAT_DEFENSE]);
                }
                else
                {
                    throw new Exception(MISSING_GUARD_PAIR_MESSAGE);
                }
            }            
            return defense;
        }
    }
}
