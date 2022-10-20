using System.Collections.Generic;
namespace RoleplayGame
{
    public class Enano : Personaje
    {
        public Hacha Hacha { get;  set; }
        public Casco Casco { get;  set; }
        public Escudo Escudo { get;  set; }

        public Enano(string nombre) : base(nombre)
        {
            this.Hacha = new Hacha();
            this.Casco = new Casco();
            this.Escudo = new Escudo();
        }

        public int Ataque 
        {
            get
            {
                return Hacha.Ataque + Casco.Defensa;
            }
        }

        public int Defensa
        {
            get
            {
                return Hacha.Ataque + Casco.Defensa;
            }
        }
    }
}