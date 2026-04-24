using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls;

namespace TralhoGumo2
{
    public partial class CadastroCategoria : Form
    {
        private static CadastroCategoria _instance;
        private CadastroCategoria()
        {
            InitializeComponent();
        }
        public static CadastroCategoria GetInstance()
        {
            _instance = new CadastroCategoria();
            return _instance;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.FormClosing -= ChildHideHandler;
                child.Close();
            }
        }
        private void ChildHideHandler(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }



        private void btnCategoriaSalvar_Click(object sender, EventArgs e)
        {
            List<String> lst = new List<String>();
            foreach (Categoria c in CategoriaRepository.FindAll())
            {
                lst.Add(c.Nome);
            }
            if (txtCategoriaNome.Text == null || txtCategoriaNome.Text == "" || lst.Contains(txtCategoriaNome.Text))
            {
                lblCategoriaNomeAlerta.Visible = true;
            }
            else
            {
                Categoria c = new Categoria() { Nome = txtCategoriaNome.Text };
                CategoriaRepository.SaveOrUpdate(c);
                Hide();
                CadastroProduto.GetBindCategoria();
            }
        }

        private void txtCategoriaNome_TextChanged(object sender, EventArgs e)
        {
            lblCategoriaNomeAlerta.Visible = false;
            lblCategoriaSalva.Visible = false;
        }

        private void CadastroCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtCategoriaNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnCategoriaSalvar.Focus();
            }
        }
    }
}
