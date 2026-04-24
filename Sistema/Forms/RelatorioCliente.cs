using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TralhoGumo2
{
    public partial class RelatorioCliente : Form
    {
        private static Cliente cliente;
        private static BindingList<Cliente> BindCliente = new BindingList<Cliente>();
        private static RelatorioCliente _instance;
        public static BindingList<Cliente> GetBindCliente()
        {
            BindCliente.Clear();
            foreach (Cliente c in ClienteRepository.FindAll())
            {
                BindCliente.Add(c);
            }
            return BindCliente;
        }

        private RelatorioCliente()
        {
            InitializeComponent();
            if (cliente != null) 
            {
                txtRelatorioClientes.Text = cliente.Nome;
                lblRelatorioClienteCpfDados.Text = cliente.Cpf;
                lblRelatorioClienteIdadeDados.Text = cliente.Idade.ToString();
                lblRelatorioClienteTelefoneDados.Text = cliente.Telefone;
                lblRelatorioClienteNomeDados.Text = cliente.Nome;
            }
        }

        public static RelatorioCliente GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioCliente();
            }
            return _instance;
        }
        public static void SetCliente(Cliente c) 
        {
            cliente = c;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstRelatorioClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRelatorioClientes_TextChanged(object sender, EventArgs e)
        {
            lblRelatorioClienteBotoesAlerta.Visible = false;
            List<String> lst = new List<String>();
            lst.Clear();
            foreach (Cliente c in RelatorioCliente.GetBindCliente())
            {
                if (c.Nome.Contains(txtRelatorioClientes.Text)) 
                { 
                    lst.Add(c.Nome);
                }
            }
            lstRelatorioClientes.DataSource = lst;
            lstRelatorioClientes.SelectedItem = null;
            if (ClienteRepository.FindByPartialName(txtRelatorioClientes.Text).Count == 1)
            {
                Cliente c = ClienteRepository.FindByPartialName(txtRelatorioClientes.Text)[0];
                lblRelatorioClienteCpfDados.Text = c.Cpf;
                lblRelatorioClienteIdadeDados.Text = c.Idade.ToString();
                lblRelatorioClienteNomeDados.Text = c.Nome;
                lblRelatorioClienteTelefoneDados.Text = c.Telefone;
                lstRelatorioClientes.Visible = false;
                cliente = c;
            }
            else
            {
                lstRelatorioClientes.Visible = true;
            }
        }

        private void lstRelatorioClientes_Click(object sender, EventArgs e)
        {
            if (lstRelatorioClientes.SelectedItem == null)
            {
                lstRelatorioClientes.Visible = true;
            }
            else
            {
                txtRelatorioClientes.Text = lstRelatorioClientes.SelectedItem.ToString();
                lstRelatorioClientes.Visible = false;
                lblRelatorioClienteBotoesAlerta.Visible = false;
            }
        }

        private void lstRelatorioClientes_KeyUp(object sender, KeyEventArgs e)
        {
            lblRelatorioClienteBotoesAlerta.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                if (lstRelatorioClientes.SelectedItem == null)
                {
                    lstRelatorioClientes.Visible = true;
                }
                else
                {
                    txtRelatorioClientes.Text = lstRelatorioClientes.SelectedItem.ToString();
                    lstRelatorioClientes.Visible = false;
                }
            }
        }

        private void btnRelatorioClienteAtualizar_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                CadastroCliente.SetCliente(ClienteRepository.FindById(cliente.Id));
                CadastroCliente.Set();
                lstRelatorioClientes.Visible = false;
                Sistema.mnuUsuariosClientesCadastro1();
            }
            else
            {
                lblRelatorioClienteBotoesAlerta.Visible = true;
            }
        }

        private void btnRelatorioClienteAtualizarLista_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                Cliente c = ClienteRepository.FindById(cliente.Id);
                lblRelatorioClienteCpfDados.Text = c.Cpf;
                lblRelatorioClienteIdadeDados.Text = c.Idade.ToString();
                lblRelatorioClienteNomeDados.Text = c.Nome;
                lblRelatorioClienteTelefoneDados.Text = c.Telefone;
                lstRelatorioClientes.Visible = false;
                lblRelatorioClienteBotoesAlerta.Visible = false;
            }
            else
            {
                lstRelatorioClientes.Visible = true;
            }
        }

        private void btnRelatorioClienteDeletar_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                ClienteRepository.Remove(cliente);
                txtRelatorioClientes.Text = "";
                lblRelatorioClienteCpfDados.Text = "";
                lblRelatorioClienteIdadeDados.Text = "";
                lblRelatorioClienteTelefoneDados.Text = "";
                lblRelatorioClienteNomeDados.Text = "";
                lstRelatorioClientes.Visible = false;
                cliente = null;
                lblRelatorioClienteBotoesAlerta.Visible = false;
            }
            else 
            {
                lblRelatorioClienteBotoesAlerta.Visible = true;
            }
        }
    }
}
