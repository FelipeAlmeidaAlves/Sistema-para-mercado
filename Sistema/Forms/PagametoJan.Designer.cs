namespace TralhoGumo2.Forms
{
    partial class PagametoJan
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
            pnlPagamento = new Panel();
            lblPagou = new Label();
            btnPagou = new Button();
            lblPagamentoPagamento = new Label();
            cboPagamento = new ComboBox();
            cboPagamentoCompra = new ComboBox();
            lblPagamentoCliente = new Label();
            lblPagamentoCompra = new Label();
            lstPagamentoCliente = new ListBox();
            txtPagamentoCliente = new TextBox();
            pnlPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPagamento
            // 
            pnlPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPagamento.Controls.Add(lblPagou);
            pnlPagamento.Controls.Add(btnPagou);
            pnlPagamento.Controls.Add(lblPagamentoPagamento);
            pnlPagamento.Controls.Add(cboPagamento);
            pnlPagamento.Controls.Add(cboPagamentoCompra);
            pnlPagamento.Controls.Add(lblPagamentoCliente);
            pnlPagamento.Controls.Add(lblPagamentoCompra);
            pnlPagamento.Controls.Add(lstPagamentoCliente);
            pnlPagamento.Controls.Add(txtPagamentoCliente);
            pnlPagamento.Location = new Point(12, 12);
            pnlPagamento.Name = "pnlPagamento";
            pnlPagamento.Size = new Size(776, 426);
            pnlPagamento.TabIndex = 0;
            // 
            // lblPagou
            // 
            lblPagou.AutoSize = true;
            lblPagou.Location = new Point(478, 59);
            lblPagou.Name = "lblPagou";
            lblPagou.Size = new Size(177, 15);
            lblPagou.TabIndex = 10;
            lblPagou.Text = "Caso usuario tenha pago aperte:";
            // 
            // btnPagou
            // 
            btnPagou.Location = new Point(478, 77);
            btnPagou.Name = "btnPagou";
            btnPagou.Size = new Size(75, 23);
            btnPagou.TabIndex = 5;
            btnPagou.Text = "Pago";
            btnPagou.UseVisualStyleBackColor = true;
            btnPagou.Click += btnPagou_Click;
            // 
            // lblPagamentoPagamento
            // 
            lblPagamentoPagamento.AutoSize = true;
            lblPagamentoPagamento.Location = new Point(478, 7);
            lblPagamentoPagamento.Name = "lblPagamentoPagamento";
            lblPagamentoPagamento.Size = new Size(71, 15);
            lblPagamentoPagamento.TabIndex = 8;
            lblPagamentoPagamento.Text = "Pagamento:";
            // 
            // cboPagamento
            // 
            cboPagamento.FormattingEnabled = true;
            cboPagamento.Location = new Point(478, 25);
            cboPagamento.Name = "cboPagamento";
            cboPagamento.Size = new Size(197, 23);
            cboPagamento.TabIndex = 4;
            cboPagamento.KeyUp += cboPagamento_KeyUp;
            // 
            // cboPagamentoCompra
            // 
            cboPagamentoCompra.FormattingEnabled = true;
            cboPagamentoCompra.Location = new Point(193, 25);
            cboPagamentoCompra.Name = "cboPagamentoCompra";
            cboPagamentoCompra.Size = new Size(279, 23);
            cboPagamentoCompra.TabIndex = 3;
            cboPagamentoCompra.SelectedIndexChanged += cboPagamentoCompra_SelectedIndexChanged;
            cboPagamentoCompra.KeyUp += cboPagamentoCompra_KeyUp;
            // 
            // lblPagamentoCliente
            // 
            lblPagamentoCliente.AutoSize = true;
            lblPagamentoCliente.Location = new Point(3, 7);
            lblPagamentoCliente.Name = "lblPagamentoCliente";
            lblPagamentoCliente.Size = new Size(47, 15);
            lblPagamentoCliente.TabIndex = 5;
            lblPagamentoCliente.Text = "Cliente:";
            // 
            // lblPagamentoCompra
            // 
            lblPagamentoCompra.AutoSize = true;
            lblPagamentoCompra.Location = new Point(193, 7);
            lblPagamentoCompra.Name = "lblPagamentoCompra";
            lblPagamentoCompra.Size = new Size(53, 15);
            lblPagamentoCompra.TabIndex = 4;
            lblPagamentoCompra.Text = "Compra:";
            // 
            // lstPagamentoCliente
            // 
            lstPagamentoCliente.FormattingEnabled = true;
            lstPagamentoCliente.ItemHeight = 15;
            lstPagamentoCliente.Location = new Point(3, 47);
            lstPagamentoCliente.Name = "lstPagamentoCliente";
            lstPagamentoCliente.Size = new Size(143, 154);
            lstPagamentoCliente.TabIndex = 2;
            lstPagamentoCliente.Click += lstPagamentoCliente_Click;
            lstPagamentoCliente.KeyUp += lstPagamentoCliente_KeyUp;
            // 
            // txtPagamentoCliente
            // 
            txtPagamentoCliente.Location = new Point(3, 25);
            txtPagamentoCliente.Name = "txtPagamentoCliente";
            txtPagamentoCliente.Size = new Size(143, 23);
            txtPagamentoCliente.TabIndex = 1;
            txtPagamentoCliente.TextChanged += txtPagamentoCliente_TextChanged;
            txtPagamentoCliente.KeyUp += txtPagamentoCliente_KeyUp;
            // 
            // PagametoJan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPagamento);
            Name = "PagametoJan";
            Text = "PagametoJan";
            pnlPagamento.ResumeLayout(false);
            pnlPagamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPagamento;
        private ListBox lstPagamentoCliente;
        private TextBox txtPagamentoCliente;
        private ComboBox cboPagamentoCompra;
        private Label lblPagamentoCliente;
        private Label lblPagamentoCompra;
        private Label lblPagamentoPagamento;
        private ComboBox cboPagamento;
        private Label lblPagou;
        private Button btnPagou;
    }
}