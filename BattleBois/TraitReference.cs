using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBois
{
    static class TraitReference
    {
        private static readonly String STRING_FMT_ARG_0 = "{0}";
        private static readonly String TRAIT_FILE = "TraitDefinitions.json";
        private static bool loaded = false;
        private static TraitDefinitions definitions;

        public class TraitDefinitions
        {
            public Dictionary<String, String> List = new Dictionary<String, String>();
        }        

        public static void LoadTraitDefinitions()
        {
            definitions = JsonFiles.LoadFromDefault<TraitDefinitions>(TRAIT_FILE);
            loaded = true;
        }

        public static List<string> GetTraitNameList()
        {
            if (loaded)
            {
                return definitions.List.Keys.ToList();
            }
            else
            {
                return new List<string>();
            }
        }

        public static bool IsThisATrait(String traitName)
        {
            if (loaded)
            {
                return GetTraitNameList().Contains(traitName);
            }
            else
            {
                return false;
            }
        }

        public static String GetFullTraitDescription(String traitName, int value)
        {
            if (IsThisATrait(traitName))
            {
                String explanation = definitions.List[traitName];
                String nameFormat = ": ", descriptionValue = "N";
                if(explanation.Contains(STRING_FMT_ARG_0))
                {
                    nameFormat = " "+ STRING_FMT_ARG_0 + ": ";
                    descriptionValue = value.ToString();
                }

                String description = traitName + nameFormat + definitions.List[traitName];
                description = String.Format(description, descriptionValue);
                return description;
            }
            else
            {
                return "Couldn't find a trait named \"" + traitName + "\"";
            }
        }
    }
}
