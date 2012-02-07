using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class AutoMav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inputlabel = new System.Windows.Forms.Label();
            this.directoryInput = new System.Windows.Forms.TextBox();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.recurseBox = new System.Windows.Forms.CheckBox();
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.directoryCmdView = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.included = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GoButton = new System.Windows.Forms.Button();
            this.populateTreeButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.deleteSelectedRows = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.directoryCmdView)).BeginInit();
            this.SuspendLayout();
            // 
            // Inputlabel
            // 
            this.Inputlabel.AutoSize = true;
            this.Inputlabel.Location = new System.Drawing.Point(32, 21);
            this.Inputlabel.Name = "Inputlabel";
            this.Inputlabel.Size = new System.Drawing.Size(31, 13);
            this.Inputlabel.TabIndex = 0;
            this.Inputlabel.Text = "Input";
            this.Inputlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // directoryInput
            // 
            this.directoryInput.Location = new System.Drawing.Point(85, 18);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.Size = new System.Drawing.Size(230, 20);
            this.directoryInput.TabIndex = 1;
            this.directoryInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dicrectoryInput_keyPressed);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.BackColor = System.Drawing.Color.Black;
            this.cmdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(6)))));
            this.cmdTextBox.Location = new System.Drawing.Point(35, 322);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.ReadOnly = true;
            this.cmdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cmdTextBox.Size = new System.Drawing.Size(907, 581);
            this.cmdTextBox.TabIndex = 2;
            this.cmdTextBox.Text = "awd";
            this.cmdTextBox.TextChanged += new System.EventHandler(this.cmdTextBox_TextChanged);
            // 
            // recurseBox
            // 
            this.recurseBox.AutoSize = true;
            this.recurseBox.Location = new System.Drawing.Point(388, 19);
            this.recurseBox.Name = "recurseBox";
            this.recurseBox.Size = new System.Drawing.Size(72, 17);
            this.recurseBox.TabIndex = 5;
            this.recurseBox.Text = "Recurse?";
            this.recurseBox.UseVisualStyleBackColor = true;
            this.recurseBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(35, 46);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(344, 270);
            this.directoryTreeView.TabIndex = 9;
            this.directoryTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_DoubleClick);
            this.directoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directoryTreeView_AfterSelect);
            // 
            // directoryCmdView
            // 
            this.directoryCmdView.AllowUserToAddRows = false;
            this.directoryCmdView.AllowUserToOrderColumns = true;
            this.directoryCmdView.AllowUserToResizeColumns = false;
            this.directoryCmdView.AllowUserToResizeRows = false;
            this.directoryCmdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directoryCmdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Directory,
            this.Cmd,
            this.included});
            this.directoryCmdView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.directoryCmdView.Location = new System.Drawing.Point(451, 46);
            this.directoryCmdView.Name = "directoryCmdView";
            this.directoryCmdView.Size = new System.Drawing.Size(491, 270);
            this.directoryCmdView.TabIndex = 10;
            this.directoryCmdView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirectoryCmdView_CellContentDoubleClick);
            this.directoryCmdView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DirectoryCmdView_EditingControlShowing);
            this.directoryCmdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirectoryCmdView_CellContentClick);
            // 
            // Directory
            // 
            this.Directory.HeaderText = "Directory";
            this.Directory.MinimumWidth = 15;
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.Width = 260;
            // 
            // Cmd
            // 
            this.Cmd.HeaderText = "Cmd";
            this.Cmd.Items.AddRange(new object[] {
            "inst",
            "insto",
            "maven eclipse"});
            this.Cmd.MaxDropDownItems = 20;
            this.Cmd.Name = "Cmd";
            // 
            // included
            // 
            this.included.HeaderText = "Included?";
            this.included.Name = "included";
            this.included.Width = 70;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(841, 15);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(101, 23);
            this.GoButton.TabIndex = 11;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // populateTreeButton
            // 
            this.populateTreeButton.Location = new System.Drawing.Point(321, 16);
            this.populateTreeButton.Name = "populateTreeButton";
            this.populateTreeButton.Size = new System.Drawing.Size(58, 24);
            this.populateTreeButton.TabIndex = 13;
            this.populateTreeButton.Text = "Load";
            this.populateTreeButton.UseVisualStyleBackColor = true;
            this.populateTreeButton.Click += new System.EventHandler(this.populateTreeButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(627, 16);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(101, 23);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(385, 87);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(60, 23);
            this.moveUpButton.TabIndex = 15;
            this.moveUpButton.Text = "UP!";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(385, 145);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(60, 23);
            this.moveDownButton.TabIndex = 16;
            this.moveDownButton.Text = "DOWN!";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // deleteSelectedRows
            // 
            this.deleteSelectedRows.Location = new System.Drawing.Point(385, 116);
            this.deleteSelectedRows.Name = "deleteSelectedRows";
            this.deleteSelectedRows.Size = new System.Drawing.Size(60, 23);
            this.deleteSelectedRows.TabIndex = 17;
            this.deleteSelectedRows.Text = "DELETE!";
            this.deleteSelectedRows.UseVisualStyleBackColor = true;
            this.deleteSelectedRows.Click += new System.EventHandler(this.deleteSelectedRows_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(385, 293);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CLEAR!";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AutoMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 915);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteSelectedRows);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.populateTreeButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.directoryCmdView);
            this.Controls.Add(this.directoryTreeView);
            this.Controls.Add(this.recurseBox);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.Inputlabel);
            this.MaximizeBox = false;
            this.Name = "AutoMav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMav";

            ((System.ComponentModel.ISupportInitialize)(this.directoryCmdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inputlabel;
        private System.Windows.Forms.TextBox directoryInput;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.CheckBox recurseBox;
        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.DataGridView directoryCmdView;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button populateTreeButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button deleteSelectedRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cmd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn included;
        private Button clearButton;
    }
}

