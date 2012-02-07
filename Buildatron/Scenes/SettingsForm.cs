using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            stopOnFailCheckBox.Checked  = Settings.STOP_ON_BUILD_FAIL;
            clearOutputCheckBox.Checked = Settings.CLEAR_OUTPUT_ON_EACH_COMMAND;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e){
            //Set settings
            Settings.STOP_ON_BUILD_FAIL             = stopOnFailCheckBox.Checked;
            Settings.CLEAR_OUTPUT_ON_EACH_COMMAND   = clearOutputCheckBox.Checked;
            this.Close();
        }
    }
}
