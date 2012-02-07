using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Xml.XPath;

using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;

namespace Buildatron.Scene.s.userControl.rights.operational{
    public partial class OperationalControl {

        private void initialiseFromXMLConfiguration() {

            foreach (String s in PreloadedConfigurationGetterService.getInstance().getDirectoriesFromXMLConfiguration(this.configFile)){
                handleDirectoryTreeViewPopulationFromDirectory(s);
            }
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

        private void enableControls(List<Control> disableds){
            foreach (Control current in disableds){
                if (current.InvokeRequired){
                    //current.Invoke(new ProcessThreadHandler.enableControlsCallBack(this.enableControlsWithInvoke), new object[] { current});
                }
                else{
                    this.enableControlsWithInvoke(current);
                }
            }
        }
        private void enableControlsWithInvoke(Control c){
            c.Enabled = true;
        }
}   }
