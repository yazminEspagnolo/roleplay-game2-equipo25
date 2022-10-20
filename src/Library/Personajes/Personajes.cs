using System.Collections.Generic;
namespace RoleplayGame
{
    public class Personaje
    {
        private int vida = 100;

        public int Defensa { get;}

        public int Ataque { get;}

        public Personaje(string nombre)
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


    
}

