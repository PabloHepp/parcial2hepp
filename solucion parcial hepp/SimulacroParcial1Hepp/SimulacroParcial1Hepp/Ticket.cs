using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    abstract public class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora;

        public Ticket()
        {
            fechaHora = DateTime.Now;
        }
        public int VerNro()
        {
            return nroOrden;
            
        }

        public DateTime VerFecha()
        {
            return fechaHora;
        }

        public override string ToString()
        {
            return $"{nroOrden}";
        }


    }


    
}
