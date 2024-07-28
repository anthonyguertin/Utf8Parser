using Utf8Parser;
namespace ToTestClassLibrary
{
    internal class Program
    {
        public static string configPath = @"C:\Users\it.department\source\repos\Utf8Parser\ToTestClassLibrary\config";
        static void Main(string[] args)
        {
            var parser = new Utf8Parser.UtfParser(configPath);
            var config = parser.GetKeyValuePair();
            foreach (var kvp in config)
            {
                Console.WriteLine($"{kvp.Key}{kvp.Value}");
            }
        }
    }
}
