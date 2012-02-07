using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.XPath;

namespace Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations {
    public class PreloadedConfigurationValidationService {

        private static PreloadedConfigurationValidationService instance;
        public static PreloadedConfigurationValidationService getInstance() {
            if (PreloadedConfigurationValidationService.instance == null) {
                PreloadedConfigurationValidationService.instance = new PreloadedConfigurationValidationService();
            }
            return PreloadedConfigurationValidationService.instance;
        }

        public void getConfigurations() {}
        private string getOrCreateConfigurationFile(string file) {
            if(!Directory.Exists("xml")){
                Directory.CreateDirectory("xml");
            }
            if(!File.Exists("xml/" + file + ".xml")){
                PreloadedConfigurationModificationsService.getInstance().createEmptyConfiguration("xml/" + file + ".xml");
            }
            return "xml/" + file + ".xml";
        }

        public bool validateConfiguration(string path) {
            bool b = true;
            XPathNavigator nav = XPathHandler.getInstance().setupUp(path);
            foreach (string s in new validation.ConfigurationValidationRequirements().validableXPathStrings) {
                b = b && XPathHandler.getInstance().returnString(nav, s) != null;
            }
            return b;
        }

        public bool validateFilePattern(string filePattern) {
            return true;
        }

        public bool validateName(string name) {
            return !File.Exists("xml/ " + name + ".xml");
        }
    }
}
