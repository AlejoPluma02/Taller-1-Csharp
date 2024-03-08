namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tres números enteros:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                int mayor = Math.Max(num1, Math.Max(num2, num3));

                int menor = Math.Min(num1, Math.Min(num2, num3));

                int medio = num1 + num2 + num3 - mayor - menor;

                Console.WriteLine($"El número mayor es: {mayor}");
                Console.WriteLine($"El número menor es: {menor}");
                Console.WriteLine($"El número de medio es: {medio}");
            }
            else
            {
                Console.WriteLine("Los números ingresados deben ser diferentes.");
            }
        }
    }
}
