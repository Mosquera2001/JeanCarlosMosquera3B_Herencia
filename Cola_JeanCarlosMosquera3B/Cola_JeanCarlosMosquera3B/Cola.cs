using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_JeanCarlosMosquera3B
{
    public class Cola
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }
        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese el dato que contendra el nuevo nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("\n Nodo Ingresado\n\n");

        }
        public void DesplegarCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La Cola se encuentra vacía\n\n");
            }

        }
        public void BuscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.Write(" Ingrese el dato del nodo a buscar: ");
            int NodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == NodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", NodoBuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La Cola se encuentra vacía\n\n");
            }
        }
        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.Write(" Ingrese el dato del nodo a buscar para modificar: ");
            int NodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == NodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", NodoBuscado);
                        Console.WriteLine("Ingrese el nuevo dato para este Nodo: ");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Nodo modificado\n");
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La Cola se encuentra vacía\n\n");
            }



        }
        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;
            Console.Write(" Ingrese el dato del nodo a buscar para eliminar: ");
            int NodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == NodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado", NodoBuscado);

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente ;
                        }
                        Console.WriteLine("\n Nodo eliminado\n");
                        Encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La Cola se encuentra vacía\n\n");
            }

        }
    }
}

