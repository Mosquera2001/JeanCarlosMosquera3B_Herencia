using System;
using System.Collections.Generic;
using System.Text;

namespace Facultad
{
    class Profesor : Empleado
    {
        public string Departamento { get; set; }
        public Profesor(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoEntrada, string Departamento) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoEntrada)
        {
            this.Departamento = Departamento;
        }
        public void MostrarProfesor()
        {
            Console.WriteLine("----------\nDATOS PROFESOR\n---------");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año de Incorporacion: " + AñoEntrada);
            Console.WriteLine("Departamento: " + Departamento);
        }
        public void CambioDepartamento()
        {
            string DepartamentoNuevo;
            Console.WriteLine("Departamento a cambiar:");
            DepartamentoNuevo = Convert.ToString(Console.ReadLine());
            Departamento = DepartamentoNuevo;
            Console.WriteLine("Departamento nuevo: " + Departamento);
        }
        public void MostrarProfesorFinal()
        {
            Console.WriteLine("-----------------\nDATOS PROFESOR ACTUALIZADOS\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoEntrada);
            Console.WriteLine("Departamento: " + Departamento);
        }
    }
}
