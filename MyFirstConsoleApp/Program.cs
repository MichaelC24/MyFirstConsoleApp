namespace MyFirstConsoleApp
{
    internal class Program
    {
        public static string Name { get; set; } = "greg";
        static void Main(string[] args)
        {

            Console.WriteLine($"Hello,{Name} World!");
        }
    }
}
