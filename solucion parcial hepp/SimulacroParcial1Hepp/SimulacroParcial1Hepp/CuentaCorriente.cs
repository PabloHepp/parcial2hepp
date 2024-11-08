using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    internal class CuentaCorriente:IComparable<CuentaCorriente>
    {
        private int nroCuenta;
        private Cliente titular;
        private double saldo;

        public CuentaCorriente(int nro, Cliente titular)
        {
            nroCuenta = nro;
            this.titular = titular;
            saldo = 0;
        }

        public Cliente VerTitular()
        {
            return titular;
        }

        public int VerNroCuenta()
        {
            return nroCuenta;
        }

        public void RegistrarPago(double monto)
        {
            saldo = saldo - monto;
        }

        public void RegistrarVenta(double monto)
        {
            saldo = saldo + monto;
        }

        public double VerSaldo()
        {
            return saldo;
        }

        public void AgregarSaldo(double monto)
        {
            saldo = monto;
        }


        public int CompareTo(CuentaCorriente other)
        {
            if (other != null)
                return nroCuenta.CompareTo(other.nroCuenta);
            return 1;
        }

        public override string ToString()
        {
            return $"{nroCuenta}";
        }

    }
}
