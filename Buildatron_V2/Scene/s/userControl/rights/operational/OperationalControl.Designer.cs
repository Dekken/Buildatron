namespace Buildatron.Scene.s.userControl.rights.operational {
    partial class OperationalControl {
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
            this.operationalControlDirectoryNodeTreeView = new System.Windows.Forms.TreeView();
            this.operationControlCommandsDataGridView = new System.Windows.Forms.DataGridView();
            this.goButton = new System.Windows.Forms.Button();
            this.directoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.includeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.displayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autoExitColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.waitForExit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.waitForExit.Visible = Program.isDevMode();
                        
            ((System.ComponentModel.ISupportInitialize)(this.operationControlCommandsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // killProcessesButton
            // 
            this.killProcessesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.killProcessesButton.Visible = false;
            // 
            // operationalControlDirectoryNodeTreeView
            // 
            this.operationalControlDirectoryNodeTreeView.Location = new System.Drawing.Point(2, 0);
            this.operationalControlDirectoryNodeTreeView.Name = "operationalControlDirectoryNodeTreeView";
            this.operationalControlDirectoryNodeTreeView.Size = new System.Drawing.Size(301, 376);
            this.operationalControlDirectoryNodeTreeView.TabIndex = 37;
            this.operationalControlDirectoryNodeTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.operationalControlDirectoryNodeTreeView_DoubleClick);
            // 
            // operationControlCommandsDataGridView
            // 
            this.operationControlCommandsDataGridView.AllowUserToAddRows = false;
            this.operationControlCommandsDataGridView.AllowUserToResizeColumns = false;
            this.operationControlCommandsDataGridView.AllowUserToResizeRows = false;
            this.operationControlCommandsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.operationControlCommandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationControlCommandsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directoryColumn,
            this.commandColumn,
            this.includeColumn,
            this.displayColumn,
            this.autoExitColumn,
            this.waitForExit});
            this.operationControlCommandsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.operationControlCommandsDataGridView.Location = new System.Drawing.Point(309, 0);
            this.operationControlCommandsDataGridView.Name = "operationControlCommandsDataGridView";
            this.operationControlCommandsDataGridView.RowHeadersVisible = false;
            this.operationControlCommandsDataGridView.Size = new System.Drawing.Size(740, 375);
            this.operationControlCommandsDataGridView.TabIndex = 34;
            // 
            // goButton
            // 
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(937, 411);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(101, 23);
            this.goButton.TabIndex = 40;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // directoryColumn
            // 
            this.directoryColumn.HeaderText = "directory";
            this.directoryColumn.MinimumWidth = 15;
            this.directoryColumn.Name = "directoryColumn";
            this.directoryColumn.ReadOnly = true;
            this.directoryColumn.Width = 310;
            // 
            // commandColumn
            // 
            this.commandColumn.HeaderText = "Command";
            this.commandColumn.Items.AddRange(new object[] {
            "inst",
            "insto",
            "maven eclipse"});
            this.commandColumn.MaxDropDownItems = 20;
            this.commandColumn.Name = "commandColumn";
            // 
            // includeColumn
            // 
            this.includeColumn.HeaderText = "include?";
            this.includeColumn.MinimumWidth = 60;
            this.includeColumn.Name = "includeColumn";
            this.includeColumn.Width = 70;
            // 
            // displayColumn
            // 
            this.displayColumn.HeaderText = "display?";
            this.displayColumn.MinimumWidth = 60;
            this.displayColumn.Name = "displayColumn";
            this.displayColumn.Width = 70;
            // 
            // autoExitColumn
            // 
            this.autoExitColumn.HeaderText = "Auto Exit?";
            this.autoExitColumn.MinimumWidth = 60;
            this.autoExitColumn.Name = "autoExitColumn";
            this.autoExitColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autoExitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.autoExitColumn.Width = 80;
            // 
            // waitForExit
            // 
            this.waitForExit.HeaderText = "Wait for exit?";
            this.waitForExit.Name = "waitForExit";
            this.waitForExit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.waitForExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OperationalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.operationalControlDirectoryNodeTreeView);
            this.Controls.Add(this.operationControlCommandsDataGridView);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OperationalControl";
            this.Size = new System.Drawing.Size(1079, 467);
            this.Controls.SetChildIndex(this.killProcessesButton, 0);
            this.Controls.SetChildIndex(this.operationControlCommandsDataGridView, 0);
            this.Controls.SetChildIndex(this.operationalControlDirectoryNodeTreeView, 0);
            this.Controls.SetChildIndex(this.cmdTextBox, 0);
            this.Controls.SetChildIndex(this.goButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.operationControlCommandsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView operationControlCommandsDataGridView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TreeView operationalControlDirectoryNodeTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn commandColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn displayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoExitColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waitForExit;

    }
}
