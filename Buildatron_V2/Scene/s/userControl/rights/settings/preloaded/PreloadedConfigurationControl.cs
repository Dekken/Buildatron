using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.IO;
using Buildatron.Scene.s.userControl.rights.err;

using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;
using Buildatron.Scene.s.userControl.services.data.grid.view;

namespace Buildatron.Scene.s.userControl.rights.settings.preloaded {
    public partial class PreloadedConfigurationControl : RightUserControl {

        private string selectedConfigFile = "";

        public PreloadedConfigurationControl() {
            InitializeComponent();
            
            InitialisePreloadedConfigurationsScene();
            
        }

        private void OperationalControlAddNewConfigurationButton_Click(object sender, EventArgs e) {
           
            createNewConfiguration();
        }

        private void createNewConfiguration(){
            if (preloadedConfigurationsTreeView.Nodes.Count < 16) {
                if (!File.Exists("xml/new profile.xml")) {
                    PreloadedConfigurationModificationsService.getInstance().createEmptyConfiguration("xml/new profile.xml");
                    preloadedConfigurationsTreeView.Nodes.Add(getNode("new profile"));
                    ((UserControlForm)this.Parent).addNodeToLeftControlTreeView("new profile");
                } else {
                    cmdTextBox.Text = "You must rename the current 'new profile' profile";
                }
            }  
        }

        private void preloadedConfigurationsTreeView_Click(object sender, TreeNodeMouseClickEventArgs e) {
            Console.WriteLine("preloadedConfigurationsTreeView_Click");
        }
        private void preloadedConfigurationsTreeView_DoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            Console.WriteLine("preloadedConfigurationsTreeView_DoubleClick");
        }

        private void preloadedConfigurationsTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            if (sender is TreeView) { }
            if (e.Node is TreeNode) { populateForSelectedNode(e.Node); }
        }

        private void preloadedConfigurationCommandsDataGridView_Save(object sender, EventArgs e){
            
            List<string> errors = new List<string>();

            if (PreloadedConfigurationValidationService.getInstance().validateFilePattern(preloadedConfigurationFilePatternTextBox.Text.Trim())){

                String s;            
                if (PreloadedConfigurationValidationService.getInstance().validateName((s = preloadedConfigurationNameTextBox.Text.Trim()))) {
                    try{
                        PreloadedConfigurationModificationsService.getInstance().updateName(this.selectedConfigFile, s);
                        int i = 0;
                        foreach(TreeNode n in preloadedConfigurationsTreeView.Nodes){
                            if(n.Name.Equals(this.selectedConfigFile)){
                                n.Name = s;
                                n.Text = s; break;
                            }i++;
                        }
                        ((UserControlForm)this.Parent).renameConfigurationNode(i, s);
                        this.selectedConfigFile = s;

                        PreloadedConfigurationModificationsService.getInstance().updateFilePattern(this.selectedConfigFile, preloadedConfigurationFilePatternTextBox.Text.Trim());
                        DataGridView ec = (sender as DataGridView);            
                        foreach(DataGridViewRow r in preloadedConfigurationCommandsDataGridView.Rows){                
                            DataGridViewTextBoxCell one = r.Cells[0] as DataGridViewTextBoxCell;
                            DataGridViewTextBoxCell two = r.Cells[1] as DataGridViewTextBoxCell;
                    
                            PreloadedConfigurationModificationsService.getInstance().updateCommandName(this.selectedConfigFile, ((string)one.Value).Trim(), "" + (one.RowIndex + 1));
                            PreloadedConfigurationModificationsService.getInstance().updateCommandString(this.selectedConfigFile, ((string)two.Value).Trim(), "" + (two.RowIndex + 1));
                        }
                    }catch(IOException ioe){
                         errors.Add("That profile already exists");
                    }                
                } else {
                     errors.Add("That is not a valid name");
                }
            }else{
                preloadedConfigurationFilePatternTextBox.Text = PreloadedConfigurationGetterService.getInstance().getFilePattern(this.selectedConfigFile);
                errors.Add("That is not a valid file pattern");
            }

            string error = "";
            foreach(string s in errors){
                error += s + "\n";
            }
            this.cmdTextBox.Text = error.Trim();
        }



        private void preloadedConfigurationAddCommandButton_Click(object sender, EventArgs e) {            
            addRowToCommandDataGridView(new Command("name", "command"));
            PreloadedConfigurationModificationsService.getInstance().createCommand(this.selectedConfigFile);
        }




        public void preloadedConfigurationsDirectoryTextBox_keyPressed(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
               preloadedConfigurationsDirectoryTextBox_HandleReturn(sender, e);
            } 
        }
        public void preloadedConfigurationsDirectoryTextBox_HandleReturn(object sender, EventArgs e) {
            string s = ""; 
            if (Directory.Exists(s = (sender as TextBox).Text.Trim())) {
                preloadedConfigurationDirectoriesTreeView.Nodes.Add(new TreeNode() {  
                    Text = s,
                    Name = s
                });
                PreloadedConfigurationModificationsService.getInstance().createDirectory(this.selectedConfigFile, s);
                preloadedConfigurationsDirectoryTextBox.Text = "";
            }
        }

        public void preloadedConfigurationDirectoriesTreeView_keyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                if (preloadedConfigurationDirectoriesTreeView.SelectedNode != null) {
                    PreloadedConfigurationModificationsService.getInstance().removeDirectory(this.selectedConfigFile, preloadedConfigurationDirectoriesTreeView.SelectedNode.Index + 1);
                    preloadedConfigurationDirectoriesTreeView.SelectedNode.Remove();                    
                }
            }            
        }

        private void preloadedConfigurationCommandsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }        
        private void preloadedConfigurationCommandsDataGridView_KeyDown(object sender, KeyEventArgs e) {
            foreach(DataGridViewRow r in preloadedConfigurationCommandsDataGridView.Rows){
                foreach(DataGridViewCell c in r.Cells){
                    if(c.Selected){
                        switch(e.KeyCode){
                            case Keys.W: 
                                try{
                                    DataGridViewKeyEventRowManager.moveRowDownOrFail(preloadedConfigurationCommandsDataGridView, r.Index); 
                                    PreloadedConfigurationModificationsService.getInstance().swapCommands(this.selectedConfigFile, r.Index, r.Index + 1);
                                }
                                catch(FailToMoveDataGridViewRowException fail){ cmdTextBox.Text = "I can't do that Dave.";}
                                
                                break;
                            case Keys.S: 
                                try{
                                    DataGridViewKeyEventRowManager.moveRowUpOrFail(preloadedConfigurationCommandsDataGridView, r.Index); 
                                    PreloadedConfigurationModificationsService.getInstance().swapCommands(this.selectedConfigFile, r.Index - 1, r.Index);
                                }
                                catch(FailToMoveDataGridViewRowException fail){ cmdTextBox.Text = "I can't do that Dave.";}                           
                            
                                break;
                            case Keys.Delete: 
                                DataGridViewKeyEventRowManager.deleteRowOrFail(preloadedConfigurationCommandsDataGridView, r.Index); 
                            
                                break;

                        }
                    }
                }
            }



        }
    }
}