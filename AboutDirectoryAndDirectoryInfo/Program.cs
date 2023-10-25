namespace AboutDirectoryAndDirectoryInfo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string path = @"c:\test\myfolder";

            try
            {
                // LIstando diretórios
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                // Listando arquivos
                // vamos usar var em vez de IEnumerables<string> e o .NET fará
                // a inferência de tipos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + "\\newfolder"); // ou @"\newfolder" ou @"c:\test\myfolder"
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}