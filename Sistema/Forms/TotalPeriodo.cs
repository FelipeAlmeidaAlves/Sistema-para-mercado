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
    public partial class TotalPeriodo : Form
    {
        private static TotalPeriodo _instance;
        private TotalPeriodo()
        {
            InitializeComponent();
        }
        public static TotalPeriodo GetInstance()
        {
            _instance = new TotalPeriodo();
            return _instance;
        }
        private void dtpDataInicio_ValueChanged(object sender, EventArgs e)
        {
            List<UInt64> lstid = new List<UInt64>();
            foreach (Compra c in CompraRepository.FindAllWClienteVendedorPagamento())
            {
                if (c.Efetivacao > dtpDataInicio.Value && c.Efetivacao < dtpDataFinal.Value)
                {
                    lstid.Add(c.Id);
                }
            }
            lstCompras.DataSource = lstid;

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            List<UInt64> lstid = new List<UInt64>();
            foreach (Compra c in CompraRepository.FindAllWClienteVendedorPagamento())
            {
                if (c.Efetivacao > dtpDataInicio.Value && c.Efetivacao < dtpDataFinal.Value)
                {
                    lstid.Add(c.Id);
                }
            }
            lstCompras.DataSource = lstid;

        }

        private void lstCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCompras.SelectedItem != null)
            {
                Compra c = CompraRepository.FindByIdWClienteVendedorPagamento(Convert.ToUInt64(lstCompras.Text));
                lblClienteDados.Text = c.Cliente.Nome;
                lblEfetivacaoDados.Text = c.Efetivacao.ToString();
                lblEstadoDados.Text = c.Estado.ToString();
                lblVendedorDados.Text = c.Vendedor.Nome;
            }
        }

        private void dtpDataInicio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDataFinal.Focus();
            }
        }

        private void dtpDataFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstCompras.Focus();
            }
        }
    }
}
