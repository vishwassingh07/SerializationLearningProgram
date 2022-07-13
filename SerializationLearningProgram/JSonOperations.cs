using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLearningProgram
{
    /// <summary>
    /// Json Input and Output Operations
    /// </summary>
    public class JSonOperations
    {
        /// <summary>
        /// Json Serializer
        /// </summary>
        public static void JSonSerialize()
        {
            string jsonPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\jsonData.json";
            //Collection Initializer
            List<Person> person = new List<Person>()
            {
                new Person(){personId=4, name = "Shobhit", address = "Jabalpur"},
                new Person(){personId=2, name = "Vivek", address = "Mumbai"},
                new Person(){personId=3, name = "Siddhant", address = "Bhopal"},

            };
            //SerializeObject method for converting object into json date
            string result = JsonConvert.SerializeObject(person);
            //Writing into file
            File.WriteAllText(jsonPath, result);

        }
        /// <summary>
        /// Json Deserialization
        /// </summary>
        public static void JSonDeserialize()
        {
            string jsonPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\jsonData.json";
            //Checking for file exixtance
            if (FileOperations.DoesFileExist(jsonPath))
            {
                //Reading from the file
                string jsonData = File.ReadAllText(jsonPath);
                //Deserializer method for converting the json data
                List<Person> result = JsonConvert.DeserializeObject<List<Person>>(jsonData);
                if (result.Count != 0)
                {
                    foreach (Person person in result)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
