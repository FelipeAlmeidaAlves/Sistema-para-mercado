namespace TralhoGumo2.Forms
{
    partial class ComissaoPeriodo
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
            pnlComissao = new Panel();
            lblComissaoDados = new Label();
            lblComissão = new Label();
            lblVendedor = new Label();
            lstVendedor = new ListBox();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicio = new DateTimePicker();
            lblDataFinal = new Label();
            lblDataInicio = new Label();
            pnlComissao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlComissao
            // 
            pnlComissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlComissao.Controls.Add(lblComissaoDados);
            pnlComissao.Controls.Add(lblComissão);
            pnlComissao.Controls.Add(lblVendedor);
            pnlComissao.Controls.Add(lstVendedor);
            pnlComissao.Controls.Add(dtpDataFinal);
            pnlComissao.Controls.Add(dtpDataInicio);
            pnlComissao.Controls.Add(lblDataFinal);
            pnlComissao.Controls.Add(lblDataInicio);
            pnlComissao.Location = new Point(12, 12);
            pnlComissao.Name = "pnlComissao";
            pnlComissao.Size = new Size(496, 157);
            pnlComissao.TabIndex = 0;
            // 
            // lblComissaoDados
            // 
            lblComissaoDados.BackColor = Color.White;
            lblComissaoDados.BorderStyle = BorderStyle.FixedSingle;
            lblComissaoDados.Font = new Font("Segoe UI", 12F);
            lblComissaoDados.Location = new Point(385, 37);
            lblComissaoDados.Name = "lblComissaoDados";
            lblComissaoDados.Size = new Size(111, 23);
            lblComissaoDados.TabIndex = 10;
            // 
            // lblComissão
            // 
            lblComissão.AutoSize = true;
            lblComissão.Font = new Font("Segoe UI", 14F);
            lblComissão.Location = new Point(291, 37);
            lblComissão.Name = "lblComissão";
            lblComissão.Size = new Size(97, 25);
            lblComissão.TabIndex = 9;
            lblComissão.Text = "Comissão:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14F);
            lblVendedor.Location = new Point(148, 9);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(98, 25);
            lblVendedor.TabIndex = 8;
            lblVendedor.Text = "Vendedor:";
            // 
            // lstVendedor
            // 
            lstVendedor.FormattingEnabled = true;
            lstVendedor.ItemHeight = 15;
            lstVendedor.Location = new Point(148, 37);
            lstVendedor.Name = "lstVendedor";
            lstVendedor.Size = new Size(120, 109);
            lstVendedor.TabIndex = 3;
            lstVendedor.SelectedIndexChanged += lstVendedor_SelectedIndexChanged;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(3, 99);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(115, 23);
            dtpDataFinal.TabIndex = 2;
            dtpDataFinal.ValueChanged += dtpDataFinal_ValueChanged;
            dtpDataFinal.KeyUp += dtpDataFinal_KeyUp;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(3, 37);
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
            lblDataFinal.Location = new Point(3, 71);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(56, 25);
            lblDataFinal.TabIndex = 5;
            lblDataFinal.Text = "Final:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 14F);
            lblDataInicio.Location = new Point(3, 9);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(62, 25);
            lblDataInicio.TabIndex = 3;
            lblDataInicio.Text = "Inicio:";
            // 
            // ComissaoPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 181);
            Controls.Add(pnlComissao);
            Name = "ComissaoPeriodo";
            Text = "ComissaoPeriodo";
            pnlComissao.ResumeLayout(false);
            pnlComissao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlComissao;
        private Label lblComissaoDados;
        private Label lblComissão;
        private Label lblVendedor;
        private ListBox lstVendedor;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicio;
        private Label lblDataFinal;
        private Label lblDataInicio;
    }
}