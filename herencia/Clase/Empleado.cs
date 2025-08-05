using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Clase
{
    public class Empleado: Persona
    {
        private string cargo;
        private decimal salario;

        public Empleado(int id, string cedula, string nombres, string apellido, int edad, string color,string cargo, decimal salario) : base (id, cedula,nombres,apellido,edad,color)
        {

            this.cargo = cargo;
            this.salario = salario;
        }

        public string Cargo { get => cargo;  }
        public decimal Salario { get => salario; }
    }
}
