using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            int opcion = 0;
            
            do
            {
                Console.WriteLine("*****MENÚ PILA*****");
                Console.WriteLine("1. Añadir");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Limpiar");
                Console.WriteLine("4. Imprimir");
                Console.WriteLine("5. Salir");

                Console.WriteLine("ELIGA LA OPCIÓN QUE DESEEA");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                
                    case 1:
                        Añadir(ref cola);
                        break;
                    case 2:
                        Eliminar(ref cola);
                        break;
                    case 3:
                        Limpiar(ref cola);
                        break;
                    case 4:
                        Imprimir(cola);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("ERROR: intente digitando otra opción");
                        break;

                }

            } while (opcion != 5);
            Console.ReadKey();
        }

        private static void Imprimir(Queue cola)
        {
            //  throw new NotImplementedException();
            if (cola.Count > 0)
            {
                Console.WriteLine(" ");
                foreach (int auxi in cola)
                {
                    Console.WriteLine("     |  |");
                    if (auxi < 10)
                    {
                        Console.WriteLine(" |   0 {1}   |" + auxi);
                    }
                    else
                    {
                        Console.WriteLine(" |   0 {1}   |" + auxi);
                        Console.WriteLine(" |  ------   |");
                    }
                }
                Console.WriteLine("\nPresione una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La cola esta vacia");
            }
            Console.ReadLine();
        }

        private static void Limpiar(ref Queue cola)
        {
            // throw new NotImplementedException();
            cola.Clear();
            Imprimir(cola);
        }

        private static void Eliminar(ref Queue cola)
        {
            // throw new NotImplementedException();
            int numero = (int)cola.Dequeue();
            Console.WriteLine("Elemento" + numero + "eliminado");

            Imprimir(cola);

        }

        private static void Añadir(ref Queue cola)
        {
            // throw new NotImplementedException();
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 104 || numero <= 0)
                {

                    Console.WriteLine("Solo son permitidos numeros del 1 al 104");

                }
                else
                {
                    cola.Enqueue(numero);
                    Imprimir(cola);
                }
            }
            catch
            {
                Console.WriteLine("Error: Solo son permitidos numeros del 1 al 104");
            }
        }

    }
}
