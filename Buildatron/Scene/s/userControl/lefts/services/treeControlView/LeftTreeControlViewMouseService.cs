using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Buildatron.Scene.s.userControl.lefts.services {

    public class LeftTreeControlViewMouseService {

        public static void handleLeftMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeView tv = (TreeView) sender;
            if (e.Button.Equals(MouseButtons.Left)) {
                
                if (e.Node is ControlTreeNode) {
                    ControlTreeNode node = (ControlTreeNode)e.Node;
                    ((UserControlForm)((UserControl)tv.GetContainerControl()).Parent).setRightControl(node.getControl());
                }
            } else if (e.Button.Equals(MouseButtons.Right)) {

            } else if (e.Button.Equals(MouseButtons.Middle)) {

            }
        }
    }
}
