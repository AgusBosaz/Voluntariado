using System;
public abstract class Participantes
{
    private string nombre;
    private int dni;

    public Participantes(string nombre, int dni)
    {
        this.nombre = nombre;
        this.dni = dni;
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public int Dni
    {
        get { return this.Dni; }
        set { this.Dni = value; }
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Nombre del voluntario: " + nombre);
        Console.WriteLine("Dni del voluntario: " + dni);
    }

}