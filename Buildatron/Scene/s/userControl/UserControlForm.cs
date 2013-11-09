using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using Buildatron.Handling.Process;
using Buildatron.Scene.s.userControl;

using System.Timers;


namespace Buildatron.Scene.s {  

	public partial class UserControlForm : Form {

		// User Controls
		private List<ProcessHandle> processQueue = new List<ProcessHandle>(); 
		
		private RightUserControl right;
		private LeftUserControl left;
		private BottomUserControl bottom;

		private System.Timers.Timer processQueueTimer;

		private bool processQueueIsLocked = false;

		public UserControlForm() {
			InitializeComponent();

			this.FormClosing  += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
			this.Controls.Add(right = new RightUserControl(this));
			this.Controls.Add(left  = new LeftUserControl(this));
			this.Controls.Add(bottom  = new BottomUserControl(this));
			
			left.InitialiseNodes();						
			((this).Parent) = ((this).Parent);
			userControl.services.master.configuration.MasterConfigurationValidationService.getInstance().validateMasterConfigurationFile();

			this.processQueueTimer   = new System.Timers.Timer(1000);
			this.processQueueTimer.Elapsed += new ElapsedEventHandler(this.handleProcessQueues);
			this.processQueueTimer.Enabled = true;
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

		public void addNewProcessHandleToQueueAndBottom(ProcessHandle ph){
			if(processQueueIsLocked) { return; }
			processQueueIsLocked = true;
			processQueue.Add(ph);
			bottom.addNewProcessHandle(ph);
			processQueueIsLocked = false;
		}

	   public bool removeProcessHandleIfExists(ProcessHandle ph){
			if(processQueue.Contains(ph)){
				processQueue.Remove(ph); return true;
			}
			return false;
		}

		public void handleProcessQueues(object sender, System.Timers.ElapsedEventArgs e){
			try{refreshBottomDataGridView(this.handleProcessQueue(sender, e)); }
			catch(InvalidOperationException ioe) {};			
		}

		private void refreshBottomDataGridView(List<ProcessHandle> handles){
			bottom.threadSafeRefreshDataGridView(handles);
		}
	
		private void closeForm(object sender, FormClosingEventArgs e){
			left.closeForm(sender, e);
			Application.Exit();
		}

		public List<ProcessHandle> handleProcessQueue(object sender, System.Timers.ElapsedEventArgs e){
			if(processQueue.Count == 0) { return processQueue; }
			if(processQueueIsLocked) { return processQueue; }
			processQueueIsLocked = true;

			//Remove finished
			List<ProcessHandle> toRemove = new List<ProcessHandle>();
			try{
				foreach(ProcessHandle ph in processQueue){
					if(ph.getBlockedBy() == null){
						ph.start();
						ph.setBlockedBy(ph);
					}
				}
				foreach(ProcessHandle ph in processQueue){
					if(ph.hasProcessExited())
						toRemove.Add(ph);
				}
				processQueueIsLocked = false;
				if(toRemove.Count == 0)	 { return processQueue; }
				processQueueIsLocked = true;
				foreach(ProcessHandle ph in processQueue){
					foreach(ProcessHandle removed in toRemove){
						if(ph.getBlockedBy().Equals(removed)){
							ph.start();
						}
					}
				}
				 processQueueIsLocked = false;
				if(!Settings.AUTO_DELETE_DEAD_PROCESSES_FROM_VIEW){
					return processQueue;
				}
				processQueueIsLocked = true;
			
				foreach(ProcessHandle ph in toRemove){
					processQueue.Remove(ph);
				}
				processQueueIsLocked = false;
				foreach(ProcessHandle ph in processQueue){
					if(ph.hasProcessStarted()){
						return processQueue;
					}
				}
				if(processQueue.Count > 0){
					processQueue[0].start();
				}	 
			}catch(System.Reflection.TargetInvocationException tie ){}
				   
			return processQueue;
		}

		public void addToProcessQueue(ProcessHandle ph) { this.processQueue.Add(ph); }
		public List<ProcessHandle> getProcessQueue() { return this.processQueue; }
	}
}