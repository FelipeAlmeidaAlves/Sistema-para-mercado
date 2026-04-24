using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TralhoGumo2.Forms
{
    public partial class PagametoJan : Form
    {
        private BindingList<Cliente> _clientes = new BindingList<Cliente>();
        private BindingList<Compra> _compras = new BindingList<Compra>();
        private static PagametoJan _instance;

        private Cliente _clienteSelecionado;

        private PagametoJan()
        {
            InitializeComponent();

            lstPagamentoCliente.DisplayMember = "Nome";
            cboPagamentoCompra.DisplayMember.ToString();

            CarregarClientes();
            lstPagamentoCliente.DataSource = _clientes;
            cboPagamento.DisplayMember.ToString();
        }

        public static PagametoJan GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PagametoJan();
            }
            return _instance;

        }

        private void CarregarClientes()
        {
            _clientes.Clear();
            foreach (var c in ClienteRepository.FindAll())
                _clientes.Add(c);
        }

        private void CarregarCompras(Cliente c)
        {
            _compras.Clear();
            foreach (var co in CompraRepository.FindAllWCliente())
            {
                if (co.Cliente.Id == c.Id)
                {
                    co.Pagamentos = PagamentoRepository.FindByCompraId(co.Id);
                    _compras.Add(co);
                }
            }

            cboPagamentoCompra.DataSource = _compras;
        }
        private void txtPagamentoCliente_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPagamentoCliente.Text.Trim();

            if (texto.Length == 0)
            {
                lstPagamentoCliente.DataSource = _clientes;
                lstPagamentoCliente.ClearSelected();
                _clienteSelecionado = null;
                cboPagamentoCompra.DataSource = null;
                return;
            }
            var filtrado = _clientes
                .Where(c => c.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();

            lstPagamentoCliente.DataSource = filtrado;
            lstPagamentoCliente.ClearSelected();

            if (filtrado.Count == 1)
            {
                _clienteSelecionado = filtrado[0];
                CarregarCompras(_clienteSelecionado);
            }
        }

        private void lstPagamentoCliente_Click(object sender, EventArgs e)
        {
            if (lstPagamentoCliente.SelectedItem is Cliente c)
            {
                _clienteSelecionado = c;
                txtPagamentoCliente.Text = c.Nome;
                CarregarCompras(c);
            }
        }

        private void lstPagamentoCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lstPagamentoCliente.SelectedItem is Cliente c)
            {
                _clienteSelecionado = c;
                txtPagamentoCliente.Text = c.Nome;
                CarregarCompras(c);
            }
        }

        private void cboPagamentoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPagamentoCompra.SelectedItem is Compra compraSelecionada)
            {
                Preencher(compraSelecionada);
            }

        }
        private void Preencher(Compra compra)
        {
            cboPagamento.Items.Clear();

            if (compra?.Pagamentos != null && compra.Pagamentos.Count > 0)
            {
                foreach (var pagamento in compra.Pagamentos)
                {
                    decimal valorComMulta = (compra.Total / compra.Pagamentos.Count) + pagamento.MultaAtraso;
                    cboPagamento.Items.Add($"{pagamento.Vencimento:dd/MM/yyyy HH:mm} Valor: {valorComMulta:N2}");
                }

                cboPagamento.SelectedIndex = 0;
            }
        }


        private void btnPagou_Click(object sender, EventArgs e)
        {
            Pagamento c = (Pagamento)cboPagamento.SelectedItem;
            c.DataPagamento = DateTime.Now;
            PagamentoRepository.SaveOrUpdate(c);
        }

        private void txtPagamentoCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboPagamentoCompra.Focus();
            }
        }

        private void cboPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPagou.Focus();
            }
        }

        private void cboPagamentoCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboPagamento.Focus();
            }
        }
    }
}
