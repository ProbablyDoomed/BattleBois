using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleBois
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestButtonClick(object sender, EventArgs e)
        {
            CUnit dave = JsonFiles.LoadFrom<CUnit>("AbsoluteUnit.json");
            String dice = dave.Dice["Casualty Dice"];
            Console.WriteLine(dice + " --> " + Dice.Roll(dice).ToString());

            foreach (KeyValuePair<String, int> item in dave.Traits)
            {
                Console.WriteLine(item.Key + " " + (item.Value == 0 ? "" : item.Value.ToString()));
            }

            CUnit mike = new CUnit
            {
                Name = "Armed Bastards",
                Type = "Light Infantry",
                Stats = new Dictionary<string, double>
                {
                    ["Offensive Strength"] = 30,
		            ["Defensive Strength"] = 70,
		            ["Initiative Penalty"] = -3,
		            ["Recruitment Cost"]   = 2.5,
		            ["Maintenence Cost"]   = 0.5
                },
                Dice = new Dictionary<string, string>
                {
                    ["Casualty Dice"] = "1d20",
                    ["Morale Dice"] = "3d8-1"
                },
                Traits = new Dictionary<string, int>
                {
                    ["Horsedread"] = 10,
                    ["Horsebane"] = 20
                }
            };

            JsonFiles.SaveAs<CUnit>("bigbois.json", mike);


            CArmy fightClub = new CArmy()
            {
                Name = "Fight Club",
                Commander = JsonFiles.LoadFrom<CCommander>("Cy.json")
            };

            for (int i=0; i<10; i++)
            {
                fightClub.Divisions.Add(new CDivision()
                    {
                        UnitType = mike,
                        Name = "Mike Division " + i.ToString(),
                        Size = i * 10 - i
                    }
                );
            }

            JsonFiles.SaveAs<CArmy>("fightclub.json", fightClub);

        }
    }
}
