namespace RoleplayGame
{
    public class Mago : Personaje
    {
        public LibroDeHechizos LibroDeHechizos { get; set; }
        public BastonMagico BastonMagico { get; set; }

        public Mago(string nombre) : base(nombre)
        {
            this.LibroDeHechizos = new LibroDeHechizos();
            this.BastonMagico = new BastonMagico();
        }
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
