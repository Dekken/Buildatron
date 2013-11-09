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

        private HashSet<OperationalControl> opCons = new HashSet<OperationalControl>();

        private TreeNode viewRootNode;

        public LeftUserControl(Form f) {
            this.Parent = f;
            InitializeComponent();
            this.Location = new System.Drawing.Point(10, 10);            
        }

        private void leftTreeControlView_Click(object sender, TreeNodeMouseClickEventArgs e) {
            LeftTreeControlViewService.handleMouseClick(sender, e);
        }

        public void InitialiseNodes() {
            PreloadedConfigurationControl preloadedConfig;            
            ControlTreeNode preloaded = new ControlTreeNode((preloadedConfig = new PreloadedConfigurationControl((Form)this.Parent)));

            viewRootNode = new TreeNode();
            viewRootNode.Text = "Views";
            viewRootNode.Name = "Views";
            leftTreeControlView.Nodes.Add(viewRootNode);
            leftTreeControlView.Nodes.Add(preloaded); 

            preloaded.Text = "Configuration";
            preloaded.Name = "Configuration";
            preloadedConfig.preSetupChecks();
            preloadedConfig.populatePreloadedConfigurationTreeView();

            foreach(string s in getConfigurationsFiles()){
                createAndAddControlTreeNode(s);
            }
        }

        private void createAndAddControlTreeNode(string path){
            OperationalControl opCon = new OperationalControl((Form)this.Parent, path);
            opCons.Add(opCon);
            ControlTreeNode n = new ControlTreeNode(opCon);
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

        public List<OperationalControl> getConfigurationsLoaded(){
            List<OperationalControl> operationalControls = new List<OperationalControl>();
            foreach(TreeNode tn in viewRootNode.Nodes){
                if(tn is ControlTreeNode){
                    operationalControls.Add((tn as ControlTreeNode).getControl() as OperationalControl);
                }
            }
            return operationalControls;
        }

        public List<String> getConfigurationsFiles(){
           List<string> configs = new List<string>(); 
           if (Directory.Exists("xml")) {
                foreach (string path in Directory.GetFiles("xml")) {
                    if (rights.settings.preloaded.services.configurations.PreloadedConfigurationValidationService.getInstance().validateConfiguration(path)) {
                        configs.Add(path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - (path.LastIndexOf("\\") + 1)));
                    }
                }
            }  
            return configs;
        }

        public void closeForm(object sender, FormClosingEventArgs e){
            foreach(OperationalControl opCon in opCons)
                opCon.closeForm(sender, e);
        }
    }    
}
