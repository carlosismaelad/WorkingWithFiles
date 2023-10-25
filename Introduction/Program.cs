using System.IO;

namespace Introduction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string sourcepath = @"c:\text\file1.txt";
            string targetPath = @"c:\text\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcepath);
                fileInfo.CopyTo(targetPath);

                // Mostrar no terminal
                string[] lines = File.ReadAllLines(sourcepath); // instanciando vetor com o conteúdo do arquivo
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Copied successfully!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
