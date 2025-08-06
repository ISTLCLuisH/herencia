using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Clase
{
    public class Estudiante : Persona
    {
        private string carrera;
        private decimal promedio;




        public Estudiante(int id, string cedula, string nombres, string apellidos, int edad, string color, string carrera, decimal promedio) : base (id, cedula, nombres, apellidos, edad, color)
        {
            this.carrera = carrera;
            this.promedio = promedio;
        }                                                                                                                           
        public string Carrera { get => carrera; }
        public decimal Promedio { get => promedio; }
        public string Carrera1 { get => carrera; }
        public decimal Promedio1 { get => promedio; }


    }
}
