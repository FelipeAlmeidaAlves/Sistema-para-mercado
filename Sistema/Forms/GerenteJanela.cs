using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Pqc.Crypto.Falcon;
using TrabalhoGuisso;

namespace TralhoGumo2
{
    public partial class GerenteJanela : Form
    {
        public bool Autorizado { get; private set; } = false;
        private static GerenteJanela _instance;
        private GerenteJanela()
        {
            InitializeComponent();
            txtGmail.Focus();
            txtSenha.Clear();
            txtGmail.Clear();

        }
        public static GerenteJanela GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new GerenteJanela();
            }
            return _instance;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
            txtSenha.Clear();
            txtGmail.Clear();
            txtGmail.Focus();
        }

        private void txtGmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                lblErro.Visible = false;
                return;
            }
            txtSenha.Focus();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                lblErro.Visible = false;
                btnFinalizar.Focus();
                return;
            }
            Finalizar();
            Erro();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Finalizar();
            Erro();
        }

        public Boolean Finalizar()
        {
            List<Vendedor> vend = VendedorRepository.FindAllWithCredencial();
            foreach (Vendedor v in vend)
            {
                if (txtGmail.Text == v.Gmail && Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT) == v.Credencial.SenhaHash)
                {
                    if (v.Credencial.Perfil == Perfil.Gerente)
                    {
                        Autorizado = true;
                        this.Hide();
                        txtSenha.Clear();
                        txtGmail.Clear();
                        txtGmail.Focus();
                        return true;
                    }
                }
            }
            Autorizado = false;
            txtSenha.Clear();
            txtGmail.Clear();
            txtGmail.Focus();
            return false;
        }
        public void Erro()
        {
            if (!Autorizado)
            {
                lblErro.Visible = true;
            }
        }
        public void ResetarAutorizacao()
        {
            Autorizado = false;
        }

    }
}
