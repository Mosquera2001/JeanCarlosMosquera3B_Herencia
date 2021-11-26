using System;
using System.Collections.Generic;
using System.Text;

namespace Facultad
{
    class Estudiante : Persona
    {
        public int Curso { get; set; }
        public Estudiante(string Nombre, string Apellido, int Cedula, string EstadoCivil, int Curso) : base(Nombre, Apellido, Cedula, EstadoCivil)
        {
            this.Curso = Curso;
        }
        public void MostrarEstudiante()
        {
            Console.WriteLine("------------\nDATOS ESTUDIANTE\n------------");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " +Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Curso: " + Curso);
        }
        public void CambiarCurso()
        {
            int NuevoCurso;
            Console.WriteLine("Ingrese nuevo Curso: ");
            NuevoCurso = Convert.ToInt32(Console.ReadLine());
            Curso = NuevoCurso;
            Console.WriteLine("Su nuevo curso es: " + Curso);
        }
        public void MostrarEstudianteFinal()
        {
            Console.WriteLine("-----------------\nDATOS ESTUDIANTE ACTUALIZADOS\n-----------------");
            Console.WriteLine("ESTUDIANTE");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Curso: " + Curso);

        }
    }
}