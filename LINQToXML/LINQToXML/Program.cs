using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = System.IO.Directory.GetCurrentDirectory();
            // XElement xelement = XElement.Load(@"Test.xml", LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            XElement xelement = XElement.Load(@"..\..\..\Test.xml");

            var fileSettings = from filexml in xelement.Descendants()
                               select filexml;
            try
            {
                Console.WriteLine("------------FirstNode---------------");
                foreach (XElement xEle in fileSettings)
                {
                    Console.WriteLine(xEle.Name + ": " + xEle.FirstNode);
                }
                Console.WriteLine("----------------------------------------");


                Console.WriteLine("------------Value---------------");
                foreach (XElement xEle in fileSettings)
                {
                    Console.WriteLine(xEle.Name + ": " + xEle.Value);
                }
                Console.WriteLine("----------------------------------------");


                Console.WriteLine("------------Attribute---------------");
                foreach (XElement xEle in fileSettings)
                {
                    Console.WriteLine(xEle.Name + ": " + xEle.Attribute("Attr")?.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();

        }
    }
}
