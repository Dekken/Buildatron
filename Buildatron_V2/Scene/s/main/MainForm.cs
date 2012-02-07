using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buildatron{
    public partial class BuildingForm : Form {

        public BuildingForm() {
            InitializeComponent();          
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void DirectoryCmdView_CellContentClick(object sender, DataGridViewCellEventArgs e){        }

        private void DirectoryCmdView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){}

        private void DirectoryCmdView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            DataGridViewComboBoxEditingControl comboControl = e.Control as DataGridViewComboBoxEditingControl;
            if (comboControl != null) {
                // Set the DropDown style to get an editable ComboBox
                if (comboControl.DropDownStyle != ComboBoxStyle.DropDown) {
                    comboControl.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
        }

        private void dicrectoryInput_keyPressed(object sender, KeyPressEventArgs  e){
            if(e.KeyChar == (char)Keys.Return){
                populateTreeButton_Click(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e){
            Settings.RECURSE_DIRECTORY = recurseBox.Checked;
        }
        
        private void treeView1_DoubleClick(object sender, TreeNodeMouseClickEventArgs e){
            /*   DirectoryTreeNode node = (DirectoryTreeNode) e.Node;
               bool enabledGoButton = directoryCmdView.RowCount == 0;
               String path = DirectoryHandler.getInstance().getPathFromParent(node.getFileDirectory(), node.getFileDirectory().getPath());
               if (directoryCmdView.Rows.GetRowCount(DataGridViewElementStates.Visible) <= Settings.MAX_SEQUENTIAL_COMMANDS){
                   populateFDCommands(node.getFileDirectory());
                   DataGridHandler.getInstance().addRow(directoryCmdView, node.getFileDirectory());
                   if(enabledGoButton){
                       GoButton.Enabled = true;
                   }
               }*/
        }
        
        private void populateTreeButton_Click(object sender, EventArgs e){
            String content = directoryInput.Text.Trim();
            int res = Helper.getInstance().ValidateDirectoryInput(content);
            if (res == 0){
                //Helper.getInstance().ThrowError(HelperErrors.NOT_A_DIRECTORY_OR_COMMAND);
                return;
            }
            else if(res == 1){
                //Helper.getInstance().RunCommand(content, cmdTextBox);
                return;
            }
            //Root directory has null parent;
            FileDirectory rd = new FileDirectory(content, null);
            if(false){
                DirectoryTreeViewThreadHandler tvht = new DirectoryTreeViewThreadHandler(rd, directoryTreeView);
                DirectoryThreadHandler dht = new DirectoryThreadHandler(rd, "");
                Cursor.Current = Cursors.WaitCursor;
                try{
                    if (!tvht.checkNodeExists(directoryTreeView)) {
                        Thread handleDirectory = new Thread(new ThreadStart(dht.Handle));
                        handleDirectory.Start();
                        handleDirectory.Join();

                        Thread handleTreeView = new Thread(new ThreadStart(tvht.HandleDirectoryTree));
                        handleTreeView.Start();
                        handleTreeView.Join();
                        directoryTreeView.Nodes.Add(tvht.getRoot());
                    }
                }finally{
                    Cursor.Current = Cursors.Default;
                }  
            }      
        }

        private void directoryTreeView_AfterSelect(object sender, TreeViewEventArgs e){}
        /*
        private void deleteSelectedRows_Click(object sender, EventArgs e){
            foreach(DataGridViewRow r in directoryCmdView.SelectedRows){
               OperationalControlDataGridHandler.getInstance().remRow(directoryCmdView,  r.Index);
            }
            foreach(DataGridViewCell c in directoryCmdView.SelectedCells){
                OperationalControlDataGridHandler.getInstance().remRow(directoryCmdView, c.OwningRow.Index);
            }
            if (directoryCmdView.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0){
                GoButton.Enabled    = false;
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e){
            foreach(DataGridViewRow r in directoryCmdView.SelectedRows){
                OperationalControlDataGridHandler.getInstance().moveRowsUp((DirectoryDataGridViewRow)r);
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e){
           foreach(DataGridViewRow r in directoryCmdView.SelectedRows){
               OperationalControlDataGridHandler.getInstance().moveRowsDown((DirectoryDataGridViewRow)r);
            }
        }*/

        private void GoButton_Click(object sender, EventArgs e){
            Cursor.Current = Cursors.WaitCursor;

            List<Control> disableds = new List<Control>();
            disableds.Add(directoryTreeView);
            disableds.Add(directoryCmdView);
            disableds.Add(directoryInput);

            disableds.Add(GoButton);

            foreach(Control c in disableds){
                c.Enabled = false;
            }
            /*
            ProcessThreadHandler pth = new ProcessThreadHandler("cmd.exe", disableds, directoryCmdView);
            pth.Handle();*/
        }

        private void cmdTextBox_TextChanged(object sender, EventArgs e){}

        private void clearButton_Click(object sender, EventArgs e){
            cmdTextBox.Text = "";
        }
        /* - moved to OperationalControl.Service.cs
        private void populateFDCommands(FileDirectory fd, string configFile){
            RunnableCommandManager manager = RunnableCommandManager.getInstance();
            if(System.IO.File.Exists("C:\\maven.txt")){
                string[] lines = System.IO.File.ReadAllLines("C:\\maven.txt");
                if(lines[0] != null){
                    foreach(string s in lines){
                        if(s.Contains("|")){
                            string[] bits = s.Split('|');
                            commands.addMvnCmd(bits[0], bits[1]);
                        }else{
                            commands.addMvnCmd(s);
                        }
                    }
                }
                
            }else{
                commands.addMvnCmd("tree");
            }
        }*/
    }
}
