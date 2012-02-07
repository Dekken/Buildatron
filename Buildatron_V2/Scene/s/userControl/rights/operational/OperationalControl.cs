using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Timers;
using System.Threading;

using Buildatron.Handling.Process;

using Buildatron.Scene.s.userControl;

namespace Buildatron.Scene.s.userControl.rights.operational {
    public partial class OperationalControl :  RightUserControl {

        
        
        private string configFile;
                
        public OperationalControl(string configFile) : base() {            
            InitializeComponent();
       
            this.configFile     = configFile;
            this.Location       = new System.Drawing.Point(220, 10);
            
            this.initialiseFromXMLConfiguration();
            this.waitForExit.Visible = Program.isDevMode();
            //((DataGridViewTextBoxColumn)this.operationControlCommandsDataGridView.Columns[0]).ReadOnly = !Program.isDevMode();
        }

        //Getters/Setters
        public void setCmdTextBox(String s)         { this.cmdTextBox.Text = s; }

        public TreeView getDirectoryTreeView()      { return this.operationalControlDirectoryNodeTreeView; }
    }
}
