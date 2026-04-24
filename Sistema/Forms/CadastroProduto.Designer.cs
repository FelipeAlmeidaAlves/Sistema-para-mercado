namespace TralhoGumo2
{
    partial class CadastroProduto
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
            pnlCadastroProduto = new Panel();
            lblProdutoSalvo = new Label();
            btnNovaCategoria = new Button();
            btnProdutoSalvar = new Button();
            txtProdutoEstoqueMinimo = new TextBox();
            txtProdutoEstoque = new TextBox();
            txtProdutoPreco = new TextBox();
            cboProdutoCategoria = new ComboBox();
            txtProdutoNome = new TextBox();
            lblProdutoEstoqueAlerta = new Label();
            lblProdutoPrecoAlerta = new Label();
            lblProdutoCategoriaAlerta = new Label();
            lblProdutoNomeAlerta = new Label();
            lblProdutoEstoqueMinimo = new Label();
            lblProdutoEstoque = new Label();
            lblProdutoPreco = new Label();
            lblProdutoCategoria = new Label();
            lblProdutoNome = new Label();
            pnlCadastroProduto.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroProduto
            // 
            pnlCadastroProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroProduto.Controls.Add(lblProdutoSalvo);
            pnlCadastroProduto.Controls.Add(btnNovaCategoria);
            pnlCadastroProduto.Controls.Add(btnProdutoSalvar);
            pnlCadastroProduto.Controls.Add(txtProdutoEstoqueMinimo);
            pnlCadastroProduto.Controls.Add(txtProdutoEstoque);
            pnlCadastroProduto.Controls.Add(txtProdutoPreco);
            pnlCadastroProduto.Controls.Add(cboProdutoCategoria);
            pnlCadastroProduto.Controls.Add(txtProdutoNome);
            pnlCadastroProduto.Controls.Add(lblProdutoEstoqueAlerta);
            pnlCadastroProduto.Controls.Add(lblProdutoPrecoAlerta);
            pnlCadastroProduto.Controls.Add(lblProdutoCategoriaAlerta);
            pnlCadastroProduto.Controls.Add(lblProdutoNomeAlerta);
            pnlCadastroProduto.Controls.Add(lblProdutoEstoqueMinimo);
            pnlCadastroProduto.Controls.Add(lblProdutoEstoque);
            pnlCadastroProduto.Controls.Add(lblProdutoPreco);
            pnlCadastroProduto.Controls.Add(lblProdutoCategoria);
            pnlCadastroProduto.Controls.Add(lblProdutoNome);
            pnlCadastroProduto.Location = new Point(12, 12);
            pnlCadastroProduto.Name = "pnlCadastroProduto";
            pnlCadastroProduto.Size = new Size(366, 433);
            pnlCadastroProduto.TabIndex = 0;
            // 
            // lblProdutoSalvo
            // 
            lblProdutoSalvo.AutoSize = true;
            lblProdutoSalvo.BackColor = Color.Green;
            lblProdutoSalvo.Font = new Font("Segoe UI", 10F);
            lblProdutoSalvo.ForeColor = Color.Blue;
            lblProdutoSalvo.Location = new Point(158, 407);
            lblProdutoSalvo.Name = "lblProdutoSalvo";
            lblProdutoSalvo.Size = new Size(122, 19);
            lblProdutoSalvo.TabIndex = 17;
            lblProdutoSalvo.Text = "Salvo com sucesso";
            lblProdutoSalvo.Visible = false;
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.Location = new Point(242, 124);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(100, 23);
            btnNovaCategoria.TabIndex = 6;
            btnNovaCategoria.Text = "Nova Categoria";
            btnNovaCategoria.UseVisualStyleBackColor = true;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // btnProdutoSalvar
            // 
            btnProdutoSalvar.AutoSize = true;
            btnProdutoSalvar.Font = new Font("Segoe UI", 12F);
            btnProdutoSalvar.Location = new Point(286, 399);
            btnProdutoSalvar.Name = "btnProdutoSalvar";
            btnProdutoSalvar.Size = new Size(75, 31);
            btnProdutoSalvar.TabIndex = 7;
            btnProdutoSalvar.Text = "Salvar";
            btnProdutoSalvar.UseVisualStyleBackColor = true;
            btnProdutoSalvar.Click += btnProdutoSalvar_Click;
            // 
            // txtProdutoEstoqueMinimo
            // 
            txtProdutoEstoqueMinimo.Font = new Font("Segoe UI", 12F);
            txtProdutoEstoqueMinimo.Location = new Point(8, 353);
            txtProdutoEstoqueMinimo.Name = "txtProdutoEstoqueMinimo";
            txtProdutoEstoqueMinimo.Size = new Size(169, 29);
            txtProdutoEstoqueMinimo.TabIndex = 5;
            txtProdutoEstoqueMinimo.Text = "10";
            txtProdutoEstoqueMinimo.TextChanged += txtProdutoEstoqueMinimo_TextChanged;
            txtProdutoEstoqueMinimo.KeyUp += txtProdutoEstoqueMinimo_KeyUp;
            // 
            // txtProdutoEstoque
            // 
            txtProdutoEstoque.Font = new Font("Segoe UI", 12F);
            txtProdutoEstoque.Location = new Point(8, 276);
            txtProdutoEstoque.Name = "txtProdutoEstoque";
            txtProdutoEstoque.Size = new Size(122, 29);
            txtProdutoEstoque.TabIndex = 4;
            txtProdutoEstoque.Text = "0";
            txtProdutoEstoque.TextChanged += txtProdutoEstoque_TextChanged;
            txtProdutoEstoque.KeyUp += txtProdutoEstoque_KeyUp;
            // 
            // txtProdutoPreco
            // 
            txtProdutoPreco.Font = new Font("Segoe UI", 12F);
            txtProdutoPreco.Location = new Point(10, 198);
            txtProdutoPreco.Name = "txtProdutoPreco";
            txtProdutoPreco.Size = new Size(122, 29);
            txtProdutoPreco.TabIndex = 3;
            txtProdutoPreco.Text = "R$0,00";
            txtProdutoPreco.TextChanged += txtProdutoPreco_TextChanged;
            txtProdutoPreco.KeyUp += txtProdutoPreco_KeyUp;
            // 
            // cboProdutoCategoria
            // 
            cboProdutoCategoria.Font = new Font("Segoe UI", 12F);
            cboProdutoCategoria.FormattingEnabled = true;
            cboProdutoCategoria.Location = new Point(8, 120);
            cboProdutoCategoria.Name = "cboProdutoCategoria";
            cboProdutoCategoria.Size = new Size(228, 29);
            cboProdutoCategoria.TabIndex = 2;
            cboProdutoCategoria.DropDown += cboProdutoCategoria_DropDown;
            cboProdutoCategoria.TextChanged += cboProdutoCategoria_TextChanged;
            cboProdutoCategoria.KeyUp += cboProdutoCategoria_KeyUp;
            // 
            // txtProdutoNome
            // 
            txtProdutoNome.Font = new Font("Segoe UI", 12F);
            txtProdutoNome.Location = new Point(8, 42);
            txtProdutoNome.Name = "txtProdutoNome";
            txtProdutoNome.Size = new Size(228, 29);
            txtProdutoNome.TabIndex = 1;
            txtProdutoNome.TextChanged += txtProdutoNome_TextChanged;
            txtProdutoNome.KeyUp += txtProdutoNome_KeyUp;
            // 
            // lblProdutoEstoqueAlerta
            // 
            lblProdutoEstoqueAlerta.AutoSize = true;
            lblProdutoEstoqueAlerta.Location = new Point(426, 299);
            lblProdutoEstoqueAlerta.Name = "lblProdutoEstoqueAlerta";
            lblProdutoEstoqueAlerta.Size = new Size(0, 15);
            lblProdutoEstoqueAlerta.TabIndex = 8;
            // 
            // lblProdutoPrecoAlerta
            // 
            lblProdutoPrecoAlerta.AutoSize = true;
            lblProdutoPrecoAlerta.BackColor = Color.Yellow;
            lblProdutoPrecoAlerta.ForeColor = Color.Red;
            lblProdutoPrecoAlerta.Location = new Point(8, 230);
            lblProdutoPrecoAlerta.Name = "lblProdutoPrecoAlerta";
            lblProdutoPrecoAlerta.Size = new Size(82, 15);
            lblProdutoPrecoAlerta.TabIndex = 7;
            lblProdutoPrecoAlerta.Text = "Preço Inválido";
            lblProdutoPrecoAlerta.Visible = false;
            // 
            // lblProdutoCategoriaAlerta
            // 
            lblProdutoCategoriaAlerta.AutoSize = true;
            lblProdutoCategoriaAlerta.BackColor = Color.Yellow;
            lblProdutoCategoriaAlerta.ForeColor = Color.Red;
            lblProdutoCategoriaAlerta.Location = new Point(8, 152);
            lblProdutoCategoriaAlerta.Name = "lblProdutoCategoriaAlerta";
            lblProdutoCategoriaAlerta.Size = new Size(102, 15);
            lblProdutoCategoriaAlerta.TabIndex = 6;
            lblProdutoCategoriaAlerta.Text = "Categoria Inválida";
            lblProdutoCategoriaAlerta.Visible = false;
            // 
            // lblProdutoNomeAlerta
            // 
            lblProdutoNomeAlerta.AutoSize = true;
            lblProdutoNomeAlerta.BackColor = Color.Yellow;
            lblProdutoNomeAlerta.Font = new Font("Segoe UI", 9F);
            lblProdutoNomeAlerta.ForeColor = Color.Red;
            lblProdutoNomeAlerta.Location = new Point(8, 74);
            lblProdutoNomeAlerta.Name = "lblProdutoNomeAlerta";
            lblProdutoNomeAlerta.Size = new Size(85, 15);
            lblProdutoNomeAlerta.TabIndex = 5;
            lblProdutoNomeAlerta.Text = "Nome Inválido";
            lblProdutoNomeAlerta.Visible = false;
            // 
            // lblProdutoEstoqueMinimo
            // 
            lblProdutoEstoqueMinimo.AutoSize = true;
            lblProdutoEstoqueMinimo.Font = new Font("Segoe UI", 15F);
            lblProdutoEstoqueMinimo.Location = new Point(8, 322);
            lblProdutoEstoqueMinimo.Name = "lblProdutoEstoqueMinimo";
            lblProdutoEstoqueMinimo.Size = new Size(159, 28);
            lblProdutoEstoqueMinimo.TabIndex = 4;
            lblProdutoEstoqueMinimo.Text = "Estoque Mínimo:";
            // 
            // lblProdutoEstoque
            // 
            lblProdutoEstoque.AutoSize = true;
            lblProdutoEstoque.Font = new Font("Segoe UI", 15F);
            lblProdutoEstoque.Location = new Point(8, 245);
            lblProdutoEstoque.Name = "lblProdutoEstoque";
            lblProdutoEstoque.Size = new Size(86, 28);
            lblProdutoEstoque.TabIndex = 3;
            lblProdutoEstoque.Text = "Estoque:";
            // 
            // lblProdutoPreco
            // 
            lblProdutoPreco.AutoSize = true;
            lblProdutoPreco.Font = new Font("Segoe UI", 15F);
            lblProdutoPreco.Location = new Point(8, 167);
            lblProdutoPreco.Name = "lblProdutoPreco";
            lblProdutoPreco.Size = new Size(65, 28);
            lblProdutoPreco.TabIndex = 2;
            lblProdutoPreco.Text = "Preço:";
            // 
            // lblProdutoCategoria
            // 
            lblProdutoCategoria.AutoSize = true;
            lblProdutoCategoria.Font = new Font("Segoe UI", 15F);
            lblProdutoCategoria.Location = new Point(3, 89);
            lblProdutoCategoria.Name = "lblProdutoCategoria";
            lblProdutoCategoria.Size = new Size(101, 28);
            lblProdutoCategoria.TabIndex = 1;
            lblProdutoCategoria.Text = "Categoria:";
            // 
            // lblProdutoNome
            // 
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Font = new Font("Segoe UI", 15F);
            lblProdutoNome.Location = new Point(3, 13);
            lblProdutoNome.Name = "lblProdutoNome";
            lblProdutoNome.Size = new Size(70, 28);
            lblProdutoNome.TabIndex = 0;
            lblProdutoNome.Text = "Nome:";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 457);
            Controls.Add(pnlCadastroProduto);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            FormClosing += CadastroProduto_FormClosing;
            Load += CadastroProduto_Load;
            pnlCadastroProduto.ResumeLayout(false);
            pnlCadastroProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroProduto;
        private Label lblProdutoNome;
        private Label lblProdutoCategoria;
        private Label lblProdutoEstoque;
        private Label lblProdutoPreco;
        private Label lblProdutoNomeAlerta;
        private Label lblProdutoEstoqueMinimo;
        private Label lblProdutoCategoriaAlerta;
        private TextBox txtProdutoNome;
        private Label lblProdutoEstoqueAlerta;
        private Label lblProdutoPrecoAlerta;
        private TextBox txtProdutoEstoqueMinimo;
        private TextBox txtProdutoEstoque;
        private TextBox txtProdutoPreco;
        private Button btnProdutoSalvar;
        private Button btnNovaCategoria;
        private ComboBox cboProdutoCategoria;
        private Label lblProdutoSalvo;
    }
}