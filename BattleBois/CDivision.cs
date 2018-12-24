using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    class CDivision
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public CUnit UnitType { get; set; }

        public int Size { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int Morale { get; set; } = 0;

        public int Initiative { get; set; } = 0;

        public int AttackResult { get; set; } = 0;
        public int InflictedCasualties { get; set; } = 0;

        public Guid GuardPairing { get; set; } = Guid.Empty;


        public int RollInitiative(CCommander commander, int modifiers)
        {
            Initiative = Dice.Roll("1d20") 
                + UnitType.Stats["Initiative Penalty"] 
                + commander.Stats["Wisdom"] 
                + modifiers
                ;

            return Initiative;
        }

        public int RollAttack(CCommander commander, String proficiency, int modifiers)
        {
            AttackResult = Dice.Roll("1d100") 
                + UnitType.Stats["Offensive Strength"] 
                + Morale 
                + commander.Stats["Intelligence"] + commander.Stats[proficiency]
                + modifiers
                ;

            return AttackResult;
        }

        public int RollCasualties()
        {
            InflictedCasualties = (Dice.Roll(UnitType.Dice["Casualty Dice"]) * Size) / 100;
            return InflictedCasualties;
        }
    }
}
