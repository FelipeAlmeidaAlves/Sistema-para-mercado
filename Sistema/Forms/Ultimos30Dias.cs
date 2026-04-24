using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TralhoGumo2.Forms
{
    public partial class Ultimos30Dias : Form
    {
        private static Ultimos30Dias _instance;
        private Ultimos30Dias()
        {
            InitializeComponent();
            List<UInt64> lstid = new List<UInt64>();
            foreach (Compra c in CompraRepository.FindAll()) 
            {
                if (c.Efetivacao > DateTime.Now.AddDays(-30)) 
                {
                    lstid.Add(c.Id);
                }
            }
            lstCompra.DataSource = lstid;
        }
        public static Ultimos30Dias GetInstance() 
        {
            _instance = new Ultimos30Dias();
            return _instance;
        }

        private void lstCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCompra.SelectedItem != null)
            {
                Compra c = CompraRepository.FindByIdWClienteVendedorPagamento(Convert.ToUInt64(lstCompra.Text));
                lblClienteDados.Text = c.Cliente.Nome;
                lblEfetivacaoDados.Text = c.Efetivacao.ToString();
                lblEstadoDados.Text = c.Estado.ToString();
                lblVendedorDados.Text = c.Vendedor.Nome;
            }
        }
    }
}
