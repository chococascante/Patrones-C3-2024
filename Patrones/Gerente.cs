using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class Gerente : Empleado
    {
        public Gerente(string nombre, int horasTrabajadas, decimal tarifaPorHora) : base(nombre, horasTrabajadas, tarifaPorHora)
        {
        }

        public override decimal CalcularSalario()
        {
            decimal salarioBase = HorasTrabajadas * TarifaPorHora; // base.CalcularSalario();
            return salarioBase * 1.2m;
        }
    }
}
