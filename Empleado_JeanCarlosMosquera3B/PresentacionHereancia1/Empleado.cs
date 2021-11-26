using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class Empleado
    {
        private string fecha_de_Ingreso;
        private string fecha_de_Salida;
        private int precio_Hora_Trabajada;

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }
        public int N_Horas_Trabajadas { get; }

        public Empleado(string Nombres, string Apellidos, int Edad, string Departamento, string fecha_de_Ingreso, int precio_Hora_Trabajada)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Departamento = Departamento;

        }

        public Empleado(string nombres, string apellidos, int edad, string departamento, int precio_Hora_Trabajada, int n_Horas_Trabajadas)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Departamento = departamento;
            this.precio_Hora_Trabajada = precio_Hora_Trabajada;
            N_Horas_Trabajadas = n_Horas_Trabajadas;
        }

        public Empleado(string nombres, string apellidos, int edad, string departamento, string fecha_de_Ingreso, string fecha_de_Salida)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Departamento = departamento;
            this.fecha_de_Ingreso = fecha_de_Ingreso;
            this.fecha_de_Salida = fecha_de_Salida;
        }
    }
}
