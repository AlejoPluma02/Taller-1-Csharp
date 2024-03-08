namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números del 1 al 50, excepto el 25:");

            for (int i = 1; i <= 50; i++)
            {
                if (i != 25)
                {
                    Console.WriteLine($"Número {i}:");
                }
            }
        }
    }
}
