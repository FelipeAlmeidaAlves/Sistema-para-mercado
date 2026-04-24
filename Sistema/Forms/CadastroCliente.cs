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
    public partial class CadastroCliente : Form
    {
        private static UInt64 u;
        private static Cliente cliente = null;
        private static CadastroCliente _instance;
        private CadastroCliente()
        {
            InitializeComponent();
            if (cliente != null && u == 0)
            {
                u = 1;
                txtClienteEndereco.Text = cliente.Endereco;
                txtClienteNome.Text = cliente.Nome;
                mskClienteCpf.Text = cliente.Cpf;
                mskClienteTelefone.Text = cliente.Telefone;
                dtpClienteNascimento.Value = cliente.Nascimento;
                this.FormClosing += ChildHideHandler;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
        }

        public static void SetCliente(Cliente c)
        {
            cliente = c;
        }
        public static void Set()
        {
            u = 0; ;
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
        public static CadastroCliente GetInstance()
        {
            _instance = new CadastroCliente();
            return _instance;
        }

        private void btnClienteSalvar_Click(object sender, EventArgs e)
        {
            UInt64 x = 0;
            UInt64 Cpf = 0;
            UInt64 tel = 0;


            try
            {
                Cpf = Convert.ToUInt64(mskClienteCpf.Text.Replace(".", "").Replace("-", "").Trim());
            }
            catch (Exception)
            {
                lblClienteCpfAlerta.Visible = true;
                x++;
            }

            try
            {
                tel = Convert.ToUInt64(mskClienteTelefone.Text.Replace("_", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim());
            }
            catch (Exception)
            {
                lblClienteTelefoneAlerta.Visible = true;
                x++;
            }


            if (Cpf < 10000000000)
            {
                lblClienteCpfAlerta.Visible = true;
                x++;
            }
            if (tel < 10000000000)
            {
                lblClienteTelefoneAlerta.Visible = true;
                x++;
            }
            if (txtClienteNome.Text is null || txtClienteNome.Text.Trim() == "")
            {
                lblClienteNomeAlerta.Visible = true;
                x++;
            }
            if (txtClienteEndereco.Text is null || txtClienteEndereco.Text.Trim() == "")
            {
                lblClienteEnderecoAlerta.Visible = true;
                x++;
            }
            if (dtpClienteNascimento.Value > DateTime.Now.AddYears(-18) || dtpClienteNascimento.Value < DateTime.Now.AddYears(-150))
            {
                lblClienteNascimentoAlerta.Visible = true;
                x++;
            }
            if (x != 0)
            {
                txtClienteNome.Focus();
            }
            else
            {
                Cliente c = new Cliente();
                if (cliente == null)
                {
                    c.Nome = txtClienteNome.Text;
                    c.Cpf = mskClienteCpf.Text.Replace("-", "").Replace(".", "");
                    c.Endereco = txtClienteEndereco.Text;
                    c.Telefone = mskClienteTelefone.Text;
                    c.Nascimento = dtpClienteNascimento.Value;
                }
                else
                {
                    c.Id = cliente.Id;
                    c.Nome = txtClienteNome.Text;
                    c.Cpf = mskClienteCpf.Text.Replace("-", "").Replace(".", "");
                    c.Endereco = txtClienteEndereco.Text;
                    c.Telefone = mskClienteTelefone.Text;
                    c.Nascimento = dtpClienteNascimento.Value;
                }
                ClienteRepository.SaveOrUpdate(c);
                cliente = null;

                txtClienteEndereco.Clear();
                txtClienteNome.Clear();
                mskClienteCpf.Clear();
                mskClienteTelefone.Clear();
                dtpClienteNascimento.Value = DateTime.Now;
                lblClienteNome.Focus();
                lblClienteSalvo.Visible = true;
            }
        }

        private void mskClienteCpf_TextChanged(object sender, EventArgs e)
        {
            lblClienteCpfAlerta.Visible = false;
            lblClienteSalvo.Visible = false;
        }

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {
            lblClienteNomeAlerta.Visible = false;
            lblClienteSalvo.Visible = false;
        }

        private void txtClienteEndereco_TextChanged(object sender, EventArgs e)
        {
            lblClienteEnderecoAlerta.Visible = false;
            lblClienteSalvo.Visible = false;
        }

        private void mskClienteTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblClienteTelefoneAlerta.Visible = false;
            lblClienteSalvo.Visible = false;
        }

        private void dtpClienteNascimento_ValueChanged(object sender, EventArgs e)
        {
            lblClienteNascimentoAlerta.Visible = false;
            lblClienteSalvo.Visible = false;
        }
        public void ChildHideHandler(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void CadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente = null;
            u = 1;
        }

        private void txtClienteNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskClienteCpf.Focus();
            }
        }

        private void mskClienteCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtClienteEndereco.Focus();
            }
        }

        private void txtClienteEndereco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskClienteTelefone.Focus();
            }
        }

        private void mskClienteTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpClienteNascimento.Focus();
            }
        }

        private void dtpClienteNascimento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnClienteSalvar.Focus();
            }
        }
    }
}
