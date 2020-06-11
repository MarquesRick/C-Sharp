using System;
using System.IO;

namespace UsingBlock2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file2_copy.txt";
            try
            {
                //forma resumida de instanciação
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
