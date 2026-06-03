using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        List<Participantes> participantes = new List<Participantes>();

        int opcion;

        do
        {
            Console.WriteLine("\n=== VOLUNTARIADO ===");
            Console.WriteLine("1- Registrar voluntario");
            Console.WriteLine("2- Mostrar Informacion de voluntarios");
            Console.WriteLine("0- Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("1- Voluntario.");
                    Console.WriteLine("2- Coordinador.");

                    int tipo = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el numero de DNI: ");
                    int dni = int.Parse(Console.ReadLine());

                    switch (tipo)
                    {
                        case 1:

                            Console.WriteLine($"Ingrese la cantidad de horas trabajadas.");
                            int horas = int.Parse(Console.ReadLine());

                            participantes.Add(new Voluntarios(nombre, dni, horas));

                            break;

                        case 2:

                            Console.WriteLine($"Ingrese el area asignada.");
                            string area = Console.ReadLine();

                            Console.WriteLine($"Ingrese la cantidad de personas que coordina.");
                            int cantidad = int.Parse(Console.ReadLine());

                            participantes.Add(new Coordinadores(nombre, dni, area, cantidad));

                            break;
                    }

                    break;

                case 2:

                    if (participantes.Count == 0)
                    {
                        System.Console.WriteLine($"Debe ingresar Voluntarios para mostrar.");
                        break;
                    }
                    System.Console.WriteLine($"Voluntarios...");
                    foreach (Participantes participante in participantes)
                    {
                        participante.MostrarInformacion();
                    }
                    break;
            }

        } while (opcion != 0);
    }
}