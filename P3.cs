namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de empleados: ");
            int empleados = int.Parse(Console.ReadLine());

            for (int i = 0; i < empleados; i++)
            {
                Console.WriteLine("Ingrese el sueldo del empleado: " + i);
                int sueldo = int.Parse(Console.ReadLine());

                int descuentoRenta = (int)(sueldo * 0.10);
                int descuentoAFP = (int)(sueldo * 0.05);
                int descunetoSeguroSocial = (int)(sueldo * 0.04);

                int totNet = sueldo - descuentoRenta - descuentoAFP - descunetoSeguroSocial;

                Console.WriteLine($"Sueldo del empleado {i}: {sueldo}");
                Console.WriteLine($"Descuento de renta: {descuentoRenta}");
                Console.WriteLine($"Descuento de AFP: {descuentoAFP}");
                Console.WriteLine($"Descuento de seguro social: {descunetoSeguroSocial}");
                Console.WriteLine($"Sueldo neto del empleado {i}: {totNet}");
            } 
        }
    }
}
