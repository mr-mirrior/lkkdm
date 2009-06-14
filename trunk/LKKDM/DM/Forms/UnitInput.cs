using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM.Forms
{
    public partial class UnitInput : Form
    {
        public UnitInput()
        {
            InitializeComponent();
        }

        private void cbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnd.SelectedIndex < cbStart.SelectedIndex)
                cbEnd.SelectedIndex = cbStart.SelectedIndex;
        }

        private void cbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStart.SelectedIndex > cbEnd.SelectedIndex)
            cbStart.SelectedIndex = cbEnd.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            float StartZ,EndZ;
            if (!float.TryParse(tbDesignz.Text, out StartZ) && !float.TryParse(tbDesignz.Text, out EndZ))
            {
                Utils.MB.Warning("高程必须全是数字!");
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnitInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ToolsWindow.I.FrmUnit = null;
        }
    }
}
