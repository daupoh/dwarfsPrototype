using System;

using System.Xml;

namespace dwarfsDiamond.XmlFiles
{
    public static class SCXmlHelper
    {
        static string
            m_strXmlError = "Не найден узел",
            m_strServerErrorsParent = "serverErrors",

            m_strServerConstantParent = "serverConstant",


            m_strFilePathModelError = "C:\\Users\\daupoh\\documents\\visual studio 2015\\Projects\\dwarfsDiamond\\dwarfsDiamond\\XmlFiles\\ModelErrors.xml",
            m_strFilePathStringConstant = "C:\\Users\\daupoh\\documents\\visual studio 2015\\Projects\\dwarfsDiamond\\dwarfsDiamond\\XmlFiles\\StringConstants.xml";

        static XmlDocument m_xmlModelErrors=null,
            m_xmlStringContsants = null;

        public static string getServerError(string nodeName)
        {
            string serverError = "";
            serverError = getTextByNode(m_xmlModelErrors, m_strServerErrorsParent, nodeName, m_strFilePathModelError);
            return serverError;
        }
        public static string getServerConstant(string nodeName)
        {
            string serverConst = "";
            serverConst = getTextByNode(m_xmlStringContsants, m_strServerConstantParent, nodeName, m_strFilePathStringConstant);
            return serverConst;
        }
        public static string getTextByNode(XmlDocument xmlDoc, string parentNode, string nodeName, string filePath)
        {
            if (xmlDoc == null)
            {
                xmlDoc=initializeXmlDoc(xmlDoc,filePath);
            }
            string textNode = "";
            XmlElement xRoot = xmlDoc.DocumentElement;
            bool nodeHasFinded = false;
            foreach (XmlElement xpnode in xRoot)
            {
                if (xpnode.LocalName == nodeName)
                {
                    textNode = xpnode.InnerText;
                    nodeHasFinded = true;
                    break;
                }
            }             
            if (!nodeHasFinded)
            {
                throw new FormatException(m_strXmlError);
            }
            return textNode;
        }

        private static XmlDocument initializeXmlDoc(XmlDocument xmlDoc, string filePath)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            return xmlDoc;
        }
    }
}

