using system;
public abstract class Participantes
{
private string nombre;
private int dni;

public Participantes(string nombre, int dni)
{
nombre = nombre;
dni = dni;
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
Console.Writeline("Nombre del participante: " + nombre);
Console.Writeline("Dni del participante: " + dni);
}

}