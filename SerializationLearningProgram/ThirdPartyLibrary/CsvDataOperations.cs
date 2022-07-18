using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLearningProgram
{
    // Read and Write Operation On Csv Data
    public class CsvDataOperations
    {
        // Csv Serialization 
        public static void CsvSerialize()
        {
            StreamWriter sw = null;
            CsvWriter csvWriter = null;
            try
            {
                string csvPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\csvData.csv";
                List<Person> person = new List<Person>()
            {
                new Person(){personId=101, name = "Sarang", address = "Pune"},
                new Person(){personId=102, name = "Aman", address = "Thane"},
                new Person(){personId=103, name = "Priyanshu", address = "Noida"}

            };
                sw = new StreamWriter(csvPath);
                csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(person);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sw.Close();
            }
        }
        // Csv Deserialization
        public static void CsvDeserialization()
        {
            try
            {
                string csvPath = @"D:\RFP BATCH 157\SerializationLearningProgram\SerializationLearningProgram\SerializationLearningProgram\FileIO\csvData.csv";
                StreamReader sr = new StreamReader(csvPath);
                CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Person>  res = csvReader.GetRecords<Person>().ToList();
                foreach(Person person in res)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
