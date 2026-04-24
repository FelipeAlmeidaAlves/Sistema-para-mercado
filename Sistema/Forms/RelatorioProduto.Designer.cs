namespace TralhoGumo2.Forms
{
    partial class RelatorioProduto
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
            pnlRelatorioProduto = new Panel();
            pnlRelatorioClienteDados = new Panel();
            lblRelatorioProdutoCategoriaDados = new Label();
            lblRelatorioProdutoCategoria = new Label();
            lblRelatorioProdutoBotoesAlerta = new Label();
            btnRelatorioProdutoAtualizarLista = new Button();
            btnRelatorioProdutoDeletar = new Button();
            btnRelatorioProdutoAtualizar = new Button();
            lblRelatorioProdutoEstoqueMinimoDados = new Label();
            lblRelatorioProdutoEstoqueDados = new Label();
            lblRelatorioProdutoPrecoDados = new Label();
            lblRelatorioProdutoNomeDados = new Label();
            lblRelatorioProdutoEstoqueMinimo = new Label();
            lblRelatorioProdutoEstoque = new Label();
            lblRelatorioProdutoPreco = new Label();
            lblRelatorioProdutoNome = new Label();
            lstRelatorioProduto = new ListBox();
            txtRelatorioProduto = new TextBox();
            pnlRelatorioProduto.SuspendLayout();
            pnlRelatorioClienteDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRelatorioProduto
            // 
            pnlRelatorioProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioProduto.Controls.Add(pnlRelatorioClienteDados);
            pnlRelatorioProduto.Controls.Add(lstRelatorioProduto);
            pnlRelatorioProduto.Controls.Add(txtRelatorioProduto);
            pnlRelatorioProduto.Location = new Point(12, 12);
            pnlRelatorioProduto.Name = "pnlRelatorioProduto";
            pnlRelatorioProduto.Size = new Size(523, 204);
            pnlRelatorioProduto.TabIndex = 0;
            // 
            // pnlRelatorioClienteDados
            // 
            pnlRelatorioClienteDados.BackColor = Color.WhiteSmoke;
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoCategoriaDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoCategoria);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoBotoesAlerta);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioProdutoAtualizarLista);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioProdutoDeletar);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioProdutoAtualizar);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoEstoqueMinimoDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoEstoqueDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoPrecoDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoNomeDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoEstoqueMinimo);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoEstoque);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoPreco);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioProdutoNome);
            pnlRelatorioClienteDados.Location = new Point(194, 0);
            pnlRelatorioClienteDados.Name = "pnlRelatorioClienteDados";
            pnlRelatorioClienteDados.Size = new Size(329, 204);
            pnlRelatorioClienteDados.TabIndex = 2;
            // 
            // lblRelatorioProdutoCategoriaDados
            // 
            lblRelatorioProdutoCategoriaDados.BackColor = Color.White;
            lblRelatorioProdutoCategoriaDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioProdutoCategoriaDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoCategoriaDados.Location = new Point(101, 43);
            lblRelatorioProdutoCategoriaDados.Name = "lblRelatorioProdutoCategoriaDados";
            lblRelatorioProdutoCategoriaDados.Size = new Size(144, 23);
            lblRelatorioProdutoCategoriaDados.TabIndex = 13;
            // 
            // lblRelatorioProdutoCategoria
            // 
            lblRelatorioProdutoCategoria.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoCategoria.Location = new Point(14, 44);
            lblRelatorioProdutoCategoria.Name = "lblRelatorioProdutoCategoria";
            lblRelatorioProdutoCategoria.Size = new Size(81, 23);
            lblRelatorioProdutoCategoria.TabIndex = 12;
            lblRelatorioProdutoCategoria.Text = "Categoria:";
            // 
            // lblRelatorioProdutoBotoesAlerta
            // 
            lblRelatorioProdutoBotoesAlerta.AutoSize = true;
            lblRelatorioProdutoBotoesAlerta.BackColor = Color.Yellow;
            lblRelatorioProdutoBotoesAlerta.Font = new Font("Segoe UI", 9F);
            lblRelatorioProdutoBotoesAlerta.ForeColor = Color.Red;
            lblRelatorioProdutoBotoesAlerta.Location = new Point(69, 185);
            lblRelatorioProdutoBotoesAlerta.Name = "lblRelatorioProdutoBotoesAlerta";
            lblRelatorioProdutoBotoesAlerta.Size = new Size(95, 15);
            lblRelatorioProdutoBotoesAlerta.TabIndex = 11;
            lblRelatorioProdutoBotoesAlerta.Text = "Produto Inválido";
            lblRelatorioProdutoBotoesAlerta.Visible = false;
            // 
            // btnRelatorioProdutoAtualizarLista
            // 
            btnRelatorioProdutoAtualizarLista.AutoSize = true;
            btnRelatorioProdutoAtualizarLista.BackColor = Color.Transparent;
            btnRelatorioProdutoAtualizarLista.Font = new Font("Segoe UI", 14F);
            btnRelatorioProdutoAtualizarLista.ForeColor = SystemColors.ControlText;
            btnRelatorioProdutoAtualizarLista.Location = new Point(5, 165);
            btnRelatorioProdutoAtualizarLista.Name = "btnRelatorioProdutoAtualizarLista";
            btnRelatorioProdutoAtualizarLista.Size = new Size(43, 35);
            btnRelatorioProdutoAtualizarLista.TabIndex = 3;
            btnRelatorioProdutoAtualizarLista.Text = "🔄";
            btnRelatorioProdutoAtualizarLista.UseVisualStyleBackColor = false;
            btnRelatorioProdutoAtualizarLista.Click += btnRelatorioProdutoAtualizarLista_Click;
            // 
            // btnRelatorioProdutoDeletar
            // 
            btnRelatorioProdutoDeletar.AutoSize = true;
            btnRelatorioProdutoDeletar.Font = new Font("Segoe UI", 12F);
            btnRelatorioProdutoDeletar.Location = new Point(251, 169);
            btnRelatorioProdutoDeletar.Name = "btnRelatorioProdutoDeletar";
            btnRelatorioProdutoDeletar.Size = new Size(75, 31);
            btnRelatorioProdutoDeletar.TabIndex = 5;
            btnRelatorioProdutoDeletar.Text = "Deletar";
            btnRelatorioProdutoDeletar.UseVisualStyleBackColor = true;
            btnRelatorioProdutoDeletar.Click += btnRelatorioProdutoDeletar_Click;
            // 
            // btnRelatorioProdutoAtualizar
            // 
            btnRelatorioProdutoAtualizar.AutoSize = true;
            btnRelatorioProdutoAtualizar.Font = new Font("Segoe UI", 12F);
            btnRelatorioProdutoAtualizar.Location = new Point(164, 169);
            btnRelatorioProdutoAtualizar.Name = "btnRelatorioProdutoAtualizar";
            btnRelatorioProdutoAtualizar.Size = new Size(81, 31);
            btnRelatorioProdutoAtualizar.TabIndex = 4;
            btnRelatorioProdutoAtualizar.Text = "Atualizar";
            btnRelatorioProdutoAtualizar.UseVisualStyleBackColor = true;
            btnRelatorioProdutoAtualizar.Click += btnRelatorioProdutoAtualizar_Click;
            // 
            // lblRelatorioProdutoEstoqueMinimoDados
            // 
            lblRelatorioProdutoEstoqueMinimoDados.BackColor = Color.White;
            lblRelatorioProdutoEstoqueMinimoDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioProdutoEstoqueMinimoDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoEstoqueMinimoDados.Location = new Point(101, 134);
            lblRelatorioProdutoEstoqueMinimoDados.Name = "lblRelatorioProdutoEstoqueMinimoDados";
            lblRelatorioProdutoEstoqueMinimoDados.Size = new Size(109, 23);
            lblRelatorioProdutoEstoqueMinimoDados.TabIndex = 7;
            // 
            // lblRelatorioProdutoEstoqueDados
            // 
            lblRelatorioProdutoEstoqueDados.BackColor = Color.White;
            lblRelatorioProdutoEstoqueDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioProdutoEstoqueDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoEstoqueDados.Location = new Point(101, 103);
            lblRelatorioProdutoEstoqueDados.Name = "lblRelatorioProdutoEstoqueDados";
            lblRelatorioProdutoEstoqueDados.Size = new Size(109, 23);
            lblRelatorioProdutoEstoqueDados.TabIndex = 6;
            // 
            // lblRelatorioProdutoPrecoDados
            // 
            lblRelatorioProdutoPrecoDados.BackColor = Color.White;
            lblRelatorioProdutoPrecoDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioProdutoPrecoDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoPrecoDados.Location = new Point(101, 73);
            lblRelatorioProdutoPrecoDados.Name = "lblRelatorioProdutoPrecoDados";
            lblRelatorioProdutoPrecoDados.Size = new Size(109, 23);
            lblRelatorioProdutoPrecoDados.TabIndex = 5;
            // 
            // lblRelatorioProdutoNomeDados
            // 
            lblRelatorioProdutoNomeDados.BackColor = Color.White;
            lblRelatorioProdutoNomeDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioProdutoNomeDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoNomeDados.Location = new Point(101, 12);
            lblRelatorioProdutoNomeDados.Name = "lblRelatorioProdutoNomeDados";
            lblRelatorioProdutoNomeDados.Size = new Size(188, 23);
            lblRelatorioProdutoNomeDados.TabIndex = 4;
            // 
            // lblRelatorioProdutoEstoqueMinimo
            // 
            lblRelatorioProdutoEstoqueMinimo.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoEstoqueMinimo.Location = new Point(0, 135);
            lblRelatorioProdutoEstoqueMinimo.Name = "lblRelatorioProdutoEstoqueMinimo";
            lblRelatorioProdutoEstoqueMinimo.Size = new Size(100, 23);
            lblRelatorioProdutoEstoqueMinimo.TabIndex = 3;
            lblRelatorioProdutoEstoqueMinimo.Text = "Estoque Mín:";
            // 
            // lblRelatorioProdutoEstoque
            // 
            lblRelatorioProdutoEstoque.AutoSize = true;
            lblRelatorioProdutoEstoque.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoEstoque.Location = new Point(27, 105);
            lblRelatorioProdutoEstoque.Name = "lblRelatorioProdutoEstoque";
            lblRelatorioProdutoEstoque.Size = new Size(68, 21);
            lblRelatorioProdutoEstoque.TabIndex = 2;
            lblRelatorioProdutoEstoque.Text = "Estoque:";
            // 
            // lblRelatorioProdutoPreco
            // 
            lblRelatorioProdutoPreco.AutoSize = true;
            lblRelatorioProdutoPreco.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoPreco.Location = new Point(43, 75);
            lblRelatorioProdutoPreco.Name = "lblRelatorioProdutoPreco";
            lblRelatorioProdutoPreco.Size = new Size(52, 21);
            lblRelatorioProdutoPreco.TabIndex = 1;
            lblRelatorioProdutoPreco.Text = "Preço:";
            // 
            // lblRelatorioProdutoNome
            // 
            lblRelatorioProdutoNome.AutoSize = true;
            lblRelatorioProdutoNome.Font = new Font("Segoe UI", 12F);
            lblRelatorioProdutoNome.Location = new Point(39, 14);
            lblRelatorioProdutoNome.Name = "lblRelatorioProdutoNome";
            lblRelatorioProdutoNome.Size = new Size(56, 21);
            lblRelatorioProdutoNome.TabIndex = 0;
            lblRelatorioProdutoNome.Text = "Nome:";
            // 
            // lstRelatorioProduto
            // 
            lstRelatorioProduto.FormattingEnabled = true;
            lstRelatorioProduto.ItemHeight = 15;
            lstRelatorioProduto.Location = new Point(3, 25);
            lstRelatorioProduto.Name = "lstRelatorioProduto";
            lstRelatorioProduto.Size = new Size(170, 154);
            lstRelatorioProduto.TabIndex = 2;
            lstRelatorioProduto.Visible = false;
            lstRelatorioProduto.Click += lstRelatorioProduto_Click;
            lstRelatorioProduto.KeyUp += lstRelatorioProduto_KeyUp;
            // 
            // txtRelatorioProduto
            // 
            txtRelatorioProduto.Location = new Point(3, 3);
            txtRelatorioProduto.Name = "txtRelatorioProduto";
            txtRelatorioProduto.Size = new Size(170, 23);
            txtRelatorioProduto.TabIndex = 1;
            txtRelatorioProduto.TextChanged += txtRelatorioProduto_TextChanged;
            // 
            // RelatorioProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 228);
            Controls.Add(pnlRelatorioProduto);
            Name = "RelatorioProduto";
            Text = "RelatorioProduto";
            pnlRelatorioProduto.ResumeLayout(false);
            pnlRelatorioProduto.PerformLayout();
            pnlRelatorioClienteDados.ResumeLayout(false);
            pnlRelatorioClienteDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioProduto;
        private ListBox lstRelatorioProduto;
        private TextBox txtRelatorioProduto;
        private Panel pnlRelatorioClienteDados;
        private Label lblRelatorioProdutoBotoesAlerta;
        private Button btnRelatorioProdutoAtualizarLista;
        private Button btnRelatorioProdutoDeletar;
        private Button btnRelatorioProdutoAtualizar;
        private Label lblRelatorioProdutoEstoqueMinimoDados;
        private Label lblRelatorioProdutoEstoqueDados;
        private Label lblRelatorioProdutoPrecoDados;
        private Label lblRelatorioProdutoNomeDados;
        private Label lblRelatorioProdutoEstoqueMinimo;
        private Label lblRelatorioProdutoEstoque;
        private Label lblRelatorioProdutoPreco;
        private Label lblRelatorioProdutoNome;
        private Label lblRelatorioProdutoCategoria;
        private Label lblRelatorioProdutoCategoriaDados;
    }
}