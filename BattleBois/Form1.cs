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

        const String TRAIT_NAME_CONTROL_PREFIX = "TextTraitName";
        const String TRAIT_VALUE_CONTROL_PREFIX = "NumericTraitValue";

        public Form1()
        {
            InitializeComponent();

            TraitReference.LoadTraitDefinitions();
            ClearAllTraitRows();

        }        

        private void ShowSaveJsonObjectDialog<T>(T objectToSave)
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

        private T ShowLoadJsonObjectDialog<T>()
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
        
        private void RefreshTraitDescriptionList(object sender, EventArgs e)
        {
            UnitCreateTraitDetailText.Text = "";
            for (int row = 0; row < UnitTraitsTable.RowCount; row++)
            {
                TextBox newTextBox = (TextBox)(UnitTraitsTable.Controls[TRAIT_NAME_CONTROL_PREFIX + row.ToString()]);
                NumericUpDown newNumeric = (NumericUpDown)(UnitTraitsTable.Controls[TRAIT_VALUE_CONTROL_PREFIX + row.ToString()]);
                String name = newTextBox.Text;
                int value = (int)newNumeric.Value;

                UnitCreateTraitDetailText.Text = UnitCreateTraitDetailText.Text + TraitReference.GetFullTraitDescription(name, value) + "\r\n";
  
            }
        }

        private void UnitTraitAddButton_Click(object sender, EventArgs e)
        {
            AddNewTraitRow();
        }

        private void AddNewTraitRow()
        {
            int newRow = UnitTraitsTable.RowCount;

            if (newRow < MAX_TRAITS)
            {
                TextBox newText = new TextBox()
                {
                    Name = TRAIT_NAME_CONTROL_PREFIX + newRow.ToString(),
                    Dock = DockStyle.Fill                   
                };
                newText.TextChanged += new EventHandler(RefreshTraitDescriptionList);

                NumericUpDown newNumeric = new NumericUpDown()
                {
                    Name = TRAIT_VALUE_CONTROL_PREFIX + newRow.ToString(),
                    Dock = DockStyle.Fill
                };
                newNumeric.ValueChanged += new EventHandler(RefreshTraitDescriptionList);

                UnitTraitsTable.Controls.Add(newText, 0, newRow);
                UnitTraitsTable.Controls.Add(newNumeric, 1, newRow);
                UnitTraitsTable.RowCount++;
            }
        }

        private void AddNewTraitRow(String name, double value)
        {
            AddNewTraitRow();
            int lastRow = UnitTraitsTable.RowCount - 1;
            TextBox newTextBox = (TextBox)(UnitTraitsTable.Controls[TRAIT_NAME_CONTROL_PREFIX + lastRow.ToString()]);
            NumericUpDown newNumeric = (NumericUpDown)(UnitTraitsTable.Controls[TRAIT_VALUE_CONTROL_PREFIX + lastRow.ToString()]);
            newTextBox.Text = name;
            newNumeric.Value = (decimal)value;
        }

        private void UnitTraitRemoveButton_Click(object sender, EventArgs e)
        {
            RemoveLastTraitRow();
        }

        private void RemoveLastTraitRow()
        {
            int lastRow = UnitTraitsTable.RowCount - 1;

            if (lastRow >= 0)
            {
                UnitTraitsTable.Controls.RemoveByKey(TRAIT_NAME_CONTROL_PREFIX + lastRow.ToString());
                UnitTraitsTable.Controls.RemoveByKey(TRAIT_VALUE_CONTROL_PREFIX + lastRow.ToString());
                UnitTraitsTable.RowCount--;
            }
        }

        private void ClearAllTraitRows()
        {
            while(UnitTraitsTable.RowCount > 0)
            {
                RemoveLastTraitRow();
            }
        }

        private void UnitSaveButton_Click(object sender, EventArgs e)
        {
            CUnit unitToSave = new CUnit()
            {
                Name = UnitNameText.Text,
                Type = UnitTypeCombo.Text,
                Stats = new Dictionary<string, double>
                {
                    [CUnit.STAT_OFFENSE]     = (double) UnitOffenseNumeric.Value,
                    [CUnit.STAT_DEFENSE]     = (double) UnitDefenseNumeric.Value,
                    [CUnit.STAT_INITIATIVE]  = (double) UnitInitiativeNumeric.Value,
                    [CUnit.STAT_RECRUITMENT] = (double) UnitRecruitmentNumeric.Value,
                    [CUnit.STAT_MAINTENANCE] = (double) UnitMaintenenceNumeric.Value
                },
                Dice = new Dictionary<string, string>
                {
                    [CUnit.DICE_CASUALTY] = UnitCasualtyText.Text,
                    [CUnit.DICE_MORALE]   = UnitMoraleText.Text
                }                
            };

            var traitSet = new Dictionary<string, int>();
            TextBox traitNameTextBox;
            NumericUpDown traitValueNumeric;
            for (int row = 0; row < UnitTraitsTable.RowCount; row++)
            {
                traitNameTextBox = (TextBox) UnitTraitsTable.Controls[TRAIT_NAME_CONTROL_PREFIX + row.ToString()];
                traitValueNumeric = (NumericUpDown) UnitTraitsTable.Controls[TRAIT_VALUE_CONTROL_PREFIX + row.ToString()];
                traitSet.Add(traitNameTextBox.Text, (int)traitValueNumeric.Value);
            }
            unitToSave.Traits = traitSet;

            ShowSaveJsonObjectDialog<CUnit>(unitToSave);

        }

        private void UnitLoadButton_Click(object sender, EventArgs e)
        {
            CUnit unitToLoad = ShowLoadJsonObjectDialog<CUnit>();

            if (unitToLoad != default(CUnit))
            {
                UnitNameText.Text = unitToLoad.Name;
                UnitTypeCombo.Text = unitToLoad.Type;

                UnitOffenseNumeric.Value     = (decimal) unitToLoad.Stats[CUnit.STAT_OFFENSE];
                UnitDefenseNumeric.Value     = (decimal) unitToLoad.Stats[CUnit.STAT_DEFENSE];
                UnitInitiativeNumeric.Value  = (decimal) unitToLoad.Stats[CUnit.STAT_INITIATIVE];
                UnitRecruitmentNumeric.Value = (decimal) unitToLoad.Stats[CUnit.STAT_RECRUITMENT];
                UnitMaintenenceNumeric.Value = (decimal) unitToLoad.Stats[CUnit.STAT_MAINTENANCE];

                UnitCasualtyText.Text = unitToLoad.Dice[CUnit.DICE_CASUALTY];
                UnitMoraleText.Text   = unitToLoad.Dice[CUnit.DICE_MORALE];

                ClearAllTraitRows();
                
                foreach (var trait in unitToLoad.Traits)
                {
                    AddNewTraitRow(trait.Key, trait.Value);
                }                
            }
        }

        private void CommanderSaveButton_Click(object sender, EventArgs e)
        {
            CCommander commanderToSave = new CCommander()
            {
                Name = CommanderNameText.Text,
                Stats = new Dictionary<string, int>
                {
                    [CCommander.STAT_INT] = (int) CommanderIntNumeric.Value,
                    [CCommander.STAT_WIS] = (int) CommanderWisNumeric.Value,
                    [CCommander.STAT_CHA] = (int) CommanderChaNumeric.Value,
                    [CCommander.STAT_LAND_WAR] = (int) CommanderLandWarNumeric.Value,
                    [CCommander.STAT_MARITIME] = (int) CommanderMaritimeNumeric.Value
                }
            };

            ShowSaveJsonObjectDialog<CCommander>(commanderToSave);
        }

        private void CommanderLoadButton_Click(object sender, EventArgs e)
        {
            CCommander commanderToLoad = ShowLoadJsonObjectDialog<CCommander>();

            if (commanderToLoad != default(CCommander))
            {
                CommanderNameText.Text = commanderToLoad.Name;

                CommanderIntNumeric.Value      = (decimal) commanderToLoad.Stats[CCommander.STAT_INT];
                CommanderWisNumeric.Value      = (decimal) commanderToLoad.Stats[CCommander.STAT_WIS];
                CommanderChaNumeric.Value      = (decimal) commanderToLoad.Stats[CCommander.STAT_CHA];
                CommanderLandWarNumeric.Value  = (decimal) commanderToLoad.Stats[CCommander.STAT_LAND_WAR];
                CommanderMaritimeNumeric.Value = (decimal) commanderToLoad.Stats[CCommander.STAT_MARITIME];
            }
        }

        private void TestButtonClick(object sender, EventArgs e)
        {

        }
    }
}