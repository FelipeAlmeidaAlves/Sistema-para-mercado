using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MySqlX.XDevAPI;
using TrabalhoGuisso;

namespace TralhoGumo2
{
    public partial class RelatorioVendedor : Form
    {
        private static RelatorioVendedor _instance;
        private Vendedor vendedor;
        private static BindingList<Vendedor> BindVendedor = new BindingList<Vendedor>();
        public static BindingList<Vendedor> GetBindVendedor()
        {
            BindVendedor.Clear();
            foreach (Vendedor v in VendedorRepository.FindAllWithCredencial())
            {
                BindVendedor.Add(v);
            }
            return BindVendedor;
        }
        private RelatorioVendedor()
        {
            InitializeComponent();
        }

        public static RelatorioVendedor GetInstance()
        {
            _instance = new RelatorioVendedor();
            return _instance;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
        }

        private void txtRelatorioVendedor_TextChanged(object sender, EventArgs e)
        {
            lblRelatorioVendedorBotoesAlerta.Visible = false;
            List<String> lst = new List<String>();
            lst.Clear();
            foreach (Vendedor v in RelatorioVendedor.GetBindVendedor())
            {
                if (v.Nome.Contains(txtRelatorioVendedor.Text))
                {
                        lst.Add(v.Nome);
                }
            }
            lstRelatorioVendedor.DataSource = lst;
            lstRelatorioVendedor.SelectedItem = null;
            if (VendedorRepository.FindByPartialName(txtRelatorioVendedor.Text).Count == 1)
            {
                Vendedor v = VendedorRepository.FindByPartialName(txtRelatorioVendedor.Text)[0];
                lblRelatorioVendedorEmailDados.Text = v.Gmail;
                lblRelatorioVendedorPerfilDados.Text = v.Credencial.Perfil.ToString();
                lblRelatorioVendedorNomeDados.Text = v.Nome;
                lblRelatorioVendedorTelefoneDados.Text = v.Telefone;
                lstRelatorioVendedor.Visible = false;
                vendedor = v;
            }
            else
            {
                lstRelatorioVendedor.Visible = true;
            }
        }

        private void lstRelatorioVendedor_Click(object sender, EventArgs e)
        {
            if (lstRelatorioVendedor.SelectedItem != null)
            {
                txtRelatorioVendedor.Text = lstRelatorioVendedor.SelectedItem.ToString();
                lstRelatorioVendedor.Visible = false;
                lblRelatorioVendedorBotoesAlerta.Visible = false;
            }
            else
            {
                lstRelatorioVendedor.Visible = true;
            }
        }

        private void lstRelatorioVendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstRelatorioVendedor.SelectedItem != null)
                {
                    txtRelatorioVendedor.Text = lstRelatorioVendedor.SelectedItem.ToString();
                    lstRelatorioVendedor.Visible = false;
                    lblRelatorioVendedorBotoesAlerta.Visible = false;
                }
                else
                {
                    lstRelatorioVendedor.Visible = true;
                }
            }
        }

        private void btnRelatorioVendedorAtualizarLista_Click(object sender, EventArgs e)
        {
            if (vendedor != null)
            {
                Vendedor v = VendedorRepository.FindById(vendedor.Id);
                lblRelatorioVendedorNomeDados.Text = v.Nome;
                lblRelatorioVendedorPerfilDados.Text = vendedor.Credencial.Perfil.ToString();
                lblRelatorioVendedorTelefoneDados.Text = v.Telefone;
                lblRelatorioVendedorEmailDados.Text = v.Gmail;
                lstRelatorioVendedor.Visible = false;
                lblRelatorioVendedorBotoesAlerta.Visible = false;
            }
            else
            {
                lstRelatorioVendedor.Visible = true;
            }
        }

        private void btnRelatorioVendedorAtualizar_Click(object sender, EventArgs e)
        {
            if (vendedor != null)
            {
                CadastroVendedor.SetVendedor(VendedorRepository.FindById(vendedor.Id));
                CadastroVendedor.set();
                lstRelatorioVendedor.Visible = false;
                Sistema.mnuUsuariosColaboradoresCadastro1();
            }
            else
            {
                lblRelatorioVendedorBotoesAlerta.Visible = true;
            }
        }

        private void btnRelatorioVendedorDeletar_Click(object sender, EventArgs e)
        {
            if (vendedor != null)
            {
                VendedorRepository.Remove(vendedor);
                txtRelatorioVendedor.Clear();
                lblRelatorioVendedorNomeDados.Text = "";
                lblRelatorioVendedorTelefoneDados.Text = "";
                lblRelatorioVendedorPerfilDados.Text = "";
                lblRelatorioVendedorEmailDados.Text = "";
                lstRelatorioVendedor.Visible = false;
                vendedor = null;
                lblRelatorioVendedorBotoesAlerta.Visible = false;
            }
            else
            {
                lblRelatorioVendedorBotoesAlerta.Visible = true;
            }
        }
    }
}
