namespace UsingBlock
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string path = @"c:\text\file1.txt";

            // Using block é uma sintaxe simplificada que garante que
            // os objetos IDisposable serão fechados.
            // Esses são objetos que NÃO são gerenciados pelo  CLR. Eles
            // precisam ser manualmente fechados
            // Ex: Font, FileStream, StreamReader, StreamWriter etc.

            try
            {
                // Tudo que colocarmos nesse bloco será executado
                // e ao final será automaticamente fechado.
                // Podemos cascatear mais de um bloco using.
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
