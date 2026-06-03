using system;
class Voluntarios : Participantes
{
private int horasTrabajadas;

public Coordinadores(string nombre, int dni, int horasTrabajadas) : base(nombre, dni)
{
horasTrabajadas = horasTrabajadas;
}
public int HorasTrabajadas
{
get { return this.horasTrabajadas; }
set { this.horasTrabajadas = value; }
}
public override void MostrarInformacion()
{
base.MostrarInformacion();
Console.Writeline("Horas trabajadas: " + horasTrabajadas);
}

}