using System;
using System.IO;

namespace ManipulandoArquivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            //v1/FileStream fs = null;
            StreamReader sr = null;

            try
            {
                ///v1/ Modelo Antigo de fazer
                //v1/ fs = new FileStream(path, FileMode.Open);  // Instanciei um FileStream associado ao arquivo e abrindo o mesmo
                //v1/ sr = new StreamReader(fs);

                ///v2/ Nova forma de fazer
                sr = File.OpenText(path);
                while (!sr.EndOfStream) //Enquando não chegar no final da Stream 
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               
            }
            catch (IOException e)
            {

                Console.WriteLine("An erro accorred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
               //v1/ if (fs != null) fs.Close();
               
            }

            Console.ReadKey();
            
        }
    }
}
