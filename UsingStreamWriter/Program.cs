namespace UsingStreamWriter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string sourcePath = @"c:\text\file1.txt";
            string targetPath = @"c:\text\file2.txt";

            // Vamos transformar todo o conteúdo de file1 em
            // uppercase para o file2
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

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
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
