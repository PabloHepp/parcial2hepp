using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    internal class Pago:Ticket
    {
        private static int nroinicio;
        public CuentaCorriente ficha;

        public Pago(int nroCuenta)
        {
            nroOrden = ++nroinicio;
            
        }

        public int VerDni()
        {
            return ficha.VerDniTitular();
        }

        public void AgregarCuenta (CuentaCorriente nueva)
        {
            ficha = nueva;
        }
        public void MontoPago(double valor)
        {
            ficha.RegistrarPago(valor);
        }

        public override string ToString()
        {
            return $"PAGO:;{base.ToString()};{ficha.VerDniTitular()};{ficha.VerNroCuenta()}";
        }
    }
}
