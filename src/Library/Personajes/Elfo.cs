namespace RoleplayGame
{
    public class Elfo : Personaje
    {

        public Arco Arco { get; set; }
        public Capa Capa { get; set; }
        public BastonMagico BastonMagico { get; set; }

        
        public Elfo(string nombre) : base(nombre)
        {
            this.Arco = new Arco();
            this.Capa = new Capa();
            this.BastonMagico = new BastonMagico();
        }
        public int Ataque
        {
            get
            {
                return Arco.Ataque + Capa.Defensa;
            }
        }

        public int Defensa
        {
            get
            {
                return Arco.Ataque + Capa.Defensa;
            }
        }
    }
    

}

