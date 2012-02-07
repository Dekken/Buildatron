namespace WindowsFormsApplication1
{
    partial class SettingsForm
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
            this.stopOnFailCheckBox = new System.Windows.Forms.CheckBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.clearOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // stopOnFailCheckBox
            // 
            this.stopOnFailCheckBox.AutoSize = true;
            this.stopOnFailCheckBox.Location = new System.Drawing.Point(86, 66);
            this.stopOnFailCheckBox.Name = "stopOnFailCheckBox";
            this.stopOnFailCheckBox.Size = new System.Drawing.Size(114, 17);
            this.stopOnFailCheckBox.TabIndex = 4;
            this.stopOnFailCheckBox.Text = "Stop on Build Fail?";
            this.stopOnFailCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(104, 221);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // clearOutputCheckBox
            // 
            this.clearOutputCheckBox.AutoSize = true;
            this.clearOutputCheckBox.Location = new System.Drawing.Point(86, 89);
            this.clearOutputCheckBox.Name = "clearOutputCheckBox";
            this.clearOutputCheckBox.Size = new System.Drawing.Size(180, 17);
            this.clearOutputCheckBox.TabIndex = 6;
            this.clearOutputCheckBox.Text = "Clear output on each command?";
            this.clearOutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.clearOutputCheckBox);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.stopOnFailCheckBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox stopOnFailCheckBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox clearOutputCheckBox;

    }
}