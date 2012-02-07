
using System;
using System.Windows.Forms;

namespace Buildatron {
    public partial class BuildingForm : Form {


        public void setCmdTextBox(String s){
            this.cmdTextBox.Text = s;                  
        }

        public void setRecurseBoxEnability(bool b){
             this.recurseBox.Checked = b;
        }

        public void setDirectoryInput(String s){
            this.directoryInput.Text = s;
        }
    }
}