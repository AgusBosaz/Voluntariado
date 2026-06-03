using system;
class Coordinadores : Participantes
{
private string areaAsignada;
private int personasACargo;

public Coordinadores(string nombre, int dni, string areaAsignada, int personasACargo) : base(nombre, dni)
{
areaAsignada = AreaAsignada;
personasACargo = personasACargo;
}
public string areaAsignada
{
get { return this.areaAsignada; }
set { this.areaAsignada = value; }
}
public int PersonasACargo
{
get { return this.PersonasACargo; }
set { this.PersonasACargo = value; }
}
public override void MostrarInformacion()
{
base.MostrarInformacion();
Console.Writeline("Area asignada: " + areaAsignada);
Console.Writeline("Personas a cargo: " + personasACargo);
}

}