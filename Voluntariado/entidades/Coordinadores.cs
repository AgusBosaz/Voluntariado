using System;
public class Coordinadores : Participantes
{
    private string areaAsignada;
    private int personasACargo;

    public Coordinadores(string nombre, int dni, string area, int personasACargo) : base(nombre, dni)
    {
        this.areaAsignada = area;
        this.personasACargo = personasACargo;
    }
    public string AreaAsignada
    {
        get { return this.areaAsignada; }
        set { this.areaAsignada = value; }
    }
    public int PersonasACargo
    {
        get { return this.personasACargo; }
        set { this.personasACargo = value; }
    }
    public override void MostrarInformacion()
    {
        System.Console.WriteLine("-------------------------------");
        base.MostrarInformacion();
        Console.WriteLine("Area asignada: " + areaAsignada);
        Console.WriteLine("Personas a cargo: " + personasACargo);
        System.Console.WriteLine("-------------------------------");
    }

}