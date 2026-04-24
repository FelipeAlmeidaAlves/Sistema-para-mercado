namespace TralhoGumo2
{
    partial class Venda
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
            panel1 = new Panel();
            numParcelas = new NumericUpDown();
            lblParcelas = new Label();
            btnCancelar = new Button();
            btnRemover = new Button();
            lblClientes = new Label();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            lstCompras = new ListBox();
            lblEstoque = new Label();
            btnAdicionar = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtValorUnitario = new TextBox();
            lblValorUnitario = new Label();
            lblQuantidade = new Label();
            numQuantidade = new NumericUpDown();
            lstProduto = new ListBox();
            lblProduto = new Label();
            txtProduto = new TextBox();
            btnSalvar = new Button();
            txtClientes = new TextBox();
            lstClientes = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(numParcelas);
            panel1.Controls.Add(lblParcelas);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(lblClientes);
            panel1.Controls.Add(txtDesconto);
            panel1.Controls.Add(lblDesconto);
            panel1.Controls.Add(lstCompras);
            panel1.Controls.Add(lblEstoque);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(txtValorUnitario);
            panel1.Controls.Add(lblValorUnitario);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(numQuantidade);
            panel1.Controls.Add(lstProduto);
            panel1.Controls.Add(lblProduto);
            panel1.Controls.Add(txtProduto);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtClientes);
            panel1.Controls.Add(lstClientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 439);
            panel1.TabIndex = 0;
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(570, 254);
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(32, 23);
            numParcelas.TabIndex = 9;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            numParcelas.KeyUp += numParcelas_KeyUp;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(448, 236);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(134, 15);
            lblParcelas.TabIndex = 23;
            lblParcelas.Text = "Quantidade de parcelas:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(625, 412);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(544, 102);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(3, 29);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(75, 15);
            lblClientes.TabIndex = 20;
            lblClientes.Text = "Id do cliente:";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(448, 176);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 8;
            txtDesconto.TextChanged += txtDesconto_TextChanged;
            txtDesconto.KeyPress += txtDesconto_KeyPress;
            txtDesconto.KeyUp += txtDesconto_KeyUp;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(448, 158);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(154, 15);
            lblDesconto.TabIndex = 18;
            lblDesconto.Text = "Desconto em porcentagem:";
            // 
            // lstCompras
            // 
            lstCompras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCompras.FormattingEnabled = true;
            lstCompras.ItemHeight = 21;
            lstCompras.Location = new Point(649, 9);
            lstCompras.Name = "lstCompras";
            lstCompras.Size = new Size(169, 340);
            lstCompras.TabIndex = 10;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.BackColor = Color.Red;
            lblEstoque.ForeColor = Color.Yellow;
            lblEstoque.Location = new Point(443, 130);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(195, 15);
            lblEstoque.TabIndex = 16;
            lblEstoque.Text = "Quantidade insuficiente no estoque";
            lblEstoque.Visible = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(463, 102);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            btnAdicionar.KeyUp += btnAdicionar_KeyUp;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(721, 382);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(80, 23);
            txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(679, 385);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total:";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(721, 353);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.ReadOnly = true;
            txtValorUnitario.Size = new Size(80, 23);
            txtValorUnitario.TabIndex = 12;
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Location = new Point(679, 356);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(36, 15);
            lblValorUnitario.TabIndex = 11;
            lblValorUnitario.Text = "Valor:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(448, 60);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(476, 78);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(44, 23);
            numQuantidade.TabIndex = 5;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            numQuantidade.KeyUp += numQuantidade_KeyUp;
            // 
            // lstProduto
            // 
            lstProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProduto.FormattingEnabled = true;
            lstProduto.ItemHeight = 21;
            lstProduto.Location = new Point(236, 31);
            lstProduto.Name = "lstProduto";
            lstProduto.Size = new Size(206, 319);
            lstProduto.TabIndex = 4;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(167, 5);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(66, 15);
            lblProduto.TabIndex = 7;
            lblProduto.Text = "Produto Id:";
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProduto.Location = new Point(236, 0);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(206, 25);
            txtProduto.TabIndex = 3;
            txtProduto.TextChanged += txtProduto_TextChanged;
            txtProduto.KeyPress += txtProduto_KeyPress;
            txtProduto.KeyUp += txtProduto_KeyUp;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Location = new Point(721, 411);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 25);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar Compra";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtClientes
            // 
            txtClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientes.Location = new Point(3, 47);
            txtClientes.Name = "txtClientes";
            txtClientes.Size = new Size(161, 25);
            txtClientes.TabIndex = 1;
            txtClientes.TextChanged += txtClientes_TextChanged;
            txtClientes.KeyPress += txtClientes_KeyPress;
            txtClientes.KeyUp += txtClientes_KeyUp;
            // 
            // lstClientes
            // 
            lstClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 21;
            lstClientes.Location = new Point(3, 78);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(161, 193);
            lstClientes.TabIndex = 2;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 463);
            Controls.Add(panel1);
            Name = "Venda";
            Text = "Venda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstClientes;
        private TextBox txtClientes;
        private Button btnSalvar;
        private NumericUpDown numQuantidade;
        private ListBox lstProduto;
        private Label lblProduto;
        private TextBox txtProduto;
        private Label lblQuantidade;
        private Label lblValorUnitario;
        private TextBox txtValorUnitario;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnAdicionar;
        private Label lblEstoque;
        private ListBox lstCompras;
        private Label lblDesconto;
        private TextBox txtDesconto;
        private Label lblClientes;
        private Button btnRemover;
        private Button btnCancelar;
        private Label lblParcelas;
        private NumericUpDown numParcelas;
    }
}