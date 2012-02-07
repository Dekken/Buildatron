using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;


namespace Buildatron.Scene.s.userControl.services.master.configuration {
    public class MasterConfigurationValidationService {

        private static MasterConfigurationValidationService instance;
        public static MasterConfigurationValidationService getInstance() {
            if (MasterConfigurationValidationService.instance == null) {
                MasterConfigurationValidationService.instance = new MasterConfigurationValidationService();
            }
            return MasterConfigurationValidationService.instance;
        }

        public void validateMasterConfigurationFile() {
            checkMasterConfigurationExistsIfNotCreateIt();


        }

        private void checkMasterConfigurationExistsIfNotCreateIt() { 
            if(!File.Exists("buildatron.xml")){
                File.AppendAllText("buildatron.xml",
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + "\n" +
                "<buildatron>" + "\n" +
	            "\t<options>" + "\n" +
	            "\t</options>" + "\n" +
                "</buildatron>"
                );
            }
        }
    }
}
