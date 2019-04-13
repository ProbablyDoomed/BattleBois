using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleBois
{
    public partial class Form1 : Form
    {
        const int MAX_TRAITS = 10;

        const String TRAIT_NAME_CONTROL_PREFIX = "textTraitName";
        const String TRAIT_VALUE_CONTROL_PREFIX = "numericTraitValue";

        public Form1()
        {
            InitializeComponent();
            clearAllTraitRows();
        }        

        private void showSaveJsonObjectDialog<T>(T objectToSave)
        {
            saveDialog.InitialDirectory = Application.StartupPath 
                                        + Path.DirectorySeparatorChar 
                                        + JsonFiles.TYPE_DIRECTORIES[typeof(T)];

            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                JsonFiles.SaveAs<T>(saveDialog.FileName, objectToSave);
            }
        }

        private T showLoadJsonObjectDialog<T>()
        {
            loadDialog.InitialDirectory = Application.StartupPath
                                        + Path.DirectorySeparatorChar
                                        + JsonFiles.TYPE_DIRECTORIES[typeof(T)];

            loadDialog.ShowDialog();

            if (loadDialog.FileName != "")
            {
                return JsonFiles.LoadFrom<T>(loadDialog.FileName);                
            }
            else
            {
                return default(T);
            }
        }        

        private void buttonTraitAdd_Click(object sender, EventArgs e)
        {
            addNewTraitRow();
        }

        private void addNewTraitRow()
        {
            int newRow = unitTraitsTable.RowCount;

            if (newRow < MAX_TRAITS)
            {
                TextBox newText = new TextBox()
                {
                    Name = TRAIT_NAME_CONTROL_PREFIX + newRow.ToString(),
                    Dock = DockStyle.Fill
                };

                NumericUpDown newNumeric = new NumericUpDown()
                {
                    Name = TRAIT_VALUE_CONTROL_PREFIX + newRow.ToString(),
                    Dock = DockStyle.Fill
                };

                unitTraitsTable.Controls.Add(newText, 0, newRow);
                unitTraitsTable.Controls.Add(newNumeric, 1, newRow);
                unitTraitsTable.RowCount++;
            }
        }

        private void addNewTraitRow(String name, double value)
        {
            addNewTraitRow();
            int lastRow = unitTraitsTable.RowCount - 1;
            TextBox newTextBox = (TextBox)(unitTraitsTable.Controls[TRAIT_NAME_CONTROL_PREFIX + lastRow.ToString()]);
            NumericUpDown newNumeric = (NumericUpDown)(unitTraitsTable.Controls[TRAIT_VALUE_CONTROL_PREFIX + lastRow.ToString()]);
            newTextBox.Text = name;
            newNumeric.Value = (decimal)value;
        }

        private void buttonTraitRemove_Click(object sender, EventArgs e)
        {
            removeLastTraitRow();
        }

        private void removeLastTraitRow()
        {
            int lastRow = unitTraitsTable.RowCount - 1;

            if (lastRow >= 0)
            {
                unitTraitsTable.Controls.RemoveByKey(TRAIT_NAME_CONTROL_PREFIX + lastRow.ToString());
                unitTraitsTable.Controls.RemoveByKey(TRAIT_VALUE_CONTROL_PREFIX + lastRow.ToString());
                unitTraitsTable.RowCount--;
            }
        }

        private void clearAllTraitRows()
        {
            while(unitTraitsTable.RowCount > 0)
            {
                removeLastTraitRow();
            }
        }

        private void buttonSaveUnit_Click(object sender, EventArgs e)
        {
            CUnit unitToSave = new CUnit()
            {
                Name = unitNameText.Text,
                Type = unitTypeCombo.Text,
                Stats = new Dictionary<string, double>
                {
                    ["Offensive Strength"] = (double) unitOffenseNumeric.Value,
                    ["Defensive Strength"] = (double) unitDefenseNumeric.Value,
                    ["Initiative Penalty"] = (double) unitInitiativeNumeric.Value,
                    ["Recruitment Cost"]   = (double) unitRecruitmentNumeric.Value,
                    ["Maintenence Cost"]   = (double) unitMaintenenceNumeric.Value
                },
                Dice = new Dictionary<string, string>
                {
                    ["Casualty Dice"] = unitCasualtyText.Text,
                    ["Morale Dice"]   = unitMoraleText.Text
                }                
            };

            var traitSet = new Dictionary<string, int>();
            TextBox traitNameTextBox;
            NumericUpDown traitValueNumeric;
            for (int row = 0; row < unitTraitsTable.RowCount; row++)
            {
                traitNameTextBox = (TextBox) unitTraitsTable.Controls[TRAIT_NAME_CONTROL_PREFIX + row.ToString()];
                traitValueNumeric = (NumericUpDown) unitTraitsTable.Controls[TRAIT_VALUE_CONTROL_PREFIX + row.ToString()];
                traitSet.Add(traitNameTextBox.Text, (int)traitValueNumeric.Value);
            }
            unitToSave.Traits = traitSet;

            showSaveJsonObjectDialog<CUnit>(unitToSave);

        }

        private void buttonLoadUnit_Click(object sender, EventArgs e)
        {
            CUnit unitToLoad = showLoadJsonObjectDialog<CUnit>();

            if (unitToLoad != default(CUnit))
            {
                unitNameText.Text = unitToLoad.Name;
                unitTypeCombo.Text = unitToLoad.Type;

                unitOffenseNumeric.Value     = (decimal) unitToLoad.Stats["Offensive Strength"];
                unitDefenseNumeric.Value     = (decimal) unitToLoad.Stats["Defensive Strength"];
                unitInitiativeNumeric.Value  = (decimal) unitToLoad.Stats["Initiative Penalty"];
                unitRecruitmentNumeric.Value = (decimal) unitToLoad.Stats["Recruitment Cost"];
                unitMaintenenceNumeric.Value = (decimal) unitToLoad.Stats["Maintenence Cost"] ;

                unitCasualtyText.Text = unitToLoad.Dice["Casualty Dice"];
                unitMoraleText.Text   = unitToLoad.Dice["Morale Dice"];

                clearAllTraitRows();

                foreach(var trait in unitToLoad.Traits)
                {
                    addNewTraitRow(trait.Key, trait.Value);
                }
            }
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
                    ["Recruitment Cost"] = 2.5,
                    ["Maintenence Cost"] = 0.5
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

            for (int i = 0; i < 10; i++)
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