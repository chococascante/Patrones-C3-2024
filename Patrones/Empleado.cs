using System;


public class Empleado
{
    public string Nombre;
    public int HorasTrabajadas;
    public decimal TarifaPorHora;
    public Empleado(string nombre, int horasTrabajadas, decimal tarifaPorHora)
	{
        Nombre = nombre;
        HorasTrabajadas = horasTrabajadas;
        TarifaPorHora = tarifaPorHora;
    }

    public virtual decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}
