using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLearningProgram
{
    public class FileOperations
    { 
        public static bool DoesFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists ");
                return true;
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
                return false;
            }
        }
    }
}
