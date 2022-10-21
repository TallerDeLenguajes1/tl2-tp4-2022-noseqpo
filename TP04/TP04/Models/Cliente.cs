using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP04.Models
{
    public class Cliente : Persona
    {
        string refDir;
        public Cliente(int id, string name, string dir, string refD, int tel) : base(id, name, dir, tel)
        {
            this.refDir = refD;
        }
    }
}