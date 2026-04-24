using MySqlX.XDevAPI;
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
    public partial class RelatorioProduto : Form
    {
        private static RelatorioProduto _instance;
        private Produto produto;
        private static BindingList<Produto> BindProduto = new BindingList<Produto>();
        private RelatorioProduto()
        {
            InitializeComponent();
        }

        public static RelatorioProduto GetInstance()
        {
            _instance = new RelatorioProduto();
            return _instance;
        }
        public static BindingList<Produto> GetBindProduto()
        {
            BindProduto.Clear();
            foreach (Produto p in ProdutoRepository.FindAll())
            {
                BindProduto.Add(p);
            }
            return BindProduto;
        }

        private void txtRelatorioProduto_TextChanged(object sender, EventArgs e)
        {
            List<String> lst = new List<string>();
            lst.Clear();
            foreach (Produto p in RelatorioProduto.GetBindProduto())
            {
                if (p.Nome.Contains(txtRelatorioProduto.Text))
                {
                    lst.Add(p.Nome);
                }
            }
            lstRelatorioProduto.DataSource = lst;
            lstRelatorioProduto.SelectedItem = null;
            if (ProdutoRepository.FindByPartialName(txtRelatorioProduto.Text).Count == 1)
            {
                Produto p = ProdutoRepository.FindByPartialName(txtRelatorioProduto.Text)[0];
                lblRelatorioProdutoNomeDados.Text = p.Nome;
                lblRelatorioProdutoPrecoDados.Text = "R$"+p.Preco.ToString();
                lblRelatorioProdutoEstoqueDados.Text = p.Estoque.ToString();
                lblRelatorioProdutoEstoqueMinimoDados.Text = p.EstoqueMinimo.ToString();
                lblRelatorioProdutoCategoriaDados.Text = p.Categoria.Nome;
                lstRelatorioProduto.Visible = false;
                produto = p;
            }
            else
            {
                lstRelatorioProduto.Visible = true;
            }
        }

        private void lstRelatorioProduto_Click(object sender, EventArgs e)
        {
            if (lstRelatorioProduto.SelectedItem == null)
            {
                lstRelatorioProduto.Visible = true;
            }
            else
            {
                txtRelatorioProduto.Text = lstRelatorioProduto.SelectedItem.ToString();
                lstRelatorioProduto.Visible = false;
                lblRelatorioProdutoBotoesAlerta.Visible = false;
            }
        }

        private void lstRelatorioProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstRelatorioProduto.SelectedItem == null)
                {
                    lstRelatorioProduto.Visible = true;
                }
                else
                {
                    txtRelatorioProduto.Text = lstRelatorioProduto.SelectedItem.ToString();
                    lstRelatorioProduto.Visible = false;
                    lblRelatorioProdutoBotoesAlerta.Visible = false;
                }
            }
        }

        private void btnRelatorioProdutoAtualizarLista_Click(object sender, EventArgs e)
        {
            if (produto != null)
            {
                Produto p = ProdutoRepository.FindById(produto.Id);
                lblRelatorioProdutoPrecoDados.Text = "R$"+p.Preco.ToString();
                lblRelatorioProdutoEstoqueDados.Text = p.Estoque.ToString();
                lblRelatorioProdutoEstoqueMinimoDados.Text = p.EstoqueMinimo.ToString();
                lblRelatorioProdutoCategoriaDados.Text = p.Categoria.Nome;
                lblRelatorioProdutoNomeDados.Text = p.Nome;
                lstRelatorioProduto.Visible = false;
                lblRelatorioProdutoBotoesAlerta.Visible = false;
            }
            else
            {
                lstRelatorioProduto.Visible = true;
            }
        }

        private void btnRelatorioProdutoAtualizar_Click(object sender, EventArgs e)
        {
            if (produto != null)
            {
                CadastroProduto.SetProduto(ProdutoRepository.FindById(produto.Id));
                CadastroProduto.Set();
                lstRelatorioProduto.Visible = false;
                Sistema.mnuProdutosCadastro1();
            }
            else
            {
                lblRelatorioProdutoBotoesAlerta.Visible = true;
            }
        }

        private void btnRelatorioProdutoDeletar_Click(object sender, EventArgs e)
        {
            if (produto != null)
            {
                ProdutoRepository.Remove(produto);
                txtRelatorioProduto.Text = "";
                lblRelatorioProdutoPrecoDados.Text = "";
                lblRelatorioProdutoNomeDados.Text = "";
                lblRelatorioProdutoEstoqueDados.Text = "";
                lblRelatorioProdutoEstoqueMinimoDados.Text = "";
                lblRelatorioProdutoCategoriaDados.Text = "";
                lstRelatorioProduto.Visible = false;
                produto = null;
                lblRelatorioProdutoBotoesAlerta.Visible = false;
            }
            else
            {
                lblRelatorioProdutoBotoesAlerta.Visible = true;
            }
        }
    }
}
