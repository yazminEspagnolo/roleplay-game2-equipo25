using System.Collections.Generic;
namespace RoleplayGame
{
    public class Enano
    {
        private int vida = 100;

        public Enano(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }

        public Hacha Hacha { get; set; }

        public Escudo Escudo { get; set; }

        public Casco Casco { get; set; }

        public int Ataque
        {
            get
            {
                return Hacha.Ataque;
            }
        }

        public int Defensa
        {
            get
            {
                return Escudo.Defensa + Casco.Defensa;
            }
        }

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
}