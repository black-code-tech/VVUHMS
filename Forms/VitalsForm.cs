using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVUHMS.Forms
{
    public partial class VitalsForm : Form
    {
        #region Constructor
        public VitalsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region close window
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
