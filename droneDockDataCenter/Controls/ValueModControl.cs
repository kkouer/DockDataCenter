using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter.Controls
{
    public partial class ValueModControl : DSkin.Controls.DSkinUserControl
    {
        public ValueModControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public string InfoValue 
        {
            get
            {
                return this.dSkinLabel2.Text;
            }
            set
            {
                this.dSkinLabel2.Text = value;
            }
        }
        public DSkin.Controls.DSkinNumericUpDown NumMinValue
        {
            get
            {
                return this.dSkinNumericUpDown1;
            }
            set
            {
                this.dSkinNumericUpDown1 = value;
            }
        }

        public DSkin.Controls.DSkinNumericUpDown NumMaxValue
        {
            get
            {
                return this.dSkinNumericUpDown2;
            }
            set
            {
                this.dSkinNumericUpDown2 = value;
            }
        }


    }
}
