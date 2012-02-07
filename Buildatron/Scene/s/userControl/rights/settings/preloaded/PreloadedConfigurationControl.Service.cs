using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Threading;

using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;

namespace Buildatron.Scene.s.userControl.rights.settings.preloaded {
    public partial class PreloadedConfigurationControl {

        public void InitialisePreloadedConfigurationsScene() {

        }

        public void populatePreloadedConfigurationTreeView() {
            
            foreach (string path in Directory.GetFiles("xml")){
                if (PreloadedConfigurationValidationService.getInstance().validateConfiguration(path)){
                    preloadedConfigurationsTreeView.Nodes.Add(getNode(path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - (path.LastIndexOf("\\") + 1))));
                }
            }
            preloadedConfigurationsTreeView.SelectedNode = preloadedConfigurationsTreeView.Nodes[0];
            
        }   

        public void preSetupChecks(){            
            if (!Directory.Exists("xml")){
                Directory.CreateDirectory("xml");
                createNewConfiguration();                
                
            }else if(Directory.GetFiles("xml").Length == 0) { 
                createNewConfiguration();           
            }
            
        }

        public TreeNode getNode(string path) {
            TreeNode n = new TreeNode();
            n.Text = path;
            n.Name = path;
            return n;
        }

        public void populateForSelectedNode(TreeNode node) {
            if (this.selectedConfigFile.Equals(node.Name)) { return; }
            this.selectedConfigFile = node.Name;
            
            preloadedConfigurationNameTextBox.Text = this.selectedConfigFile;
            preloadedConfigurationFilePatternTextBox.Text = PreloadedConfigurationGetterService.getInstance().getFilePattern(this.selectedConfigFile);
            preloadedConfigurationCommandsDataGridView.Rows.Clear();
            preloadedConfigurationDirectoriesTreeView.Nodes.Clear();

            foreach (Command c in PreloadedConfigurationGetterService.getInstance().getCommandsFromXMLConfiguration(this.selectedConfigFile)){
                addRowToCommandDataGridView(c);
            }
            foreach (string s in PreloadedConfigurationGetterService.getInstance().getDirectoriesFromXMLConfiguration(this.selectedConfigFile)){
                preloadedConfigurationDirectoriesTreeView.Nodes.Add(s);
            }
        }

        private void addRowToCommandDataGridView(Command c) {
            DataGridViewRow directoryDataGridViewRow = new DataGridViewRow();

            DataGridViewTextBoxCell nameDataGridViewTextBoxCell = new DataGridViewTextBoxCell();
            directoryDataGridViewRow.Cells.Add(nameDataGridViewTextBoxCell);
            nameDataGridViewTextBoxCell.Value = c.getName();
            nameDataGridViewTextBoxCell.ReadOnly = false;

            DataGridViewTextBoxCell commandDataGridViewTextBoxCell = new DataGridViewTextBoxCell();
            directoryDataGridViewRow.Cells.Add(commandDataGridViewTextBoxCell);
            commandDataGridViewTextBoxCell.Value = c.getCommand();
            commandDataGridViewTextBoxCell.ReadOnly = false;

            preloadedConfigurationCommandsDataGridView.Rows.Add(directoryDataGridViewRow);
            preloadedConfigurationCommandsDataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        private void handleDataGridViewMoveRowUp(int index){

        }
    }
}
