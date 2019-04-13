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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabUnitCommander = new System.Windows.Forms.TabPage();
            this.buttonLoadUnit = new System.Windows.Forms.Button();
            this.buttonSaveUnit = new System.Windows.Forms.Button();
            this.buttonTraitRemove = new System.Windows.Forms.Button();
            this.buttonTraitAdd = new System.Windows.Forms.Button();
            this.tableUnitCreateStats = new System.Windows.Forms.TableLayoutPanel();
            this.unitTraitsLabel = new System.Windows.Forms.Label();
            this.unitMoraleText = new System.Windows.Forms.TextBox();
            this.unitMoraleLabel = new System.Windows.Forms.Label();
            this.unitCasualtyText = new System.Windows.Forms.TextBox();
            this.unitCasualtyLabel = new System.Windows.Forms.Label();
            this.unitMaintenenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitRecruitmentNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitInitiativeNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitDefenseNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitNameText = new System.Windows.Forms.TextBox();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.unitTypeLabel = new System.Windows.Forms.Label();
            this.unitTypeCombo = new System.Windows.Forms.ComboBox();
            this.unitOffenseLabel = new System.Windows.Forms.Label();
            this.unitDefenseLabel = new System.Windows.Forms.Label();
            this.unitInitiativeLabel = new System.Windows.Forms.Label();
            this.unitRecruitmentLabel = new System.Windows.Forms.Label();
            this.unitMaintenenceLabel = new System.Windows.Forms.Label();
            this.unitOffenseNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitTraitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.battlePage = new System.Windows.Forms.TabPage();
            this.tabs = new System.Windows.Forms.TabControl();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabUnitCommander.SuspendLayout();
            this.tableUnitCreateStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitMaintenenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitRecruitmentNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitInitiativeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDefenseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOffenseNumeric)).BeginInit();
            this.tabs.SuspendLayout();
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 604);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Create Divisions and Armies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabUnitCommander
            // 
            this.tabUnitCommander.Controls.Add(this.buttonLoadUnit);
            this.tabUnitCommander.Controls.Add(this.buttonSaveUnit);
            this.tabUnitCommander.Controls.Add(this.buttonTraitRemove);
            this.tabUnitCommander.Controls.Add(this.buttonTraitAdd);
            this.tabUnitCommander.Controls.Add(this.tableUnitCreateStats);
            this.tabUnitCommander.Location = new System.Drawing.Point(4, 22);
            this.tabUnitCommander.Name = "tabUnitCommander";
            this.tabUnitCommander.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnitCommander.Size = new System.Drawing.Size(1181, 604);
            this.tabUnitCommander.TabIndex = 1;
            this.tabUnitCommander.Text = "Create Units and Commanders";
            this.tabUnitCommander.UseVisualStyleBackColor = true;
            // 
            // buttonLoadUnit
            // 
            this.buttonLoadUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadUnit.Location = new System.Drawing.Point(430, 59);
            this.buttonLoadUnit.Name = "buttonLoadUnit";
            this.buttonLoadUnit.Size = new System.Drawing.Size(81, 53);
            this.buttonLoadUnit.TabIndex = 4;
            this.buttonLoadUnit.Text = "Load Unit";
            this.buttonLoadUnit.UseVisualStyleBackColor = true;
            this.buttonLoadUnit.Click += new System.EventHandler(this.buttonLoadUnit_Click);
            // 
            // buttonSaveUnit
            // 
            this.buttonSaveUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUnit.Location = new System.Drawing.Point(430, 6);
            this.buttonSaveUnit.Name = "buttonSaveUnit";
            this.buttonSaveUnit.Size = new System.Drawing.Size(81, 53);
            this.buttonSaveUnit.TabIndex = 3;
            this.buttonSaveUnit.Text = "Save Unit";
            this.buttonSaveUnit.UseVisualStyleBackColor = true;
            this.buttonSaveUnit.Click += new System.EventHandler(this.buttonSaveUnit_Click);
            // 
            // buttonTraitRemove
            // 
            this.buttonTraitRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraitRemove.Location = new System.Drawing.Point(430, 240);
            this.buttonTraitRemove.Name = "buttonTraitRemove";
            this.buttonTraitRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonTraitRemove.TabIndex = 2;
            this.buttonTraitRemove.Text = "-";
            this.buttonTraitRemove.UseVisualStyleBackColor = true;
            this.buttonTraitRemove.Click += new System.EventHandler(this.buttonTraitRemove_Click);
            // 
            // buttonTraitAdd
            // 
            this.buttonTraitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraitAdd.Location = new System.Drawing.Point(430, 278);
            this.buttonTraitAdd.Name = "buttonTraitAdd";
            this.buttonTraitAdd.Size = new System.Drawing.Size(32, 32);
            this.buttonTraitAdd.TabIndex = 1;
            this.buttonTraitAdd.Text = "+";
            this.buttonTraitAdd.UseVisualStyleBackColor = true;
            this.buttonTraitAdd.Click += new System.EventHandler(this.buttonTraitAdd_Click);
            // 
            // tableUnitCreateStats
            // 
            this.tableUnitCreateStats.ColumnCount = 2;
            this.tableUnitCreateStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUnitCreateStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUnitCreateStats.Controls.Add(this.unitTraitsLabel, 0, 9);
            this.tableUnitCreateStats.Controls.Add(this.unitMoraleText, 1, 8);
            this.tableUnitCreateStats.Controls.Add(this.unitMoraleLabel, 0, 8);
            this.tableUnitCreateStats.Controls.Add(this.unitCasualtyText, 1, 7);
            this.tableUnitCreateStats.Controls.Add(this.unitCasualtyLabel, 0, 7);
            this.tableUnitCreateStats.Controls.Add(this.unitMaintenenceNumeric, 1, 6);
            this.tableUnitCreateStats.Controls.Add(this.unitRecruitmentNumeric, 1, 5);
            this.tableUnitCreateStats.Controls.Add(this.unitInitiativeNumeric, 1, 4);
            this.tableUnitCreateStats.Controls.Add(this.unitDefenseNumeric, 1, 3);
            this.tableUnitCreateStats.Controls.Add(this.unitNameText, 1, 0);
            this.tableUnitCreateStats.Controls.Add(this.unitNameLabel, 0, 0);
            this.tableUnitCreateStats.Controls.Add(this.unitTypeLabel, 0, 1);
            this.tableUnitCreateStats.Controls.Add(this.unitTypeCombo, 1, 1);
            this.tableUnitCreateStats.Controls.Add(this.unitOffenseLabel, 0, 2);
            this.tableUnitCreateStats.Controls.Add(this.unitDefenseLabel, 0, 3);
            this.tableUnitCreateStats.Controls.Add(this.unitInitiativeLabel, 0, 4);
            this.tableUnitCreateStats.Controls.Add(this.unitRecruitmentLabel, 0, 5);
            this.tableUnitCreateStats.Controls.Add(this.unitMaintenenceLabel, 0, 6);
            this.tableUnitCreateStats.Controls.Add(this.unitOffenseNumeric, 1, 2);
            this.tableUnitCreateStats.Controls.Add(this.unitTraitsTable, 1, -1);
            this.tableUnitCreateStats.Location = new System.Drawing.Point(8, 7);
            this.tableUnitCreateStats.Name = "tableUnitCreateStats";
            this.tableUnitCreateStats.RowCount = 10;
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableUnitCreateStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableUnitCreateStats.Size = new System.Drawing.Size(416, 589);
            this.tableUnitCreateStats.TabIndex = 0;
            // 
            // unitTraitsLabel
            // 
            this.unitTraitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitTraitsLabel.AutoSize = true;
            this.unitTraitsLabel.Location = new System.Drawing.Point(3, 243);
            this.unitTraitsLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.unitTraitsLabel.Name = "unitTraitsLabel";
            this.unitTraitsLabel.Size = new System.Drawing.Size(98, 13);
            this.unitTraitsLabel.TabIndex = 18;
            this.unitTraitsLabel.Text = "Traits";
            this.unitTraitsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // unitMoraleText
            // 
            this.unitMoraleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitMoraleText.Location = new System.Drawing.Point(107, 211);
            this.unitMoraleText.Name = "unitMoraleText";
            this.unitMoraleText.Size = new System.Drawing.Size(306, 20);
            this.unitMoraleText.TabIndex = 17;
            // 
            // unitMoraleLabel
            // 
            this.unitMoraleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitMoraleLabel.AutoSize = true;
            this.unitMoraleLabel.Location = new System.Drawing.Point(3, 208);
            this.unitMoraleLabel.Name = "unitMoraleLabel";
            this.unitMoraleLabel.Size = new System.Drawing.Size(98, 26);
            this.unitMoraleLabel.TabIndex = 16;
            this.unitMoraleLabel.Text = "Morale Dice";
            this.unitMoraleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitCasualtyText
            // 
            this.unitCasualtyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitCasualtyText.Location = new System.Drawing.Point(107, 185);
            this.unitCasualtyText.Name = "unitCasualtyText";
            this.unitCasualtyText.Size = new System.Drawing.Size(306, 20);
            this.unitCasualtyText.TabIndex = 15;
            // 
            // unitCasualtyLabel
            // 
            this.unitCasualtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitCasualtyLabel.AutoSize = true;
            this.unitCasualtyLabel.Location = new System.Drawing.Point(3, 182);
            this.unitCasualtyLabel.Name = "unitCasualtyLabel";
            this.unitCasualtyLabel.Size = new System.Drawing.Size(98, 26);
            this.unitCasualtyLabel.TabIndex = 14;
            this.unitCasualtyLabel.Text = "Casualty Dice";
            this.unitCasualtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitMaintenenceNumeric
            // 
            this.unitMaintenenceNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitMaintenenceNumeric.DecimalPlaces = 2;
            this.unitMaintenenceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.unitMaintenenceNumeric.Location = new System.Drawing.Point(107, 159);
            this.unitMaintenenceNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.unitMaintenenceNumeric.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.unitMaintenenceNumeric.Name = "unitMaintenenceNumeric";
            this.unitMaintenenceNumeric.Size = new System.Drawing.Size(306, 20);
            this.unitMaintenenceNumeric.TabIndex = 13;
            // 
            // unitRecruitmentNumeric
            // 
            this.unitRecruitmentNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitRecruitmentNumeric.DecimalPlaces = 2;
            this.unitRecruitmentNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.unitRecruitmentNumeric.Location = new System.Drawing.Point(107, 133);
            this.unitRecruitmentNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.unitRecruitmentNumeric.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.unitRecruitmentNumeric.Name = "unitRecruitmentNumeric";
            this.unitRecruitmentNumeric.Size = new System.Drawing.Size(306, 20);
            this.unitRecruitmentNumeric.TabIndex = 12;
            // 
            // unitInitiativeNumeric
            // 
            this.unitInitiativeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitInitiativeNumeric.Location = new System.Drawing.Point(107, 107);
            this.unitInitiativeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitInitiativeNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.unitInitiativeNumeric.Name = "unitInitiativeNumeric";
            this.unitInitiativeNumeric.Size = new System.Drawing.Size(306, 20);
            this.unitInitiativeNumeric.TabIndex = 11;
            // 
            // unitDefenseNumeric
            // 
            this.unitDefenseNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitDefenseNumeric.Location = new System.Drawing.Point(107, 81);
            this.unitDefenseNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitDefenseNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.unitDefenseNumeric.Name = "unitDefenseNumeric";
            this.unitDefenseNumeric.Size = new System.Drawing.Size(306, 20);
            this.unitDefenseNumeric.TabIndex = 10;
            // 
            // unitNameText
            // 
            this.unitNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitNameText.Location = new System.Drawing.Point(107, 3);
            this.unitNameText.Name = "unitNameText";
            this.unitNameText.Size = new System.Drawing.Size(306, 20);
            this.unitNameText.TabIndex = 0;
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Location = new System.Drawing.Point(3, 0);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(98, 26);
            this.unitNameLabel.TabIndex = 1;
            this.unitNameLabel.Text = "Unit Name";
            this.unitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitTypeLabel
            // 
            this.unitTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitTypeLabel.AutoSize = true;
            this.unitTypeLabel.Location = new System.Drawing.Point(3, 26);
            this.unitTypeLabel.Name = "unitTypeLabel";
            this.unitTypeLabel.Size = new System.Drawing.Size(98, 26);
            this.unitTypeLabel.TabIndex = 2;
            this.unitTypeLabel.Text = "Unit Type";
            this.unitTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitTypeCombo
            // 
            this.unitTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitTypeCombo.FormattingEnabled = true;
            this.unitTypeCombo.Items.AddRange(new object[] {
            "Light Infanty",
            "Heavy Infantry",
            "Light Cavalry",
            "Heavy Cavalry",
            "Siege Weapon"});
            this.unitTypeCombo.Location = new System.Drawing.Point(107, 29);
            this.unitTypeCombo.Name = "unitTypeCombo";
            this.unitTypeCombo.Size = new System.Drawing.Size(306, 21);
            this.unitTypeCombo.TabIndex = 3;
            // 
            // unitOffenseLabel
            // 
            this.unitOffenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitOffenseLabel.AutoSize = true;
            this.unitOffenseLabel.Location = new System.Drawing.Point(3, 52);
            this.unitOffenseLabel.Name = "unitOffenseLabel";
            this.unitOffenseLabel.Size = new System.Drawing.Size(98, 26);
            this.unitOffenseLabel.TabIndex = 4;
            this.unitOffenseLabel.Text = "Offensive Strength";
            this.unitOffenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitDefenseLabel
            // 
            this.unitDefenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitDefenseLabel.AutoSize = true;
            this.unitDefenseLabel.Location = new System.Drawing.Point(3, 78);
            this.unitDefenseLabel.Name = "unitDefenseLabel";
            this.unitDefenseLabel.Size = new System.Drawing.Size(98, 26);
            this.unitDefenseLabel.TabIndex = 5;
            this.unitDefenseLabel.Text = "Defensive Strength";
            this.unitDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitInitiativeLabel
            // 
            this.unitInitiativeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitInitiativeLabel.AutoSize = true;
            this.unitInitiativeLabel.Location = new System.Drawing.Point(3, 104);
            this.unitInitiativeLabel.Name = "unitInitiativeLabel";
            this.unitInitiativeLabel.Size = new System.Drawing.Size(98, 26);
            this.unitInitiativeLabel.TabIndex = 6;
            this.unitInitiativeLabel.Text = "Initiative Penalty";
            this.unitInitiativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitRecruitmentLabel
            // 
            this.unitRecruitmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitRecruitmentLabel.AutoSize = true;
            this.unitRecruitmentLabel.Location = new System.Drawing.Point(3, 130);
            this.unitRecruitmentLabel.Name = "unitRecruitmentLabel";
            this.unitRecruitmentLabel.Size = new System.Drawing.Size(98, 26);
            this.unitRecruitmentLabel.TabIndex = 7;
            this.unitRecruitmentLabel.Text = "Recruitment Cost";
            this.unitRecruitmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitMaintenenceLabel
            // 
            this.unitMaintenenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitMaintenenceLabel.AutoSize = true;
            this.unitMaintenenceLabel.Location = new System.Drawing.Point(3, 156);
            this.unitMaintenenceLabel.Name = "unitMaintenenceLabel";
            this.unitMaintenenceLabel.Size = new System.Drawing.Size(98, 26);
            this.unitMaintenenceLabel.TabIndex = 8;
            this.unitMaintenenceLabel.Text = "Maintenence Cost";
            this.unitMaintenenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitOffenseNumeric
            // 
            this.unitOffenseNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitOffenseNumeric.Location = new System.Drawing.Point(107, 55);
            this.unitOffenseNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitOffenseNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.unitOffenseNumeric.Name = "unitOffenseNumeric";
            this.unitOffenseNumeric.Size = new System.Drawing.Size(306, 20);
            this.unitOffenseNumeric.TabIndex = 9;
            // 
            // unitTraitsTable
            // 
            this.unitTraitsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.unitTraitsTable.ColumnCount = 2;
            this.unitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.unitTraitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.unitTraitsTable.Location = new System.Drawing.Point(107, 237);
            this.unitTraitsTable.Name = "unitTraitsTable";
            this.unitTraitsTable.RowCount = 1;
            this.unitTraitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.unitTraitsTable.Size = new System.Drawing.Size(306, 349);
            this.unitTraitsTable.TabIndex = 19;
            // 
            // battlePage
            // 
            this.battlePage.Location = new System.Drawing.Point(4, 22);
            this.battlePage.Name = "battlePage";
            this.battlePage.Padding = new System.Windows.Forms.Padding(3);
            this.battlePage.Size = new System.Drawing.Size(1181, 604);
            this.battlePage.TabIndex = 0;
            this.battlePage.Text = "Battle Manager";
            this.battlePage.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.battlePage);
            this.tabs.Controls.Add(this.tabUnitCommander);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1189, 630);
            this.tabs.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(1189, 630);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BattlesBois";
            this.tabUnitCommander.ResumeLayout(false);
            this.tableUnitCreateStats.ResumeLayout(false);
            this.tableUnitCreateStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitMaintenenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitRecruitmentNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitInitiativeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDefenseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOffenseNumeric)).EndInit();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabUnitCommander;
        private System.Windows.Forms.Button buttonSaveUnit;
        private System.Windows.Forms.Button buttonTraitRemove;
        private System.Windows.Forms.Button buttonTraitAdd;
        private System.Windows.Forms.TableLayoutPanel tableUnitCreateStats;
        private System.Windows.Forms.Label unitTraitsLabel;
        private System.Windows.Forms.TextBox unitMoraleText;
        private System.Windows.Forms.Label unitMoraleLabel;
        private System.Windows.Forms.TextBox unitCasualtyText;
        private System.Windows.Forms.Label unitCasualtyLabel;
        private System.Windows.Forms.NumericUpDown unitMaintenenceNumeric;
        private System.Windows.Forms.NumericUpDown unitRecruitmentNumeric;
        private System.Windows.Forms.NumericUpDown unitInitiativeNumeric;
        private System.Windows.Forms.NumericUpDown unitDefenseNumeric;
        private System.Windows.Forms.TextBox unitNameText;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.Label unitTypeLabel;
        private System.Windows.Forms.ComboBox unitTypeCombo;
        private System.Windows.Forms.Label unitOffenseLabel;
        private System.Windows.Forms.Label unitDefenseLabel;
        private System.Windows.Forms.Label unitInitiativeLabel;
        private System.Windows.Forms.Label unitRecruitmentLabel;
        private System.Windows.Forms.Label unitMaintenenceLabel;
        private System.Windows.Forms.NumericUpDown unitOffenseNumeric;
        private System.Windows.Forms.TableLayoutPanel unitTraitsTable;
        private System.Windows.Forms.TabPage battlePage;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Button buttonLoadUnit;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog loadDialog;
    }
}

