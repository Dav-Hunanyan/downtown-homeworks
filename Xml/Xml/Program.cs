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
            Employee employee = new Employee(103221, "AAAAAAAAAAA");
            Xml.Serializer(employee, xml);
            Employee employee1 = Xml.Deserializer<Employee>(xml);




        }




    }
}
