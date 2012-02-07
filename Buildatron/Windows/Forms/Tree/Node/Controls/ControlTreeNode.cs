using System;
using System.Windows.Forms;

using Buildatron.Scene.s.userControl;

public class ControlTreeNode : TreeNode {

    private RightUserControl control;

    public ControlTreeNode(RightUserControl control) {
        this.control = control;
    }

    public RightUserControl getControl() {
        return this.control;
    }
}
