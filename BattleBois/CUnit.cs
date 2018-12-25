using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleBois 
{
    class CUnit
    {
        public static readonly String DEFAULT_NAME = "Unnamed";
        public static readonly String DEFAULT_TYPE = "Untyped";

        public String Name { get; set; } = DEFAULT_NAME;
        public String Type { get; set; } = DEFAULT_TYPE;
        public Dictionary<String, double> Stats { get; set; } = new Dictionary<string, double>();
        public Dictionary<String, String> Dice { get; set; } = new Dictionary<string, string>();
        public Dictionary<String, int> Traits { get; set; } = new Dictionary<string, int>();
    }
}