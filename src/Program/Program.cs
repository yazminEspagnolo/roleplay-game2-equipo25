using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeHechizos book =new LibroDeHechizos();
            book.Hechizos = new Hechizo[]{ new Hechizo() };

            Mago Istari = new Mago("Istari");
            Istari.BastonMagico = new BastonMagico();
            Istari.LibroDeHechizos = book;

            Elfo elfo = new Elfo("Elfo");
            elfo.BastonMagico = new BastonMagico();

            Enano gruñon = new Enano("Gruñon");
            gruñon.Hacha = new Hacha();
            gruñon.Casco = new Casco();
            gruñon.Escudo = new Escudo();

            
            Console.WriteLine($"Gruñon tiene {gruñon.Vida} de vida");
            Console.WriteLine($"Istari ataca a Gruñon con {Istari.Ataque}");

            gruñon.OfensaDeAtaque(Istari.Ataque);

            Console.WriteLine($"Gruñon tiene {gruñon.Vida} de vida");


            Console.WriteLine($"Elfo ayuda a Gruñon con {elfo.Ataque}");
            gruñon.Curar();
            Console.WriteLine($"Gruñon tiene {gruñon.Vida} de vida restaurada");
        }
    }
}
