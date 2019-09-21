using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace XMLS
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement element = new XElement("note", new XElement("head", new XElement("Shead", "二级标题1")),
                new XElement("body", "一级结点2", new XAttribute("length", 50), 89, new Student().ToString()),
                new XElement("foot", "一级结点3"),
                new XElement("test", "", new XAttribute("q180", "30")));
              

            var find = from x in element.Descendants()
                       //where x.HasAttributes != false
                       //where  x.HasAttributes == false
                       where ((string)x.Attribute("q180")).Contains("30")
                       select x;
            foreach (var item in find)
            {
                Console.WriteLine(item) ;
            }
            Console.ReadLine();
        }
    }
    public class Student
    {

    }
}
