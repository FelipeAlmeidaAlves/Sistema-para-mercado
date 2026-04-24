using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TralhoGumo2.Forms;

namespace TralhoGumo2
{
    public partial class Venda : Form
    {
        private static Venda _instance;
        private Decimal? DescontoAutorizado = null;
        private Cliente _cliente;
        Compra Com = new Compra();
        private static BindingList<Cliente> BindCliente = new BindingList<Cliente>();
        private static BindingList<Produto> Produtos = new BindingList<Produto>();
        private static BindingList<Item> ItensDaCompra = new BindingList<Item>();
        private static Vendedor _usuarioLogado;
        private bool _carregando = false;


        public static void SetUsuarioLogado(Vendedor vendedor)
        {
            _usuarioLogado = vendedor;
        }

        private Venda()
        {
            InitializeComponent();
            _carregando = true;
            lstClientes.SelectedIndex = -1;
            EventosGlobais.ClientesAtualizados += AtualizarListaClientes;
            EventosGlobais.ProdutosAtualizados += AtualizarListaProdutos;
            lstClientes.DataSource = GetBindCliente();
            lstClientes.DisplayMember = "Nome";
            lstProduto.DataSource = GetBindItens();
            TornarInvisivel();
            lstProduto.ClearSelected();
            numParcelas.Minimum = 1;
            lstCompras.DataSource = ItensDaCompra;
            lstCompras.DisplayMember = "Descricao";
            txtDesconto.Text = "0,00";
            _carregando = false;
            lstClientes.SelectedIndex = -1;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent.Disposing)
                return;
            e.Cancel = true;
            this.Hide();
        }

