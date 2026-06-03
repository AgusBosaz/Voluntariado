using System;
public class Voluntarios : Participantes
{
    private int horasTrabajadas;

    public Voluntarios(string nombre, int dni, int horasTrabajadas) : base(nombre, dni)
    {
        this.horasTrabajadas = horasTrabajadas;
    }
    public int HorasTrabajadas
    {
        get { return this.horasTrabajadas; }
        set { this.horasTrabajadas = value; }
    }
    public override void MostrarInformacion()
    {
        System.Console.WriteLine("-------------------------------");
        base.MostrarInformacion();
        Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
        System.Console.WriteLine("-------------------------------");
    }

}