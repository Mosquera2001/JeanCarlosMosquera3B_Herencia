using System;

namespace Cola_JeanCarlosMosquera3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola pila = new Cola();
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n |----------------------------------| ");
                Console.WriteLine(" |*************TAD Cola*************|");
                Console.WriteLine(" |---------------|------------------| ");
                Console.WriteLine(" | 1. Insertar   |  4. Eliminar     |");
                Console.WriteLine(" | 2. Buscar     |  5. Desplegar    |");
                Console.WriteLine(" | 3. Modificar  |  6. Salir        |");
                Console.WriteLine(" |----------------------------------| ");
                Console.Write(" Elija una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n Insertar Nodo en la Cola \n");
                        pila.InsertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Buscar un Nodo en la Cola \n");
                        pila.BuscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar un Nodo en la Cola \n");
                        pila.ModificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Eliminar un Nodo en la Cola \n");
                        pila.EliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Desplegar Cola de Nodos \n");
                        pila.DesplegarCola();
                        break;
                    case 6:
                        Console.WriteLine("\n\n Programa finalizado.... \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opción escogida no valida \n");
                        break;
                }
                {

                }
            } while (opcionMenu != 6);
        }
    }
}
