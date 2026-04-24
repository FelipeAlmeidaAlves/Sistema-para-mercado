using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoGuisso;

namespace TralhoGumo2.Forms
{
    public partial class ComissaoPeriodo : Form
    {
        private static ComissaoPeriodo _instance;
        private ComissaoPeriodo()
        {
            InitializeComponent();
            lstVendedor.DisplayMember = "Nome";
        }
        public static ComissaoPeriodo GetInstance()
        {
            _instance = new ComissaoPeriodo();
            return _instance;
        }

        private void dtpDataInicio_ValueChanged(object sender, EventArgs e)
        {
            List<Vendedor> lst = new List<Vendedor>();
            foreach (Compra c in CompraRepository.FindAllWVendedor())
            {
                if (!lst.Contains(c.Vendedor))
                {
                    lst.Add(c.Vendedor);
                }
            }
            lstVendedor.DataSource = lst;
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            List<Vendedor> lst = new List<Vendedor>();
            foreach (Compra c in CompraRepository.FindAllWVendedor())
            {
                if (c.Efetivacao > dtpDataInicio.Value && c.Efetivacao < dtpDataFinal.Value)
                {
                    if (!lst.Contains(c.Vendedor))
                    {
                        lst.Add(c.Vendedor);
                    }
                }
            }
            lstVendedor.DataSource = lst;
        }

        private void lstVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVendedor.SelectedItem != null)
            {
                Decimal d = 0;
                Vendedor v = VendedorRepository.FindByName(lstVendedor.SelectedItem.ToString());
                foreach (Compra c in CompraRepository.FindAllWVendedorAndItens())
                {
                    if (v.Id == c.Vendedor.Id)
                    {
                        d += c.CalcularComissao();
                    }
                }
                lblComissaoDados.Text = "R$" + d;
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
                lstVendedor.Focus();
            }
        }
    }
}
