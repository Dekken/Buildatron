using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.XPath;


namespace Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations {
    class PreloadedConfigurationGetterService {

        private static PreloadedConfigurationGetterService instance;
        public static PreloadedConfigurationGetterService getInstance() {
            if (PreloadedConfigurationGetterService.instance == null) {
                PreloadedConfigurationGetterService.instance = new PreloadedConfigurationGetterService();
            }
            return PreloadedConfigurationGetterService.instance;
        }

        public List<string> getDirectoriesFromXMLConfiguration(string config) {
            XPathNavigator nav      = XPathHandler.getInstance().setupUp("xml/" + config + ".xml");
            XPathNodeIterator xpni = nav.Select("//configuration/directories/directory");

            List<string> configs = new List<string>();

            foreach (XPathNavigator item in xpni){
                configs.Add(esc(item.Value));
            }

            return configs;            
        }

        public List<Command>  getCommandsFromXMLConfiguration(string config) {
            XPathNavigator nav      = XPathHandler.getInstance().setupUp("xml/" + config + ".xml");
            XPathNodeIterator xpni  = nav.Select("//configuration/commands/command");
            List<Command> commands  = new List<Command>();
            foreach (XPathNavigator item in xpni) {
                commands.Add(new Command(esc(item.GetAttribute("name", "")), esc(item.Value)));
            }
            
            return commands;
        }

        public string getFilePattern(string config) {
            return getValueFromXMLWithXpath(config, "//configuration/filePattern[1]");
        }

        public string getValueFromXMLWithXpath(string config, string xp){
            XPathNavigator nav = XPathHandler.getInstance().setupUp("xml/" + config + ".xml");
            XPathNodeIterator xpni = nav.Select(xp);
            foreach (XPathNavigator item in xpni){
                return esc(item.Value);
            }
            return "";
        }

        public string getCommand(string configFile, string s){
            return getValueFromXMLWithXpath(configFile, "//configuration/commands/command[@name='" + s + "']");
        }

        public Command getCommand(string configFile, int i){

            XPathNavigator nav      = XPathHandler.getInstance().setupUp("xml/" + configFile + ".xml");
            XPathNodeIterator xpni  = nav.Select("//configuration/commands/command[" + i + "]");
            Command c = null;
            foreach (XPathNavigator item in xpni) {
                c = new Command(esc(item.GetAttribute("name", "")), esc(item.Value));
            }
            
            return c;
        }

        private string esc(string s){
            return s.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&amp;", "&").Replace("&quot;", "\"").Replace("&apos;", "’").Replace("&#39;", "’");
            //return System.Security.SecurityElement.Escape(s);
        }
    }
}
