﻿using System;
using System.IO;
using System.Text;
using System.Xml;

namespace TiaImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TiaXmlCombiner [Verz. XML ohne Code] [Verz. XML mit Code]");
            CombineDirs(args[0], args[1]);
        }

        private static void CombineDirs(string dir1, string dir2)
        {
            var fls = Directory.GetFiles(dir1, "*.xml");
            foreach (var f in fls)
            {
                var f2 = Path.Combine(dir2, Path.GetFileName(f));
                if (File.Exists(f2))
                {
                    var combined = CombineFiles(f, f2);
                    File.WriteAllText(f, combined, new UTF8Encoding(true));
                }
            }

            var dirs = Directory.GetDirectories(dir1);
            foreach(var d in dirs)
            {
                var rel = Path.GetRelativePath(dir1, d);
                var newP = Path.Combine(dir2, rel);
                CombineDirs(d, newP);
            }
        }

        private static string CombineFiles(string fileWithoutCode, string fileWithCode)
        {
            var xml1 = File.ReadAllText(fileWithoutCode);
            var xml2 = File.ReadAllText(fileWithCode);

            XmlDocument xmlDoc1 = new XmlDocument();
            XmlNamespaceManager ns1 = new XmlNamespaceManager(xmlDoc1.NameTable);
            ns1.AddNamespace("smns", "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v3");
            ns1.AddNamespace("smns2", "http://www.siemens.com/automation/Openness/SW/Interface/v3");

            XmlDocument xmlDoc2 = new XmlDocument();
            XmlNamespaceManager ns2 = new XmlNamespaceManager(xmlDoc2.NameTable);
            ns2.AddNamespace("smns", "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v3");
            ns2.AddNamespace("smns2", "http://www.siemens.com/automation/Openness/SW/Interface/v3");

            xmlDoc1.LoadXml(xml1);
            xmlDoc2.LoadXml(xml2);

            var codeNode = xmlDoc2.SelectNodes("//SW.Blocks.CompileUnit")[0];

            //var insertNode = xmlDoc1.SelectNodes("//SW.Blocks.FC/ObjectList")[0];
            //var maxId = xmlDoc1.SelectNodes("//*[@ID]").Cast<XmlNode>().Select(x => int.Parse(x.Attributes["ID"].Value, System.Globalization.NumberStyles.HexNumber)).Max();
            //codeNode.Attributes["ID"].Value = (maxId++).ToString("X");
            //insertNode.AppendChild(xmlDoc1.ImportNode(codeNode, true));

            var oldCodeNode = xmlDoc1.SelectNodes("//SW.Blocks.CompileUnit")[0];
            oldCodeNode.InnerXml = codeNode.InnerXml;


            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (TextWriter writer = new EncodingStringWriter(sb, Encoding.UTF8))
            {
                xmlDoc1.Save(writer);
            }
            var code = sb.ToString();


            return code;
        }
    }

    class EncodingStringWriter : StringWriter
    {
        private readonly Encoding _encoding;

        public EncodingStringWriter(StringBuilder builder, Encoding encoding) : base(builder)
        {
            _encoding = encoding;
        }

        public override Encoding Encoding
        {
            get { return _encoding; }
        }
    }
}