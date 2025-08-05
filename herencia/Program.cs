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
            Console.WriteLine("COLOR:"+EMPLEADO.Color);
            Console.WriteLine("CARGO:"+((Empleado)EMPLEADO).Cargo);
            Console.WriteLine("SALARIO:"+((Empleado)EMPLEADO).Salario);
            Console.ReadKey();
        }
        
    }
}
