using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funda_TrabajoParcial
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int tipo { get; set; }
        public string Tramite { get; set; }
        public int monto { get; set; }

        public void crearPersona(string nombre)
        {
            Random r = new Random();
            this.tipo = r.Next(1, 4);
            this.Nombre = nombre;
            int tr = r.Next(1, 3);
            switch(tr)
            {
                case 1: this.Tramite = "Depósito"; break;
                case 2: this.Tramite = "Retiro"; break;
            }
            this.monto = r.Next(100, 5000);
        }
    }
}
