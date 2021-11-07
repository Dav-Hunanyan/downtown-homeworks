using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xml
{
    class Program
    {

        static void Main(string[] args)
        {

            string xml = @"F:\employee.txt";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            Employee employee = new Employee(103221, "AAAAAAAAAAA");
            // TextWriter txtWriter = new StreamWriter(xml);
            //  xmlSerializer.Serialize(txtWriter, employee);

            StreamReader streamReader = new StreamReader(xml);
            Employee employee1 = (Employee)xmlSerializer.Deserialize(streamReader);
        }




    }
}
