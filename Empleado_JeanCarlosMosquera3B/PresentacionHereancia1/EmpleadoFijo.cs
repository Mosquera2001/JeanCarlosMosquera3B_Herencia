using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoFijo : Empleado
    {
        private int Año_Ingreso { get; set; }
        private int Años_Empresa { get; set; }
        int SueldoFijo { get; set; }
        int Base = 500;
        

        public EmpleadoFijo (string Nombres, string Apellidos, int Edad, string Departamento, int Año_Ingreso, int Años_Empresa) : base(Nombres, Apellidos, Edad, Departamento, Año_Ingreso, Años_Empresa)
        {
            this.Año_Ingreso = Año_Ingreso;
            this.Años_Empresa = Años_Empresa;
        }

        

        public void mostrarEmpleadoFijo()
        {
            Console.WriteLine("---------------INFORMACIÓN EMPLEADO FIJO----------------");
            Console.WriteLine("Nombres : " + Nombres);
            Console.WriteLine("Apellidos : " + Apellidos);
            Console.WriteLine("Edad : " + Edad + " años");
            Console.WriteLine("Departamento : " + Departamento);
            Console.WriteLine("Año de Ingreso : " + Año_Ingreso);
            Console.WriteLine("Años en la empresa : " + Años_Empresa);
            SueldoFijo = (Base + 25) * Años_Empresa;
            Console.WriteLine("Sueldo Mensual : $" + SueldoFijo);

        }
        

    }
}
