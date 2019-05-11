using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    public class CDivision
    {
        public static readonly String DEFAULT_NAME = "Unnamed";

        public Guid ID { get; set; } = Guid.NewGuid();
        public String Name { get; set; } = DEFAULT_NAME;
        public CUnit UnitType { get; set; } = new CUnit();

        public int StartingSize { get; set; } = 0;
        public int CurrentSize { get; set; } = 0;

        public int Morale { get; set; } = 0;
        public int RetreatScore { get; set; } = 0;

        public int Initiative { get; set; } = 0;

        public Guid GuardPairing { get; set; } = Guid.Empty;

    }
}