        public static Venda GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Venda();
            }
            return _instance;
        }
        public static BindingList<Cliente> GetBindCliente()
        {
            BindCliente.Clear();
            foreach (Cliente c in ClienteRepository.FindAll())
            {
                BindCliente.Add(c);
            }
            return BindCliente;
        }
        public static BindingList<Produto> GetBindItens()
        {
            Produtos.Clear();
            foreach (Produto c in ProdutoRepository.FindAll().Where(x => x.Ativo))
            {
                Produtos.Add(c);
            }
            return Produtos;
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ItensDaCompra)
            {
                item.Produto.Estoque += item.Quantidade;
            }
            if (lstClientes.SelectedItem == null || _usuarioLogado == null)
            {
                Cancelar();
                return;
            }
            Conferir();
            numQuantidade.Value = 1;
            Com = new Compra
            {
                Numero = 0,
                ClienteId = ((Cliente)lstClientes.SelectedItem).Id,
                VendedorId = _usuarioLogado.Id,
                Itens = new List<Item>(),
                Pagamentos = new List<Pagamento>(),
                Inicio = DateTime.Now
            };
            ItensDaCompra.Clear();

            Com.Cliente = (Cliente)lstClientes.SelectedItem;
            ItensDaCompra.Clear();
        }

        public void TornarVisivel()
        {
            lblProduto.Visible = true;
            txtProduto.Visible = true;
            lstProduto.Visible = true;
            lblQuantidade.Visible = true;
            txtValorUnitario.Visible = true;
            txtTotal.Visible = true;
            lblTotal.Visible = true;
            lblValorUnitario.Visible = true;
            lblQuantidade.Visible = true;
            numQuantidade.Visible = true;
            btnAdicionar.Visible = true;
            btnSalvar.Visible = true;
            lstCompras.Visible = true;
            lblDesconto.Visible = true;
            txtDesconto.Visible = true;
            btnRemover.Visible = true;
            btnCancelar.Visible = true;
            lblParcelas.Visible = true;
            numParcelas.Visible = true;
        }
        public void TornarInvisivel()
        {
            lblProduto.Visible = false;
            txtProduto.Visible = false;
            lstProduto.Visible = false;
            lblQuantidade.Visible = false;
            txtValorUnitario.Visible = false;
            txtTotal.Visible = false;
            lblTotal.Visible = false;
            lblValorUnitario.Visible = false;
            lblQuantidade.Visible = false;
            numQuantidade.Visible = false;
            btnAdicionar.Visible = false;
            btnSalvar.Visible = false;
            lstCompras.Visible = false;
            lblDesconto.Visible = false;
            txtDesconto.Visible = false;
            btnRemover.Visible = false;
            btnCancelar.Visible = false;
            numParcelas.Visible = false;
            lblParcelas.Visible = false;
        }
        public void Conferir()
        {
            if (_carregando)
                return;
            txtTotal.Clear();
            txtValorUnitario.Clear();
            if (lstClientes.SelectedItem == null)
            {
                TornarInvisivel();
                return;
            }
            Cliente c = (Cliente)lstClientes.SelectedItem;
            if (c != null && !c.PodeRealizarNovaCompra())
            {
                TornarInvisivel();
                MessageBox.Show(
                    "O cliente não pode realizar compras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GerenteJanela gerenteJanela = GerenteJanela.GetInstance();
                gerenteJanela.ResetarAutorizacao();
                gerenteJanela.ShowDialog();
                if (gerenteJanela.Autorizado)
                {
                    TornarVisivel();
                }
                else
                {
                    return;
                }

            }
            else
            {
                TornarVisivel();
                return;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lstProduto.SelectedItem == null)
                return;
            if (numQuantidade.Value == 0)
                return;

            Produto p = (Produto)lstProduto.SelectedItem;
            uint qtdNova = (uint)numQuantidade.Value;
            if (qtdNova > p.Estoque)
            {
                lblEstoque.Visible = true;
                return;
            }

            lblEstoque.Visible = false;
            decimal descontoTela = CalcularDescontoTela();
            if (descontoTela > 0.05m)
            {
                if (DescontoAutorizado == null || descontoTela > DescontoAutorizado)
                {
                    MessageBox.Show(
                        "O desconto é maior que o desconto maximo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GerenteJanela gen = GerenteJanela.GetInstance();
                    gen.ResetarAutorizacao();
                    gen.ShowDialog();

                    if (!gen.Autorizado)
                        return;

                    DescontoAutorizado = descontoTela;
                }
            }
            Item itemExistente = ItensDaCompra.FirstOrDefault(x => x.ProdutoId == p.Id);

            Item item;

            if (itemExistente != null)
            {
                itemExistente.Quantidade += qtdNova;
                var itemCompra = Com.Itens.First(x => x.ProdutoId == p.Id);
                itemCompra.Quantidade = itemExistente.Quantidade;
                int index = ItensDaCompra.IndexOf(itemExistente);
                ItensDaCompra[index] = itemExistente;

                item = itemExistente;
            }
            else
            {
                item = new Item()
                {
                    ProdutoId = p.Id,
                    Produto = p,
                    Quantidade = qtdNova,
                    PrecoUnitario = p.Preco,
                    Desconto = descontoTela
                };

                Com.Itens.Add(item);
                ItensDaCompra.Add(item);
            }
            p.Estoque -= qtdNova;
            txtValorUnitario.Text = item.CalcularTotal().ToString("N2");
            lstCompras.ClearSelected();
            numQuantidade.Value = 1;
            lstProduto.ClearSelected();
            AtualizarTotais();
        }


        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            lblEstoque.Visible = false;
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                lstProduto.DataSource = Produtos;
                return;
            }
            ulong idDigitado;
            if (!ulong.TryParse(txtProduto.Text, out idDigitado))
                return;
            var filtrados = Produtos
                .Where(p => p.Id.ToString().Contains(txtProduto.Text))
                .ToList();

            lstProduto.DataSource = filtrados;
            lstProduto.DisplayMember = "NomeComPreco";
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "")
                return;
            string somenteDigitos = new string(txtDesconto.Text.Where(char.IsDigit).ToArray());


            if (somenteDigitos.Length == 0)
                somenteDigitos = "0";


            decimal valor = decimal.Parse(somenteDigitos) / 100m;

            if (valor > 99.99m)
                valor = 99.99m;

            txtDesconto.TextChanged -= txtDesconto_TextChanged;
            txtDesconto.Text = valor.ToString("N2");
            txtDesconto.SelectionStart = txtDesconto.Text.Length;
            txtDesconto.TextChanged += txtDesconto_TextChanged;
        }
        private void AtualizarTotais()
        {
            txtTotal.Text = Com.CalcularTotal().ToString("N2");
        }

        private decimal CalcularDescontoTela()
        {
            if (decimal.TryParse(txtDesconto.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valorPercent))
            {
                return valorPercent / 100m;
            }
            return 0m;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ItensDaCompra.Count == 0)
                return;
            var result = MessageBox.Show(
                "Realmente confirmar?"
                , "Confirmação"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            Com.VendedorId = _usuarioLogado.Id;
            Com.Vendedor = null;

            Com.ClienteId = ((Cliente)lstClientes.SelectedItem).Id;
            int qtdParcelas = (int)numParcelas.Value;
            DateTime baseTime = DateTime.Now.AddHours(1);

            Com.Pagamentos.Clear();

            for (int i = 0; i < qtdParcelas; i++)
            {
                Pagamento p = new Pagamento
                {
                    Vencimento = baseTime.AddMonths(i)
                };

                Com.Pagamentos.Add(p);
            }

            Com.Cliente = null;
            foreach (var item in Com.Itens)
            {
                ProdutoRepository.SaveOrUpdate(item.Produto);
            }
            Com.Efetivacao = DateTime.Now;
            Com.Comissao = Com.CalcularComissao();
            Com.Total = Com.CalcularTotal();
            CompraRepository.SaveOrUpdate(Com);
            Com = new Compra
            {
                Numero = 0,
                ClienteId = ((Cliente)lstClientes.SelectedItem).Id,
                VendedorId = _usuarioLogado.Id,
                Itens = new List<Item>(),
                Pagamentos = new List<Pagamento>()
            };

            ItensDaCompra.Clear();
            lstClientes.SelectedIndex = -1;
            TornarInvisivel();

            lstCompras.DataSource = null;
            lstCompras.DataSource = ItensDaCompra;

        }

        private void txtClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtClientes_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtClientes.Text))
            {
                lstClientes.DataSource = BindCliente;
                lstClientes.ClearSelected();
                ListaClientes();
                return;
            }

            ulong idDigitado;
            if (!ulong.TryParse(txtClientes.Text, out idDigitado))
                return;

            var filtrados = BindCliente
                .Where(c => c.Id.ToString().Contains(txtClientes.Text))
                .ToList();

            lstClientes.DataSource = filtrados;
            lstClientes.DisplayMember.ToString();
        }
        public void ListaClientes()
        {

            if (lstClientes.SelectedItem == null)
            {
                TornarInvisivel();
                return;
            }

            Conferir();
            numQuantidade.Value = 1;
            Cliente clienteSelecionado = (Cliente)lstClientes.SelectedItem;
            var clienteDb = ClienteRepository.FindById(clienteSelecionado.Id);
            if (clienteDb == null)
            {
                MessageBox.Show("O cliente selecionado não existe no banco!");
                TornarInvisivel();
                return;
            }
            if (Com == null || Com.Efetivacao != null)
            {
                Com = new Compra
                {
                    Numero = 0,
                    ClienteId = clienteDb.Id,
                    VendedorId = _usuarioLogado.Id,
                    Itens = new List<Item>(),
                    Pagamentos = new List<Pagamento>()
                };
            }

            ItensDaCompra.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstCompras.SelectedItem == null)
                return;
            Item item = (Item)lstCompras.SelectedItem;
            item.Produto.Estoque += item.Quantidade;
            ItensDaCompra.Remove(item);
        }
        public void AtualizarListaClientes()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = GetBindCliente();
            lstClientes.DisplayMember = "Nome";
        }

        public void AtualizarListaProdutos()
        {
            lstProduto.DataSource = null;
            lstProduto.DataSource = GetBindItens();
            lstProduto.DisplayMember = "NomeComPreco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //            var result = MessageBox.Show(
            //    "Tem certeza que quer fazer isso?",
            //    "Confirmação",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question
            //);

            //            if (result == DialogResult.Yes)
            //            {
            //                // usuário confirmou
            //            }
            //            else
            //            {
            //                // usuário cancelou
            //            }
            var result = MessageBox.Show(
                "Realmente cancelar?"
                , "Confirmação"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            lstClientes.SelectedIndex = -1;
        }
        private void Cancelar()
        {
            foreach (var item in ItensDaCompra)
            {
                item.Produto.Estoque += item.Quantidade;
            }
            ItensDaCompra.Clear();
            DescontoAutorizado = null;
            txtDesconto.Text = "0,00";
            TornarInvisivel();
        }
        private void AtualizarLimiteDeParcelas()
        {
            numParcelas.Minimum = 1;
            Decimal total = Com.CalcularTotal();
            Int32 limite = 1;
            for (Int32 i = 1; i <= 6; i++)
            {
                Decimal valorParcela = total / i;

                if (valorParcela >= 50)
                {
                    limite = i;
                }
                else
                {
                    break;
                }
            }

            numParcelas.Maximum = limite;

            if (numParcelas.Value > limite)
                numParcelas.Value = limite;
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLimiteDeParcelas();
        }

        private void txtClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProduto.Focus();
            }
        }

        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numQuantidade.Focus();
            }
        }

        private void numQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar.Focus();
            }
        }

        private void btnAdicionar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numParcelas.Focus();
            }
        }

        private void numParcelas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }
    }
}
