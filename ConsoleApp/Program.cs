namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Press 'q' to quit or any other key to continue...");
                var input = Console.ReadKey(true);
                if (input.KeyChar == 'q')
                {
                    break;
                }
                Console.WriteLine($"You pressed: {input.KeyChar}");
            } while (true);
        }
    }
}
