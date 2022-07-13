using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLearningProgram
{
    /// <summary>
    /// Person class for storing person details
    /// </summary>
    public class Person
    {
        public int personId { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return $"ID : " + personId +" "+ "Name : " + name +" "+ "Address : " + address;
        }
    }
}
