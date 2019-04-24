namespace BattleBois
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
            this.button1 = new System.Windows.Forms.Button();
            this.TabArmy = new System.Windows.Forms.TabPage();
            this.ArmyAddDivisionButton = new System.Windows.Forms.Button();
            this.ArmyDivisionListBox = new System.Windows.Forms.ListBox();
            this.DivisionUnitLoadButton = new System.Windows.Forms.Button();
            this.DivisionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.DivisionMoraleLabel = new System.Windows.Forms.Label();
            this.DivisionNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DivisionUnitLabel = new System.Windows.Forms.Label();
            this.DivisionSizeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.TabArmy.SuspendLayout();
            this.DivisionLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TestButtonClick);
            // 
            // TabArmy
            // 
            this.TabArmy.Controls.Add(this.ArmyAddDivisionButton);
            this.TabArmy.Controls.Add(this.ArmyDivisionListBox);
            this.TabArmy.Controls.Add(this.DivisionUnitLoadButton);
            this.TabArmy.Controls.Add(this.DivisionLayoutPanel);
            this.TabArmy.Location = new System.Drawing.Point(4, 22);
            this.TabArmy.Name = "TabArmy";
            this.TabArmy.Padding = new System.Windows.Forms.Padding(3);
            this.TabArmy.Size = new System.Drawing.Size(884, 554);
            this.TabArmy.TabIndex = 2;
            this.TabArmy.Text = "Create Armies";
            this.TabArmy.UseVisualStyleBackColor = true;
            // 
            // ArmyAddDivisionButton
            // 
            this.ArmyAddDivisionButton.Location = new System.Drawing.Point(211, 122);
            this.ArmyAddDivisionButton.Name = "ArmyAddDivisionButton";
            this.ArmyAddDivisionButton.Size = new System.Drawing.Size(109, 23);
            this.ArmyAddDivisionButton.TabIndex = 9;
            this.ArmyAddDivisionButton.Text = "Add to Army -->";
            this.ArmyAddDivisionButton.UseVisualStyleBackColor = true;
            this.ArmyAddDivisionButton.Click += new System.EventHandler(this.ArmyAddDivisionButton_Click);
            // 
            // ArmyDivisionListBox
            // 
            this.ArmyDivisionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmyDivisionListBox.FormattingEnabled = true;
            this.ArmyDivisionListBox.ItemHeight = 20;
            this.ArmyDivisionListBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.ArmyDivisionListBox.Location = new System.Drawing.Point(491, 6);
            this.ArmyDivisionListBox.Name = "ArmyDivisionListBox";
            this.ArmyDivisionListBox.Size = new System.Drawing.Size(387, 524);
            this.ArmyDivisionListBox.TabIndex = 8;
            this.ArmyDivisionListBox.SelectedIndexChanged += new System.EventHandler(this.ArmyDivisionListBox_SelectedIndexChanged);
            // 
            // DivisionUnitLoadButton
            // 
            this.DivisionUnitLoadButton.Location = new System.Drawing.Point(326, 35);
            this.DivisionUnitLoadButton.Name = "DivisionUnitLoadButton";
            this.DivisionUnitLoadButton.Size = new System.Drawing.Size(54, 23);
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
            this.DivisionLayoutPanel.Controls.Add(this.numericUpDown3, 1, 3);
            this.DivisionLayoutPanel.Controls.Add(this.numericUpDown4, 1, 2);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionMoraleLabel, 0, 3);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionNameLabel, 0, 0);
            this.DivisionLayoutPanel.Controls.Add(this.textBox1, 1, 0);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionUnitLabel, 0, 1);
            this.DivisionLayoutPanel.Controls.Add(this.DivisionSizeLabel, 0, 2);
            this.DivisionLayoutPanel.Controls.Add(this.comboBox1, 1, 1);
            this.DivisionLayoutPanel.Location = new System.Drawing.Point(8, 6);
            this.DivisionLayoutPanel.Name = "DivisionLayoutPanel";
            this.DivisionLayoutPanel.RowCount = 4;
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.DivisionLayoutPanel.Size = new System.Drawing.Size(312, 110);
            this.DivisionLayoutPanel.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Location = new System.Drawing.Point(89, 85);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown3.TabIndex = 13;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.Location = new System.Drawing.Point(89, 58);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown4.TabIndex = 12;
            // 
            // DivisionMoraleLabel
            // 
            this.DivisionMoraleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionMoraleLabel.AutoSize = true;
            this.DivisionMoraleLabel.Location = new System.Drawing.Point(4, 82);
            this.DivisionMoraleLabel.Name = "DivisionMoraleLabel";
            this.DivisionMoraleLabel.Size = new System.Drawing.Size(78, 27);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(89, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 14;
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
            this.TabUnitCommander.Padding = new System.Windows.Forms.Padding(3);
            this.TabUnitCommander.Size = new System.Drawing.Size(884, 554);
            this.TabUnitCommander.TabIndex = 1;
            this.TabUnitCommander.Text = "Create Unit Types and Commanders";
            this.TabUnitCommander.UseVisualStyleBackColor = true;
            // 
            // UnitCreateTraitDetailText
            // 
            this.UnitCreateTraitDetailText.Location = new System.Drawing.Point(387, 254);
            this.UnitCreateTraitDetailText.Multiline = true;
            this.UnitCreateTraitDetailText.Name = "UnitCreateTraitDetailText";
            this.UnitCreateTraitDetailText.ReadOnly = true;
            this.UnitCreateTraitDetailText.Size = new System.Drawing.Size(483, 290);
            this.UnitCreateTraitDetailText.TabIndex = 8;
            // 
            // CommanderLoadButton
            // 
            this.CommanderLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommanderLoadButton.Location = new System.Drawing.Point(783, 61);
            this.CommanderLoadButton.Name = "CommanderLoadButton";
            this.CommanderLoadButton.Size = new System.Drawing.Size(87, 53);
            this.CommanderLoadButton.TabIndex = 7;
            this.CommanderLoadButton.Text = "Load Commander";
            this.CommanderLoadButton.UseVisualStyleBackColor = true;
            this.CommanderLoadButton.Click += new System.EventHandler(this.CommanderLoadButton_Click);
            // 
            // CommanderSaveButton
            // 
            this.CommanderSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommanderSaveButton.Location = new System.Drawing.Point(783, 8);
            this.CommanderSaveButton.Name = "CommanderSaveButton";
            this.CommanderSaveButton.Size = new System.Drawing.Size(87, 53);
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
            this.CommanderCreateStatsTable.Location = new System.Drawing.Point(465, 7);
            this.CommanderCreateStatsTable.Name = "CommanderCreateStatsTable";
            this.CommanderCreateStatsTable.RowCount = 6;
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CommanderCreateStatsTable.Size = new System.Drawing.Size(312, 164);
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
            this.CommanderMaritimeNumeric.Size = new System.Drawing.Size(203, 20);
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
            this.CommanderLandWarNumeric.Size = new System.Drawing.Size(203, 20);
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
            this.CommanderChaNumeric.Size = new System.Drawing.Size(203, 20);
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
            this.CommanderWisNumeric.Size = new System.Drawing.Size(203, 20);
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
            this.CommanderMaritimeLabel.Size = new System.Drawing.Size(94, 27);
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
            this.CommanderNameText.Size = new System.Drawing.Size(203, 20);
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
            this.CommanderIntNumeric.Size = new System.Drawing.Size(203, 20);
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
            this.UnitLoadButton.Location = new System.Drawing.Point(327, 60);
            this.UnitLoadButton.Name = "UnitLoadButton";
            this.UnitLoadButton.Size = new System.Drawing.Size(81, 53);
            this.UnitLoadButton.TabIndex = 4;
            this.UnitLoadButton.Text = "Load Unit";
            this.UnitLoadButton.UseVisualStyleBackColor = true;
            this.UnitLoadButton.Click += new System.EventHandler(this.UnitLoadButton_Click);
            // 
            // UnitSaveButton
            // 
            this.UnitSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitSaveButton.Location = new System.Drawing.Point(327, 7);
            this.UnitSaveButton.Name = "UnitSaveButton";
            this.UnitSaveButton.Size = new System.Drawing.Size(81, 53);
            this.UnitSaveButton.TabIndex = 3;
            this.UnitSaveButton.Text = "Save Unit";
            this.UnitSaveButton.UseVisualStyleBackColor = true;
            this.UnitSaveButton.Click += new System.EventHandler(this.UnitSaveButton_Click);
            // 
            // UnitTraitRemoveButton
            // 
            this.UnitTraitRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTraitRemoveButton.Location = new System.Drawing.Point(327, 250);
            this.UnitTraitRemoveButton.Name = "UnitTraitRemoveButton";
            this.UnitTraitRemoveButton.Size = new System.Drawing.Size(32, 32);
            this.UnitTraitRemoveButton.TabIndex = 2;
            this.UnitTraitRemoveButton.Text = "-";
            this.UnitTraitRemoveButton.UseVisualStyleBackColor = true;
            this.UnitTraitRemoveButton.Click += new System.EventHandler(this.UnitTraitRemoveButton_Click);
            // 
            // UnitTraitAddButton
            // 
            this.UnitTraitAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTraitAddButton.Location = new System.Drawing.Point(327, 288);
            this.UnitTraitAddButton.Name = "UnitTraitAddButton";
            this.UnitTraitAddButton.Size = new System.Drawing.Size(32, 32);
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
            this.UnitCreateStatsTable.Location = new System.Drawing.Point(8, 7);
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
            this.UnitCreateStatsTable.Size = new System.Drawing.Size(313, 541);
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
            this.UnitMoraleText.Size = new System.Drawing.Size(200, 20);
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
            this.UnitCasualtyText.Size = new System.Drawing.Size(200, 20);
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
            this.UnitMaintenenceNumeric.Size = new System.Drawing.Size(200, 20);
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
            this.UnitRecruitmentNumeric.Size = new System.Drawing.Size(200, 20);
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
            this.UnitInitiativeNumeric.Size = new System.Drawing.Size(200, 20);
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
            this.UnitDefenseNumeric.Size = new System.Drawing.Size(200, 20);
            this.UnitDefenseNumeric.TabIndex = 10;
            // 
            // UnitNameText
            // 
            this.UnitNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitNameText.Location = new System.Drawing.Point(109, 4);
            this.UnitNameText.Name = "UnitNameText";
            this.UnitNameText.Size = new System.Drawing.Size(200, 20);
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
            this.UnitTypeCombo.Items.AddRange(new object[] {
            "Light Infanty",
            "Heavy Infantry",
            "Light Cavalry",
            "Heavy Cavalry",
            "Siege Weapon"});
            this.UnitTypeCombo.Location = new System.Drawing.Point(109, 31);
            this.UnitTypeCombo.Name = "UnitTypeCombo";
            this.UnitTypeCombo.Size = new System.Drawing.Size(200, 21);
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
            this.UnitOffenseNumeric.Size = new System.Drawing.Size(200, 20);
            this.UnitOffenseNumeric.TabIndex = 9;
            // 
            // UnitTraitsTable
            // 
            this.UnitTraitsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTraitsTable.ColumnCount = 2;
            this.UnitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UnitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.UnitTraitsTable.Location = new System.Drawing.Point(109, 247);
            this.UnitTraitsTable.Name = "UnitTraitsTable";
            this.UnitTraitsTable.RowCount = 1;
            this.UnitTraitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UnitTraitsTable.Size = new System.Drawing.Size(200, 290);
            this.UnitTraitsTable.TabIndex = 19;
            // 
            // TabBattle
            // 
            this.TabBattle.Location = new System.Drawing.Point(4, 22);
            this.TabBattle.Name = "TabBattle";
            this.TabBattle.Padding = new System.Windows.Forms.Padding(3);
            this.TabBattle.Size = new System.Drawing.Size(884, 554);
            this.TabBattle.TabIndex = 0;
            this.TabBattle.Text = "Battle Manager";
            this.TabBattle.UseVisualStyleBackColor = true;
            // 
            // AppTabs
            // 
            this.AppTabs.Controls.Add(this.TabBattle);
            this.AppTabs.Controls.Add(this.TabArmy);
            this.AppTabs.Controls.Add(this.TabUnitCommander);
            this.AppTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabs.Location = new System.Drawing.Point(0, 0);
            this.AppTabs.Name = "AppTabs";
            this.AppTabs.SelectedIndex = 0;
            this.AppTabs.Size = new System.Drawing.Size(892, 580);
            this.AppTabs.TabIndex = 1;
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "json";
            this.saveDialog.Filter = "JSON files|*.json";
            this.saveDialog.Title = "Save Unit JSON File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 580);
            this.Controls.Add(this.AppTabs);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BattleBois";
            this.TabArmy.ResumeLayout(false);
            this.DivisionLayoutPanel.ResumeLayout(false);
            this.DivisionLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog loadDialog;
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
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label DivisionMoraleLabel;
        private System.Windows.Forms.Label DivisionNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DivisionUnitLabel;
        private System.Windows.Forms.Label DivisionSizeLabel;
        private System.Windows.Forms.Button DivisionUnitLoadButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox ArmyDivisionListBox;
        private System.Windows.Forms.Button ArmyAddDivisionButton;
    }
}

