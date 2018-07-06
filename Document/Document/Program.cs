using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Document");

                Console.WriteLine("Enter the name of the Document:");

                string name = Console.ReadLine();

                Console.WriteLine("Enter the Content for the Document:");

                string content = Console.ReadLine();

                string fileName = name + ".txt";

                string path = Environment.CurrentDirectory + "/" + fileName;

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, content);
                }

                Console.WriteLine(fileName + " was successfully saved. The document contains " + content.Length + " characters");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
    }
}
