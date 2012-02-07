using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations {
    public class PreloadedConfigurationModificationsService {

        private static PreloadedConfigurationModificationsService instance;
        public static PreloadedConfigurationModificationsService getInstance() {
            if (PreloadedConfigurationModificationsService.instance == null) {
                PreloadedConfigurationModificationsService.instance = new PreloadedConfigurationModificationsService();
            }
            return PreloadedConfigurationModificationsService.instance;
        }

        public void createEmptyConfiguration(string configFile) {
            File.AppendAllText(configFile,
                "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + "\n" +
                "<configuration>" + "\n" +
                "\t<filePattern></filePattern>" + "\n" +
                "\t<directories>" + "\n" +
                "\t</directories>" + "\n" +
                "\t<commands>" + "\n" +
                "\t</commands>" + "\n" +
                "</configuration>"
            );
        }

        public void createCommand(string configFile) {
            this.createXMLNodeWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/commands", "command", "command");
            this.createXMLAttributeWithXpathAndValue("xml/" + configFile + ".xml", "//configuration/commands/command[last()]", "name", "name");
        }

        public void createDirectory(string configFile, string directory) {
            this.createXMLNodeWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/directories", "directory", directory);
        }
        public void removeDirectory(string configFile, int node) {
            this.removeFromXMLWithXPath("xml/" + configFile + ".xml", "//configuration/directories/directory[" + node + "]");
        }

        public void updateName(string configFile, string s){
            if(File.Exists("xml/" + configFile + ".xml")){
                File.Move("xml/" + configFile + ".xml", "xml/" + s + ".xml");
            }
        }

        public void updateDirectory(string configFile, string s, int node) {
            updateXMLWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/directories/directory[" + node + "]", s);
        }

        public void updateCommandName(string configFile, string s, string row) {
            updateXMLWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/commands/command[" + row + "]/@name", s);
        }

        public void updateCommandString(string configFile, string s, string row){
            updateXMLWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/commands/command[" + row + "]", s);
        }

        public void swapCommands(string config, int a, int b){
            Command ca = PreloadedConfigurationGetterService.getInstance().getCommand(config, a);
        }

        public void updateFilePattern(string configFile, string s) {
            updateXMLWithXPathAndValue("xml/" + configFile + ".xml", "//configuration/filePattern[1]", s);
        }

        private void updateXMLWithXPathAndValue(string configFile, string xp, string s) {
            XmlDocument doc = XPathHandler.getInstance().setupUpToSave(configFile);
            XPathNavigator nav = doc.CreateNavigator();
            
            XPathNodeIterator xpni = nav.Select(xp);
            foreach (XPathNavigator item in xpni) {
                if (item.CanEdit) {
                    item.SetValue(System.Security.SecurityElement.Escape(s));
                } else {
                    Console.WriteLine("Cannot edit");
                }
                doc.Save(configFile);
            }
        }

        private void removeFromXMLWithXPath(string configFile, string xp) {
            XmlDocument doc = XPathHandler.getInstance().setupUpToSave(configFile);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator xpni = nav.Select(xp);
            foreach (XPathNavigator item in xpni) {
                if (item.CanEdit) {
                    item.DeleteSelf();
                } else {
                    Console.WriteLine("Cannot edit");
                }
                doc.Save(configFile);
            }
        }


        public void createXMLNodeWithXPathAndValue(string configFile, string xp, string node, string value){

            XmlDocument doc = XPathHandler.getInstance().setupUpToSave(configFile);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator xpni = nav.Select(xp);

            while (xpni.MoveNext()) { }
            if (xpni.Current.CanEdit) {
                xpni.Current.AppendChildElement("", node, "", value);
            } else {
                Console.WriteLine("Cannot edit");
            }
            doc.Save(configFile);
        }

        public void createXMLAttributeWithXpathAndValue(string configFile, string xp, string node, string value){

            XmlDocument doc = XPathHandler.getInstance().setupUpToSave(configFile);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator xpni = nav.Select(xp);

            foreach (XPathNavigator item in xpni){

                if (item.CanEdit){                    
                    
                    item.CreateAttribute("", node, "", value);
                }else{
                    Console.WriteLine("Cannot edit");
                }
            }
            doc.Save(configFile);

        }


    }
}