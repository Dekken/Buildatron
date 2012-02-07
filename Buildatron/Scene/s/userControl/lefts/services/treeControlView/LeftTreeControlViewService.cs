using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Buildatron.Scene.s.userControl.lefts.services {

    public class LeftTreeControlViewService {

        public static void handleMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            LeftTreeControlViewMouseService.handleLeftMouseClick(sender, e);
        }


    }
}
