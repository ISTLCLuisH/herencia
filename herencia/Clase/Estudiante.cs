using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Clase
{
    public class Estudiante
    {
        private string carrera;
        private decimal promedio;

        public Estudiante(string carrera, decimal promedio ,int id, string cedula, string nombres, string apellido, int edad, string color, string cargo, decimal salario) : base (id, cedula, nombres, apellido, edad, color)
        {
            this.carrera = carrera;
            this.promedio = promedio;
        }
        public string Carrera { get => carrera; }
        public decimal Promedio { get => promedio; }

    }
}
