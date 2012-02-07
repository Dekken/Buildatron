using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using Buildatron.Scene.s.userControl;

namespace Buildatron.Scene.s {  

    public partial class UserControlForm : Form {

        // User Controls
        
        private RightUserControl right;
        private LeftUserControl left;

        public UserControlForm() {
            InitializeComponent();
            
            this.FormClosing  += new System.Windows.Forms.FormClosingEventHandler(this.UserControlForm_FormClosing);
            this.Controls.Add(right = new RightUserControl());
            this.Controls.Add(left  = new LeftUserControl());
            left.InitialiseNodes();                        

            userControl.services.master.configuration.MasterConfigurationValidationService.getInstance().validateMasterConfigurationFile();
        }

        public void setRightControl(RightUserControl right) {
            Point l = this.right.Location;
            this.Controls.Remove(this.right);
            this.right = right;
            this.Controls.Add(this.right);
            this.right.Location = l;
        }

        public void addNodeToLeftControlTreeView(string s) {
            left.addNodeToLeftControlTreeView(s);
        }

        public void removeConfiguration(string configuration, int node){
        }

        public void renameConfigurationNode(int i, string s){
            left.renameConfigurationNode(i, s);
        }
    
        private void UserControlForm_FormClosing(object sender, FormClosingEventArgs   e){   
            Application.Exit();
        }
    }
}