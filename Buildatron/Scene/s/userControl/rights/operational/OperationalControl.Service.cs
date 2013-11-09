using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Xml.XPath;

using Buildatron.Handling.Process;

using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;

namespace Buildatron.Scene.s.userControl.rights.operational{
	public partial class OperationalControl {

		private void initialiseFromXMLConfiguration() {

			foreach (String s in PreloadedConfigurationGetterService.getInstance().getDirectoriesFromXMLConfiguration(this.configFile)){
				handleDirectoryTreeViewPopulationFromDirectory(s);
			}
			services.datagrid.OperationalControlDataGridHandler.getInstance().addSavedRows(operationControlCommandsDataGridView, this.configFile);
		}

		public void handleDirectoryTreeViewPopulationFromDirectory(string directory) {		  
			//this.operationControlCommandsDataGridView.EditingControlShowing += preloadedConfigurationCommandsDataGridView_EditingControlShowing
			//Root directory has null parent;
			FileDirectory rd = new FileDirectory(directory, null);
			if (DirectoryHandler.getInstance().directoryHasFilePattern(directory, PreloadedConfigurationGetterService.getInstance().getFilePattern(this.configFile))) {
				DirectoryTreeViewThreadHandler tvht = new DirectoryTreeViewThreadHandler(rd, this.getDirectoryTreeView());
				DirectoryThreadHandler dht = new DirectoryThreadHandler(rd, PreloadedConfigurationGetterService.getInstance().getFilePattern(this.configFile));
				Cursor.Current = Cursors.WaitCursor;
				try {
					if (!tvht.checkNodeExists(this.getDirectoryTreeView())) {
						Thread handleDirectory = new Thread(new ThreadStart(dht.Handle));
						handleDirectory.Start();
						handleDirectory.Join();

						Thread handleTreeView = new Thread(new ThreadStart(tvht.HandleDirectoryTree));
						handleTreeView.Start();
						handleTreeView.Join();
						this.getDirectoryTreeView().Nodes.Add(tvht.getRoot());                        
					}
				} finally {
					Cursor.Current = Cursors.Default;
				}
			}
		}

		public void saveSequence() { 
            PreloadedConfigurationModificationsService.getInstance().removeSequences(this.configFile);
            PreloadedConfigurationModificationsService.getInstance().addSequences(this.configFile);
            Console.Out.WriteLine("Save Sequence");
            foreach (DataGridViewRow dr in operationControlCommandsDataGridView.Rows){
                Console.Out.WriteLine(dr.Cells[0].Value.ToString());
                PreloadedConfigurationModificationsService.getInstance()
                    .addSequence(
                        this.configFile,
                        dr.Cells[0].Value.ToString(),
                        ((DataGridViewComboBoxCell)dr.Cells[1]).Items.IndexOf(dr.Cells[1].Value).ToString(),
                        dr.Cells[2].Value.ToString() == "True" ? "1" : "0",
                        dr.Cells[3].Value.ToString() == "True" ? "1" : "0",
                        dr.Cells[4].Value.ToString() == "True" ? "1" : "0");
            }
        }
}   }
