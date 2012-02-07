using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Buildatron.Handling.Process;
using Buildatron.Windows.Forms.Data.Grid.View.Process.Handle;

namespace Buildatron.Scene.s.userControl {
    public partial class BottomUserControl : UserControl {

        private delegate void refreshUserControlProcessHandleDataGridView(List<ProcessHandle> handles);
        List<ProcessHandle> processHandles;

        public BottomUserControl(Form f) {
            this.Parent = f;
            InitializeComponent();
            this.Location = new System.Drawing.Point(10, 470);
            processHandles = new List<ProcessHandle>();
        }

        public void addNewProcessHandle(ProcessHandle ph){
            processHandles.Add(ph);
            addToDataView(ph);
        }

        public  List<ProcessHandle> getProcessHandles(){
            return this.processHandles;
        }

        private void bottomUserControlProcessHandleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(bottomUserControlProcessHandleDataGridView.Columns[e.ColumnIndex].Name.Equals("KILL")){
                if(bottomUserControlProcessHandleDataGridView.CurrentRow is ProcessHandleDataGridViewRow){
                    ProcessHandle ph = (bottomUserControlProcessHandleDataGridView.CurrentRow as ProcessHandleDataGridViewRow).getProcessHandle();
                    if(ph.hasProcessStarted()){
                        ph.Kill(); return;
                    }
                    ((UserControlForm)this.Parent).removeProcessHandleIfExists(ph);
                }
            }            
        }

        public void addToDataView(ProcessHandle ph){
            ProcessHandleDataGridViewRow processHandleDataGridViewRow = new ProcessHandleDataGridViewRow(ph);
		    string dir = ph.getProcessCaller().getDirectory();

		    DirectoryDataGridViewTextBoxCell pid        = new DirectoryDataGridViewTextBoxCell(ph.getPID());
		    DirectoryDataGridViewTextBoxCell directory  = new DirectoryDataGridViewTextBoxCell(dir);
		    DirectoryDataGridViewTextBoxCell command    = new DirectoryDataGridViewTextBoxCell(ph.getProcessCaller().getCmd());
            DirectoryDataGridViewTextBoxCell cpu        = new DirectoryDataGridViewTextBoxCell(ph.getCPUUsage());
            DirectoryDataGridViewTextBoxCell ram        = new DirectoryDataGridViewTextBoxCell(ph.getRAMUsage());
            DirectoryDataGridViewTextBoxCell runTime    = new DirectoryDataGridViewTextBoxCell(ph.getRunningTime());
            DirectoryDataGridViewTextBoxCell blocker    = new DirectoryDataGridViewTextBoxCell(ph.getBlockedBy() != null ? ph.getBlockedBy().getPID() : "");
            DataGridViewButtonCell kill                 = new DataGridViewButtonCell();            

		    if (dir.Length > 50){
			    int i = dir.Length;
			    int num = 20;
			    while (i > 50){
				    i--;
				    num++;
			    }
			    dir = dir.Substring(0, 5) + "....." + dir.Substring(num);
		    }
            pid.Value = ph.getPID();
            directory.Value = dir;
            command.Value = ph.getProcessCaller().getCmd();
            cpu.Value = ph.getCPUUsage();
            ram.Value = ph.getRAMUsage();
            runTime.Value = ph.getRunningTime();
            blocker.Value = ph.getBlockedBy() != null ? ph.getBlockedBy().getPID() : "";
            kill.Value = "KILL";
            
            processHandleDataGridViewRow.Cells.Add(pid);
            processHandleDataGridViewRow.Cells.Add(directory);
            processHandleDataGridViewRow.Cells.Add(command);
            processHandleDataGridViewRow.Cells.Add(cpu);
            processHandleDataGridViewRow.Cells.Add(ram);
            processHandleDataGridViewRow.Cells.Add(runTime);
            processHandleDataGridViewRow.Cells.Add(blocker);
            processHandleDataGridViewRow.Cells.Add(kill);
                
        
		    this.bottomUserControlProcessHandleDataGridView.Rows.Add(processHandleDataGridViewRow);
        }
        
        public void refreshDataGridView(List<ProcessHandle> handles){
            this.bottomUserControlProcessHandleDataGridView.Rows.Clear();
            try{
                foreach(ProcessHandle ph in handles){
                    addToDataView(ph);
                }
            }
            catch(System.Reflection.TargetInvocationException tie){
                this.bottomUserControlProcessHandleDataGridView.Rows.Clear();
            }
            catch(InvalidOperationException ioe){
                this.bottomUserControlProcessHandleDataGridView.Rows.Clear();
            }
        }

        public void threadSafeRefreshDataGridView(List<ProcessHandle> handles){		
		    if (this.bottomUserControlProcessHandleDataGridView.InvokeRequired){
			    this.bottomUserControlProcessHandleDataGridView.BeginInvoke(new BottomUserControl.refreshUserControlProcessHandleDataGridView(this.refreshDataGridView), new object[]
			    {handles});
		    }
		    else{
			    this.refreshDataGridView(handles);
		    }
	    }
}   }
