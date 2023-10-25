namespace AboutPath
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string path = @"c:\test\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // informa o carcatere de separação

            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // informa o carcatere usado para separar entre paths diferentes

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // retorna até o nome do último diretório/pasta

            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // retorna o nome do arquivo

            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // retorna até o nome do arquivo sem a extensão

            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // retorna apenas a extensão do arquivo

            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // retorna o caminho do path por inteiro

            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // informa a pasta temporária do sistema na qual eu posso manipular dados temporários de aplicações


        }
    }
}