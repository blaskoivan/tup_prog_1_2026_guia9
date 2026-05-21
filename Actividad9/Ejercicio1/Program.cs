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
            if (cont != 0)          
                return (double)acum / cont;
            return 0;
        }
    }

    internal class Program
    {
        static NumericService p = new NumericService();

        public void MostrarPantallaMenu()
        {
            Console.Clear();
            Console.WriteLine("Título Menú");
            Console.WriteLine("1. Ingresar un número");
            Console.WriteLine("2. Mostrar acumulado");
            Console.WriteLine("3. Mostrar cantidad ingresada");
            Console.WriteLine("4. Mostrar promedio");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
        }

        public void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            p.RegistrarNumero(numero);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarPantallaAcumulado()
        {
            Console.Clear();
            Console.WriteLine($"El total acumulado es: {p.acum}");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarCantidadNumerosIngresados()
        {
            Console.Clear();
            Console.WriteLine($"La cantidad de números ingresados es: {p.cont}");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public void MostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine($"El promedio es: {p.CalcularPromedio()}");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program app = new Program();
            int opcion;

            do
            {
                app.MostrarPantallaMenu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        app.MostrarPantallaSolicitarNumero(); 
                        break;
                    case 2: 
                        app.MostrarPantallaAcumulado();
                        break;
                    case 3: 
                        app.MostrarCantidadNumerosIngresados(); 
                        break;
                    case 4:
                        app.MostrarPromedio();
                        break;
                    default:
                        opcion = 0;
                        break;
                }

            } while (opcion != 0);
        }
    }
}