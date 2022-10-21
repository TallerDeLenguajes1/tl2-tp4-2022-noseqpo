namespace TP04.Models
{
    public class Cadete : Persona
    {

        public List<Pedido> pedidos = new List<Pedido>();

        public Cadete(int id, string name, string dir, int tel) : base(id, name, dir, tel)
        {

        }

        public int JornalACobrar()
        {
            return pedidos.Count * 300;
        }

    }
}