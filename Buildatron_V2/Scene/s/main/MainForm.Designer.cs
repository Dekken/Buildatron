using System.Windows.Forms;

namespace Buildatron
{
    partial class BuildingForm
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
            this.recurseBox = new System.Windows.Forms.CheckBox();
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.directoryCmdView = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.included = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GoButton = new System.Windows.Forms.Button();
            this.killProcessesButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.clearButton = new System.Windows.Forms.Button();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.directoryCmdView)).BeginInit();
            this.SuspendLayout();
            // 
            // Inputlabel
            // 
            this.Inputlabel.AutoSize = true;
            this.Inputlabel.Location = new System.Drawing.Point(207, 19);
            this.Inputlabel.Name = "Inputlabel";
            this.Inputlabel.Size = new System.Drawing.Size(49, 13);
            this.Inputlabel.TabIndex = 0;
            this.Inputlabel.Text = "Directory";
            this.Inputlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // directoryInput
            // 
            this.directoryInput.Location = new System.Drawing.Point(262, 16);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.Size = new System.Drawing.Size(230, 20);
            this.directoryInput.TabIndex = 1;
            this.directoryInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dicrectoryInput_keyPressed);
            // 
            // recurseBox
            // 
            this.recurseBox.AutoSize = true;
            this.recurseBox.Location = new System.Drawing.Point(498, 18);
            this.recurseBox.Name = "recurseBox";
            this.recurseBox.Size = new System.Drawing.Size(72, 17);
            this.recurseBox.TabIndex = 5;
            this.recurseBox.Text = "Recurse?";
            this.recurseBox.UseVisualStyleBackColor = true;
            this.recurseBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(210, 44);
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
            this.directoryCmdView.Location = new System.Drawing.Point(626, 12);
            this.directoryCmdView.Name = "directoryCmdView";
            this.directoryCmdView.Size = new System.Drawing.Size(521, 302);
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
            this.GoButton.Enabled = false;
            this.GoButton.Location = new System.Drawing.Point(1046, 401);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(101, 23);
            this.GoButton.TabIndex = 11;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // killProcessesButton
            // 
            this.killProcessesButton.Enabled = false;
            this.killProcessesButton.Location = new System.Drawing.Point(928, 401);
            this.killProcessesButton.Name = "killProcessesButton";
            this.killProcessesButton.Size = new System.Drawing.Size(101, 23);
            this.killProcessesButton.TabIndex = 19;
            this.killProcessesButton.Text = "KILL";
            this.killProcessesButton.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(192, 383);
            this.treeView1.TabIndex = 20;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(560, 291);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CLEAR!";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.BackColor = System.Drawing.Color.Black;
            this.cmdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(6)))));
            this.cmdTextBox.Location = new System.Drawing.Point(210, 320);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.ReadOnly = true;
            this.cmdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cmdTextBox.Size = new System.Drawing.Size(937, 75);
            this.cmdTextBox.TabIndex = 2;
            this.cmdTextBox.Text = "awd";
            this.cmdTextBox.TextChanged += new System.EventHandler(this.cmdTextBox_TextChanged);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 441);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.killProcessesButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.directoryCmdView);
            this.Controls.Add(this.directoryTreeView);
            this.Controls.Add(this.recurseBox);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.Inputlabel);
            this.MaximizeBox = false;
            this.Name = "BuildingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMav";
            ((System.ComponentModel.ISupportInitialize)(this.directoryCmdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inputlabel;
        private System.Windows.Forms.TextBox directoryInput;
        private System.Windows.Forms.CheckBox recurseBox;
        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.DataGridView directoryCmdView;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cmd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn included;
        private Button killProcessesButton;
        private TreeView treeView1;
        private Button clearButton;
        private TextBox cmdTextBox;
    }
}

