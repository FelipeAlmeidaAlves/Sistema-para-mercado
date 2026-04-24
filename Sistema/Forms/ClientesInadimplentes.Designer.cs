namespace TralhoGumo2.Forms
{
    partial class ClientesInadimplentes
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
            lblErro = new Label();
            btnEncontrarCliente = new Button();
            lstClientesInadimplestes = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblErro);
            panel1.Controls.Add(btnEncontrarCliente);
            panel1.Controls.Add(lstClientesInadimplestes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 293);
            panel1.TabIndex = 0;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.BackColor = Color.Yellow;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(29, 272);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(118, 15);
            lblErro.TabIndex = 3;
            lblErro.Text = "Selecione um Cliente";
            lblErro.Visible = false;
            // 
            // btnEncontrarCliente
            // 
            btnEncontrarCliente.AutoSize = true;
            btnEncontrarCliente.Font = new Font("Segoe UI", 12F);
            btnEncontrarCliente.Location = new Point(19, 238);
            btnEncontrarCliente.Name = "btnEncontrarCliente";
            btnEncontrarCliente.Size = new Size(139, 31);
            btnEncontrarCliente.TabIndex = 2;
            btnEncontrarCliente.Text = "Encontrar Cliente";
            btnEncontrarCliente.UseVisualStyleBackColor = true;
            btnEncontrarCliente.Click += btnEncontrarCliente_Click;
            // 
            // lstClientesInadimplestes
            // 
            lstClientesInadimplestes.FormattingEnabled = true;
            lstClientesInadimplestes.ItemHeight = 15;
            lstClientesInadimplestes.Location = new Point(3, 3);
            lstClientesInadimplestes.Name = "lstClientesInadimplestes";
            lstClientesInadimplestes.Size = new Size(174, 229);
            lstClientesInadimplestes.TabIndex = 1;
            lstClientesInadimplestes.KeyUp += lstClientesInadimplestes_KeyUp;
            // 
            // ClientesInadimplentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 317);
            Controls.Add(panel1);
            Name = "ClientesInadimplentes";
            Text = "ClientesInadimplentes";
            Load += ClientesInadimplentes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstClientesInadimplestes;
        private Button btnEncontrarCliente;
        private Label lblErro;
    }
}