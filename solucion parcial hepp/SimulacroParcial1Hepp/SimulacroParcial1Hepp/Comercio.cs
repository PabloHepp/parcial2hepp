using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1Hepp
{
    [Serializable]
    internal class Comercio
    {
        public List<Ticket> ListaAtendidos { get; set; } = new List<Ticket>();

        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        Queue<Pago> nuevoP = new Queue<Pago>();

        //List<CuentaCorriente> listacuentasCorrientes = new List<CuentaCorriente>();
        public List<CuentaCorriente> ListaCuentasCorrientes { get; private set; } = new List<CuentaCorriente>();
        public CuentaCorriente this[int nroCuenta]
        {
            get
            {
                ListaCuentasCorrientes.Sort();
                CuentaCorriente prueba = new CuentaCorriente(nroCuenta, null);
                int idx = ListaCuentasCorrientes.BinarySearch(prueba);
                if (idx >= 0)
                {
                    return ListaCuentasCorrientes[idx];
                }
                return null;
            }
        }

        public void AgregarTicket(Ticket turno)
        {
            if (turno != null)
            {
                if (turno is Pago)
                {
                    nuevoP.Enqueue((Pago)turno);
                }
                else if (turno is Cliente)
                {
                    nuevosClientes.Enqueue((Cliente)turno);
                }
            }

        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket atendido = null;
            if (tipo == 1)
            {
                if (nuevoP.Count > 0)
                {
                    atendido = nuevoP.Dequeue();
                }
            }
            else if (tipo == 0)
            {
                if (nuevosClientes.Count > 0)
                {
                    atendido = nuevosClientes.Dequeue();
                }
            }

            if (atendido != null)
            {
                ListaAtendidos.Add(atendido);
            }
            return atendido;
        }

        public CuentaCorriente ConsultarCuenta(int nroCuenta)
        {
            CuentaCorriente nuevo = this[nroCuenta];

            /*
            if (nuevo == null)
            {
                Cliente cliente = new Cliente(dni);
                nuevo = new CuentaCorriente(nroCuenta, cliente);
                listacuentasCorrientes.Add(nuevo);
            }
            */
            return nuevo;
        }
    }

}

