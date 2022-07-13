using System;
namespace SerializationLearningProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Serialization Learning Program\n*********************************************");
            bool end = true;
            Console.WriteLine("1. Json Serialization\n2. End the program");
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