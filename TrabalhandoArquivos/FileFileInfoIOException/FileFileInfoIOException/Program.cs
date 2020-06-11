using System;
using System.IO;
namespace FileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            // coloca-se @ para não precisar colocar '\\' em cada diretório-caminho
            string sourcePath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file1.txt";
            string targetPath = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file2_copy.txt";
            try
            {
                File.Copy(sourcePath, targetPath);
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
