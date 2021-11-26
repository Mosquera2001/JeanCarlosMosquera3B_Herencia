using System;

namespace Facultad
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Jean Carlos ", "Mosquera", 1316764974, "Soltero", 4);
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n |-----------------------------------------------------------| ");
                Console.WriteLine(" |********************Opciones Estudiante*******************|");
                Console.WriteLine(" |----------------------------------------------------------| ");
                Console.WriteLine(" | 1. Mostrar datos Estudiante    |  3. Modificar Curso     |");
                Console.WriteLine(" | 2. Modificar Estado Civil                                |");
                Console.WriteLine(" | 4. Mostrar datos actualizados                            |");
                Console.WriteLine(" | 5. Finalizar                                             |");
                Console.WriteLine(" |----------------------------------------------------------| ");
                Console.Write(" Elija una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n Mostrar datos Estudiante \n");
                        estudiante.MostrarEstudiante();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Modificar Estado Civil \n");
                        estudiante.CambioEstadoCivil();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar Curso \n");
                        estudiante.ModificarCurso();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Mostrar datos actualizados \n");
                        estudiante.MostrarEstudianteActualizado();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Estudiante finalizado... \n");
                        break;

                    default:
                        Console.WriteLine("\n\n Opción escogida no valida \n");
                        break;

                }

            } while (opcionMenu != 5);

            
            
            Profesor profesor = new Profesor("kender Manuel", "Parraga", 1351654547, "Casado", 13, 2018, "Matematicas");
            int opcionMenu2 = 0;
            do
            {
                Console.WriteLine("\n |--------------------------------------------------------| ");
                Console.WriteLine(" |*****************Opciones Profesor**********************|");
                Console.WriteLine(" |--------------------------------------------------------| ");
                Console.WriteLine(" | 1. Mostrar Datos Profesro |  3. Modificar Departamento |");
                Console.WriteLine(" | 2. Modificar Estado Civil                              |");
                Console.WriteLine(" | 4. Mostrar datos actualizados                          |");
                Console.WriteLine(" | 5. Finalizar                                           |");
                Console.WriteLine(" |--------------------------------------------------------| ");
                Console.Write(" Elija una opción: ");
                opcionMenu2 = int.Parse(Console.ReadLine());
                switch (opcionMenu2)
                {
                    case 1:
                        Console.WriteLine("\n\n Mostrar datos profesor \n");
                        profesor.MostrarProfesor();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Modificar Estado Civil \n");
                        profesor.CambioEstadoCivil();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar Departamento \n");
                        profesor.ModificarDepartamento();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Mostrar datos actualizados \n");
                        profesor.MostrarDatosProfesorActualizados();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Profesor finalizado... \n");
                        break;

                    default:
                        Console.WriteLine("\n\n Opción escogida no valida \n");
                        break;

                }

            } while (opcionMenu2 != 5);

          
            
            Personal personal = new Personal("Manuel Vicente", "Velez", 1303389546, "Divorciado", 023, 2019, "Limpieza");
            int opcionMenu3 = 0;
            do
            {
                Console.WriteLine("\n |------------------------------------------------------| ");
                Console.WriteLine(" |**************Opciones Personal-Empleado**************|");
                Console.WriteLine(" |------------------------------------------------------| ");
                Console.WriteLine(" | 1. Mostrar Datos Empleado | 3. Modificar N° Despacho |");
                Console.WriteLine(" | 2. Modificar Estado Civil                            |");
                Console.WriteLine(" | 4. Mostrar datos actualizados                        |");
                Console.WriteLine(" | 5. Cambiar seccion empleado de servicio              |");
                Console.WriteLine(" | 6. Finalizar                                         |");
                Console.WriteLine(" |------------------------------------------------------| ");
                Console.Write(" Elija una opción: ");
                opcionMenu3 = int.Parse(Console.ReadLine());
                switch (opcionMenu3)
                {
                    case 1:
                        Console.WriteLine("\n\n Mostrar datos Personal-Empleado \n");
                        personal.MostrarEmpleado();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Modificar Estado Civil \n");
                        personal.CambioEstadoCivil();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar Numero de Despacho \n");
                       personal.AsignarNuevoDespacho();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Mostrar datos actualizados \n");
                        personal.MostrarEmpleadoActualizado();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Cambiar seccion del Empleado de Servicio \n");
                        personal.Cambio_Seccion();
                        break;

                    case 6:
                        Console.WriteLine("\n\n Empleado finalizado... \n");
                        break;

                    default:
                        Console.WriteLine("\n\n Opción escogida no valida \n");
                        break;

                }

            } while (opcionMenu3 != 6);


        }
    }
}
