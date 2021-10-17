using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Basiclibrarycode.Ydw
{
    public class XMLHelp
    {
        private string basePath = "";
        private string xmlPath()
        {
            if (!string.IsNullOrEmpty(basePath) && File.Exists(basePath))
            {
                return basePath; 
            }
            string path = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["CachePath"];
            if (File.Exists(path))
            {
                basePath = path;
                return basePath;
            }
            if (NewXMLFile(path, "Cache"))
            {
                basePath = path;
                return basePath;
            }
            return path;
        }

        /// <summary>
        /// 获取XML文件根目录下的Datatable
        /// </summary>
        /// <returns>返回list</returns>
        public DataTable getXMLTable()
        {
            DataTable xmlTable = new DataTable("xmltable");
            xmlTable.Columns.Add("Column_Key");
            xmlTable.Columns.Add("Column_Value");
            xmlTable.Columns.Add("Column_Description");
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                XmlNode root = xmlDoc.SelectSingleNode(xmlDoc.DocumentElement.Name);
                if (root.HasChildNodes)
                {
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        DataRow dr = xmlTable.NewRow();
                        dr["Column_Key"] = node.Name;
                        dr["Column_Value"] = node.InnerText;
                        dr["Column_Description"] = node.Attributes["Description"].Value;
                        xmlTable.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return xmlTable;
        }
        /// <summary>
        /// 获取XML文件根目录下的List列表
        /// </summary>
        /// <returns>返回list</returns>
        public List<XMLContent> getXMLList()
        {
            List<XMLContent> objlist = new List<XMLContent>();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                XmlNode root = xmlDoc.SelectSingleNode(xmlDoc.DocumentElement.Name);
                if (root.HasChildNodes)
                {
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        XMLContent obj = new XMLContent();
                        obj.Column_Key = node.Name;
                        obj.Column_Value = node.InnerText;
                        obj.Column_Description = node.Attributes["Description"].Value;
                        objlist.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objlist;
        }
        /// <summary>
        /// 判断XML文件中根目录下某个节点是否存在
        /// </summary>
        /// <param name="key">根目录下的节点名称</param>
        /// <returns>true：存在；false：不存在</returns>
        public Boolean isXMLKeyNull(string key)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                string xPath = string.Format("{0}/{1}", xmlDoc.DocumentElement.Name, key);
                return xmlDoc.SelectSingleNode(xPath) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 查询XML节点对象列表
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <returns>返回list</returns>
        public List<XMLContent> getKeyValue(string key)
        {
            List<XMLContent> objlist = new List<XMLContent>();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                string xPath = string.Format("{0}/{1}", xmlDoc.DocumentElement.Name, key);
                var xmlcontent = xmlDoc.SelectSingleNode(xPath);
                XMLContent obj = new XMLContent();
                obj.Column_Key = xmlcontent.Name;
                obj.Column_Value = xmlcontent.InnerText;
                obj.Column_Description = xmlcontent.Attributes["Description"].Value;
                objlist.Add(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objlist;
        }
        public string getValue(string key)
        {
            List<XMLContent> objlist = getXMLList();
            return objlist.Where(l => l.Column_Key == key).FirstOrDefault().Column_Value;
        }
        /// <summary>
        /// 保存数据到XML文件的根节点之下
        /// </summary>
        /// <param name="XMLList">保存的数据列表</param>
        /// <param name="msg">返回的消息信息</param>
        /// <returns>返回是否保存成功</returns>
        public Boolean AddXMLKsy(List<XMLContent> XMLList)
        {
            try
            {
                if (isXMLKeyNull(XMLList[0].Column_Key))
                {
                    return false;
                }
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                XmlNode root = xmlDoc.SelectSingleNode(xmlDoc.DocumentElement.Name);
                XmlElement xele = xmlDoc.CreateElement(XMLList[0].Column_Key);
                xele.SetAttribute("Description", XMLList[0].Column_Description);
                xele.InnerText = string.IsNullOrEmpty(XMLList[0].Column_Value) ? "" : XMLList[0].Column_Value;
                root.AppendChild(xele);
                xmlDoc.Save(xmlPath());
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean addXMLKsyForKey(string key, string value)
        {
            try
            {
                if (isXMLKeyNull(key))
                {
                    return false;
                }
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                XmlNode root = xmlDoc.SelectSingleNode(xmlDoc.DocumentElement.Name);
                XmlElement xele = xmlDoc.CreateElement(key);
                xele.SetAttribute("Description", DateTime.Now.ToLocalTime().ToString());
                xele.InnerText = string.IsNullOrEmpty(value) ? "" : value;
                root.AppendChild(xele);
                xmlDoc.Save(xmlPath());
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 编辑XML文件
        /// </summary>
        /// <param name="XMLList">需要编辑的数据列表</param>
        /// <returns>返回是否编辑成功</returns>
        public Boolean EditXMLKsy(List<XMLContent> XMLList)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                string xPath = string.Format("{0}/{1}", xmlDoc.DocumentElement.Name, XMLList[0].Column_Key);
                XmlNode root = xmlDoc.SelectSingleNode(xPath);
                if (root != null)
                {
                    var xx = XMLList[0].Column_Description;
                    root.InnerText = string.IsNullOrEmpty(XMLList[0].Column_Value) ? "" : XMLList[0].Column_Value;
                    root.Attributes["Description"].Value = XMLList[0].Column_Description;
                    xmlDoc.Save(xmlPath());
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据 Key 添加键值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean editXMLKsyForKey(string key,string value)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                string xPath = string.Format("{0}/{1}", xmlDoc.DocumentElement.Name, key);
                XmlNode root = xmlDoc.SelectSingleNode(xPath);
                if (root != null)
                {
                    root.InnerText = string.IsNullOrEmpty(value) ? "" : value;
                    root.Attributes["Description"].Value = DateTime.Now.ToLocalTime().ToString();
                    xmlDoc.Save(xmlPath());
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据 key 删除数据
        /// </summary>
        /// <param name="appKey"></param>
        /// <returns></returns>
        public Boolean DelXMLKsy(string appKey)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //加载xml文件（参数为xml文件的路径）
                xmlDoc.Load(xmlPath());
                XmlNode root = xmlDoc.SelectSingleNode(xmlDoc.DocumentElement.Name);
                XmlNode node = root.SelectSingleNode(appKey);
                if (root != null)
                {
                    root.RemoveChild(node);
                    xmlDoc.Save(xmlPath());
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 创建XML文件
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <param name="root">根节点名称</param>
        /// <returns>返回是否创建成功</returns>
        public Boolean NewXMLFile(string filename, string root)
        {
            string content = "";
            content += "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n";
            content += "<" + root + ">\n" + "</" + root + ">";
            try
            {
                // 创建文件
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名，还可以为word等文件
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                sw.WriteLine(content); // 写入Hello World
                sw.Close(); //关闭文件
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class XMLContent
    {
        public string Column_Key { get; set; }
        public string Column_Value { get; set; }
        public string Column_Description { get; set; }
    }
}
