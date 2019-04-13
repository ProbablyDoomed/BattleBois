using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    class CArmy
    {
        private int _totalSize = 0;
        private double _totalUpkeep = 0;
        private double _totalCost = 0;
        private int _totalLosses = 0;
        private readonly string MISSING_GUARD_PAIR_MESSAGE = "Guard pairing GUID not found.";


        public static readonly String DEFAULT_NAME = "Unnamed";

        public String Name { get; set; } = DEFAULT_NAME;
        public List<CDivision> Divisions { get; set; } = new List<CDivision>();
        public CCommander Commander { get; set; } = new CCommander();

        public int GetTotalSize()
        {
            return _totalSize;
        }

        public double GetTotalCost()
        {
            return _totalCost;
        }

        public double GetTotalUpkeep()
        {
            return _totalUpkeep;
        }

        public int GetTotalLosses()
        {
            return _totalLosses;
        }

        public void RecalculateStats()
        {
            _totalSize = 0;
            _totalCost = 0;
            _totalLosses = 0;
            foreach (CDivision division in Divisions)
            {
                _totalSize   += division.CurrentSize;
                _totalCost   += (division.CurrentSize * division.UnitType.Stats[CUnit.STAT_RECRUITMENT]);
                _totalUpkeep += (division.CurrentSize * division.UnitType.Stats[CUnit.STAT_MAINTENANCE]);
                _totalLosses += (division.StartingSize - division.CurrentSize);
            }
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
