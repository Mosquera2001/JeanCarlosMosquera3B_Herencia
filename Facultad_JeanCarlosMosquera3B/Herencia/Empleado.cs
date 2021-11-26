using System;
using System.Collections.Generic;
using System.Text;

namespace Facultad
{
    class Empleado:Persona
    {
        public int NumeroDespacho { get; set; }
        public int AñoEntrada { get; set; }
        public Empleado(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoEntrada) : base(Nombre, Apellido, Cedula, EstadoCivil)
        {
            this.NumeroDespacho = NumeroDespacho;
            this.AñoEntrada = AñoEntrada;
        }
        public void CambioDespacho()
        {
            int NuevoDespacho;
            Console.WriteLine("Asignar nuevo despacho: ");
            NuevoDespacho = Convert.ToInt32(Console.ReadLine());
            NumeroDespacho = NuevoDespacho;
            Console.WriteLine("Nuevo despacho: "+NumeroDespacho);
        }
    }
}
