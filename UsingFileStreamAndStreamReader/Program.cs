namespace UsingFileStreamAndStreamReader
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string path = @"c:\text\file1.txt";

            // Recurso externo não gerenciado pelo CLR
            // Uma conversa com o sistema operacional

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
            finally
            {
                // Fechando as streams
                // Se for diferente de nulo (aberto)
                if (sr != null) sr.Close();
            }
        }
    }
}
