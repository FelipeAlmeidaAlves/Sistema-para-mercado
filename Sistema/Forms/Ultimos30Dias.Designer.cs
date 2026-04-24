namespace TralhoGumo2.Forms
{
    partial class Ultimos30Dias
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
            pnl30 = new Panel();
            lblEstadoDados = new Label();
            lblEstado = new Label();
            lblEfetivacaoDados = new Label();
            lblClienteDados = new Label();
            lblVendedorDados = new Label();
            lblEfetivacao = new Label();
            lblCliente = new Label();
            lblVendedor = new Label();
            lstCompra = new ListBox();
            pnl30.SuspendLayout();
            SuspendLayout();
            // 
            // pnl30
            // 
            pnl30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl30.Controls.Add(lblEstadoDados);
            pnl30.Controls.Add(lblEstado);
            pnl30.Controls.Add(lblEfetivacaoDados);
            pnl30.Controls.Add(lblClienteDados);
            pnl30.Controls.Add(lblVendedorDados);
            pnl30.Controls.Add(lblEfetivacao);
            pnl30.Controls.Add(lblCliente);
            pnl30.Controls.Add(lblVendedor);
            pnl30.Controls.Add(lstCompra);
            pnl30.Location = new Point(12, 12);
            pnl30.Name = "pnl30";
            pnl30.Size = new Size(451, 160);
            pnl30.TabIndex = 0;
            // 
            // lblEstadoDados
            // 
            lblEstadoDados.BackColor = Color.White;
            lblEstadoDados.BorderStyle = BorderStyle.FixedSingle;
            lblEstadoDados.Font = new Font("Segoe UI", 12F);
            lblEstadoDados.Location = new Point(295, 101);
            lblEstadoDados.Name = "lblEstadoDados";
            lblEstadoDados.Size = new Size(123, 23);
            lblEstadoDados.TabIndex = 20;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14F);
            lblEstado.Location = new Point(226, 99);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 25);
            lblEstado.TabIndex = 19;
            lblEstado.Text = "Estado:";
            // 
            // lblEfetivacaoDados
            // 
            lblEfetivacaoDados.BackColor = Color.White;
            lblEfetivacaoDados.BorderStyle = BorderStyle.FixedSingle;
            lblEfetivacaoDados.Font = new Font("Segoe UI", 12F);
            lblEfetivacaoDados.Location = new Point(295, 69);
            lblEfetivacaoDados.Name = "lblEfetivacaoDados";
            lblEfetivacaoDados.Size = new Size(123, 23);
            lblEfetivacaoDados.TabIndex = 18;
            // 
            // lblClienteDados
            // 
            lblClienteDados.BackColor = Color.White;
            lblClienteDados.BorderStyle = BorderStyle.FixedSingle;
            lblClienteDados.Font = new Font("Segoe UI", 12F);
            lblClienteDados.Location = new Point(295, 41);
            lblClienteDados.Name = "lblClienteDados";
            lblClienteDados.Size = new Size(123, 23);
            lblClienteDados.TabIndex = 17;
            // 
            // lblVendedorDados
            // 
            lblVendedorDados.BackColor = Color.White;
            lblVendedorDados.BorderStyle = BorderStyle.FixedSingle;
            lblVendedorDados.Font = new Font("Segoe UI", 12F);
            lblVendedorDados.Location = new Point(295, 13);
            lblVendedorDados.Name = "lblVendedorDados";
            lblVendedorDados.Size = new Size(123, 23);
            lblVendedorDados.TabIndex = 16;
            // 
            // lblEfetivacao
            // 
            lblEfetivacao.AutoSize = true;
            lblEfetivacao.Font = new Font("Segoe UI", 14F);
            lblEfetivacao.Location = new Point(196, 67);
            lblEfetivacao.Name = "lblEfetivacao";
            lblEfetivacao.Size = new Size(102, 25);
            lblEfetivacao.TabIndex = 15;
            lblEfetivacao.Text = "Efetivação:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14F);
            lblCliente.Location = new Point(223, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(75, 25);
            lblCliente.TabIndex = 14;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14F);
            lblVendedor.Location = new Point(200, 11);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(98, 25);
            lblVendedor.TabIndex = 13;
            lblVendedor.Text = "Vendedor:";
            // 
            // lstCompra
            // 
            lstCompra.FormattingEnabled = true;
            lstCompra.ItemHeight = 15;
            lstCompra.Location = new Point(3, 3);
            lstCompra.Name = "lstCompra";
            lstCompra.Size = new Size(181, 154);
            lstCompra.TabIndex = 1;
            lstCompra.SelectedIndexChanged += lstCompra_SelectedIndexChanged;
            // 
            // Ultimos30Dias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 184);
            Controls.Add(pnl30);
            Name = "Ultimos30Dias";
            Text = "Ultimos30Dias";
            pnl30.ResumeLayout(false);
            pnl30.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl30;
        private ListBox lstCompra;
        private Label lblEstadoDados;
        private Label lblEstado;
        private Label lblEfetivacaoDados;
        private Label lblClienteDados;
        private Label lblVendedorDados;
        private Label lblEfetivacao;
        private Label lblCliente;
        private Label lblVendedor;
    }
}