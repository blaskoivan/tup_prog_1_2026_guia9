using System.Security.Cryptography.X509Certificates;

namespace Ejercicio1
{
    internal class NumericService
    {
        public int acum = 0;
        public int cont = 0;
        public void RegistrarNumero(int numero)
        {
            cont++;
            acum += numero;
        }
        public double CalcularPromedio()
        {
            double prom = 0;
            if (acum != 0)
            {
                prom = acum / cont;
            }
            else
            {
                prom = 0;

            }
            return prom;
        }
        class Program {

            static NumericService p= new NumericService();
            public void MostrarPantallaMenu()
            {
                Console.Clear();
                Console.WriteLine("Titulo menu");
                Console.WriteLine("1. Ingrese un numero");
                Console.WriteLine("2. Mostrar cant acum");
                Console.WriteLine("3. Mostrar cant ingresados");
                Console.WriteLine("4. Mostrar Promedio");
            }
            public void MostrarPantallaSolicitarNumero()
            {

                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                p.RegistrarNumero(numero);
                Console.WriteLine("Presione una tecla para continuar");
            }
            public void MostrarPantallaAcumulado()
            {
                Console.Clear();
                Console.WriteLine($"El total acumulado es: {p.acum}");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
            public void MostrarCantidadNumerosIngresados()
            {
                Console.Clear();
                Console.WriteLine($"La cantidad de numeros ingresados es: {p.cont}");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
            public void MostrarPromedio()
            {

                Console.WriteLine($"El promedio es {p.CalcularPromedio()}");
            }
        }
            static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion=
                
                

            } while (opcion > 0);

        }
    }
}
