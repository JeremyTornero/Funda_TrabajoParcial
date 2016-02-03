using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funda_TrabajoParcial
{
    public class Control
    {
        public Queue<Persona> Cola_Clientes { get; set; }
        public Queue<Persona> Cola_No_Clientes { get; set; }
        public Queue<Persona> Cola_Preferencial { get; set; }

        public List<Persona> Clientes { get; set; }
        public List<Persona> No_Clientes { get; set; }
        public List<Persona> Preferencial { get; set; }

        public void IngresarCliente(Persona persona)
        {
            if (persona.tipo == 1 && Cola_Preferencial.Count < 25)
                Cola_Preferencial.Enqueue(persona);
            else
                if (persona.tipo == 2 && Cola_Clientes.Count < 25)
                    Cola_Clientes.Enqueue(persona);
                else
                    if (persona.tipo == 3 && Cola_No_Clientes.Count < 25)
                        Cola_No_Clientes.Enqueue(persona);
        }
    }
}
