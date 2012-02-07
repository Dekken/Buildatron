using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Buildatron.Scene.s.userControl.rights.operational.services.directory.input {
    class OperationalControlDirectoryInputService {

        private static OperationalControlDirectoryInputService instance;
        public static OperationalControlDirectoryInputService getInstance() {
            if (OperationalControlDirectoryInputService.instance == null) {
                OperationalControlDirectoryInputService.instance = new OperationalControlDirectoryInputService();
            }
            return OperationalControlDirectoryInputService.instance;
        }

        
    }
}
