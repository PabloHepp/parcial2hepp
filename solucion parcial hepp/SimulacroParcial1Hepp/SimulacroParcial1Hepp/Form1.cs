using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroParcial1Hepp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Comercio comercio = new Comercio();
                

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("Datos.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                comercio = bf.Deserialize(fs) as Comercio;
            }
            catch { }
            finally
            {
                if (fs != null) fs.Close();
            }
                       
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("Datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, comercio);
            }
            catch { }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            



        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            Ticket atendido = null;

            if (rbPagos.Checked) 
                atendido = comercio.AtenderTicket(0);

            if(rbCompras.Checked)
            atendido = comercio.AtenderTicket(1);

            if (atendido != null)
            {
                lbxTurnos.Items.Remove(atendido);
            }
        }

     

        private void btnExportarTickets_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Exportando Tickets";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    string linea = "TIPO;NroTicket;DNI;NroCuenta";
                   
                    sw.WriteLine(linea);

                    foreach (Ticket ticket in comercio.ListaAtendidos)
                    {
                        linea = ticket.ToString();
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al exportar");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

     
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket nuevo = null;

            try
            {
                if (ckbCuenta.Checked)
                {
                    int nroCta = Convert.ToInt32(txbCtacte.Text);

                    nuevo = new Pago(nroCta);
                    ((Pago)nuevo).AgregarCuenta(comercio.ConsultarCuenta(nroCta));
                    comercio.AgregarTicket(nuevo);
                }
                else
                {
                    string dni = txbDNI.Text;
                    nuevo = new Cliente(dni);
                    comercio.AgregarTicket(nuevo);
                }
                if (nuevo != null)
                {
                    lbxTurnos.Items.Add(nuevo.ToString());
                }
            }
            catch { }
        }

        private void btnImportarCuenta_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importando lista de Cuentas Corrientes";
            openFileDialog1.Filter = "Archivos .CSV | *.CSV";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                    sr = new StreamReader(fs);

                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');

                        int nroCuenta = Convert.ToInt32(campos[0]);
                        string dni = (campos[1]);
                        double saldo = Convert.ToDouble(campos[2]);

                        if (!comercio.ListaCuentasCorrientes.Contains(comercio.ConsultarCuenta(nroCuenta)))
                        {
                            CuentaCorriente importada = new CuentaCorriente(nroCuenta, new Cliente(dni));
                            importada.AgregarSaldo(saldo);
                            comercio.ListaCuentasCorrientes.Add(importada);
                        }
                        
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la importación");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }



}

