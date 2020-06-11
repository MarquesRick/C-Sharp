using System;
using System.IO;

namespace FileStreamStreamReader2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\henma\source\repos\MarquesRick\C-Sharp\TrabalhandoArquivos\file2_copy.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);

                //metodo para mostrar todas as linhas
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }
}
