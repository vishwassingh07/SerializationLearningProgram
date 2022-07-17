using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationLearningProgram
{
    public class XmlOperations
    {
        //Xml Serialization 
        public static void XmlSerialize()
        {
            StreamWriter sw = null;
            try
            {
                string xmlPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\XmlData.txt";
                Person person = new Person() { personId = 14, name = "Sheetal", address = "Jaipur" };

                XmlSerializer xml = new XmlSerializer(typeof(Person));
                sw = new StreamWriter(xmlPath);
                xml.Serialize(sw, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        // Xml Deserialization
        public static void XmlDeserialize()
        {
            try
            {
                string xmlPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\XmlData.txt";
                using (StreamReader sr = new StreamReader(xmlPath))
                {
                    if (File.Exists(xmlPath))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(Person));
                       Person person = (Person)xml.Deserialize(sr);
                        Console.WriteLine(person);
                    }
                }             
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
