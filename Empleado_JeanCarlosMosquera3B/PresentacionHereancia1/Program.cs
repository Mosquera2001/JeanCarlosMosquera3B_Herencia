using System;

namespace PresentacionHereancia1
{
    class Program
    {
        static void Main(string[] args)
        {



            EmpleadoxHoras horas = new EmpleadoxHoras("Juan carlos", "Mosquera Rodriguez", 28, "Administrativo", 18, 30);
            horas.mostrarEmpleadoxhoras();



            EmpleadoTemporal temporal = new EmpleadoTemporal("Pedro Javier", "Solorzano Perez", 30, "Limpieza", "20 de noviembre 2021", "30 de noviembre 2022");
            temporal.mostrarEmpleadoTemporal();


            EmpleadoFijo fijo = new EmpleadoFijo("Katherine Isabel", "Velez Martinez", 30, "Recursos Humanos", 2015, 6);
            fijo.mostrarEmpleadoFijo();





            {
            }
        }
    }
}
