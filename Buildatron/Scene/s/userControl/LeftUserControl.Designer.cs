namespace Buildatron.Scene.s.userControl {
    partial class LeftUserControl {
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
            this.leftTreeControlView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // leftTreeControlView
            // 
            this.leftTreeControlView.Location = new System.Drawing.Point(3, 3);
            this.leftTreeControlView.Name = "leftTreeControlView";
            this.leftTreeControlView.Size = new System.Drawing.Size(194, 434);
            this.leftTreeControlView.TabIndex = 21;
            
            this.leftTreeControlView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTreeControlView_Click);
            // 
            // LeftUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftTreeControlView);
            this.Name = "LeftUserControl";
            this.Size = new System.Drawing.Size(200, 440);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView leftTreeControlView;
    }
}
