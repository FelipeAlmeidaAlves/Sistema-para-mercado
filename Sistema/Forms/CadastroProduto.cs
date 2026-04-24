
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
    public partial class CadastroProduto : Form
    {
        private static UInt64 u;
        private static Produto produto;
        private static CadastroProduto _instance;
        private Boolean travar = false;
        private static BindingList<Categoria> BindCategoria = new BindingList<Categoria>();

        public static BindingList<Categoria> GetBindCategoria()
        {
            BindCategoria.Clear();
            foreach (Categoria c in CategoriaRepository.FindAll())
            {
                BindCategoria.Add(c);
            }
            return BindCategoria;
        }
        private CadastroProduto()
        {
            InitializeComponent();
            List<String> lst = new List<String>();
            foreach (Categoria c in CadastroProduto.GetBindCategoria())
            {
                lst.Add(c.Nome);
            }
            cboProdutoCategoria.DataSource = lst;
            cboProdutoCategoria.SelectedItem = null;
            if (produto != null && u == 0)
            {
                u = 1;
                txtProdutoEstoque.Text = produto.Estoque.ToString();
                txtProdutoEstoqueMinimo.Text = produto.EstoqueMinimo.ToString();
                txtProdutoNome.Text = produto.Nome;
                cboProdutoCategoria.Text = produto.Categoria.Nome;
                txtProdutoPreco.Text = produto.Preco.ToString();
            }
            else
            {
                cboProdutoCategoria.Text = "Selecionar Categoria";
            }

        }
        public static CadastroProduto GetInstance()
        {
            _instance = new CadastroProduto();
            return _instance;
        }
        public static void SetProduto(Produto p)
        {
            produto = p;
        }
        public static void Set()
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


        private void txtProdutoPreco_TextChanged(object sender, EventArgs e)
        {
            lblProdutoPrecoAlerta.Visible = false;

            if (travar) return;

            travar = true;
            int maxdigito = 8;
            TextBox t = (TextBox)sender;
            string numeros = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");
            if (numeros.Length > maxdigito)
            {
                numeros = numeros.Substring(0, maxdigito);
            }
            if (numeros.Length == 0)
            {
                numeros = "0";
            }
            Decimal valor = Decimal.Parse(numeros) / 100m;
            t.Text = $"{valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))}";

            t.SelectionStart = t.Text.Length;
            travar = false;
        }

        private void txtProdutoEstoque_TextChanged(object sender, EventArgs e)
        {
            if (travar) return;
            TextBox t = (TextBox)sender;
            string numeros = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");
            if (numeros.Length == 0)
            {
                numeros = "0";
            }
            if (numeros.Length == 2 && numeros.StartsWith("0"))
            {
                numeros = numeros.Remove(0, 1);
            }
            t.Text = numeros;
            t.SelectionStart = t.Text.Length;
            travar = false;
        }

        private void txtProdutoEstoqueMinimo_TextChanged(object sender, EventArgs e)
        {
            if (travar) return;
            TextBox t = (TextBox)sender;
            string numeros = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");
            if (numeros.Length == 0)
            {
                numeros = "0";
            }
            if (numeros.Length == 2 && numeros.StartsWith("0"))
            {
                numeros = numeros.Remove(0, 1);
            }
            t.Text = numeros;
            t.SelectionStart = t.Text.Length;
            travar = false;
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            CadastroCategoria.GetInstance().Show();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
        }

        private void btnProdutoSalvar_Click(object sender, EventArgs e)
        {
            int x = 0;
            List<String> lstPro = new List<String>();
            foreach (Produto p in ProdutoRepository.FindAll())
            {
                lstPro.Add(p.Nome);
            }
            List<String> lstCat = new List<String>();
            foreach (Categoria c in CadastroProduto.GetBindCategoria())
            {
                lstCat.Add(c.Nome);
            }
            if (txtProdutoNome.Text == null || txtProdutoNome.Text == "" || lstPro.Contains(txtProdutoNome.Text))
            {
                x++;
                lblProdutoNomeAlerta.Visible = true;
            }
            if (cboProdutoCategoria.SelectedItem == null || lstCat.Contains(cboProdutoCategoria.Text) == false)
            {
                x++;
                lblProdutoCategoriaAlerta.Visible = true;
            }
            if (txtProdutoPreco.Text == "R$0,00")
            {
                x++;
                lblProdutoPrecoAlerta.Visible = true;
            }
            if (produto != null)
            {
                if (lstPro.Contains(txtProdutoNome.Text))
                {
                    x--;
                    lblProdutoNomeAlerta.Visible = false;
                }
            }
            if (x != 0)
            {
                txtProdutoNome.Focus();
            }
            else
            {
                Produto p = new Produto();
                if (produto != null)
                {

                    p.Id = produto.Id;
                    p.Nome = txtProdutoNome.Text;
                    p.Categoria = CategoriaRepository.FindByName(cboProdutoCategoria.Text);
                    p.Estoque = Convert.ToUInt32(txtProdutoEstoque.Text);
                    p.EstoqueMinimo = Convert.ToUInt32(txtProdutoEstoqueMinimo.Text);
                    p.Preco = Convert.ToDecimal(txtProdutoPreco.Text.Replace(",", "").Replace("R", "").Replace("$", "")) / 100m;
                }
                else
                {
                    p.Nome = txtProdutoNome.Text;
                    p.Categoria = CategoriaRepository.FindByName(cboProdutoCategoria.Text);
                    p.Estoque = Convert.ToUInt32(txtProdutoEstoque.Text);
                    p.EstoqueMinimo = Convert.ToUInt32(txtProdutoEstoqueMinimo.Text);
                    p.Preco = Convert.ToDecimal(txtProdutoPreco.Text.Replace(",", "").Replace("R", "").Replace("$", "")) / 100m;
                }
                ProdutoRepository.SaveOrUpdate(p);
                txtProdutoEstoque.Clear();
                txtProdutoEstoqueMinimo.Text = "10";
                txtProdutoPreco.Clear();
                txtProdutoNome.Clear();
                cboProdutoCategoria.Text = "Selecionar categoria";
                txtProdutoNome.Focus();
                lblProdutoSalvo.Visible = true;
            }
        }

        private void txtProdutoNome_TextChanged(object sender, EventArgs e)
        {
            lblProdutoNomeAlerta.Visible = false;
            lblProdutoSalvo.Visible = false;
        }

        private void cboProdutoCategoria_TextChanged(object sender, EventArgs e)
        {
            lblProdutoCategoriaAlerta.Visible = false;
            lblProdutoSalvo.Visible = false;
        }

        private void CadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            produto = null;
        }

        private void cboProdutoCategoria_DropDown(object sender, EventArgs e)
        {
            List<String> lst = new List<String>();
            foreach (Categoria c in CategoriaRepository.FindAll())
            {
                lst.Add(c.Nome);
            }
            cboProdutoCategoria.DataSource = lst;
        }

        private void txtProdutoNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboProdutoCategoria.Focus();
            }
        }

        private void cboProdutoCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdutoPreco.Focus();
            }
        }

        private void txtProdutoPreco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdutoEstoque.Focus();
            }
        }

        private void txtProdutoEstoque_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdutoEstoqueMinimo.Focus();
            }
        }

        private void txtProdutoEstoqueMinimo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProdutoSalvar.Focus();
            }
        }
    }
}