using System;
namespace SerializationLearningProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Serialization Learning Program\n*********************************************");
            bool end = true;
            Console.WriteLine("1. Json Serialization\n2. Json Deserialization\n3. Xml Serialization\n4. " +
                "Xml Deserialization\n5. Csv Serialization\n6. Csv Deserialization\n7. End the program");
            while (end)
            {
                Console.WriteLine("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        JSonOperations.JSonSerialize();
                        Console.ReadLine();
                        break;
                    case 2:
                        JSonOperations.JSonDeserialize();
                        Console.ReadLine();
                        break;
                    case 3:
                        XmlOperations.XmlSerialize();
                        break;
                    case 4:
                        XmlOperations.XmlDeserialize();
                        break;
                    case 5:
                        CsvDataOperations.CsvSerialize();
                        break;
                    case 6:
                        CsvDataOperations.CsvDeserialization();
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }
        }
    }
}