using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP04.Models
{
    public class Persona
    {
        public int id;
        public string name;
        string dir;
        int tel;
        

        public Persona(int id, string name, string dir, int tel)
        {
            this.id = id;
            this.name = name;
            this.dir = dir;
            this.tel = tel;
        }



    }
}
