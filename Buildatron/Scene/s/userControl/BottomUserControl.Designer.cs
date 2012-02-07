namespace Buildatron.Scene.s.userControl {
    partial class BottomUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bottomUserControlProcessHandleDataGridView = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bottomUserControlProcessHandleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomUserControlProcessHandleDataGridView
            // 
            this.bottomUserControlProcessHandleDataGridView.AllowUserToAddRows = false;
            this.bottomUserControlProcessHandleDataGridView.AllowUserToDeleteRows = false;
            this.bottomUserControlProcessHandleDataGridView.AllowUserToResizeRows = false;
            this.bottomUserControlProcessHandleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomUserControlProcessHandleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Directory,
            this.Command,
            this.CPU,
            this.RAM,
            this.RunningTime,
            this.BlockedBy,
            this.KILL});
            this.bottomUserControlProcessHandleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.bottomUserControlProcessHandleDataGridView.Name = "bottomUserControlProcessHandleDataGridView";
            this.bottomUserControlProcessHandleDataGridView.ReadOnly = true;
            this.bottomUserControlProcessHandleDataGridView.RowHeadersVisible = false;
            this.bottomUserControlProcessHandleDataGridView.Size = new System.Drawing.Size(1238, 428);
            this.bottomUserControlProcessHandleDataGridView.TabIndex = 0;
            this.bottomUserControlProcessHandleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bottomUserControlProcessHandleDataGridView_CellContentClick);
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // Directory
            // 
            this.Directory.HeaderText = "Directory";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.Width = 350;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Width = 150;
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            // 
            // RunningTime
            // 
            this.RunningTime.HeaderText = "RunningTime";
            this.RunningTime.Name = "RunningTime";
            this.RunningTime.ReadOnly = true;
            this.RunningTime.Width = 150;
            // 
            // BlockedBy
            // 
            this.BlockedBy.HeaderText = "BlockedBy";
            this.BlockedBy.Name = "BlockedBy";
            this.BlockedBy.ReadOnly = true;
            // 
            // KILL
            // 
            this.KILL.HeaderText = "KILL";
            this.KILL.Name = "KILL";
            this.KILL.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CPU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "RAM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "CPU";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "RAM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "RunningTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "BlockedBy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // BottomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomUserControlProcessHandleDataGridView);
            this.Name = "BottomUserControl";
            this.Size = new System.Drawing.Size(1244, 434);
            ((System.ComponentModel.ISupportInitialize)(this.bottomUserControlProcessHandleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bottomUserControlProcessHandleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockedBy;
        private System.Windows.Forms.DataGridViewButtonColumn KILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
