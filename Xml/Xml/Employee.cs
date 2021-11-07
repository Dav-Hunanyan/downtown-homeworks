using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml
{
    public class Employee
    {
        [XmlAttribute("Id")]
        public int Id;
        [XmlAttribute("name")]
        public String name;
       
        public Employee()
        {

        }
        public Employee(int id,string Name)
        {
            Id = id;
            name = Name;        
        }
    }
}
