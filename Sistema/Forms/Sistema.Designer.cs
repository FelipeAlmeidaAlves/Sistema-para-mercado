namespace TralhoGumo2
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuUsuarios = new ToolStripMenuItem();
            mnuUsuariosClientes = new ToolStripMenuItem();
            mnuUsuariosClientesCadastro = new ToolStripMenuItem();
            mnuUsuariosClientesRelatorio = new ToolStripMenuItem();
            colaboradoresToolStripMenuItem = new ToolStripMenuItem();
            mnuUsuariosColaboradoresCadastro = new ToolStripMenuItem();
            mnuUsuariosColaboradoresRelatorio = new ToolStripMenuItem();
            mnuProdutos = new ToolStripMenuItem();
            mnuProdutosCadastro = new ToolStripMenuItem();
            mnuProdutosRelatorio = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            indicadoresToolStripMenuItem = new ToolStripMenuItem();
            mnuClientesInadimplentes = new ToolStripMenuItem();
            mnuUltimos30Dias = new ToolStripMenuItem();
            mnuComissaoPorPeriodo = new ToolStripMenuItem();
            mnuVendasPorPeriodo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuUsuarios, mnuProdutos, vendaToolStripMenuItem, indicadoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArquivoSair });
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(61, 20);
            mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(93, 22);
            mnuArquivoSair.Text = "Sair";
            mnuArquivoSair.Click += mnuArquivoSair_Click;
            // 
            // mnuUsuarios
            // 
            mnuUsuarios.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuariosClientes, colaboradoresToolStripMenuItem });
            mnuUsuarios.Name = "mnuUsuarios";
            mnuUsuarios.Size = new Size(64, 20);
            mnuUsuarios.Text = "Usuários";
            // 
            // mnuUsuariosClientes
            // 
            mnuUsuariosClientes.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuariosClientesCadastro, mnuUsuariosClientesRelatorio });
            mnuUsuariosClientes.Name = "mnuUsuariosClientes";
            mnuUsuariosClientes.Size = new Size(151, 22);
            mnuUsuariosClientes.Text = "Clientes";
            // 
            // mnuUsuariosClientesCadastro
            // 
            mnuUsuariosClientesCadastro.Name = "mnuUsuariosClientesCadastro";
            mnuUsuariosClientesCadastro.Size = new Size(121, 22);
            mnuUsuariosClientesCadastro.Text = "Cadastro";
            mnuUsuariosClientesCadastro.Click += mnuUsuariosClientesCadastro_Click;
            // 
            // mnuUsuariosClientesRelatorio
            // 
            mnuUsuariosClientesRelatorio.Name = "mnuUsuariosClientesRelatorio";
            mnuUsuariosClientesRelatorio.Size = new Size(121, 22);
            mnuUsuariosClientesRelatorio.Text = "Relatório";
            mnuUsuariosClientesRelatorio.Click += mnuUsuariosClientesRelatorio_Click;
            // 
            // colaboradoresToolStripMenuItem
            // 
            colaboradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuariosColaboradoresCadastro, mnuUsuariosColaboradoresRelatorio });
            colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            colaboradoresToolStripMenuItem.Size = new Size(151, 22);
            colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // mnuUsuariosColaboradoresCadastro
            // 
            mnuUsuariosColaboradoresCadastro.Name = "mnuUsuariosColaboradoresCadastro";
            mnuUsuariosColaboradoresCadastro.Size = new Size(121, 22);
            mnuUsuariosColaboradoresCadastro.Text = "Cadastro";
            mnuUsuariosColaboradoresCadastro.Click += mnuUsuariosColaboradoresCadastro_Click;
            // 
            // mnuUsuariosColaboradoresRelatorio
            // 
            mnuUsuariosColaboradoresRelatorio.Name = "mnuUsuariosColaboradoresRelatorio";
            mnuUsuariosColaboradoresRelatorio.Size = new Size(121, 22);
            mnuUsuariosColaboradoresRelatorio.Text = "Relatório";
            mnuUsuariosColaboradoresRelatorio.Click += mnuUsuariosColaboradoresRelatorio_Click;
            // 
            // mnuProdutos
            // 
            mnuProdutos.DropDownItems.AddRange(new ToolStripItem[] { mnuProdutosCadastro, mnuProdutosRelatorio });
            mnuProdutos.Name = "mnuProdutos";
            mnuProdutos.Size = new Size(67, 20);
            mnuProdutos.Text = "Produtos";
            // 
            // mnuProdutosCadastro
            // 
            mnuProdutosCadastro.Name = "mnuProdutosCadastro";
            mnuProdutosCadastro.Size = new Size(121, 22);
            mnuProdutosCadastro.Text = "Cadastro";
            mnuProdutosCadastro.Click += mnuProdutosCadastro_Click;
            // 
            // mnuProdutosRelatorio
            // 
            mnuProdutosRelatorio.Name = "mnuProdutosRelatorio";
            mnuProdutosRelatorio.Size = new Size(121, 22);
            mnuProdutosRelatorio.Text = "Relatorio";
            mnuProdutosRelatorio.Click += mnuProdutosRelatorio_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // indicadoresToolStripMenuItem
            // 
            indicadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuClientesInadimplentes, mnuUltimos30Dias, mnuComissaoPorPeriodo, mnuVendasPorPeriodo });
            indicadoresToolStripMenuItem.Name = "indicadoresToolStripMenuItem";
            indicadoresToolStripMenuItem.Size = new Size(80, 20);
            indicadoresToolStripMenuItem.Text = "Indicadores";
            // 
            // mnuClientesInadimplentes
            // 
            mnuClientesInadimplentes.Name = "mnuClientesInadimplentes";
            mnuClientesInadimplentes.Size = new Size(194, 22);
            mnuClientesInadimplentes.Text = "Clientes Inadimplentes";
            mnuClientesInadimplentes.Click += mnuClientesInadimplentes_Click;
            // 
            // mnuUltimos30Dias
            // 
            mnuUltimos30Dias.Name = "mnuUltimos30Dias";
            mnuUltimos30Dias.Size = new Size(194, 22);
            mnuUltimos30Dias.Text = "Últimos 30 dias";
            mnuUltimos30Dias.Click += mnuUltimos30Dias_Click;
            // 
            // mnuComissaoPorPeriodo
            // 
            mnuComissaoPorPeriodo.Name = "mnuComissaoPorPeriodo";
            mnuComissaoPorPeriodo.Size = new Size(194, 22);
            mnuComissaoPorPeriodo.Text = "Comissão por período";
            mnuComissaoPorPeriodo.Click += mnuComissaoPorPeriodo_Click;
            // 
            // mnuVendasPorPeriodo
            // 
            mnuVendasPorPeriodo.Name = "mnuVendasPorPeriodo";
            mnuVendasPorPeriodo.Size = new Size(194, 22);
            mnuVendasPorPeriodo.Text = "Vendas por período";
            mnuVendasPorPeriodo.Click += mnuVendasPorPeriodo_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Sistema";
            Text = "Sistema";
            FormClosing += Sistema_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuUsuarios;
        private ToolStripMenuItem mnuUsuariosClientes;
        private ToolStripMenuItem mnuUsuariosClientesCadastro;
        private ToolStripMenuItem mnuUsuariosClientesRelatorio;
        private ToolStripMenuItem colaboradoresToolStripMenuItem;
        private ToolStripMenuItem mnuUsuariosColaboradoresCadastro;
        private ToolStripMenuItem mnuUsuariosColaboradoresRelatorio;
        private ToolStripMenuItem mnuProdutos;
        private ToolStripMenuItem mnuProdutosCadastro;
        private ToolStripMenuItem mnuProdutosRelatorio;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem indicadoresToolStripMenuItem;
        private ToolStripMenuItem mnuClientesInadimplentes;
        private ToolStripMenuItem mnuUltimos30Dias;
        private ToolStripMenuItem mnuComissaoPorPeriodo;
        private ToolStripMenuItem mnuVendasPorPeriodo;
    }
}