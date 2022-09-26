namespace RoleplayGame
{
    public class Mago
    {
        private int vida = 100;

        public Mago(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }

        public LibroDeHechizos LibroDeHechizos { get; set; }

        public BastonMagico BastonMagico { get; set; }

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