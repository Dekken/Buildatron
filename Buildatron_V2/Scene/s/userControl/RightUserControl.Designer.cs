namespace Buildatron.Scene.s.userControl {
    partial class RightUserControl {
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
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.killProcessesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.BackColor = System.Drawing.Color.Black;
            this.cmdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(6)))));
            this.cmdTextBox.Location = new System.Drawing.Point(3, 382);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.ReadOnly = true;
            this.cmdTextBox.Size = new System.Drawing.Size(928, 55);
            this.cmdTextBox.TabIndex = 3;
            this.cmdTextBox.Text = "awd";
            // 
            // killProcessesButton
            // 
            this.killProcessesButton.Enabled = false;
            this.killProcessesButton.Location = new System.Drawing.Point(937, 382);
            this.killProcessesButton.Name = "killProcessesButton";
            this.killProcessesButton.Size = new System.Drawing.Size(101, 23);
            this.killProcessesButton.TabIndex = 38;
            this.killProcessesButton.Text = "KILL";
            this.killProcessesButton.UseVisualStyleBackColor = true;
            // 
            // RightUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.killProcessesButton);
            this.Controls.Add(this.cmdTextBox);
            this.Name = "RightUserControl";
            this.Size = new System.Drawing.Size(1050, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //protected System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        protected System.Windows.Forms.TextBox cmdTextBox;
        protected System.Windows.Forms.Button killProcessesButton;
    }
}
