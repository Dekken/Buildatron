using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

public class XPathHandler {

    public static XPathHandler instance;
    public static XPathHandler getInstance() {
        if (XPathHandler.instance == null) {
            XPathHandler.instance = new XPathHandler();
        }
        return XPathHandler.instance;
    }

    public string returnStringWithSetup(string file, string xp) {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        return returnString(doc.CreateNavigator(), xp);
    }
    public string returnString(XPathNavigator nav, string xp) {
        return nav.Select(xp).ToString();
    }

    public XPathNavigator setupUp(string file) {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        return doc.CreateNavigator();
    }

    public XPathNodeIterator setupUpAndSelectForNodeIterator(string file, string xp) {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        return doc.CreateNavigator().Select(xp);
    }

    public XmlDocument setupUpToSave(string file) {
        XmlDocument doc = new XmlDocument();
        doc.Load(file);
        return doc;
    }
    private void tearDown() { }
}