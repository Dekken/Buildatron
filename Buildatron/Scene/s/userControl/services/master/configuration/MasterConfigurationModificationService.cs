using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buildatron.Scene.s.userControl.services.master.configuration {
    public class MasterConfigurationModificationService {

        private static MasterConfigurationModificationService instance;
        public static MasterConfigurationModificationService getInstance() {
            if (MasterConfigurationModificationService.instance == null) {
                MasterConfigurationModificationService.instance = new MasterConfigurationModificationService();
            }
            return MasterConfigurationModificationService.instance;
        }
    }
}
