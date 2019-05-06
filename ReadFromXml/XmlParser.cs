using System;
using System.Xml;

namespace ReadFromXml
{
    public class XmlParser
    {
        // files
        private const string fileUrl = "URL.xml";
        private const string fileFindElements = "FindElements.xml";

        // tables
        private const string fileUrlTableUrl = "/Table/URL";
        private const string fileFindElementsTableStartPageXPath = "/Table/Start_page/XPath";


        private XmlNode LoadXmlFileAndXmlTable(string file, string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file);
            XmlNode node = xmlDoc.DocumentElement.SelectSingleNode(path);
            return node;
        }

        public XmlNode LoadFileUrlTableUrl()
        {
            return LoadXmlFileAndXmlTable(fileUrl, fileUrlTableUrl);
        }

        public XmlNode LoadFileFindElementsTableStartPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableStartPageXPath);
        }
    }
}
