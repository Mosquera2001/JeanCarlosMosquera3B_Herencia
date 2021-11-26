using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoxHoras : Empleado
    {
        private int Precio_Hora_Trabajada { get; set; }
        private new int N_Horas_Trabajadas { get; set; }
        int sueldoxhoras { get; set; }

        public EmpleadoxHoras (string Nombres, string Apellidos, int Edad, string Departamento, int Precio_Hora_Trabajada, int N_Horas_Trabajadas) : base (Nombres, Apellidos, Edad, Departamento, Precio_Hora_Trabajada,N_Horas_Trabajadas)
        {
            this.Precio_Hora_Trabajada = Precio_Hora_Trabajada;
            this.N_Horas_Trabajadas = N_Horas_Trabajadas;

        }

        

        public void mostrarEmpleadoxhoras()
        {
            Console.WriteLine("---------------INFORMACIÓN EMPLEADO POR HORAS----------------");
            Console.WriteLine("Nombres : " + Nombres);
            Console.WriteLine("Apellidos : " +Apellidos);
            Console.WriteLine("Edad : " + Edad + " años");
            Console.WriteLine("Departamento : " + Departamento);
            Console.WriteLine("Precio de hora de trabajo : $" + Precio_Hora_Trabajada);
            Console.WriteLine("Numero de horas trabajadas : " + N_Horas_Trabajadas);
            sueldoxhoras = Precio_Hora_Trabajada * N_Horas_Trabajadas;
            Console.WriteLine("Sueldo Mensual : $" + sueldoxhoras);
        }
        
    }

}
