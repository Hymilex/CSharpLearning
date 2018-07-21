using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqQ
{
    class LO
    {

        public static void ExecLinq()
        {
            List<int> ia = new List<int>();
            Random ra = new Random();
            for (int i = 0; i < 10; i++)
            {
                ia.Add(ra.Next(100));
            }
            Console.WriteLine("Linq查询:");
            LinqQuery(ia);
        }

        public static void LinqQuery(List<int> collection)
        {
            var qrs = from item in collection where item % 2 == 0 select item;

            foreach (var item in qrs)
            {
                Console.WriteLine(item+","+new string('*',9));
            }
        }

        public static string xmlString = "<Persons>"+"<Person Id = '1' >"+"<Name>Joseph</Name>"+"<Age>18</Age>"+"</Person><Person Id='2'>"+"<Name>Mike</Name>"+"<Age>12</Age>"+"</Person>"+
            "</Persons>";
        public static void LinqXML()
        {
            //导入xml
            
            XElement xmlDoc = XElement.Parse(xmlString);
            //创建查询
            var qrs = from element in xmlDoc.Elements("Person") where element.Element("Name").Value == "Mike" select element;
            foreach (var x in qrs)
            {
                Console.WriteLine("Name as :"+x.Element("Name").Value+".Id:"+x.Attribute("Id").Value);
            }
        }

        public static void ExecXML()
        {
            Console.WriteLine("LinqToXML Result:");
            LinqXML();
        }
    }
}
