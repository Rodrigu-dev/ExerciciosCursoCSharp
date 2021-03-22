using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExManipulandoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);


                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');
                        string nome = campos[0];
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Produto prod = new Produto(nome, preco, quantidade);

                        sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
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
