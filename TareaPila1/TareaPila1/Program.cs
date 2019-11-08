using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPila1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Pila = new Stack();


            int opcion;
            do
            {
                Console.WriteLine("*****MENÚ PILA*****");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Cima");
                Console.WriteLine("4. Salir");

                Console.WriteLine("ELIGA LA OPCIÓN QUE DESEEA");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Apilar(ref Pila);

                        break;

                    case 2:
                        Desapilar(ref Pila);


                        break;
                    case 3:
                        Cima(ref Pila);
                        break;
                    case 4:
                        break;
                    case 5:

                    default:
                        Console.WriteLine("No exite opción");
                        break;
                }
            } while (opcion != 4);
            Console.ReadKey();
        }

        private static void Cima(ref Stack pila)
        {
            // throw new NotImplementedException();
            int numero = 0;
            Console.WriteLine("EL Ultimo valor de la pila es ");
            Console.WriteLine(numero = (int)pila.Pop());
        }

        private static void Desapilar(ref Stack pila)
        {
            // throw new NotImplementedException();
            int num1 = Convert.ToInt32(Console.ReadLine());

            pila.Clear();
            Console.WriteLine("Su Pila a sido vaciada");
        }

        private static void Apilar(ref Stack pila)
        {
            // throw new NotImplementedException();
            Console.WriteLine("Ingrese valores a la pila ");
            int num = Convert.ToInt32(Console.ReadLine());
            pila.Push(num);
            Console.ReadKey();
        }


    }
}
       
