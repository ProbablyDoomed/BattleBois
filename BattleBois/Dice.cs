using System;
using System.Windows.Forms;

namespace BattleBois
{
    static class Dice
    {
        private static readonly char[] PLUS_MINUS_CHARS = { '+', '-' };
        private static readonly Random rng = new Random();

        public enum Advantage
        {
            None,
            Advantage,
            Disadvantage
        }

        public static int D(int d)
        {
            return rng.Next(d) + 1;
        }

        public static int ND(int n, int d)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += D(d);
            }
            return result;
        }

        public static int Roll(String diceFormula, Advantage advantage = Advantage.None)
        {
            String formula = diceFormula.Replace(" ", "").ToLower(); //filter out uppercase and spaces

            int c = 0;
            int result = 0;

            bool applyPlusMinus = true;
            int indexD = formula.IndexOf('d');
            int indexPlusMinus = formula.IndexOfAny(PLUS_MINUS_CHARS);

            if(indexPlusMinus == -1)
            {
                applyPlusMinus = false;
                indexPlusMinus = formula.Length;
            }

            try
            {
                int n = int.Parse(formula.Substring(0, indexD));
                int d = int.Parse(formula.Substring(indexD + 1, indexPlusMinus - indexD - 1));
                if (applyPlusMinus)
                {
                    c = int.Parse(formula.Substring(indexPlusMinus + 1, formula.Length - indexPlusMinus - 1));
                    if (formula[indexPlusMinus] == '-')
                    {
                        c = 0 - c;
                    }
                }

                switch (advantage)
                {
                    case Advantage.None:
                        result = ND(n, d) + c;
                        break;
                    case Advantage.Advantage:
                        result = Math.Max(ND(n, d), ND(n, d)) + c;
                        break;
                    case Advantage.Disadvantage:
                        result = Math.Min(ND(n, d), ND(n, d)) + c;
                        break;
                }
            }
            catch(FormatException e)
            {
                MessageBox.Show("Dice formula not valid. Must be of the form \"XdY\", \"XdY+Z\", or \"XdY-Z\"." 
                     + "\r\n" + "If dice formula is not applicable to the unit, use an empty string: \"\", or \"n/a\". "
                     + "\r\n" + e.Message);
            }

            return result;
        }
    }
}
