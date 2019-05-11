using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleBois 
{
    public class CUnit
    {
        public static readonly String DEFAULT_NAME = "Unnamed";
        public static readonly String DEFAULT_TYPE = "Untyped";
        public static readonly String DEFAULT_DICE = "Unnamed";
        public static readonly double DEFAULT_STAT = 0;

        public static readonly String STAT_OFFENSE     = "Offensive Strength";
        public static readonly String STAT_DEFENSE     = "Defensive Strength";
        public static readonly String STAT_INITIATIVE  = "Initiative Penalty";
        public static readonly String STAT_RECRUITMENT = "Recruitment Cost";
        public static readonly String STAT_MAINTENANCE  = "Offensive Strength";

        public static readonly String DICE_CASUALTY = "Casualty Dice";
        public static readonly String DICE_MORALE = "Morale Dice";

        public String Name { get; set; } = DEFAULT_NAME;
        public String Type { get; set; } = DEFAULT_TYPE;

        public Dictionary<String, double> Stats { get; set; } = new Dictionary<string, double>()
        {
            [CUnit.STAT_OFFENSE]     = DEFAULT_STAT,
            [CUnit.STAT_DEFENSE]     = DEFAULT_STAT,
            [CUnit.STAT_INITIATIVE]  = DEFAULT_STAT,
            [CUnit.STAT_RECRUITMENT] = DEFAULT_STAT,
            [CUnit.STAT_MAINTENANCE] = DEFAULT_STAT
        };

        public Dictionary<String, String> Dice { get; set; } = new Dictionary<string, string>()
        {
            [CUnit.DICE_CASUALTY] = DEFAULT_DICE,
            [CUnit.DICE_MORALE]   = DEFAULT_DICE
        };

        public Dictionary<String, int> Traits { get; set; } = new Dictionary<string, int>();
    }
}