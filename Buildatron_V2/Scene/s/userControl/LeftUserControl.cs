using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Buildatron.Scene.s.userControl.lefts.services;
using Buildatron.Scene.s.userControl.rights.operational;
using Buildatron.Scene.s.userControl.rights.settings.preloaded;

namespace Buildatron.Scene.s.userControl {
    public partial class LeftUserControl : UserControl {

        private TreeNode viewRootNode;

        public LeftUserControl() {
            InitializeComponent();
            this.Location = new System.Drawing.Point(10, 10);
            
        }

        private void leftTreeControlView_Click(object sender, TreeNodeMouseClickEventArgs e) {
            LeftTreeControlViewService.handleMouseClick(sender, e);
        }

        public void InitialiseNodes() {
            PreloadedConfigurationControl preloadedConfig;            
            ControlTreeNode preloaded = new ControlTreeNode((preloadedConfig = new PreloadedConfigurationControl()));
           
            preloaded.Text = "Configuration";
            preloaded.Name = "Configuration";
            preloadedConfig.preSetupChecks();
            preloadedConfig.populatePreloadedConfigurationTreeView();

            viewRootNode = new TreeNode();
            viewRootNode.Text = "Views";
            viewRootNode.Name = "Views";
            leftTreeControlView.Nodes.Add(viewRootNode);
            leftTreeControlView.Nodes.Add(preloaded); 
            if (Directory.Exists("xml")) {
                foreach (string path in Directory.GetFiles("xml")) {
                    if (rights.settings.preloaded.services.configurations.PreloadedConfigurationValidationService.getInstance().validateConfiguration(path)) {
                        createAndAddControlTreeNode(path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - (path.LastIndexOf("\\") + 1)));
                    }
                }
            }          
        }

        private void createAndAddControlTreeNode(string path){
            ControlTreeNode n = new ControlTreeNode(new OperationalControl(path));
            n.Text = path;
            n.Name = path;
            this.viewRootNode.Nodes.Add(n);
        }

        public void addNodeToLeftControlTreeView(string path) {
            createAndAddControlTreeNode(path);
        }

        public void renameConfigurationNode(int i, string s){
            this.viewRootNode.Nodes[i].Text = s;
            this.viewRootNode.Nodes[i].Name = s;
        }
    }    
}
