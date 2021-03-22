using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\file1.txt"; // Caminho do arquivo de origem.
            string targetPath = @"C:\temp\file2.txt"; // Caminho do arquivo de destino.

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Fazendo cópia do arquivo

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro occurred");
                Console.WriteLine(e.Message);
               
            }

            

            Console.ReadKey();

            
        }
    }
}
