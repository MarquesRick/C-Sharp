using System;
using System.IO;

namespace FileFileInfoIOException2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file1.txt" ;
            string targetPath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file3_copy.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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

