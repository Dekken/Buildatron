using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buildatron.Scene.s.userControl {

    public partial class RightUserControl : UserControl {
        
        public RightUserControl(Form f) {
            this.Parent = f;
            InitializeComponent();
            this.Location = new System.Drawing.Point(220, 10);
        }
    }
}
