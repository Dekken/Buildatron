

namespace Buildatron.Scene.s.userControl.rights.settings.preloaded {
    partial class PreloadedConfigurationControl {
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
            this.preloadedConfigurationsTreeView = new System.Windows.Forms.TreeView();
            this.preloadedConfigurationRemoveConfigurationButton = new System.Windows.Forms.Button();
            this.preloadedConfigurationAddConfigurationButton = new System.Windows.Forms.Button();
            this.preloadedConfigurationDirectoriesTreeView = new System.Windows.Forms.TreeView();
            this.preloadedConfigurationCommandsDataGridView = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preloadedConfigurationAddCommandButton = new System.Windows.Forms.Button();
            this.preloadedConfigurationRemoveCommandButton = new System.Windows.Forms.Button();
            this.preloadedConfigurationNameLabel = new System.Windows.Forms.Label();
            this.preloadedConfigurationNameTextBox = new System.Windows.Forms.TextBox();
            this.preloadedConfigurationsDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.preloadedConfigurationsDirectoryLabel = new System.Windows.Forms.Label();
            this.preloadedConfigurationFilePatternTextBox = new System.Windows.Forms.TextBox();
            this.preloadedConfigurationFilePatternLabel = new System.Windows.Forms.Label();
            this.RegExInfoLabel = new System.Windows.Forms.Label();
            this.preloadedConfigurationSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preloadedConfigurationCommandsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // preloadedConfigurationsTreeView
            // 
            this.preloadedConfigurationsTreeView.Location = new System.Drawing.Point(0, 2);
            this.preloadedConfigurationsTreeView.Name = "preloadedConfigurationsTreeView";
            this.preloadedConfigurationsTreeView.Size = new System.Drawing.Size(226, 314);
            this.preloadedConfigurationsTreeView.TabIndex = 39;
            this.preloadedConfigurationsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.preloadedConfigurationsTreeView_AfterSelect);
            this.preloadedConfigurationsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.preloadedConfigurationsTreeView_Click);
            this.preloadedConfigurationsTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.preloadedConfigurationsTreeView_DoubleClick);
            // 
            // preloadedConfigurationRemoveConfigurationButton
            // 
            this.preloadedConfigurationRemoveConfigurationButton.Enabled = false;
            this.preloadedConfigurationRemoveConfigurationButton.Location = new System.Drawing.Point(125, 322);
            this.preloadedConfigurationRemoveConfigurationButton.Name = "preloadedConfigurationRemoveConfigurationButton";
            this.preloadedConfigurationRemoveConfigurationButton.Size = new System.Drawing.Size(101, 23);
            this.preloadedConfigurationRemoveConfigurationButton.TabIndex = 41;
            this.preloadedConfigurationRemoveConfigurationButton.Text = "Delete";
            this.preloadedConfigurationRemoveConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // preloadedConfigurationAddConfigurationButton
            // 
            this.preloadedConfigurationAddConfigurationButton.Location = new System.Drawing.Point(0, 322);
            this.preloadedConfigurationAddConfigurationButton.Name = "preloadedConfigurationAddConfigurationButton";
            this.preloadedConfigurationAddConfigurationButton.Size = new System.Drawing.Size(101, 23);
            this.preloadedConfigurationAddConfigurationButton.TabIndex = 42;
            this.preloadedConfigurationAddConfigurationButton.Text = "Add";
            this.preloadedConfigurationAddConfigurationButton.UseVisualStyleBackColor = true;
            this.preloadedConfigurationAddConfigurationButton.Click += new System.EventHandler(this.OperationalControlAddNewConfigurationButton_Click);
            // 
            // preloadedConfigurationDirectoriesTreeView
            // 
            this.preloadedConfigurationDirectoriesTreeView.Location = new System.Drawing.Point(235, 51);
            this.preloadedConfigurationDirectoriesTreeView.Name = "preloadedConfigurationDirectoriesTreeView";
            this.preloadedConfigurationDirectoriesTreeView.Size = new System.Drawing.Size(262, 271);
            this.preloadedConfigurationDirectoriesTreeView.TabIndex = 43;
            this.preloadedConfigurationDirectoriesTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preloadedConfigurationDirectoriesTreeView_keyDown);
            // 
            // preloadedConfigurationCommandsDataGridView
            // 
            this.preloadedConfigurationCommandsDataGridView.AllowUserToAddRows = false;
            this.preloadedConfigurationCommandsDataGridView.AllowUserToResizeColumns = false;
            this.preloadedConfigurationCommandsDataGridView.AllowUserToResizeRows = false;
            this.preloadedConfigurationCommandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preloadedConfigurationCommandsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Command});
            this.preloadedConfigurationCommandsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.preloadedConfigurationCommandsDataGridView.Location = new System.Drawing.Point(503, 51);
            this.preloadedConfigurationCommandsDataGridView.MultiSelect = false;
            this.preloadedConfigurationCommandsDataGridView.Name = "preloadedConfigurationCommandsDataGridView";
            this.preloadedConfigurationCommandsDataGridView.RowHeadersVisible = false;
            this.preloadedConfigurationCommandsDataGridView.Size = new System.Drawing.Size(523, 271);
            this.preloadedConfigurationCommandsDataGridView.TabIndex = 44;
            this.preloadedConfigurationCommandsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.preloadedConfigurationCommandsDataGridView_CellContentClick);
            this.preloadedConfigurationCommandsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preloadedConfigurationCommandsDataGridView_KeyDown);
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Name";
            this.Namee.MinimumWidth = 15;
            this.Namee.Name = "Namee";
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Command.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Command.Width = 370;
            // 
            // preloadedConfigurationAddCommandButton
            // 
            this.preloadedConfigurationAddCommandButton.Location = new System.Drawing.Point(503, 328);
            this.preloadedConfigurationAddCommandButton.Name = "preloadedConfigurationAddCommandButton";
            this.preloadedConfigurationAddCommandButton.Size = new System.Drawing.Size(101, 23);
            this.preloadedConfigurationAddCommandButton.TabIndex = 47;
            this.preloadedConfigurationAddCommandButton.Text = "Add";
            this.preloadedConfigurationAddCommandButton.UseVisualStyleBackColor = true;
            this.preloadedConfigurationAddCommandButton.Click += new System.EventHandler(this.preloadedConfigurationAddCommandButton_Click);
            // 
            // preloadedConfigurationRemoveCommandButton
            // 
            this.preloadedConfigurationRemoveCommandButton.Enabled = false;
            this.preloadedConfigurationRemoveCommandButton.Location = new System.Drawing.Point(628, 328);
            this.preloadedConfigurationRemoveCommandButton.Name = "preloadedConfigurationRemoveCommandButton";
            this.preloadedConfigurationRemoveCommandButton.Size = new System.Drawing.Size(101, 23);
            this.preloadedConfigurationRemoveCommandButton.TabIndex = 48;
            this.preloadedConfigurationRemoveCommandButton.Text = "Delete";
            this.preloadedConfigurationRemoveCommandButton.UseVisualStyleBackColor = true;
            // 
            // preloadedConfigurationNameLabel
            // 
            this.preloadedConfigurationNameLabel.AutoSize = true;
            this.preloadedConfigurationNameLabel.Location = new System.Drawing.Point(235, 2);
            this.preloadedConfigurationNameLabel.Name = "preloadedConfigurationNameLabel";
            this.preloadedConfigurationNameLabel.Size = new System.Drawing.Size(41, 13);
            this.preloadedConfigurationNameLabel.TabIndex = 49;
            this.preloadedConfigurationNameLabel.Text = "Name: ";
            // 
            // preloadedConfigurationNameTextBox
            // 
            this.preloadedConfigurationNameTextBox.Location = new System.Drawing.Point(296, 2);
            this.preloadedConfigurationNameTextBox.Name = "preloadedConfigurationNameTextBox";
            this.preloadedConfigurationNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.preloadedConfigurationNameTextBox.TabIndex = 50;
            // 
            // preloadedConfigurationsDirectoryTextBox
            // 
            this.preloadedConfigurationsDirectoryTextBox.Location = new System.Drawing.Point(296, 28);
            this.preloadedConfigurationsDirectoryTextBox.Name = "preloadedConfigurationsDirectoryTextBox";
            this.preloadedConfigurationsDirectoryTextBox.Size = new System.Drawing.Size(704, 20);
            this.preloadedConfigurationsDirectoryTextBox.TabIndex = 52;
            this.preloadedConfigurationsDirectoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preloadedConfigurationsDirectoryTextBox_keyPressed);
            
            // 
            // preloadedConfigurationsDirectoryLabel
            // 
            this.preloadedConfigurationsDirectoryLabel.AutoSize = true;
            this.preloadedConfigurationsDirectoryLabel.Location = new System.Drawing.Point(235, 31);
            this.preloadedConfigurationsDirectoryLabel.Name = "preloadedConfigurationsDirectoryLabel";
            this.preloadedConfigurationsDirectoryLabel.Size = new System.Drawing.Size(55, 13);
            this.preloadedConfigurationsDirectoryLabel.TabIndex = 51;
            this.preloadedConfigurationsDirectoryLabel.Text = "Directory: ";
            // 
            // preloadedConfigurationFilePatternTextBox
            // 
            this.preloadedConfigurationFilePatternTextBox.Location = new System.Drawing.Point(564, 3);
            this.preloadedConfigurationFilePatternTextBox.Name = "preloadedConfigurationFilePatternTextBox";
            this.preloadedConfigurationFilePatternTextBox.Size = new System.Drawing.Size(317, 20);
            this.preloadedConfigurationFilePatternTextBox.TabIndex = 54;
            // 
            // preloadedConfigurationFilePatternLabel
            // 
            this.preloadedConfigurationFilePatternLabel.AutoSize = true;
            this.preloadedConfigurationFilePatternLabel.Location = new System.Drawing.Point(500, 5);
            this.preloadedConfigurationFilePatternLabel.Name = "preloadedConfigurationFilePatternLabel";
            this.preloadedConfigurationFilePatternLabel.Size = new System.Drawing.Size(58, 13);
            this.preloadedConfigurationFilePatternLabel.TabIndex = 53;
            this.preloadedConfigurationFilePatternLabel.Text = "FileTypes: ";
            // 
            // RegExInfoLabel
            // 
            this.RegExInfoLabel.AutoSize = true;
            this.RegExInfoLabel.Location = new System.Drawing.Point(887, 6);
            this.RegExInfoLabel.Name = "RegExInfoLabel";
            this.RegExInfoLabel.Size = new System.Drawing.Size(148, 13);
            this.RegExInfoLabel.TabIndex = 55;
            this.RegExInfoLabel.Text = " - supports CSV and wildcards";
            // 
            // preloadedConfigurationSaveButton
            // 
            this.preloadedConfigurationSaveButton.Location = new System.Drawing.Point(756, 328);
            this.preloadedConfigurationSaveButton.Name = "preloadedConfigurationSaveButton";
            this.preloadedConfigurationSaveButton.Size = new System.Drawing.Size(101, 23);
            this.preloadedConfigurationSaveButton.TabIndex = 56;
            this.preloadedConfigurationSaveButton.Text = "Save";
            this.preloadedConfigurationSaveButton.UseVisualStyleBackColor = true;
            this.preloadedConfigurationSaveButton.Click += new System.EventHandler(this.preloadedConfigurationCommandsDataGridView_Save);
            // 
            // PreloadedConfigurationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.preloadedConfigurationSaveButton);
            this.Controls.Add(this.preloadedConfigurationRemoveCommandButton);
            this.Controls.Add(this.preloadedConfigurationAddCommandButton);
            this.Controls.Add(this.RegExInfoLabel);
            this.Controls.Add(this.preloadedConfigurationFilePatternTextBox);
            this.Controls.Add(this.preloadedConfigurationFilePatternLabel);
            this.Controls.Add(this.preloadedConfigurationsDirectoryTextBox);
            this.Controls.Add(this.preloadedConfigurationCommandsDataGridView);
            this.Controls.Add(this.preloadedConfigurationDirectoriesTreeView);
            this.Controls.Add(this.preloadedConfigurationAddConfigurationButton);
            this.Controls.Add(this.preloadedConfigurationRemoveConfigurationButton);
            this.Controls.Add(this.preloadedConfigurationsTreeView);
            this.Controls.Add(this.preloadedConfigurationNameLabel);
            this.Controls.Add(this.preloadedConfigurationsDirectoryLabel);
            this.Controls.Add(this.preloadedConfigurationNameTextBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PreloadedConfigurationControl";
            this.Controls.SetChildIndex(this.killProcessesButton, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationNameTextBox, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationsDirectoryLabel, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationNameLabel, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationsTreeView, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationRemoveConfigurationButton, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationAddConfigurationButton, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationDirectoriesTreeView, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationCommandsDataGridView, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationsDirectoryTextBox, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationFilePatternLabel, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationFilePatternTextBox, 0);
            this.Controls.SetChildIndex(this.RegExInfoLabel, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationAddCommandButton, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationRemoveCommandButton, 0);
            this.Controls.SetChildIndex(this.cmdTextBox, 0);
            this.Controls.SetChildIndex(this.preloadedConfigurationSaveButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.preloadedConfigurationCommandsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView preloadedConfigurationsTreeView;
        private System.Windows.Forms.Button preloadedConfigurationRemoveConfigurationButton;
        private System.Windows.Forms.Button preloadedConfigurationAddConfigurationButton;
        private System.Windows.Forms.TreeView preloadedConfigurationDirectoriesTreeView;
        private System.Windows.Forms.DataGridView preloadedConfigurationCommandsDataGridView;
        private System.Windows.Forms.Button preloadedConfigurationAddCommandButton;
        private System.Windows.Forms.Button preloadedConfigurationRemoveCommandButton;
        private System.Windows.Forms.Label preloadedConfigurationNameLabel;
        private System.Windows.Forms.TextBox preloadedConfigurationNameTextBox;
        private System.Windows.Forms.TextBox preloadedConfigurationsDirectoryTextBox;
        private System.Windows.Forms.Label preloadedConfigurationsDirectoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.TextBox preloadedConfigurationFilePatternTextBox;
        private System.Windows.Forms.Label preloadedConfigurationFilePatternLabel;
        private System.Windows.Forms.Label RegExInfoLabel;
        private System.Windows.Forms.Button preloadedConfigurationSaveButton;


    }
}
