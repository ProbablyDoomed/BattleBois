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
        private readonly int MAX_TRAITS = 10;
        private readonly int MAX_ARMY_DIVISIONS = 30;

        private readonly String TRAIT_NAME_CONTROL_PREFIX = "TextTraitName";
        private readonly String TRAIT_VALUE_CONTROL_PREFIX = "NumericTraitValue";
        private readonly String ARMY_EDIT_DIVISION_CONTROL_PREFIX = "ArmyEditDivison";

        private readonly Color DefaultDivisionBgColour = Color.White;
        private readonly Color SelectedDivisionBgColour = Color.LightBlue;
        private readonly Color InitiativeDivisionBgColour = Color.LightGreen;
        private readonly Color TargetedDivisionBgColour = Color.LightGoldenrodYellow;

        private CUnit divisionSelectedUnitType = new CUnit();
        private CArmy armyCreatorWorkingCopy = new CArmy();
        private DivisionControl selectedDivisionControl;

        public Form1()
        {
            InitializeComponent();

            UnitTypeCombo.Items.AddRange(new object[] {
                CUnit.TYPE_LIGHT_INFANTRY,
                CUnit.TYPE_HEAVY_INFANTRY,
                CUnit.TYPE_LIGHT_CAVALRY,
                CUnit.TYPE_HEAVY_CAVALRY,
                CUnit.TYPE_SIEGE_WEAPON
            });

            TraitReference.LoadTraitDefinitions();
            ClearAllArmyRows();
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

        private void RefreshDivisionTraitDescriptionList()
        {
            ArmyUnitDetailText.Text = "";
            foreach (KeyValuePair<String,int> trait in divisionSelectedUnitType.Traits)
            {
                ArmyUnitDetailText.Text = ArmyUnitDetailText.Text + TraitReference.GetFullTraitDescription(trait.Key, trait.Value) + "\r\n";
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
            while (UnitTraitsTable.RowCount > 0)
            {
                RemoveLastTraitRow();
            }
        }

        private void AddNewArmyRow()
        {
            int newRow = ArmyTable.RowCount;

            if (newRow < MAX_ARMY_DIVISIONS)
            {
                DivisionControl newDivision = new DivisionControl()
                {
                    Name = ARMY_EDIT_DIVISION_CONTROL_PREFIX + newRow.ToString(),
                };
                newDivision.MouseClick += ArmyEditorDivision_Click;
                foreach(Control ctrl in newDivision.Controls)
                {
                    ctrl.MouseClick += ArmyEditorDivision_Click;
                }
                ArmyTable.Controls.Add(newDivision, 0, newRow);
                ArmyTable.RowCount++;
            }
        }

        private void ArmyEditorDivision_Click(object sender, EventArgs e)
        {   
            if(selectedDivisionControl != null)
            {
                selectedDivisionControl.BackColor = DefaultDivisionBgColour;
            }

            if (sender.GetType() == typeof(DivisionControl))
            {
                selectedDivisionControl = ((DivisionControl)sender);
            }
            else
            {
                selectedDivisionControl = (DivisionControl)(((Control)sender).GetContainerControl());
            }

            selectedDivisionControl.BackColor = SelectedDivisionBgColour;

            CDivision division = selectedDivisionControl.DisplayedDivision;

            DivisionNameText.Text = division.Name;
            divisionSelectedUnitType = division.UnitType;
            DivisionUnitText.Text = divisionSelectedUnitType.Name;
            DivisionSizeNumeric.Value = division.StartingSize;
            DivisionSizeNumeric.Value = division.CurrentSize;
            DivisionMoraleNumeric.Value = division.Morale;

            RefreshDivisionTraitDescriptionList();
        }
        
        private void AddNewArmyRow(CDivision division)
        {
            AddNewArmyRow();
            int lastRow = ArmyTable.RowCount - 1;
            DivisionControl control = (DivisionControl)(ArmyTable.Controls[ARMY_EDIT_DIVISION_CONTROL_PREFIX + lastRow.ToString()]);
            control.DisplayedDivision = division;
        }
        
        private void RemoveLastArmyRow()
        {
            int lastRow = ArmyTable.RowCount - 1;
            if (lastRow >= 0)
            {
                DivisionControl lastDivisionControl = (DivisionControl)(ArmyTable.Controls[ARMY_EDIT_DIVISION_CONTROL_PREFIX + lastRow.ToString()]);
                if (lastDivisionControl != null)
                {
                    armyCreatorWorkingCopy.Divisions.Remove(lastDivisionControl.DisplayedDivision);
                    ArmyTable.Controls.Remove(lastDivisionControl);
                }
                ArmyTable.RowCount--;
            }
        }

        private void ClearAllArmyRows()
        {
            while (ArmyTable.RowCount > 0)
            {
                RemoveLastArmyRow();
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

        private void DivisionUnitLoadButton_Click(object sender, EventArgs e)
        {
            CUnit loadedDivisionUnit = ShowLoadJsonObjectDialog<CUnit>();
            if(loadedDivisionUnit != null)
            {
                divisionSelectedUnitType = loadedDivisionUnit;
                DivisionUnitText.Text = loadedDivisionUnit.Name;
                RefreshDivisionTraitDescriptionList();
            }
        }

        private void ArmyAddDivisionButton_Click(object sender, EventArgs e)
        {
            CDivision division = new CDivision()
            {
                Name = DivisionNameText.Text,
                UnitType = divisionSelectedUnitType,
                StartingSize = (int)DivisionSizeNumeric.Value,
                CurrentSize = (int)DivisionSizeNumeric.Value,
                Morale = (int)DivisionMoraleNumeric.Value,
            };
            armyCreatorWorkingCopy.Divisions.Add(division);
            AddNewArmyRow(division);
        }

        private void ArmyUpdateDivisionButton_Click(object sender, EventArgs e)
        {
            if (selectedDivisionControl != null)
            {
                CDivision division = selectedDivisionControl.DisplayedDivision;

                division.Name = DivisionNameText.Text;
                division.UnitType = divisionSelectedUnitType;
                division.StartingSize = (int)DivisionSizeNumeric.Value;
                division.CurrentSize = (int)DivisionSizeNumeric.Value;
                division.Morale = (int)DivisionMoraleNumeric.Value;

                selectedDivisionControl.RefreshDisplayedUnit();
            }
        }

        private void ArmyRemoveDivisionButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            for(int row=0; row < ArmyTable.RowCount; row++)
            {
                if (found)
                {
                    ArmyTable.SetRow(ArmyTable.Controls[ARMY_EDIT_DIVISION_CONTROL_PREFIX + row.ToString()], row - 1);
                    ArmyTable.Controls[ARMY_EDIT_DIVISION_CONTROL_PREFIX + row.ToString()].Name = ARMY_EDIT_DIVISION_CONTROL_PREFIX + (row - 1).ToString();
                }
                if (ArmyTable.Controls[ARMY_EDIT_DIVISION_CONTROL_PREFIX + row.ToString()] == selectedDivisionControl)
                {
                    found = true;
                    ArmyTable.Controls.RemoveByKey(ARMY_EDIT_DIVISION_CONTROL_PREFIX + row.ToString());
                    armyCreatorWorkingCopy.Divisions.Remove(selectedDivisionControl.DisplayedDivision);
                }
            }

            if (found)
            {
                ArmyTable.RowCount--;
                selectedDivisionControl = null;
            }

        }


        private void ArmyAddCommanderButton_Click(object sender, EventArgs e)
        {
            CCommander loadedCommander = ShowLoadJsonObjectDialog<CCommander>();
            if (loadedCommander != null)
            {
                if (!ArmyCommanderList.Items.Contains(loadedCommander.Name))
                {
                    armyCreatorWorkingCopy.Commanders.Add(loadedCommander);
                    ArmyCommanderList.Items.Add(loadedCommander.Name);
                }
            }
        }


        private void ArmyRemoveCommanderButton_Click(object sender, EventArgs e)
        {
            String removedCommanderName = ArmyCommanderList.SelectedItem.ToString();
            ArmyCommanderList.Items.Remove(ArmyCommanderList.SelectedItem);
            
            bool HasRemovedCommanderName(CCommander commander)
            {
                return commander.Name == removedCommanderName;
            }

            armyCreatorWorkingCopy.Commanders.RemoveAll(HasRemovedCommanderName);
        }

        private void ArmyCommanderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArmyCommanderDetailText.Text = "";
            if (ArmyCommanderList.SelectedItem != null)
            { 

                String selectedCommanderName = ArmyCommanderList.SelectedItem.ToString();

                bool HasSelectedCommanderName(CCommander commander)
                {
                    return commander.Name == selectedCommanderName;
                }

                CCommander selectedCommander = armyCreatorWorkingCopy.Commanders.Find(HasSelectedCommanderName);

                ArmyCommanderDetailText.Text = CCommander.STAT_INT + ": " + selectedCommander.Stats[CCommander.STAT_INT] + "    " +
                    CCommander.STAT_WIS + ": " + selectedCommander.Stats[CCommander.STAT_WIS] + "    " +
                    CCommander.STAT_CHA + ": " + selectedCommander.Stats[CCommander.STAT_CHA] + "\r\n" +
                    CCommander.STAT_LAND_WAR + ": " + selectedCommander.Stats[CCommander.STAT_LAND_WAR] + "    " +
                    CCommander.STAT_MARITIME + ": " + selectedCommander.Stats[CCommander.STAT_MARITIME];

            }
        }

        private void ArmySaveButton_Click(object sender, EventArgs e)
        {
            ShowSaveJsonObjectDialog<CArmy>(armyCreatorWorkingCopy);
        }

        private void ArmyLoadButton_Click(object sender, EventArgs e)
        {
            CArmy loadedArmy = ShowLoadJsonObjectDialog<CArmy>();
            if(loadedArmy != null)
            {
                armyCreatorWorkingCopy = loadedArmy;
                ClearAllArmyRows();
                ArmyCommanderList.Items.Clear();

                foreach(CDivision division in armyCreatorWorkingCopy.Divisions)
                {
                    AddNewArmyRow(division);
                }

                foreach (CCommander commander in armyCreatorWorkingCopy.Commanders)
                {
                    if (commander != CCommander.NO_COMMANDER)
                    {
                        ArmyCommanderList.Items.Add(commander.Name);
                    }
                }

            }
            
        }
    }
}