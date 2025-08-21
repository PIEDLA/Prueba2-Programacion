// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Equipos
{
    public int Id;
    public String? Nombre;

}

public class Jugadores
{
    public int Id;
    public String? Nombre;
    public decimal Estatura;
    public bool Activo;
    public Equipos? Equipo;

}
