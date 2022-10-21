using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP04.Models
{
    public class Pedido
    {
        int nro;
        public string obs = "";
        Cliente nombre;
        public Estado est = Estado.SinAsignar;

        public Estado estado { get; internal set; }

        public Pedido(int nro, string obs, Cliente cliente)
        {
            this.nro = nro;
            this.obs = obs;
            this.nombre = cliente;

        }

    }
}
