namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la cantidad de números primos: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());
            


            int numero = 2;
            int repeticiones = 0;
            while (repeticiones < cantidadNumeros)
            {
                int contador = 0;
                for (int k = 1; k <= numero; k++)
                {
                    if (numero % k == 0)
                    {
                        contador++;
                    }
                }

                if (contador <= 2)
                {
                    Console.WriteLine(numero);
                    repeticiones++;
                }
                numero++;
            }
        }
    }
}
