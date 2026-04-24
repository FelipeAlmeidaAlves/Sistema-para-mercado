using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using TrabalhoGuisso;

namespace TralhoGumo2
{
    public partial class CadastroVendedor : Form
    {
        private static UInt64 u;
        private static Vendedor vendedor;
        private static CadastroVendedor _instance;
        private CadastroVendedor()
        {
            InitializeComponent();
            if (vendedor != null && u == 0)
            {
                u = 1;
                txtNome.Text = vendedor.Nome;
                txtEmail.Text = vendedor.Gmail;
                mskTelefone.Text = vendedor.Telefone;
                txtSenha.Text = vendedor.Credencial.SenhaTexto;
                txtSenha2.Text = vendedor.Credencial.SenhaTexto;
                if (vendedor.Credencial.Perfil == TralhoGumo2.Perfil.Gerente)
                {
                    rdbGerente.Checked = true;
                }
                else
                {
                    if (vendedor.Credencial.Perfil == TralhoGumo2.Perfil.Operador)
                    {
                        rdbOperador.Checked = true;
                    }
                    else
                    {
                        rdbVendedor.Checked = true;
                    }
                }
            }
        }
        public static CadastroVendedor GetInstance()
        {
            _instance = new CadastroVendedor();
            return _instance;
        }
        public static void SetVendedor(Vendedor v)
        {
            vendedor = v;
        }
        public static void set() 
        {
            u = 0;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
        }


        private Boolean Salvar()
        {
            if (!CamposValidos())
                return false;

            var listuser = VendedorRepository.FindAllWithCredencial();

            if (listuser.Any(u => String.Equals(u.Gmail.Trim(), txtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                lblVendedorEmailAlerta.Visible = true;
                return false;
            }
            Vendedor v = new Vendedor();

            if (vendedor != null)
            {
                v.Id = vendedor.Id;
                v.Nome = txtNome.Text.Trim();
                v.Gmail = txtEmail.Text.Trim();
                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                v.Telefone = mskTelefone.Text;
                v.Credencial.SenhaTexto = txtSenha.Text;
                v.Credencial.SenhaHash = Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT);
                vendedor = null;
            }
            else
            {
                v.Nome = txtNome.Text.Trim();
                v.Gmail = txtEmail.Text.Trim();
                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                v.Telefone = mskTelefone.Text;
                v.Credencial.SenhaTexto = txtSenha.Text;
                v.Credencial.SenhaHash = Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT);
                VendedorRepository.SaveOrUpdate(v);

                LimparCampos();
                return true;
            }

            VendedorRepository.SaveOrUpdate(v);

            LimparCampos();
            return true;
        }

        private Boolean CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblVendedorNomeAlerta.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblVendedorEmailAlerta.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtSenha2.Text))
            {
                lblVendedorSenhaAlerta.Visible = true;
                return false;
            }
            if (txtSenha.Text != txtSenha2.Text)
            {
                lblVendedorRepetirSenhaAlerta.Visible = true;
                return false;
            }
            if (rdbGerente.Checked == false && rdbOperador.Checked == false && rdbVendedor.Checked == false)
            {
                lblVendedorPerfilAlerta.Visible = true;
                return false;
            }
            if (!Perfil())
            {
                lblVendedorPerfilAlerta.Visible = true;
                return false;
            }

            return true;

        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtSenha2.Clear();
            mskTelefone.Clear();
            rdbGerente.Checked = false;
            rdbVendedor.Checked = false;
            rdbOperador.Checked = false;
        }

        private void MoverFocoAoPressionarEnter(object sender, KeyEventArgs e, Control proximo)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            if (proximo == null)
            {
                Salvar();
                return;
            }

            proximo.Focus();

            if (proximo is TextBoxBase tb)
                tb.SelectAll();
        }

        private Boolean Perfil()
        {
            if (rdbGerente.Checked == false && rdbOperador.Checked == false && rdbVendedor.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                Salvar();
                LimparCampos();
                lblVendedorSalvo.Visible = true;
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            MoverFocoAoPressionarEnter(sender, e, txtEmail);
            lblVendedorNomeAlerta.Visible = false;
            lblVendedorSalvo.Visible = false;
        }

        private void mskTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            MoverFocoAoPressionarEnter(sender, e, txtSenha);
            lblVendedorTelefoneAlerta.Visible = false;
            lblVendedorSalvo.Visible = false;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            MoverFocoAoPressionarEnter(sender, e, mskTelefone);
            lblVendedorEmailAlerta.Visible = false;
            lblVendedorSalvo.Visible = false;
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            MoverFocoAoPressionarEnter(sender, e, txtSenha2);
            lblVendedorSenhaAlerta.Visible = false;
            lblVendedorSalvo.Visible = false;
        }

        private void txtSenha2_KeyUp(object sender, KeyEventArgs e)
        {
            MoverFocoAoPressionarEnter(sender, e, btnSalvar);
            lblVendedorRepetirSenhaAlerta.Visible = false;
            lblVendedorSalvo.Visible = false;
        }

        private void CadastroVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimparCampos();
            vendedor = null;
        }
    }
}
