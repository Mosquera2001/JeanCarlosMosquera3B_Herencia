using System;
using System.Collections.Generic;
using System.Text;

namespace Facultad
{
    class Personal:Empleado
    {
        public string SeccionAsignada { get; set; }
        public Personal(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoEntrada, string SeccionAsignada) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoEntrada)
        {
            this.SeccionAsignada = SeccionAsignada;
        }
        public void MostrarEmpleado()
        {
            Console.WriteLine("------------\nDATOS EMPLEADO\n------------");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cedula: "+Cedula);
            Console.WriteLine("Estado Civil: "+EstadoCivil);
            Console.WriteLine("Número Despacho: "+NumeroDespacho);
            Console.WriteLine("Año Incorporacion: "+AñoEntrada);
            Console.WriteLine("Seccion Asignada: "+SeccionAsignada);
        }
        public void CambioSeccion()
        {
            string SeccionNueva;
            Console.WriteLine("Ingrese la nueva Seccion ");
            SeccionNueva = Convert.ToString(Console.ReadLine());
            SeccionAsignada = SeccionNueva;
            Console.WriteLine("Sección nueva: "+SeccionAsignada);
        }
        public void MostrarEmpleadoFinal()
        {
            Console.WriteLine("-----------------\nDATOS EMPLEADO ACTUALIZADOS\n-----------------");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Número Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoEntrada);
            Console.WriteLine("Seccion Asignada: " + SeccionAsignada);
        }
    }
    
}
