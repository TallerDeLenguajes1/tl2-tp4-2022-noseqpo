using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP04.Models
{
    public class Cadeteria
    {

        string nombre = "Helljumper Cadeteria";
        uint telefono = 3813300000;
        public List<Cadete> cadetes = new List<Cadete>(); 

        public Cadeteria()
        {

        }

        public void AceptarPedido()
        {
            Pedido nuevo;
            // usar reader
            Random rnd = new Random();
            //AsignarPedido(nuevo, cadetes.ElementAt(rnd.Next(1, cadetes.Count())));
        }

        public void AsignarPedido(Pedido asign, Cadete cadete)
        {
            // el cadete deberia ser seleccionado
            cadete.pedidos.Add(asign);
            if(asign.estado == Estado.Cancelado)
            {
                Console.WriteLine("El pedido seleccionado se encuentra cancelado");
            }
            else
            {
                asign.estado = Estado.Asignado; // lo encapsula con un internal??
            }
        }
        
        public void CambiarEstado(Pedido set)
        {

            int cnt = 1;
            foreach (Estado estado in (Estado[])Enum.GetValues(typeof(Estado)))
            {
                Console.WriteLine("Si desea cambiar el estado del pedido a {0} presione {1}", estado, cnt);
                cnt++;
            }
            string tmp = Console.ReadLine();
            int entrada = Int32.Parse(tmp);
            // excepciones!!!!!!

            switch (entrada)
            {
                
                default:
                    break;
            }
        }

        public void CambiarCadete(Pedido set)
        {
            int cnt = 1;
            foreach (Cadete cadete in cadetes)
            {
                Console.WriteLine("Si desea asignar el pedido al cadete {0} presione {1}", cadete.name, cnt);
                cnt++;
            }
            string tmp = Console.ReadLine();
            int entrada = Int32.Parse(tmp);
            // excepciones!!!!!!

            // index de cadete
        }

        public void InformeCadetes()
        {
            foreach (Cadete cadete in cadetes)
            {
                var resultado = from pedido in cadete.pedidos
                                where pedido.est == Estado.Entregado
                                select pedido;

                Console.WriteLine("El cadete {0} realizó {1} entregas exitosas", cadete.name, resultado.Count());
                Console.WriteLine("Por lo tanto ganó ${0} en la jornada", cadete.JornalACobrar());

            }

            Console.WriteLine("En total ");
            
        }

    }
}
