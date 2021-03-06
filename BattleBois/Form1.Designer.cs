﻿namespace BattleBois
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabArmy = new System.Windows.Forms.TabPage();
            this.ArmyUpdateDivisionButton = new System.Windows.Forms.Button();
            this.ArmyCommanderDetailText = new System.Windows.Forms.TextBox();
            this.ArmyUnitDetailText = new System.Windows.Forms.TextBox();
            this.ArmyRemoveDivisionButton = new System.Windows.Forms.Button();
            this.ArmyRemoveCommanderButton = new System.Windows.Forms.Button();
            this.ArmyAddCommanderButton = new System.Windows.Forms.Button();
            this.ArmyCommanderList = new System.Windows.Forms.ListBox();
            this.ArmyCommanderLabel = new System.Windows.Forms.Label();
            this.ArmyLoadButton = new System.Windows.Forms.Button();
            this.ArmySaveButton = new System.Windows.Forms.Button();
            this.ArmyTable = new System.Windows.Forms.TableLayoutPanel();
            this.ArmyAddDivisionButton = new System.Windows.Forms.Button();
            this.DivisionUnitLoadButton = new System.Windows.Forms.Button();
            this.DivisionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DivisionUnitText = new System.Windows.Forms.TextBox();
            this.DivisionMoraleNumeric = new System.Windows.Forms.NumericUpDown();
            this.DivisionSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.DivisionMoraleLabel = new System.Windows.Forms.Label();
            this.DivisionNameLabel = new System.Windows.Forms.Label();
            this.DivisionNameText = new System.Windows.Forms.TextBox();
            this.DivisionUnitLabel = new System.Windows.Forms.Label();
            this.DivisionSizeLabel = new System.Windows.Forms.Label();
            this.TabUnitCommander = new System.Windows.Forms.TabPage();
            this.UnitCreateTraitDetailText = new System.Windows.Forms.TextBox();
            this.CommanderLoadButton = new System.Windows.Forms.Button();
            this.CommanderSaveButton = new System.Windows.Forms.Button();
            this.CommanderCreateStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CommanderMaritimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.CommanderLandWarNumeric = new System.Windows.Forms.NumericUpDown();
            this.CommanderChaNumeric = new System.Windows.Forms.NumericUpDown();
            this.CommanderWisNumeric = new System.Windows.Forms.NumericUpDown();
            this.CommanderMaritimeLabel = new System.Windows.Forms.Label();
            this.CommanderLandWarLabel = new System.Windows.Forms.Label();
            this.CommanderChaLabel = new System.Windows.Forms.Label();
            this.CommanderNameLabel = new System.Windows.Forms.Label();
            this.CommanderNameText = new System.Windows.Forms.TextBox();
            this.CommanderIntLabel = new System.Windows.Forms.Label();
            this.CommanderIntNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitLoadButton = new System.Windows.Forms.Button();
            this.UnitSaveButton = new System.Windows.Forms.Button();
            this.UnitTraitRemoveButton = new System.Windows.Forms.Button();
            this.UnitTraitAddButton = new System.Windows.Forms.Button();
            this.UnitCreateStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.UnitTraitsLabel = new System.Windows.Forms.Label();
            this.UnitMoraleText = new System.Windows.Forms.TextBox();
            this.UnitMoraleLabel = new System.Windows.Forms.Label();
            this.UnitCasualtyText = new System.Windows.Forms.TextBox();
            this.UnitCasualtyLabel = new System.Windows.Forms.Label();
            this.UnitMaintenenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.UnitRecruitmentNumeric = new System.Windows.Forms.NumericUpDown();
            this.UnitInitiativeNumeric = new System.Windows.Forms.NumericUpDown();
            this.UnitDefenseNumeric = new System.Windows.Forms.NumericUpDown();
            this.UnitNameText = new System.Windows.Forms.TextBox();
            this.UnitNameLabel = new System.Windows.Forms.Label();
            this.UnitTypeLabel = new System.Windows.Forms.Label();
            this.UnitTypeCombo = new System.Windows.Forms.ComboBox();
            this.UnitOffenseLabel = new System.Windows.Forms.Label();
            this.UnitDefenseLabel = new System.Windows.Forms.Label();
            this.UnitInitiativeLabel = new System.Windows.Forms.Label();
            this.UnitRecruitmentLabel = new System.Windows.Forms.Label();
            this.UnitMaintenenceLabel = new System.Windows.Forms.Label();
            this.UnitOffenseNumeric = new System.Windows.Forms.NumericUpDown();
            this.UnitTraitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.TabBattle = new System.Windows.Forms.TabPage();
            this.AppTabs = new System.Windows.Forms.TabControl();
            this.TabOptions = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TraitFileResetButton = new System.Windows.Forms.Button();
            this.TraitFileExportButton = new System.Windows.Forms.Button();
            this.TraitFileSelectButton = new System.Windows.Forms.Button();
            this.BattleDirSelectButton = new System.Windows.Forms.Button();
            this.ArmyDirSelectButton = new System.Windows.Forms.Button();
            this.CommanderDirSelectButton = new System.Windows.Forms.Button();
            this.UnitDirSelectButton = new System.Windows.Forms.Button();
            this.TraitFileSelectText = new System.Windows.Forms.TextBox();
            this.BattleDirSelectText = new System.Windows.Forms.TextBox();
            this.CommanderDirSelectText = new System.Windows.Forms.TextBox();
            this.ArmyDirSelectText = new System.Windows.Forms.TextBox();
            this.UnitDirSelectText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OptionsCmdrDirLabel = new System.Windows.Forms.Label();
            this.OptionsUnitDirLabel = new System.Windows.Forms.Label();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ArmyNameLabel = new System.Windows.Forms.Label();
            this.ArmyNameText = new System.Windows.Forms.TextBox();
            this.TabArmy.SuspendLayout();
            this.DivisionLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionMoraleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionSizeNumeric)).BeginInit();
            this.TabUnitCommander.SuspendLayout();
            this.CommanderCreateStatsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderMaritimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderLandWarNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderChaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderWisNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderIntNumeric)).BeginInit();
            this.UnitCreateStatsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitMaintenenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitRecruitmentNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInitiativeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitDefenseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOffenseNumeric)).BeginInit();
            this.AppTabs.SuspendLayout();
            this.TabOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabArmy
            // 
            this.TabArmy.Controls.Add(this.ArmyNameLabel);
            this.TabArmy.Controls.Add(this.ArmyNameText);
            this.TabArmy.Controls.Add(this.ArmyUpdateDivisionButton);
            this.TabArmy.Controls.Add(this.ArmyCommanderDetailText);
            this.TabArmy.Controls.Add(this.ArmyUnitDetailText);
            this.TabArmy.Controls.Add(this.ArmyRemoveDivisionButton);
            this.TabArmy.Controls.Add(this.ArmyRemoveCommanderButton);
            this.TabArmy.Controls.Add(this.ArmyAddCommanderButton);
            this.TabArmy.Controls.Add(this.ArmyCommanderList);
            this.TabArmy.Controls.Add(this.ArmyCommanderLabel);
            this.TabArmy.Controls.Add(this.ArmyLoadButton);
            this.TabArmy.Controls.Add(this.ArmySaveButton);
            this.TabArmy.Controls.Add(this.ArmyTable);
            this.TabArmy.Controls.Add(this.ArmyAddDivisionButton);
            this.TabArmy.Controls.Add(this.DivisionUnitLoadButton);
            this.TabArmy.Controls.Add(this.DivisionLayoutPanel);
            this.TabArmy.Location = new System.Drawing.Point(4, 22);
            this.TabArmy.Name = "TabArmy";
            this.TabArmy.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabArmy.Size = new System.Drawing.Size(1056, 655);
            this.TabArmy.TabIndex = 2;
            this.TabArmy.Text = "Create Armies";
            this.TabArmy.UseVisualStyleBackColor = true;
            // 
            // ArmyUpdateDivisionButton
            // 
            this.ArmyUpdateDivisionButton.Location = new System.Drawing.Point(167, 164);
            this.ArmyUpdateDivisionButton.Name = "ArmyUpdateDivisionButton";
            this.ArmyUpdateDivisionButton.Size = new System.Drawing.Size(102, 24);
            this.ArmyUpdateDivisionButton.TabIndex = 20;
            this.ArmyUpdateDivisionButton.Text = "Update";
            this.ArmyUpdateDivisionButton.UseVisualStyleBackColor = true;
            this.ArmyUpdateDivisionButton.Click += new System.EventHandler(this.ArmyUpdateDivisionButton_Click);
            // 
            // ArmyCommanderDetailText
            // 
            this.ArmyCommanderDetailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmyCommanderDetailText.Location = new System.Drawing.Point(9, 564);
            this.ArmyCommanderDetailText.Multiline = true;
            this.ArmyCommanderDetailText.Name = "ArmyCommanderDetailText";
            this.ArmyCommanderDetailText.ReadOnly = true;
            this.ArmyCommanderDetailText.Size = new System.Drawing.Size(371, 75);
            this.ArmyCommanderDetailText.TabIndex = 19;
            // 
            // ArmyUnitDetailText
            // 
            this.ArmyUnitDetailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmyUnitDetailText.Location = new System.Drawing.Point(9, 194);
            this.ArmyUnitDetailText.Multiline = true;
            this.ArmyUnitDetailText.Name = "ArmyUnitDetailText";
            this.ArmyUnitDetailText.ReadOnly = true;
            this.ArmyUnitDetailText.Size = new System.Drawing.Size(371, 188);
            this.ArmyUnitDetailText.TabIndex = 18;
            // 
            // ArmyRemoveDivisionButton
            // 
            this.ArmyRemoveDivisionButton.Location = new System.Drawing.Point(58, 164);
            this.ArmyRemoveDivisionButton.Name = "ArmyRemoveDivisionButton";
            this.ArmyRemoveDivisionButton.Size = new System.Drawing.Size(102, 24);
            this.ArmyRemoveDivisionButton.TabIndex = 17;
            this.ArmyRemoveDivisionButton.Text = "Remove";
            this.ArmyRemoveDivisionButton.UseVisualStyleBackColor = true;
            this.ArmyRemoveDivisionButton.Click += new System.EventHandler(this.ArmyRemoveDivisionButton_Click);
            // 
            // ArmyRemoveCommanderButton
            // 
            this.ArmyRemoveCommanderButton.Location = new System.Drawing.Point(386, 509);
            this.ArmyRemoveCommanderButton.Name = "ArmyRemoveCommanderButton";
            this.ArmyRemoveCommanderButton.Size = new System.Drawing.Size(67, 22);
            this.ArmyRemoveCommanderButton.TabIndex = 16;
            this.ArmyRemoveCommanderButton.Text = "Remove";
            this.ArmyRemoveCommanderButton.UseVisualStyleBackColor = true;
            this.ArmyRemoveCommanderButton.Click += new System.EventHandler(this.ArmyRemoveCommanderButton_Click);
            // 
            // ArmyAddCommanderButton
            // 
            this.ArmyAddCommanderButton.Location = new System.Drawing.Point(386, 480);
            this.ArmyAddCommanderButton.Name = "ArmyAddCommanderButton";
            this.ArmyAddCommanderButton.Size = new System.Drawing.Size(67, 22);
            this.ArmyAddCommanderButton.TabIndex = 15;
            this.ArmyAddCommanderButton.Text = "Add...";
            this.ArmyAddCommanderButton.UseVisualStyleBackColor = true;
            this.ArmyAddCommanderButton.Click += new System.EventHandler(this.ArmyAddCommanderButton_Click);
            // 
            // ArmyCommanderList
            // 
            this.ArmyCommanderList.FormattingEnabled = true;
            this.ArmyCommanderList.Location = new System.Drawing.Point(9, 411);
            this.ArmyCommanderList.Name = "ArmyCommanderList";
            this.ArmyCommanderList.Size = new System.Drawing.Size(371, 147);
            this.ArmyCommanderList.TabIndex = 14;
            this.ArmyCommanderList.SelectedIndexChanged += new System.EventHandler(this.ArmyCommanderList_SelectedIndexChanged);
            // 
            // ArmyCommanderLabel
            // 
            this.ArmyCommanderLabel.AutoSize = true;
            this.ArmyCommanderLabel.Location = new System.Drawing.Point(9, 298);
            this.ArmyCommanderLabel.Name = "ArmyCommanderLabel";
            this.ArmyCommanderLabel.Size = new System.Drawing.Size(68, 13);
            this.ArmyCommanderLabel.TabIndex = 13;
            this.ArmyCommanderLabel.Text = "Commanders";
            // 
            // ArmyLoadButton
            // 
            this.ArmyLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmyLoadButton.Location = new System.Drawing.Point(936, 60);
            this.ArmyLoadButton.Name = "ArmyLoadButton";
            this.ArmyLoadButton.Size = new System.Drawing.Size(93, 52);
            this.ArmyLoadButton.TabIndex = 12;
            this.ArmyLoadButton.Text = "Load Army";
            this.ArmyLoadButton.UseVisualStyleBackColor = true;
            this.ArmyLoadButton.Click += new System.EventHandler(this.ArmyLoadButton_Click);
            // 
            // ArmySaveButton
            // 
            this.ArmySaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmySaveButton.Location = new System.Drawing.Point(936, 6);
            this.ArmySaveButton.Name = "ArmySaveButton";
            this.ArmySaveButton.Size = new System.Drawing.Size(93, 52);
            this.ArmySaveButton.TabIndex = 11;
            this.ArmySaveButton.Text = "Save Army";
            this.ArmySaveButton.UseVisualStyleBackColor = true;
            this.ArmySaveButton.Click += new System.EventHandler(this.ArmySaveButton_Click);
            // 
            // ArmyTable
            // 
            this.ArmyTable.AutoScroll = true;
            this.ArmyTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ArmyTable.ColumnCount = 1;
            this.ArmyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ArmyTable.Location = new System.Drawing.Point(604, 6);
            this.ArmyTable.Name = "ArmyTable";
            this.ArmyTable.RowCount = 1;
            this.ArmyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ArmyTable.Size = new System.Drawing.Size(326, 636);
            this.ArmyTable.TabIndex = 10;
            // 
            // ArmyAddDivisionButton
            // 
            this.ArmyAddDivisionButton.Location = new System.Drawing.Point(275, 164);
            this.ArmyAddDivisionButton.Name = "ArmyAddDivisionButton";
            this.ArmyAddDivisionButton.Size = new System.Drawing.Size(102, 24);
            this.ArmyAddDivisionButton.TabIndex = 9;
            this.ArmyAddDivisionButton.Text = "Add";
            this.ArmyAddDivisionButton.UseVisualStyleBackColor = true;
            this.ArmyAddDivisionButton.Click += new System.EventHandler(this.ArmyAddDivisionButton_Click);
            // 
            // DivisionUnitLoadButton
            // 
            this.DivisionUnitLoadButton.Location = new System.Drawing.Point(383, 79);
            this.DivisionUnitLoadButton.Name = "DivisionUnitLoadButton";
            this.DivisionUnitLoadButton.Size = new System.Drawing.Size(67, 22);
            this.DivisionUnitLoadButton.TabIndex = 7;
            this.DivisionUnitLoadButton.Text = "Select...";
            this.DivisionUnitLoadButton.UseVisualStyleBackColor = true;
            this.DivisionUnitLoadButton.Click += new System.EventHandler(this.DivisionUnitLoadButton_Click);
            // 
            // DivisionLayoutPanel
            // 
            this.DivisionLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DivisionLayoutPanel.ColumnCount = 2;
            this.DivisionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DivisionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DivisionLayoutPanel.Controls.Add(this.DivisionUnitText, 1, 1);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionMoraleNumeric, 1, 3);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionSizeNumeric, 1, 2);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionMoraleLabel, 0, 3);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionNameLabel, 0, 0);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionNameText, 1, 0);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionUnitLabel, 0, 1);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionSizeLabel, 0, 2);
            this.DivisionLayoutPanel.Location = new System.Drawing.Point(9, 50);
            this.DivisionLayoutPanel.Name = "DivisionLayoutPanel";
            this.DivisionLayoutPanel.RowCount = 4;
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DivisionLayoutPanel.Size = new System.Drawing.Size(371, 108);
            this.DivisionLayoutPanel.TabIndex = 6;
            // 
            // DivisionUnitText
            // 
            this.DivisionUnitText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionUnitText.Location = new System.Drawing.Point(89, 31);
            this.DivisionUnitText.Name = "DivisionUnitText";
            this.DivisionUnitText.ReadOnly = true;
            this.DivisionUnitText.Size = new System.Drawing.Size(278, 20);
            this.DivisionUnitText.TabIndex = 14;
            // 
            // DivisionMoraleNumeric
            // 
            this.DivisionMoraleNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionMoraleNumeric.Location = new System.Drawing.Point(89, 85);
            this.DivisionMoraleNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DivisionMoraleNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.DivisionMoraleNumeric.Name = "DivisionMoraleNumeric";
            this.DivisionMoraleNumeric.Size = new System.Drawing.Size(278, 20);
            this.DivisionMoraleNumeric.TabIndex = 13;
            // 
            // DivisionSizeNumeric
            // 
            this.DivisionSizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionSizeNumeric.Location = new System.Drawing.Point(89, 58);
            this.DivisionSizeNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DivisionSizeNumeric.Name = "DivisionSizeNumeric";
            this.DivisionSizeNumeric.Size = new System.Drawing.Size(278, 20);
            this.DivisionSizeNumeric.TabIndex = 12;
            this.DivisionSizeNumeric.ThousandsSeparator = true;
            this.DivisionSizeNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // DivisionMoraleLabel
            // 
            this.DivisionMoraleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionMoraleLabel.AutoSize = true;
            this.DivisionMoraleLabel.Location = new System.Drawing.Point(4, 82);
            this.DivisionMoraleLabel.Name = "DivisionMoraleLabel";
            this.DivisionMoraleLabel.Size = new System.Drawing.Size(78, 26);
            this.DivisionMoraleLabel.TabIndex = 6;
            this.DivisionMoraleLabel.Text = "Starting Morale";
            this.DivisionMoraleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DivisionNameLabel
            // 
            this.DivisionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionNameLabel.AutoSize = true;
            this.DivisionNameLabel.Location = new System.Drawing.Point(4, 1);
            this.DivisionNameLabel.Name = "DivisionNameLabel";
            this.DivisionNameLabel.Size = new System.Drawing.Size(78, 26);
            this.DivisionNameLabel.TabIndex = 2;
            this.DivisionNameLabel.Text = "Division Name";
            this.DivisionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DivisionNameText
            // 
            this.DivisionNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionNameText.Location = new System.Drawing.Point(89, 4);
            this.DivisionNameText.Name = "DivisionNameText";
            this.DivisionNameText.Size = new System.Drawing.Size(278, 20);
            this.DivisionNameText.TabIndex = 3;
            // 
            // DivisionUnitLabel
            // 
            this.DivisionUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionUnitLabel.AutoSize = true;
            this.DivisionUnitLabel.Location = new System.Drawing.Point(4, 28);
            this.DivisionUnitLabel.Name = "DivisionUnitLabel";
            this.DivisionUnitLabel.Size = new System.Drawing.Size(78, 26);
            this.DivisionUnitLabel.TabIndex = 4;
            this.DivisionUnitLabel.Text = "Unit Type";
            this.DivisionUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DivisionSizeLabel
            // 
            this.DivisionSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionSizeLabel.AutoSize = true;
            this.DivisionSizeLabel.Location = new System.Drawing.Point(4, 55);
            this.DivisionSizeLabel.Name = "DivisionSizeLabel";
            this.DivisionSizeLabel.Size = new System.Drawing.Size(78, 26);
            this.DivisionSizeLabel.TabIndex = 11;
            this.DivisionSizeLabel.Text = "Starting Size";
            this.DivisionSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabUnitCommander
            // 
            this.TabUnitCommander.Controls.Add(this.UnitCreateTraitDetailText);
            this.TabUnitCommander.Controls.Add(this.CommanderLoadButton);
            this.TabUnitCommander.Controls.Add(this.CommanderSaveButton);
            this.TabUnitCommander.Controls.Add(this.CommanderCreateStatsTable);
            this.TabUnitCommander.Controls.Add(this.UnitLoadButton);
            this.TabUnitCommander.Controls.Add(this.UnitSaveButton);
            this.TabUnitCommander.Controls.Add(this.UnitTraitRemoveButton);
            this.TabUnitCommander.Controls.Add(this.UnitTraitAddButton);
            this.TabUnitCommander.Controls.Add(this.UnitCreateStatsTable);
            this.TabUnitCommander.Location = new System.Drawing.Point(4, 22);
            this.TabUnitCommander.Name = "TabUnitCommander";
            this.TabUnitCommander.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabUnitCommander.Size = new System.Drawing.Size(1056, 655);
            this.TabUnitCommander.TabIndex = 1;
            this.TabUnitCommander.Text = "Create Unit Types and Commanders";
            this.TabUnitCommander.UseVisualStyleBackColor = true;
            // 
            // UnitCreateTraitDetailText
            // 
            this.UnitCreateTraitDetailText.Location = new System.Drawing.Point(369, 328);
            this.UnitCreateTraitDetailText.Multiline = true;
            this.UnitCreateTraitDetailText.Name = "UnitCreateTraitDetailText";
            this.UnitCreateTraitDetailText.ReadOnly = true;
            this.UnitCreateTraitDetailText.Size = new System.Drawing.Size(479, 318);
            this.UnitCreateTraitDetailText.TabIndex = 8;
            // 
            // CommanderLoadButton
            // 
            this.CommanderLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommanderLoadButton.Location = new System.Drawing.Point(854, 65);
            this.CommanderLoadButton.Name = "CommanderLoadButton";
            this.CommanderLoadButton.Size = new System.Drawing.Size(93, 52);
            this.CommanderLoadButton.TabIndex = 7;
            this.CommanderLoadButton.Text = "Load Commander";
            this.CommanderLoadButton.UseVisualStyleBackColor = true;
            this.CommanderLoadButton.Click += new System.EventHandler(this.CommanderLoadButton_Click);
            // 
            // CommanderSaveButton
            // 
            this.CommanderSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommanderSaveButton.Location = new System.Drawing.Point(854, 7);
            this.CommanderSaveButton.Name = "CommanderSaveButton";
            this.CommanderSaveButton.Size = new System.Drawing.Size(93, 52);
            this.CommanderSaveButton.TabIndex = 6;
            this.CommanderSaveButton.Text = "Save Commander";
            this.CommanderSaveButton.UseVisualStyleBackColor = true;
            this.CommanderSaveButton.Click += new System.EventHandler(this.CommanderSaveButton_Click);
            // 
            // CommanderCreateStatsTable
            // 
            this.CommanderCreateStatsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CommanderCreateStatsTable.ColumnCount = 2;
            this.CommanderCreateStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CommanderCreateStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderMaritimeNumeric, 1, 5);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderLandWarNumeric, 1, 4);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderChaNumeric, 1, 3);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderWisNumeric, 1, 2);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderMaritimeLabel, 0, 5);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderLandWarLabel, 0, 4);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderChaLabel, 0, 3);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderNameLabel, 0, 0);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderNameText, 1, 0);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderIntLabel, 0, 1);
            this.CommanderCreateStatsTable.Controls.Add(this.CommanderIntNumeric, 1, 1);
            this.CommanderCreateStatsTable.Controls.Add(this.label1, 0, 2);
            this.CommanderCreateStatsTable.Location = new System.Drawing.Point(496, 7);
            this.CommanderCreateStatsTable.Name = "CommanderCreateStatsTable";
            this.CommanderCreateStatsTable.RowCount = 6;
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.Size = new System.Drawing.Size(352, 162);
            this.CommanderCreateStatsTable.TabIndex = 5;
            // 
            // CommanderMaritimeNumeric
            // 
            this.CommanderMaritimeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderMaritimeNumeric.Location = new System.Drawing.Point(105, 139);
            this.CommanderMaritimeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CommanderMaritimeNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CommanderMaritimeNumeric.Name = "CommanderMaritimeNumeric";
            this.CommanderMaritimeNumeric.Size = new System.Drawing.Size(243, 20);
            this.CommanderMaritimeNumeric.TabIndex = 15;
            // 
            // CommanderLandWarNumeric
            // 
            this.CommanderLandWarNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderLandWarNumeric.Location = new System.Drawing.Point(105, 112);
            this.CommanderLandWarNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CommanderLandWarNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CommanderLandWarNumeric.Name = "CommanderLandWarNumeric";
            this.CommanderLandWarNumeric.Size = new System.Drawing.Size(243, 20);
            this.CommanderLandWarNumeric.TabIndex = 14;
            // 
            // CommanderChaNumeric
            // 
            this.CommanderChaNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderChaNumeric.Location = new System.Drawing.Point(105, 85);
            this.CommanderChaNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CommanderChaNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CommanderChaNumeric.Name = "CommanderChaNumeric";
            this.CommanderChaNumeric.Size = new System.Drawing.Size(243, 20);
            this.CommanderChaNumeric.TabIndex = 13;
            // 
            // CommanderWisNumeric
            // 
            this.CommanderWisNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderWisNumeric.Location = new System.Drawing.Point(105, 58);
            this.CommanderWisNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CommanderWisNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CommanderWisNumeric.Name = "CommanderWisNumeric";
            this.CommanderWisNumeric.Size = new System.Drawing.Size(243, 20);
            this.CommanderWisNumeric.TabIndex = 12;
            // 
            // CommanderMaritimeLabel
            // 
            this.CommanderMaritimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderMaritimeLabel.AutoSize = true;
            this.CommanderMaritimeLabel.Location = new System.Drawing.Point(4, 136);
            this.CommanderMaritimeLabel.Name = "CommanderMaritimeLabel";
            this.CommanderMaritimeLabel.Size = new System.Drawing.Size(94, 26);
            this.CommanderMaritimeLabel.TabIndex = 6;
            this.CommanderMaritimeLabel.Text = "Maritime Tactics";
            this.CommanderMaritimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommanderLandWarLabel
            // 
            this.CommanderLandWarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderLandWarLabel.AutoSize = true;
            this.CommanderLandWarLabel.Location = new System.Drawing.Point(4, 109);
            this.CommanderLandWarLabel.Name = "CommanderLandWarLabel";
            this.CommanderLandWarLabel.Size = new System.Drawing.Size(94, 26);
            this.CommanderLandWarLabel.TabIndex = 6;
            this.CommanderLandWarLabel.Text = "Land Warfare";
            this.CommanderLandWarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommanderChaLabel
            // 
            this.CommanderChaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderChaLabel.AutoSize = true;
            this.CommanderChaLabel.Location = new System.Drawing.Point(4, 82);
            this.CommanderChaLabel.Name = "CommanderChaLabel";
            this.CommanderChaLabel.Size = new System.Drawing.Size(94, 26);
            this.CommanderChaLabel.TabIndex = 6;
            this.CommanderChaLabel.Text = "CHA";
            this.CommanderChaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommanderNameLabel
            // 
            this.CommanderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderNameLabel.AutoSize = true;
            this.CommanderNameLabel.Location = new System.Drawing.Point(4, 1);
            this.CommanderNameLabel.Name = "CommanderNameLabel";
            this.CommanderNameLabel.Size = new System.Drawing.Size(94, 26);
            this.CommanderNameLabel.TabIndex = 2;
            this.CommanderNameLabel.Text = "Commander Name";
            this.CommanderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommanderNameText
            // 
            this.CommanderNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderNameText.Location = new System.Drawing.Point(105, 4);
            this.CommanderNameText.Name = "CommanderNameText";
            this.CommanderNameText.Size = new System.Drawing.Size(243, 20);
            this.CommanderNameText.TabIndex = 3;
            // 
            // CommanderIntLabel
            // 
            this.CommanderIntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderIntLabel.AutoSize = true;
            this.CommanderIntLabel.Location = new System.Drawing.Point(4, 28);
            this.CommanderIntLabel.Name = "CommanderIntLabel";
            this.CommanderIntLabel.Size = new System.Drawing.Size(94, 26);
            this.CommanderIntLabel.TabIndex = 4;
            this.CommanderIntLabel.Text = "INT";
            this.CommanderIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommanderIntNumeric
            // 
            this.CommanderIntNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommanderIntNumeric.Location = new System.Drawing.Point(105, 31);
            this.CommanderIntNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CommanderIntNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CommanderIntNumeric.Name = "CommanderIntNumeric";
            this.CommanderIntNumeric.Size = new System.Drawing.Size(243, 20);
            this.CommanderIntNumeric.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "WIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitLoadButton
            // 
            this.UnitLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitLoadButton.Location = new System.Drawing.Point(369, 66);
            this.UnitLoadButton.Name = "UnitLoadButton";
            this.UnitLoadButton.Size = new System.Drawing.Size(86, 52);
            this.UnitLoadButton.TabIndex = 4;
            this.UnitLoadButton.Text = "Load Unit";
            this.UnitLoadButton.UseVisualStyleBackColor = true;
            this.UnitLoadButton.Click += new System.EventHandler(this.UnitLoadButton_Click);
            // 
            // UnitSaveButton
            // 
            this.UnitSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitSaveButton.Location = new System.Drawing.Point(369, 8);
            this.UnitSaveButton.Name = "UnitSaveButton";
            this.UnitSaveButton.Size = new System.Drawing.Size(86, 52);
            this.UnitSaveButton.TabIndex = 3;
            this.UnitSaveButton.Text = "Save Unit";
            this.UnitSaveButton.UseVisualStyleBackColor = true;
            this.UnitSaveButton.Click += new System.EventHandler(this.UnitSaveButton_Click);
            // 
            // UnitTraitRemoveButton
            // 
            this.UnitTraitRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTraitRemoveButton.Location = new System.Drawing.Point(369, 254);
            this.UnitTraitRemoveButton.Name = "UnitTraitRemoveButton";
            this.UnitTraitRemoveButton.Size = new System.Drawing.Size(34, 31);
            this.UnitTraitRemoveButton.TabIndex = 2;
            this.UnitTraitRemoveButton.Text = "-";
            this.UnitTraitRemoveButton.UseVisualStyleBackColor = true;
            this.UnitTraitRemoveButton.Click += new System.EventHandler(this.UnitTraitRemoveButton_Click);
            // 
            // UnitTraitAddButton
            // 
            this.UnitTraitAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTraitAddButton.Location = new System.Drawing.Point(369, 291);
            this.UnitTraitAddButton.Name = "UnitTraitAddButton";
            this.UnitTraitAddButton.Size = new System.Drawing.Size(34, 31);
            this.UnitTraitAddButton.TabIndex = 1;
            this.UnitTraitAddButton.Text = "+";
            this.UnitTraitAddButton.UseVisualStyleBackColor = true;
            this.UnitTraitAddButton.Click += new System.EventHandler(this.UnitTraitAddButton_Click);
            // 
            // UnitCreateStatsTable
            // 
            this.UnitCreateStatsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UnitCreateStatsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.UnitCreateStatsTable.ColumnCount = 2;
            this.UnitCreateStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UnitCreateStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UnitCreateStatsTable.Controls.Add(this.UnitTraitsLabel, 0, 9);
            this.UnitCreateStatsTable.Controls.Add(this.UnitMoraleText, 1, 8);
            this.UnitCreateStatsTable.Controls.Add(this.UnitMoraleLabel, 0, 8);
            this.UnitCreateStatsTable.Controls.Add(this.UnitCasualtyText, 1, 7);
            this.UnitCreateStatsTable.Controls.Add(this.UnitCasualtyLabel, 0, 7);
            this.UnitCreateStatsTable.Controls.Add(this.UnitMaintenenceNumeric, 1, 6);
            this.UnitCreateStatsTable.Controls.Add(this.UnitRecruitmentNumeric, 1, 5);
            this.UnitCreateStatsTable.Controls.Add(this.UnitInitiativeNumeric, 1, 4);
            this.UnitCreateStatsTable.Controls.Add(this.UnitDefenseNumeric, 1, 3);
            this.UnitCreateStatsTable.Controls.Add(this.UnitNameText, 1, 0);
            this.UnitCreateStatsTable.Controls.Add(this.UnitNameLabel, 0, 0);
            this.UnitCreateStatsTable.Controls.Add(this.UnitTypeLabel, 0, 1);
            this.UnitCreateStatsTable.Controls.Add(this.UnitTypeCombo, 1, 1);
            this.UnitCreateStatsTable.Controls.Add(this.UnitOffenseLabel, 0, 2);
            this.UnitCreateStatsTable.Controls.Add(this.UnitDefenseLabel, 0, 3);
            this.UnitCreateStatsTable.Controls.Add(this.UnitInitiativeLabel, 0, 4);
            this.UnitCreateStatsTable.Controls.Add(this.UnitRecruitmentLabel, 0, 5);
            this.UnitCreateStatsTable.Controls.Add(this.UnitMaintenenceLabel, 0, 6);
            this.UnitCreateStatsTable.Controls.Add(this.UnitOffenseNumeric, 1, 2);
            this.UnitCreateStatsTable.Controls.Add(this.UnitTraitsTable, 1, -1);
            this.UnitCreateStatsTable.Location = new System.Drawing.Point(9, 7);
            this.UnitCreateStatsTable.Name = "UnitCreateStatsTable";
            this.UnitCreateStatsTable.RowCount = 10;
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UnitCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UnitCreateStatsTable.Size = new System.Drawing.Size(354, 643);
            this.UnitCreateStatsTable.TabIndex = 0;
            // 
            // UnitTraitsLabel
            // 
            this.UnitTraitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTraitsLabel.AutoSize = true;
            this.UnitTraitsLabel.Location = new System.Drawing.Point(4, 253);
            this.UnitTraitsLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.UnitTraitsLabel.Name = "UnitTraitsLabel";
            this.UnitTraitsLabel.Size = new System.Drawing.Size(98, 13);
            this.UnitTraitsLabel.TabIndex = 18;
            this.UnitTraitsLabel.Text = "Traits";
            this.UnitTraitsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UnitMoraleText
            // 
            this.UnitMoraleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitMoraleText.Location = new System.Drawing.Point(109, 220);
            this.UnitMoraleText.Name = "UnitMoraleText";
            this.UnitMoraleText.Size = new System.Drawing.Size(241, 20);
            this.UnitMoraleText.TabIndex = 17;
            // 
            // UnitMoraleLabel
            // 
            this.UnitMoraleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitMoraleLabel.AutoSize = true;
            this.UnitMoraleLabel.Location = new System.Drawing.Point(4, 217);
            this.UnitMoraleLabel.Name = "UnitMoraleLabel";
            this.UnitMoraleLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitMoraleLabel.TabIndex = 16;
            this.UnitMoraleLabel.Text = "Morale Dice";
            this.UnitMoraleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitCasualtyText
            // 
            this.UnitCasualtyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitCasualtyText.Location = new System.Drawing.Point(109, 193);
            this.UnitCasualtyText.Name = "UnitCasualtyText";
            this.UnitCasualtyText.Size = new System.Drawing.Size(241, 20);
            this.UnitCasualtyText.TabIndex = 15;
            // 
            // UnitCasualtyLabel
            // 
            this.UnitCasualtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitCasualtyLabel.AutoSize = true;
            this.UnitCasualtyLabel.Location = new System.Drawing.Point(4, 190);
            this.UnitCasualtyLabel.Name = "UnitCasualtyLabel";
            this.UnitCasualtyLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitCasualtyLabel.TabIndex = 14;
            this.UnitCasualtyLabel.Text = "Casualty Dice";
            this.UnitCasualtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitMaintenenceNumeric
            // 
            this.UnitMaintenenceNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitMaintenenceNumeric.DecimalPlaces = 2;
            this.UnitMaintenenceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UnitMaintenenceNumeric.Location = new System.Drawing.Point(109, 166);
            this.UnitMaintenenceNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UnitMaintenenceNumeric.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.UnitMaintenenceNumeric.Name = "UnitMaintenenceNumeric";
            this.UnitMaintenenceNumeric.Size = new System.Drawing.Size(241, 20);
            this.UnitMaintenenceNumeric.TabIndex = 13;
            // 
            // UnitRecruitmentNumeric
            // 
            this.UnitRecruitmentNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitRecruitmentNumeric.DecimalPlaces = 2;
            this.UnitRecruitmentNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UnitRecruitmentNumeric.Location = new System.Drawing.Point(109, 139);
            this.UnitRecruitmentNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UnitRecruitmentNumeric.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.UnitRecruitmentNumeric.Name = "UnitRecruitmentNumeric";
            this.UnitRecruitmentNumeric.Size = new System.Drawing.Size(241, 20);
            this.UnitRecruitmentNumeric.TabIndex = 12;
            // 
            // UnitInitiativeNumeric
            // 
            this.UnitInitiativeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitInitiativeNumeric.Location = new System.Drawing.Point(109, 112);
            this.UnitInitiativeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UnitInitiativeNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.UnitInitiativeNumeric.Name = "UnitInitiativeNumeric";
            this.UnitInitiativeNumeric.Size = new System.Drawing.Size(241, 20);
            this.UnitInitiativeNumeric.TabIndex = 11;
            // 
            // UnitDefenseNumeric
            // 
            this.UnitDefenseNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitDefenseNumeric.Location = new System.Drawing.Point(109, 85);
            this.UnitDefenseNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UnitDefenseNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.UnitDefenseNumeric.Name = "UnitDefenseNumeric";
            this.UnitDefenseNumeric.Size = new System.Drawing.Size(241, 20);
            this.UnitDefenseNumeric.TabIndex = 10;
            // 
            // UnitNameText
            // 
            this.UnitNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitNameText.Location = new System.Drawing.Point(109, 4);
            this.UnitNameText.Name = "UnitNameText";
            this.UnitNameText.Size = new System.Drawing.Size(241, 20);
            this.UnitNameText.TabIndex = 0;
            // 
            // UnitNameLabel
            // 
            this.UnitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitNameLabel.AutoSize = true;
            this.UnitNameLabel.Location = new System.Drawing.Point(4, 1);
            this.UnitNameLabel.Name = "UnitNameLabel";
            this.UnitNameLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitNameLabel.TabIndex = 1;
            this.UnitNameLabel.Text = "Unit Name";
            this.UnitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitTypeLabel
            // 
            this.UnitTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTypeLabel.AutoSize = true;
            this.UnitTypeLabel.Location = new System.Drawing.Point(4, 28);
            this.UnitTypeLabel.Name = "UnitTypeLabel";
            this.UnitTypeLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitTypeLabel.TabIndex = 2;
            this.UnitTypeLabel.Text = "Unit Type";
            this.UnitTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitTypeCombo
            // 
            this.UnitTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTypeCombo.FormattingEnabled = true;
            this.UnitTypeCombo.Location = new System.Drawing.Point(109, 31);
            this.UnitTypeCombo.Name = "UnitTypeCombo";
            this.UnitTypeCombo.Size = new System.Drawing.Size(241, 21);
            this.UnitTypeCombo.TabIndex = 3;
            // 
            // UnitOffenseLabel
            // 
            this.UnitOffenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitOffenseLabel.AutoSize = true;
            this.UnitOffenseLabel.Location = new System.Drawing.Point(4, 55);
            this.UnitOffenseLabel.Name = "UnitOffenseLabel";
            this.UnitOffenseLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitOffenseLabel.TabIndex = 4;
            this.UnitOffenseLabel.Text = "Offensive Strength";
            this.UnitOffenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitDefenseLabel
            // 
            this.UnitDefenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitDefenseLabel.AutoSize = true;
            this.UnitDefenseLabel.Location = new System.Drawing.Point(4, 82);
            this.UnitDefenseLabel.Name = "UnitDefenseLabel";
            this.UnitDefenseLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitDefenseLabel.TabIndex = 5;
            this.UnitDefenseLabel.Text = "Defensive Strength";
            this.UnitDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitInitiativeLabel
            // 
            this.UnitInitiativeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitInitiativeLabel.AutoSize = true;
            this.UnitInitiativeLabel.Location = new System.Drawing.Point(4, 109);
            this.UnitInitiativeLabel.Name = "UnitInitiativeLabel";
            this.UnitInitiativeLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitInitiativeLabel.TabIndex = 6;
            this.UnitInitiativeLabel.Text = "Initiative Penalty";
            this.UnitInitiativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitRecruitmentLabel
            // 
            this.UnitRecruitmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitRecruitmentLabel.AutoSize = true;
            this.UnitRecruitmentLabel.Location = new System.Drawing.Point(4, 136);
            this.UnitRecruitmentLabel.Name = "UnitRecruitmentLabel";
            this.UnitRecruitmentLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitRecruitmentLabel.TabIndex = 7;
            this.UnitRecruitmentLabel.Text = "Recruitment Cost";
            this.UnitRecruitmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitMaintenenceLabel
            // 
            this.UnitMaintenenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitMaintenenceLabel.AutoSize = true;
            this.UnitMaintenenceLabel.Location = new System.Drawing.Point(4, 163);
            this.UnitMaintenenceLabel.Name = "UnitMaintenenceLabel";
            this.UnitMaintenenceLabel.Size = new System.Drawing.Size(98, 26);
            this.UnitMaintenenceLabel.TabIndex = 8;
            this.UnitMaintenenceLabel.Text = "Maintenence Cost";
            this.UnitMaintenenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitOffenseNumeric
            // 
            this.UnitOffenseNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitOffenseNumeric.Location = new System.Drawing.Point(109, 58);
            this.UnitOffenseNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UnitOffenseNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.UnitOffenseNumeric.Name = "UnitOffenseNumeric";
            this.UnitOffenseNumeric.Size = new System.Drawing.Size(241, 20);
            this.UnitOffenseNumeric.TabIndex = 9;
            // 
            // UnitTraitsTable
            // 
            this.UnitTraitsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTraitsTable.ColumnCount = 2;
            this.UnitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UnitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.UnitTraitsTable.Location = new System.Drawing.Point(109, 247);
            this.UnitTraitsTable.Name = "UnitTraitsTable";
            this.UnitTraitsTable.RowCount = 1;
            this.UnitTraitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UnitTraitsTable.Size = new System.Drawing.Size(241, 392);
            this.UnitTraitsTable.TabIndex = 19;
            // 
            // TabBattle
            // 
            this.TabBattle.Location = new System.Drawing.Point(4, 22);
            this.TabBattle.Name = "TabBattle";
            this.TabBattle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabBattle.Size = new System.Drawing.Size(938, 545);
            this.TabBattle.TabIndex = 0;
            this.TabBattle.Text = "Battle Manager";
            this.TabBattle.UseVisualStyleBackColor = true;
            // 
            // AppTabs
            // 
            this.AppTabs.Controls.Add(this.TabBattle);
            this.AppTabs.Controls.Add(this.TabArmy);
            this.AppTabs.Controls.Add(this.TabUnitCommander);
            this.AppTabs.Controls.Add(this.TabOptions);
            this.AppTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabs.Location = new System.Drawing.Point(0, 0);
            this.AppTabs.Name = "AppTabs";
            this.AppTabs.SelectedIndex = 0;
            this.AppTabs.Size = new System.Drawing.Size(1064, 681);
            this.AppTabs.TabIndex = 1;
            // 
            // TabOptions
            // 
            this.TabOptions.Controls.Add(this.label6);
            this.TabOptions.Controls.Add(this.TraitFileResetButton);
            this.TabOptions.Controls.Add(this.TraitFileExportButton);
            this.TabOptions.Controls.Add(this.TraitFileSelectButton);
            this.TabOptions.Controls.Add(this.BattleDirSelectButton);
            this.TabOptions.Controls.Add(this.ArmyDirSelectButton);
            this.TabOptions.Controls.Add(this.CommanderDirSelectButton);
            this.TabOptions.Controls.Add(this.UnitDirSelectButton);
            this.TabOptions.Controls.Add(this.TraitFileSelectText);
            this.TabOptions.Controls.Add(this.BattleDirSelectText);
            this.TabOptions.Controls.Add(this.CommanderDirSelectText);
            this.TabOptions.Controls.Add(this.ArmyDirSelectText);
            this.TabOptions.Controls.Add(this.UnitDirSelectText);
            this.TabOptions.Controls.Add(this.label5);
            this.TabOptions.Controls.Add(this.label4);
            this.TabOptions.Controls.Add(this.label2);
            this.TabOptions.Controls.Add(this.label3);
            this.TabOptions.Controls.Add(this.OptionsCmdrDirLabel);
            this.TabOptions.Controls.Add(this.OptionsUnitDirLabel);
            this.TabOptions.Location = new System.Drawing.Point(4, 22);
            this.TabOptions.Name = "TabOptions";
            this.TabOptions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabOptions.Size = new System.Drawing.Size(1056, 655);
            this.TabOptions.TabIndex = 3;
            this.TabOptions.Text = "Options";
            this.TabOptions.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(555, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Files can be loaded and saved anywhere, but the load and save dialog boxes will s" +
    "tart in these directories by default.";
            // 
            // TraitFileResetButton
            // 
            this.TraitFileResetButton.Location = new System.Drawing.Point(701, 259);
            this.TraitFileResetButton.Name = "TraitFileResetButton";
            this.TraitFileResetButton.Size = new System.Drawing.Size(67, 22);
            this.TraitFileResetButton.TabIndex = 18;
            this.TraitFileResetButton.Text = "Reset";
            this.TraitFileResetButton.UseVisualStyleBackColor = true;
            // 
            // TraitFileExportButton
            // 
            this.TraitFileExportButton.Location = new System.Drawing.Point(701, 231);
            this.TraitFileExportButton.Name = "TraitFileExportButton";
            this.TraitFileExportButton.Size = new System.Drawing.Size(67, 22);
            this.TraitFileExportButton.TabIndex = 17;
            this.TraitFileExportButton.Text = "Export...";
            this.TraitFileExportButton.UseVisualStyleBackColor = true;
            this.TraitFileExportButton.Click += new System.EventHandler(this.TraitFileExportButton_Click);
            // 
            // TraitFileSelectButton
            // 
            this.TraitFileSelectButton.Location = new System.Drawing.Point(701, 202);
            this.TraitFileSelectButton.Name = "TraitFileSelectButton";
            this.TraitFileSelectButton.Size = new System.Drawing.Size(67, 22);
            this.TraitFileSelectButton.TabIndex = 16;
            this.TraitFileSelectButton.Text = "Select...";
            this.TraitFileSelectButton.UseVisualStyleBackColor = true;
            this.TraitFileSelectButton.Click += new System.EventHandler(this.TraitFileSelectButton_Click);
            // 
            // BattleDirSelectButton
            // 
            this.BattleDirSelectButton.Location = new System.Drawing.Point(701, 129);
            this.BattleDirSelectButton.Name = "BattleDirSelectButton";
            this.BattleDirSelectButton.Size = new System.Drawing.Size(67, 22);
            this.BattleDirSelectButton.TabIndex = 15;
            this.BattleDirSelectButton.Text = "Select...";
            this.BattleDirSelectButton.UseVisualStyleBackColor = true;
            this.BattleDirSelectButton.Click += new System.EventHandler(this.DirSelectButton_Click);
            // 
            // ArmyDirSelectButton
            // 
            this.ArmyDirSelectButton.Location = new System.Drawing.Point(701, 101);
            this.ArmyDirSelectButton.Name = "ArmyDirSelectButton";
            this.ArmyDirSelectButton.Size = new System.Drawing.Size(67, 22);
            this.ArmyDirSelectButton.TabIndex = 14;
            this.ArmyDirSelectButton.Text = "Select...";
            this.ArmyDirSelectButton.UseVisualStyleBackColor = true;
            this.ArmyDirSelectButton.Click += new System.EventHandler(this.DirSelectButton_Click);
            // 
            // CommanderDirSelectButton
            // 
            this.CommanderDirSelectButton.Location = new System.Drawing.Point(701, 72);
            this.CommanderDirSelectButton.Name = "CommanderDirSelectButton";
            this.CommanderDirSelectButton.Size = new System.Drawing.Size(67, 22);
            this.CommanderDirSelectButton.TabIndex = 13;
            this.CommanderDirSelectButton.Text = "Select...";
            this.CommanderDirSelectButton.UseVisualStyleBackColor = true;
            this.CommanderDirSelectButton.Click += new System.EventHandler(this.DirSelectButton_Click);
            // 
            // UnitDirSelectButton
            // 
            this.UnitDirSelectButton.Location = new System.Drawing.Point(701, 44);
            this.UnitDirSelectButton.Name = "UnitDirSelectButton";
            this.UnitDirSelectButton.Size = new System.Drawing.Size(67, 22);
            this.UnitDirSelectButton.TabIndex = 12;
            this.UnitDirSelectButton.Text = "Select...";
            this.UnitDirSelectButton.UseVisualStyleBackColor = true;
            this.UnitDirSelectButton.Click += new System.EventHandler(this.DirSelectButton_Click);
            // 
            // TraitFileSelectText
            // 
            this.TraitFileSelectText.Location = new System.Drawing.Point(141, 202);
            this.TraitFileSelectText.Name = "TraitFileSelectText";
            this.TraitFileSelectText.ReadOnly = true;
            this.TraitFileSelectText.Size = new System.Drawing.Size(554, 20);
            this.TraitFileSelectText.TabIndex = 11;
            // 
            // BattleDirSelectText
            // 
            this.BattleDirSelectText.Location = new System.Drawing.Point(141, 129);
            this.BattleDirSelectText.Name = "BattleDirSelectText";
            this.BattleDirSelectText.ReadOnly = true;
            this.BattleDirSelectText.Size = new System.Drawing.Size(554, 20);
            this.BattleDirSelectText.TabIndex = 9;
            // 
            // CommanderDirSelectText
            // 
            this.CommanderDirSelectText.Location = new System.Drawing.Point(141, 72);
            this.CommanderDirSelectText.Name = "CommanderDirSelectText";
            this.CommanderDirSelectText.ReadOnly = true;
            this.CommanderDirSelectText.Size = new System.Drawing.Size(554, 20);
            this.CommanderDirSelectText.TabIndex = 8;
            // 
            // ArmyDirSelectText
            // 
            this.ArmyDirSelectText.Location = new System.Drawing.Point(141, 101);
            this.ArmyDirSelectText.Name = "ArmyDirSelectText";
            this.ArmyDirSelectText.ReadOnly = true;
            this.ArmyDirSelectText.Size = new System.Drawing.Size(554, 20);
            this.ArmyDirSelectText.TabIndex = 7;
            // 
            // UnitDirSelectText
            // 
            this.UnitDirSelectText.Location = new System.Drawing.Point(141, 44);
            this.UnitDirSelectText.Name = "UnitDirSelectText";
            this.UnitDirSelectText.ReadOnly = true;
            this.UnitDirSelectText.Size = new System.Drawing.Size(554, 20);
            this.UnitDirSelectText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Default Directories:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trait Definitions File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Battles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Armies";
            // 
            // OptionsCmdrDirLabel
            // 
            this.OptionsCmdrDirLabel.AutoSize = true;
            this.OptionsCmdrDirLabel.Location = new System.Drawing.Point(62, 75);
            this.OptionsCmdrDirLabel.Name = "OptionsCmdrDirLabel";
            this.OptionsCmdrDirLabel.Size = new System.Drawing.Size(68, 13);
            this.OptionsCmdrDirLabel.TabIndex = 1;
            this.OptionsCmdrDirLabel.Text = "Commanders";
            // 
            // OptionsUnitDirLabel
            // 
            this.OptionsUnitDirLabel.AutoSize = true;
            this.OptionsUnitDirLabel.Location = new System.Drawing.Point(73, 46);
            this.OptionsUnitDirLabel.Name = "OptionsUnitDirLabel";
            this.OptionsUnitDirLabel.Size = new System.Drawing.Size(58, 13);
            this.OptionsUnitDirLabel.TabIndex = 0;
            this.OptionsUnitDirLabel.Text = "Unit Types";
            // 
            // SaveDialog
            // 
            this.SaveDialog.DefaultExt = "json";
            this.SaveDialog.Filter = "JSON files|*.json";
            this.SaveDialog.RestoreDirectory = true;
            this.SaveDialog.Title = "Save Unit JSON File";
            // 
            // LoadDialog
            // 
            this.LoadDialog.DefaultExt = "json";
            this.LoadDialog.RestoreDirectory = true;
            // 
            // FolderDialog
            // 
            this.FolderDialog.Description = "AAAAAAAA";
            // 
            // ArmyNameLabel
            // 
            this.ArmyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmyNameLabel.AutoSize = true;
            this.ArmyNameLabel.Location = new System.Drawing.Point(9, 15);
            this.ArmyNameLabel.Name = "ArmyNameLabel";
            this.ArmyNameLabel.Size = new System.Drawing.Size(61, 13);
            this.ArmyNameLabel.TabIndex = 21;
            this.ArmyNameLabel.Text = "Army Name";
            this.ArmyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArmyNameText
            // 
            this.ArmyNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmyNameText.Location = new System.Drawing.Point(76, 12);
            this.ArmyNameText.Name = "ArmyNameText";
            this.ArmyNameText.Size = new System.Drawing.Size(304, 20);
            this.ArmyNameText.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.AppTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BattleBois";
            this.TabArmy.ResumeLayout(false);
            this.TabArmy.PerformLayout();
            this.DivisionLayoutPanel.ResumeLayout(false);
            this.DivisionLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionMoraleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionSizeNumeric)).EndInit();
            this.TabUnitCommander.ResumeLayout(false);
            this.TabUnitCommander.PerformLayout();
            this.CommanderCreateStatsTable.ResumeLayout(false);
            this.CommanderCreateStatsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderMaritimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderLandWarNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderChaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderWisNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommanderIntNumeric)).EndInit();
            this.UnitCreateStatsTable.ResumeLayout(false);
            this.UnitCreateStatsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitMaintenenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitRecruitmentNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInitiativeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitDefenseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOffenseNumeric)).EndInit();
            this.AppTabs.ResumeLayout(false);
            this.TabOptions.ResumeLayout(false);
            this.TabOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage TabArmy;
        private System.Windows.Forms.TabPage TabUnitCommander;
        private System.Windows.Forms.Button UnitSaveButton;
        private System.Windows.Forms.Button UnitTraitRemoveButton;
        private System.Windows.Forms.Button UnitTraitAddButton;
        private System.Windows.Forms.TableLayoutPanel UnitCreateStatsTable;
        private System.Windows.Forms.Label UnitTraitsLabel;
        private System.Windows.Forms.TextBox UnitMoraleText;
        private System.Windows.Forms.Label UnitMoraleLabel;
        private System.Windows.Forms.TextBox UnitCasualtyText;
        private System.Windows.Forms.Label UnitCasualtyLabel;
        private System.Windows.Forms.NumericUpDown UnitMaintenenceNumeric;
        private System.Windows.Forms.NumericUpDown UnitRecruitmentNumeric;
        private System.Windows.Forms.NumericUpDown UnitInitiativeNumeric;
        private System.Windows.Forms.NumericUpDown UnitDefenseNumeric;
        private System.Windows.Forms.TextBox UnitNameText;
        private System.Windows.Forms.Label UnitNameLabel;
        private System.Windows.Forms.Label UnitTypeLabel;
        private System.Windows.Forms.ComboBox UnitTypeCombo;
        private System.Windows.Forms.Label UnitOffenseLabel;
        private System.Windows.Forms.Label UnitDefenseLabel;
        private System.Windows.Forms.Label UnitInitiativeLabel;
        private System.Windows.Forms.Label UnitRecruitmentLabel;
        private System.Windows.Forms.Label UnitMaintenenceLabel;
        private System.Windows.Forms.NumericUpDown UnitOffenseNumeric;
        private System.Windows.Forms.TableLayoutPanel UnitTraitsTable;
        private System.Windows.Forms.TabPage TabBattle;
        private System.Windows.Forms.TabControl AppTabs;
        private System.Windows.Forms.Button UnitLoadButton;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog LoadDialog;
        private System.Windows.Forms.TableLayoutPanel CommanderCreateStatsTable;
        private System.Windows.Forms.Label CommanderNameLabel;
        private System.Windows.Forms.TextBox CommanderNameText;
        private System.Windows.Forms.Label CommanderIntLabel;
        private System.Windows.Forms.NumericUpDown CommanderIntNumeric;
        private System.Windows.Forms.Button CommanderLoadButton;
        private System.Windows.Forms.Button CommanderSaveButton;
        private System.Windows.Forms.NumericUpDown CommanderMaritimeNumeric;
        private System.Windows.Forms.NumericUpDown CommanderLandWarNumeric;
        private System.Windows.Forms.NumericUpDown CommanderChaNumeric;
        private System.Windows.Forms.NumericUpDown CommanderWisNumeric;
        private System.Windows.Forms.Label CommanderMaritimeLabel;
        private System.Windows.Forms.Label CommanderLandWarLabel;
        private System.Windows.Forms.Label CommanderChaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnitCreateTraitDetailText;
        private System.Windows.Forms.TableLayoutPanel DivisionLayoutPanel;
        private System.Windows.Forms.NumericUpDown DivisionMoraleNumeric;
        private System.Windows.Forms.NumericUpDown DivisionSizeNumeric;
        private System.Windows.Forms.Label DivisionMoraleLabel;
        private System.Windows.Forms.Label DivisionNameLabel;
        private System.Windows.Forms.TextBox DivisionNameText;
        private System.Windows.Forms.Label DivisionUnitLabel;
        private System.Windows.Forms.Label DivisionSizeLabel;
        private System.Windows.Forms.Button DivisionUnitLoadButton;
        private System.Windows.Forms.Button ArmyAddDivisionButton;
        private System.Windows.Forms.TableLayoutPanel ArmyTable;
        private System.Windows.Forms.TextBox DivisionUnitText;
        private System.Windows.Forms.Button ArmyLoadButton;
        private System.Windows.Forms.Button ArmySaveButton;
        private System.Windows.Forms.Label ArmyCommanderLabel;
        private System.Windows.Forms.Button ArmyRemoveDivisionButton;
        private System.Windows.Forms.Button ArmyRemoveCommanderButton;
        private System.Windows.Forms.Button ArmyAddCommanderButton;
        private System.Windows.Forms.ListBox ArmyCommanderList;
        private System.Windows.Forms.TextBox ArmyCommanderDetailText;
        private System.Windows.Forms.TextBox ArmyUnitDetailText;
        private System.Windows.Forms.Button ArmyUpdateDivisionButton;
        private System.Windows.Forms.TabPage TabOptions;
        private System.Windows.Forms.TextBox BattleDirSelectText;
        private System.Windows.Forms.TextBox CommanderDirSelectText;
        private System.Windows.Forms.TextBox ArmyDirSelectText;
        private System.Windows.Forms.TextBox UnitDirSelectText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OptionsCmdrDirLabel;
        private System.Windows.Forms.Label OptionsUnitDirLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.TextBox TraitFileSelectText;
        private System.Windows.Forms.Button TraitFileSelectButton;
        private System.Windows.Forms.Button BattleDirSelectButton;
        private System.Windows.Forms.Button ArmyDirSelectButton;
        private System.Windows.Forms.Button CommanderDirSelectButton;
        private System.Windows.Forms.Button UnitDirSelectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TraitFileResetButton;
        private System.Windows.Forms.Button TraitFileExportButton;
        private System.Windows.Forms.Label ArmyNameLabel;
        private System.Windows.Forms.TextBox ArmyNameText;
    }
}

