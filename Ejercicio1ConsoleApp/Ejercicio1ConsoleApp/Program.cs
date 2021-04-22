using System;
using System.Linq;

namespace Ejercicio1ConsoleApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Declaración de variables
            string[] estudiantes = new string[5];
            int[,] notas = new int[5,5];
            int promedio;
            int[] promedios = new int[5];            
            int auxMayor = 0;            

            //INSTANCIA DE LA CLASE registroEstudiante
            registroEstudiante registrar = new registroEstudiante();

            // Mostramos un pequeño titulo 
            Console.WriteLine("\t ESTUDIANTES, NOTAS Y PROMEDIO \r");
            Console.WriteLine("\t ------------------------\n");
            // Método para almacenar el nombre de los 5 estudiantes 
            for (int i = 0; i < 5; i++)
            {
                estudiantes[i] = registrar.nuevoEstudiante(i+1);
            }
            Console.WriteLine("\t Lista de Estudiantes \r");
            Console.WriteLine("\t ------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }

            Console.WriteLine("\t Ingreso de Notas por Estudiante \r");
            Console.WriteLine("\t ------------------------");
            for (int f = 0; f < 5; f++)
            {
                promedio = 0;
                for (int c = 0; c < 5; c++)
                {
                    notas[f,c] = registrar.registroNota(estudiantes[f], c);                    
                    promedio += notas[f, c];                    
                }                
                promedios[f] = (promedio / 5);                
                Console.WriteLine("\n\t EL PROMEDIO DE " + estudiantes[f] + " ES DE: " + promedios[f] + " \n");
            }
            Console.WriteLine("\t RESUMEN PROMEDIO POR ESTUDIANTE \r");
            Console.WriteLine("\t ------------------------");
            var promedioMayor = promedios.Max();            
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(" -> " + estudiantes[f] + " tiene " + promedios[f] + " de promedio. ");
                if (promedios.Max() == promedios[f])
                {
                    auxMayor = f;
                }
            }
            
            Console.WriteLine("\n\t EL PROMEDIO MAYOR ES DE " + estudiantes[auxMayor] + " CON " + promedioMayor + " DE PROMEDIO. FELICIDADES! \n");

            // Mensaje antes de cerrar el programa
            Console.Write("Presione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
            Console.ReadKey();

        }
    }


    // CLASE DESARROLLADA
    class registroEstudiante
    {
        string estudiante;
        public string nuevoEstudiante(int conteo)
        {                        
            Console.WriteLine("Ingrese el nombre del Estudiante " + conteo + ", y presione Enter.");
            estudiante = Console.ReadLine();
            return estudiante;
        }
        public int registroNota(string alumno, int conteo)
        {
            int nota = 0;            
            try
            {
                Console.WriteLine("Ingrese la Nota del Curso " + (conteo + 1) + " de " + alumno + ", y presione Enter.");
                nota = Convert.ToInt32(Console.ReadLine());
                return nota;
            }
            catch (Exception)
            {
                Console.WriteLine("Debe ingresar números. \n Vuelva a ejecutar el programa!");              
            }
            return nota;
        }
    }
}
