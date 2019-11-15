using System;
using System.IO;

namespace CourseBlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string origem = @"c:\temp\exemplo.txt";

            try
            {

                using (StreamReader sr = File.OpenText(origem))
                {
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro,não foi encontrado esse arquivo ");
                Console.WriteLine(e.Message);
            }
        }
    }
}