using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


using Buildatron.Handling.Process;
using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;

namespace Buildatron.Scene.s.userControl.rights.operational {
	public partial class OperationalControl {

		private void directoryInput_keyPressed(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Return) {
				string directory = (sender as TextBox).Text.Trim();
				int res = Helper.getInstance().ValidateDirectoryInput(directory);
				if (res == 2) {
					Helper.getInstance().ThrowError(HelperErrors.NOT_A_DIRECTORY_OR_COMMAND);
					return;
				} else if (res == 1) {
					Helper.getInstance().RunCommand(directory, cmdTextBox);
					return;
				}
				handleDirectoryTreeViewPopulationFromDirectory(directory);
			}
		}

		private void operationalControlDirectoryNodeTreeView_DoubleClick(object sender, TreeNodeMouseClickEventArgs e){			
			DirectoryTreeNode node = (DirectoryTreeNode)e.Node;
			bool enabledGoButton = operationControlCommandsDataGridView.RowCount == 0;
			String path = DirectoryHandler.getInstance().getPathFromParent(node.getFileDirectory(), node.getFileDirectory().getPath());
			if (operationControlCommandsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) <= Settings.MAX_SEQUENTIAL_COMMANDS){
				
				services.datagrid.OperationalControlDataGridHandler.getInstance().addRow(operationControlCommandsDataGridView, node.getFileDirectory(), this.configFile);
				operationControlCommandsDataGridView.CellValueChanged += new DataGridViewCellEventHandler(operationControlCommandsDataGridView_CellValueChanged);

				if (enabledGoButton){
					goButton.Enabled = true;
				}
			}
		}
		private void operationControlCommandsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e){
			if((DataGridViewCell)operationControlCommandsDataGridView[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell){
				DataGridViewCheckBoxCell curCell = (DataGridViewCheckBoxCell)operationControlCommandsDataGridView[e.ColumnIndex, e.RowIndex];
			}
		}
		
		private void goButton_Click(object sender, EventArgs e){
			if(!goButton.Enabled)  return;
			goButton.Enabled = false;
			List<ProcessCaller> pcs = new List<ProcessCaller>();
			
			foreach (DirectoryDataGridViewRow directoryDataGridViewRow in this.operationControlCommandsDataGridView.Rows){

				if (directoryDataGridViewRow.Cells[2] is DataGridViewCheckBoxCell){
					if (!(bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[2]).EditedFormattedValue){
						continue;
					}
				}
				ProcessCaller pc = new ProcessCaller("cmd.exe");

				if (directoryDataGridViewRow.Cells[0] is DirectoryDataGridViewTextBoxCell){
					pc.setDirectory(((DirectoryDataGridViewTextBoxCell)directoryDataGridViewRow.Cells[0]).getDirectory());
				}
				if (directoryDataGridViewRow.Cells[1] is DataGridViewComboBoxCell){
					
					pc.setCmd(PreloadedConfigurationGetterService.getInstance().getCommand(this.configFile, ((string)((DataGridViewComboBoxCell)directoryDataGridViewRow.Cells[1]).Value).Trim() ));
				}

				if (directoryDataGridViewRow.Cells[3] is DataGridViewCheckBoxCell){ //display

					pc.setPrefix((bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[3]).EditedFormattedValue ? "/k" : "/c");
				}
				
				if (directoryDataGridViewRow.Cells[4] is DataGridViewCheckBoxCell){ //autoexit
					if ((bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[4]).EditedFormattedValue){
						pc.setAutoExit();
					}
				}
				if (directoryDataGridViewRow.Cells[5] is DataGridViewCheckBoxCell){ //wait for exit
					if ((bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[5]).EditedFormattedValue
						|| !(bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[5]).Visible){
						pc.setWaitForExit();
					}
				}

				pc.setSpecial("");
				pcs.Add(pc);
				//string text3 = "/c " + directory.ToCharArray()[0] + ": && cd " + directory + " && " + directory;
				//Console.WriteLine(text3);
			}

			//ProcessThreadHandler
			Cursor.Current = Cursors.WaitCursor;
			try{
				ProcessHandle blocker = null;
				foreach (ProcessCaller pc in pcs){
					if (pc.echo()){
						cmdTextBox.Text = pc.getCmd();
					}
					ProcessHandle ph			= new ProcessHandle(pc);
					ProcessThreadHandler pht	= new ProcessThreadHandler(ph);

					Thread handleCommand = new Thread(new ThreadStart(pht.Handle));
					handleCommand.Start();

					if(pc.waitForExit()){
						ph.setBlockedBy(blocker);
					}

					blocker = ph;
										
					((UserControlForm)this.Parent).addNewProcessHandleToQueueAndBottom(ph); 
				}
			}
			finally { Cursor.Current = Cursors.Default; }
			goButton.Enabled = true;
		}
	}
}
