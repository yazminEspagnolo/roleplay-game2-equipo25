using System.Collections.Generic;

namespace RoleplayGame
{
    public class LibroDeHechizos
    {
        public Hechizo[] Hechizos { get; set; }
        
        public int Ataque
        {
            get
            {
                int value = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    value += hechizo.Ataque;
                }
                return value;
            }
        }

        public int Defensa
        {
            get
            {
                int value = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    value += hechizo.Defensa;
                }
                return value;
            }
        }
    }
}