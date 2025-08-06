using herencia.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado EMPLEADO = new Empleado(1,"0930344742","LUIS ENRIQUE "," HUREL HERMENEGILDO", 21,"MADERA","ASISTENTE CONTABE",600);
            Console.WriteLine("ID:"+EMPLEADO.Id);
            Console.WriteLine("CEDULA:"+EMPLEADO.Cedula);
            Console.WriteLine("NOMBRES:"+EMPLEADO.Nombres);
            Console.WriteLine("APELLIDOS:"+EMPLEADO.Apellido);
            Console.WriteLine("EDAD:"+EMPLEADO.Edad);
            Console.WriteLine("COLOR:"+EMPLEADO.Cargo);
            Console.WriteLine("SALARIO:"+EMPLEADO.Salario);
            Console.ReadKey();

            Estudiante ESTUDIANTE = new Estudiante (2, "0930344742", "LUIS ENRIQUE ", "HUREL HERMENEGILDO", 21, "MADERA", "Desarrollo de Software",6);

            Console.WriteLine("ID :" + ESTUDIANTE.Id);
            Console.WriteLine("Cédula :" + ESTUDIANTE.Cedula);
            Console.WriteLine("Nombres :" + ESTUDIANTE.Nombres);
            Console.WriteLine("Apellidos :" + ESTUDIANTE.Apellido);
            Console.WriteLine("Edad :" + ESTUDIANTE.Edad);
            Console.WriteLine("Color :" + ESTUDIANTE.Color);
            Console.WriteLine("Carrera :" + ESTUDIANTE.Carrera);
           

        }
        
    }
}
