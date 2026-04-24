using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoGuisso;
using TralhoGumo2.Forms;

namespace TralhoGumo2
{
    public partial class Sistema : Form
    {
        private static Sistema _instance;
        private static Vendedor _vendedor;
        private Sistema(Vendedor v)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Text = "Sistema [" + v.Nome + "]";
            _vendedor = v;
        }
        public static Sistema GetInstance(Vendedor v)
        {
            _instance = new Sistema(v);
            return _instance;
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
            Login.GetInstance().Show();
        }

        private void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form child in this.MdiChildren)
                child.Close();
            Hide();
            Login.GetInstance().Show();
        }

        private void mnuUsuariosClientesCadastro_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastro = CadastroCliente.GetInstance();
            cadastro.MdiParent = this;
            cadastro.Show();
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;
        }
        public static void mnuUsuariosClientesCadastro1()
        {
            CadastroCliente cadastro = CadastroCliente.GetInstance();
            cadastro.MdiParent = _instance;
            cadastro.Show();
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;
        }

        private void mnuUsuariosClientesRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioCliente relatorio = RelatorioCliente.GetInstance();
            relatorio.MdiParent = this;
            relatorio.Show();
            relatorio.BringToFront();
            relatorio.WindowState = FormWindowState.Normal;
        }

        private void mnuUsuariosColaboradoresCadastro_Click(object sender, EventArgs e)
        {
            CadastroVendedor cadastro = CadastroVendedor.GetInstance();
            cadastro.MdiParent = this;
            cadastro.Show();
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;
        }
        public static void mnuUsuariosColaboradoresCadastro1()
        {
            CadastroVendedor cadastro = CadastroVendedor.GetInstance();
            cadastro.MdiParent = _instance;
            cadastro.Show();
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;
        }

        private void mnuUsuariosColaboradoresRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioVendedor cadastro = RelatorioVendedor.GetInstance();
            cadastro.MdiParent = this;
            cadastro.Show();
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;
        }

        private void mnuProdutosCadastro_Click(object sender, EventArgs e)
        {
            CadastroProduto relatorio = CadastroProduto.GetInstance();
            relatorio.MdiParent = this;
            relatorio.Show();
            relatorio.BringToFront();
            relatorio.WindowState = FormWindowState.Normal;
        }
        public static void mnuProdutosCadastro1()
        {
            CadastroProduto relatorio = CadastroProduto.GetInstance();
            relatorio.MdiParent = _instance;
            relatorio.Show();
            relatorio.BringToFront();
            relatorio.WindowState = FormWindowState.Normal;
        }

        private void mnuProdutosRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioProduto relatorio = RelatorioProduto.GetInstance();
            relatorio.MdiParent = this;
            relatorio.Show();
            relatorio.BringToFront();
            relatorio.WindowState = FormWindowState.Normal;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda.SetUsuarioLogado(_vendedor);

            var v = Venda.GetInstance();
            v.MdiParent = this;
            v.Show();
            v.BringToFront();

        }

        private void mnuClientesInadimplentes_Click(object sender, EventArgs e)
        {
            ClientesInadimplentes cliente = ClientesInadimplentes.GetInstance();
            cliente.MdiParent = this;
            cliente.Show();
            cliente.BringToFront();
            cliente.WindowState = FormWindowState.Normal;
        }

        private void mnuVendasPorPeriodo_Click(object sender, EventArgs e)
        {
            TotalPeriodo cliente = TotalPeriodo.GetInstance();
            cliente.MdiParent = this;
            cliente.Show();
            cliente.BringToFront();
            cliente.WindowState = FormWindowState.Normal;
        }

        private void mnuUltimos30Dias_Click(object sender, EventArgs e)
        {
            Ultimos30Dias cliente = Ultimos30Dias.GetInstance();
            cliente.MdiParent = this;
            cliente.Show();
            cliente.BringToFront();
            cliente.WindowState = FormWindowState.Normal;
        }

        private void mnuComissaoPorPeriodo_Click(object sender, EventArgs e)
        {
            ComissaoPeriodo cliente = ComissaoPeriodo.GetInstance();
            cliente.MdiParent = this;
            cliente.Show();
            cliente.BringToFront();
            cliente.WindowState = FormWindowState.Normal;
        }
    }
}
