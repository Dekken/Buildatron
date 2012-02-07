using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.XPath;

namespace Buildatron.Scene.s.userControl.services.master.configuration {
    public class MasterConfigurationGetterService {

        private static MasterConfigurationGetterService instance;
        public static MasterConfigurationGetterService getInstance() {
            if (MasterConfigurationGetterService.instance == null) {
                MasterConfigurationGetterService.instance = new MasterConfigurationGetterService();
            }
            return MasterConfigurationGetterService.instance;
        }

        public HashSet<string> getConfigurations() {

            XPathNavigator nav = XPathHandler.getInstance().setupUp("buildatron.xml");
            XPathNodeIterator xpni = nav.Select("//buildatron/configurations");

            HashSet<string> configs = new HashSet<string>();

            while (xpni.MoveNext()) {
                configs.Add(xpni.Current.Value);
            }

            return configs;
        }
    }
}
