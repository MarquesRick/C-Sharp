using System;
using System.IO;

namespace StreamWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file1.txt"; ;
            string targetPath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file4.txt"; ;
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //Append adiciona texto ao final
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
