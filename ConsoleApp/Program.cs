// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Jugadores jugador = new Canteranos();
var jugador1 = new Jugadores();
Canteranos jugador2 = new Canteranos();
Jugadores jugador3 = jugador2;


jugador.Id = 1;
jugador.Nombre = "Pepito Perez";
jugador.Estatura = 1.85m;
jugador.Activo = true;
jugador.Equipo = new Equipos() { Id = 1, Nombre = "Real Madrid Castilla" };
jugador.Videojuegos = new List<Videojuegos>();
jugador.Videojuegos.Add(new Videojuegos() { Id = 1, Nombre = "GTA V" });
jugador.Videojuegos.Add(new Videojuegos() { Id = 2, Nombre = "FC24" });

Console.WriteLine(jugador.Nombre);
Console.WriteLine(jugador.Equipo.Nombre);

foreach (var elemento in jugador.Videojuegos)
{
    Console.WriteLine(elemento.Nombre);
}

public class Equipos
{
    public int Id;
    public String? Nombre;

}

public class Videojuegos
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
    public List<Videojuegos>? Videojuegos;

}

public class Canteranos : Jugadores
{
    public int GolCantera;

}