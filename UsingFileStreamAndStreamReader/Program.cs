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
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.Write(line);
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
                if (fs != null) fs.Close();
            }
        }
    }
}
