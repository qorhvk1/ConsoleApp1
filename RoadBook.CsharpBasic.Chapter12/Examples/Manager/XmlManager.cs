﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoadBook.CsharpBasic.Chapter12.Examples.Manager
{
    public class XmlManager
    {
        public enum USE_TYPE { WRITE, READ };

        private XDocument _xDoc;

        private static char directorySeparator =
            Path.DirectorySeparatorChar;
        private static string crawlDirectoryPath =
            Environment.CurrentDirectory + directorySeparator + "crawled";

        public XmlManager(USE_TYPE useType)
        {
            switch (useType)
            {
                case USE_TYPE.WRITE:
                    if (Directory.Exists(crawlDirectoryPath))
                    {
                        DirectoryInfo di =
                            new DirectoryInfo(crawlDirectoryPath);
                        foreach (var file in di.GetFiles())
                        {
                            file.MoveTo(crawlDirectoryPath + directorySeparator +
                                "backup" + directorySeparator + file.Name);
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(crawlDirectoryPath);
                        Directory.CreateDirectory
                            (crawlDirectoryPath + directorySeparator + "backup");
                    }

                    _xDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", null),
                        new XElement("result"));
                    break;
                case USE_TYPE.READ:
                    if (Directory.Exists(crawlDirectoryPath))
                    {
                        DirectoryInfo di =
                            new DirectoryInfo(crawlDirectoryPath);
                        FileInfo[] fi = di.GetFiles();

                        if (fi.Length > 0)
                        {
                            _xDoc = XDocument.Load(fi[0].FullName);
                        }
                    }
                    break;

                default:
                    break;

            }
        }

        public void Write(Model.Contents contents)
        {
            _xDoc.Element("result").Add(
                new XElement("row",
                new XElement("idx", contents.Idx),
                new XElement("title", new XCData(contents.Title)),
                new XElement("summary", new XCData(contents.Summary)),
                new XElement("create_data", contents.CreateDt),
                new XElement("create_user",
                new XCData(contents.CreateUserNm)),
                new XElement("tags", new XCData(contents.Tags))
                ));
        }

        public List<Model.Contents> Read()
        {
            return _xDoc.Descendants("row").Select(s => new Model.Contents()
            {
                Idx = Convert.ToInt32(s.Element("idx").Value),
                Title = s.Element("title").Value,
                Summary = s.Element("summary").Value,
                CreateDt = Convert.ToDateTime(s.Element("create_data").Value),
                CreateUserNm = s.Element("create_user").Value,
                Tags = s.Element("tags").Value

            }).ToList();
        }
        public void Save()
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";

            _xDoc.Save(crawlDirectoryPath + directorySeparator + filename);

        }

    }
}
