namespace RoleplayGame
{
    public class Elfo
    {
        private int vida = 100;

        public Elfo(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }

        public BastonMagico BastonMagico { get; set; }
        public Anillo Anillo { get; set; }


        public int Ataque
        {
            get
            {
                return BastonMagico.Ataque;
            }
        }

        public int Defensa
        {
            get
            {
                return Anillo.Defensa + BastonMagico.Defensa;
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