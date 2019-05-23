using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleBois
{
    public partial class DivisionControl : UserControl
    {
        private static readonly String STAT_DICE_SEPARATOR = " / ";
        private static readonly String TYPE_DEFAULT_ABBREVIATION = "??";
        private static readonly Dictionary<String, String> TypeAbbreviations = new Dictionary<string, string>
        {
            [CUnit.DEFAULT_TYPE] = TYPE_DEFAULT_ABBREVIATION,
            [CUnit.TYPE_LIGHT_INFANTRY] = "LI",
            [CUnit.TYPE_HEAVY_INFANTRY] = "HI",
            [CUnit.TYPE_LIGHT_CAVALRY]  = "LC",
            [CUnit.TYPE_HEAVY_CAVALRY]  = "HC",
            [CUnit.TYPE_SIEGE_WEAPON]   = "SW",
        };

        private CDivision _displayedDivision;
        public CDivision DisplayedDivision
        {
            get { return _displayedDivision; }
            set
            {
                _displayedDivision = value;
                if (_displayedDivision == null)
                {
                    Visible = false;
                }
                else
                {
                    Visible = true;
                    RefreshDisplayedUnit();
                }
            }
        }

        public DivisionControl()
        {
            InitializeComponent();
        }

        public void ClearDisplayedDivision()
        {
            DisplayedDivision = null;
        }

        public void RefreshDisplayedUnit()
        {
            NameLabel.Text = _displayedDivision.Name;

            TroopsLabel.Text = _displayedDivision.CurrentSize.ToString();

            DefLabel.Text = _displayedDivision.UnitType.Stats[CUnit.STAT_DEFENSE].ToString();

            AtkLabel.Text = _displayedDivision.UnitType.Stats[CUnit.STAT_OFFENSE].ToString()
                + STAT_DICE_SEPARATOR + _displayedDivision.UnitType.Dice[CUnit.DICE_CASUALTY];

            MoraleLabel.Text = _displayedDivision.Morale.ToString()
                + STAT_DICE_SEPARATOR + _displayedDivision.UnitType.Dice[CUnit.DICE_MORALE];

            if (_displayedDivision.Morale > 0)
            {
                MrlIcon.Image = global::BattleBois.Properties.Resources.mrl_happy;
            }
            else if (_displayedDivision.Morale < 0)
            {
                MrlIcon.Image = global::BattleBois.Properties.Resources.mrl_sad;
            }
            else
            {
                MrlIcon.Image = global::BattleBois.Properties.Resources.mrl_neutral;
            }

            if (TypeAbbreviations.Keys.Contains(_displayedDivision.UnitType.Type))
            {
                TypeLabel.Text = TypeAbbreviations[_displayedDivision.UnitType.Type];
            }
            else
            {
                TypeLabel.Text = TYPE_DEFAULT_ABBREVIATION;
            }
        }      
    }
}
