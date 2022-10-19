using System.Collections.Generic;
namespace RoleplayGame
{
    public class Personajes
    {
        private int vida = 100;

        public Personajes(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }


        public int Vida
        {
            get
            {
                return this.vida;
            }
            private set
            {
                this.vida = value < 0 ? 0 : value;
            }
        }

        public void OfensaDeAtaque(int power)
        {
            if (this.Defensa < power)
            {
                this.Vida -= power - this.Defensa;
            }
        }

        public void Curar()
        {
            this.Vida = 100;
        }
    
    }
    public class Mago : Personajes
    {
        public Mago(string nombre) : base(nombre)
        {
            this.LibroDeHechizos = new LibroDeHechizos();
            this.BastonMagico = new BastonMagico();
             public int Ataque
        {
            get
            {
                return LibroDeHechizos.Ataque + BastonMagico.Ataque;
            }
        }
        public int Defensa
        {
            get
            {
                return LibroDeHechizos.Defensa + BastonMagico.Defensa;
            }
        }

        }
    }

    public class Elfo : Personajes
    {
        public Elfo(string nombre) : base(nombre)
        {
            this.Arco = new Arco();
            this.Capa = new Capa();
            public int Ataque
        {
            get
            {
                return Arco.Ataque + Capa.Ataque;
            }
        }

        public int Defensa
        {
            get
            {
                return Arco.Defensa + Capa.Defensa;
            }
        }
        }
    }

    public class Enano : Personajes
    {
        public Enano(string nombre) : base(nombre)
        {
            this.Hacha = new Hacha();
            this.Casco = new Casco();
            public int Ataque
        {
            get
            {
                return Hacha.Ataque + Casco.Ataque;
            }
        }

        public int Defensa
        {
            get
            {
                return Hacha.Defensa + Casco.Defensa;
            }
        }
        }
    }
}

