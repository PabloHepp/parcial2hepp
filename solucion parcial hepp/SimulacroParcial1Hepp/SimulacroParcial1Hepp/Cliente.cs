using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    internal class Cliente : Ticket
    {
        private static int nroinicio;
        private int dni;
        public int DNI { get { return dni; } }

        public Cliente(string dni)
        {
            nroOrden = ++nroinicio;

            try
            {
                if (this.dni > 3000000 && this.dni < 45000000) ;
                this.dni = Convert.ToInt32(dni);

            }
            catch (Exception e)
            {

                throw new DniIncorrectoException("El DNI debe estar entre 3000000 y 45000000");
            }

        }



        public override string ToString()
        {
            return $"CLIENTE;{base.ToString()};{dni}";
        }
    }

}

    