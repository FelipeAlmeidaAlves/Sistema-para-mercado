namespace TralhoGumo2.Forms
{
    partial class TotalPeriodo
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
            lblEstadoDados = new Label();
            lblEstado = new Label();
            lblEfetivacaoDados = new Label();
            lblClienteDados = new Label();
            lblVendedorDados = new Label();
            lblEfetivacao = new Label();
            lblCliente = new Label();
            lblVendedor = new Label();
            lblCompras = new Label();
            lstCompras = new ListBox();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicio = new DateTimePicker();
            lblDataFinal = new Label();
            lblDataInicio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblEstadoDados);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(lblEfetivacaoDados);
            panel1.Controls.Add(lblClienteDados);
            panel1.Controls.Add(lblVendedorDados);
            panel1.Controls.Add(lblEfetivacao);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblVendedor);
            panel1.Controls.Add(lblCompras);
            panel1.Controls.Add(lstCompras);
            panel1.Controls.Add(dtpDataFinal);
            panel1.Controls.Add(dtpDataInicio);
            panel1.Controls.Add(lblDataFinal);
            panel1.Controls.Add(lblDataInicio);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 224);
            panel1.TabIndex = 0;
            // 
            // lblEstadoDados
            // 
            lblEstadoDados.BackColor = Color.White;
            lblEstadoDados.BorderStyle = BorderStyle.FixedSingle;
            lblEstadoDados.Font = new Font("Segoe UI", 12F);
            lblEstadoDados.Location = new Point(479, 126);
            lblEstadoDados.Name = "lblEstadoDados";
            lblEstadoDados.Size = new Size(123, 23);
            lblEstadoDados.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14F);
            lblEstado.Location = new Point(410, 124);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 25);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            // 
            // lblEfetivacaoDados
            // 
            lblEfetivacaoDados.BackColor = Color.White;
            lblEfetivacaoDados.BorderStyle = BorderStyle.FixedSingle;
            lblEfetivacaoDados.Font = new Font("Segoe UI", 12F);
            lblEfetivacaoDados.Location = new Point(479, 94);
            lblEfetivacaoDados.Name = "lblEfetivacaoDados";
            lblEfetivacaoDados.Size = new Size(123, 23);
            lblEfetivacaoDados.TabIndex = 10;
            // 
            // lblClienteDados
            // 
            lblClienteDados.BackColor = Color.White;
            lblClienteDados.BorderStyle = BorderStyle.FixedSingle;
            lblClienteDados.Font = new Font("Segoe UI", 12F);
            lblClienteDados.Location = new Point(479, 66);
            lblClienteDados.Name = "lblClienteDados";
            lblClienteDados.Size = new Size(123, 23);
            lblClienteDados.TabIndex = 9;
            // 
            // lblVendedorDados
            // 
            lblVendedorDados.BackColor = Color.White;
            lblVendedorDados.BorderStyle = BorderStyle.FixedSingle;
            lblVendedorDados.Font = new Font("Segoe UI", 12F);
            lblVendedorDados.Location = new Point(479, 38);
            lblVendedorDados.Name = "lblVendedorDados";
            lblVendedorDados.Size = new Size(123, 23);
            lblVendedorDados.TabIndex = 8;
            // 
            // lblEfetivacao
            // 
            lblEfetivacao.AutoSize = true;
            lblEfetivacao.Font = new Font("Segoe UI", 14F);
            lblEfetivacao.Location = new Point(380, 92);
            lblEfetivacao.Name = "lblEfetivacao";
            lblEfetivacao.Size = new Size(102, 25);
            lblEfetivacao.TabIndex = 7;
            lblEfetivacao.Text = "Efetivação:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14F);
            lblCliente.Location = new Point(407, 64);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(75, 25);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente:";
            lblCliente.Click += lblCliente_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14F);
            lblVendedor.Location = new Point(384, 36);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(98, 25);
            lblVendedor.TabIndex = 5;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Segoe UI", 14F);
            lblCompras.Location = new Point(156, 10);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(77, 25);
            lblCompras.TabIndex = 4;
            lblCompras.Text = "Vendas:";
            // 
            // lstCompras
            // 
            lstCompras.FormattingEnabled = true;
            lstCompras.ItemHeight = 15;
            lstCompras.Location = new Point(156, 38);
            lstCompras.Name = "lstCompras";
            lstCompras.Size = new Size(184, 184);
            lstCompras.TabIndex = 3;
            lstCompras.SelectedIndexChanged += lstCompras_SelectedIndexChanged;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(3, 100);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(115, 23);
            dtpDataFinal.TabIndex = 2;
            dtpDataFinal.ValueChanged += dtpDataFinal_ValueChanged;
            dtpDataFinal.KeyUp += dtpDataFinal_KeyUp;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(3, 38);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(115, 23);
            dtpDataInicio.TabIndex = 1;
            dtpDataInicio.ValueChanged += dtpDataInicio_ValueChanged;
            dtpDataInicio.KeyUp += dtpDataInicio_KeyUp;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Font = new Font("Segoe UI", 14F);
            lblDataFinal.Location = new Point(3, 72);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(56, 25);
            lblDataFinal.TabIndex = 1;
            lblDataFinal.Text = "Final:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 14F);
            lblDataInicio.Location = new Point(3, 10);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(62, 25);
            lblDataInicio.TabIndex = 0;
            lblDataInicio.Text = "Inicio:";
            // 
            // TotalPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 248);
            Controls.Add(panel1);
            Name = "TotalPeriodo";
            Text = "TotalPeriodo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDataFinal;
        private Label lblDataInicio;
        private Label lblCompras;
        private ListBox lstCompras;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicio;
        private Label lblCliente;
        private Label lblVendedor;
        private Label lblEfetivacao;
        private Label lblEfetivacaoDados;
        private Label lblClienteDados;
        private Label lblVendedorDados;
        private Label lblEstadoDados;
        private Label lblEstado;
    }
}