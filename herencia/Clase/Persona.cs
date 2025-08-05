using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Clase
{
    public class Persona
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellido;
        private int edad;
        private string color;

        public Persona(int id, string cedula, string nombres, string apellido, int edad, string color)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellido = apellido;
            this.edad = edad;
            this.color = color;
        }

        public int Id { get => id; }
        public string Cedula { get => cedula; }
        public string Nombres { get => nombres; }
        public string Apellido { get => apellido;  }
        public int Edad { get => edad; }
        public string Color { get => color;  }
    }
}
