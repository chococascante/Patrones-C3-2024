using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class Consultor : Empleado
    {
        public Consultor(string nombre, int horasTrabajadas, decimal tarifaPorHora) : base(nombre, horasTrabajadas, tarifaPorHora)
        {
        }

        public override decimal CalcularSalario()
        {
            return 2000m;
        }
    }
}
