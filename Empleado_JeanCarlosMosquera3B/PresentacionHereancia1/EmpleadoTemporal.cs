using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoTemporal : Empleado
    {
        private string Fecha_de_Ingreso { get; set; }
        private string Fecha_de_Salida { get; set; }

        public EmpleadoTemporal (string Nombres, string Apellidos, int Edad, string Departamento, string Fecha_de_Ingreso, string Fecha_de_Salida) : base(Nombres, Apellidos, Edad, Departamento, Fecha_de_Ingreso, Fecha_de_Salida)
        {
            this.Fecha_de_Ingreso = Fecha_de_Ingreso;
            this.Fecha_de_Salida = Fecha_de_Salida;
        }

       
       

        public void mostrarEmpleadoTemporal()
        {
            Console.WriteLine("---------------INFORMACIÓN EMPLEADO TEMPORAL----------------");
            Console.WriteLine("Nombres : " + Nombres);
            Console.WriteLine("Apellidos : " + Apellidos);
            Console.WriteLine("Edad : " + Edad + " años");
            Console.WriteLine("Departamento : " + Departamento);
            Console.WriteLine("Fecha de ingreso : " + Fecha_de_Ingreso);
            Console.WriteLine("Fecha de salida : " + Fecha_de_Salida);
            Console.WriteLine("Sueldo Mensual : $ 400");
        }
    }
}
