namespace TralhoGumo2
{
    partial class GerenteJanela
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
            pnlGerente = new Panel();
            lblErro = new Label();
            btnFinalizar = new Button();
            lblSenha = new Label();
            lblGmail = new Label();
            txtSenha = new TextBox();
            txtGmail = new TextBox();
            pnlGerente.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGerente
            // 
            pnlGerente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGerente.Controls.Add(lblErro);
            pnlGerente.Controls.Add(btnFinalizar);
            pnlGerente.Controls.Add(lblSenha);
            pnlGerente.Controls.Add(lblGmail);
            pnlGerente.Controls.Add(txtSenha);
            pnlGerente.Controls.Add(txtGmail);
            pnlGerente.Location = new Point(12, 12);
            pnlGerente.Name = "pnlGerente";
            pnlGerente.Size = new Size(290, 243);
            pnlGerente.TabIndex = 0;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.BackColor = Color.Red;
            lblErro.ForeColor = Color.Yellow;
            lblErro.Location = new Point(85, 141);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(202, 15);
            lblErro.TabIndex = 5;
            lblErro.Text = "Os dados fornecidos estão incorretos";
            lblErro.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.AutoSize = true;
            btnFinalizar.Location = new Point(212, 215);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 25);
            btnFinalizar.TabIndex = 2;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(3, 118);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(145, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Digite a senha do Gerente:";
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Location = new Point(3, 69);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(145, 15);
            lblGmail.TabIndex = 2;
            lblGmail.Text = "Digite o gmail do Gerente:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(154, 115);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(133, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(154, 66);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(133, 23);
            txtGmail.TabIndex = 0;
            txtGmail.KeyUp += txtGmail_KeyUp;
            // 
            // GerenteJanela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 267);
            Controls.Add(pnlGerente);
            Name = "GerenteJanela";
            Text = "GerenteJanela";
            pnlGerente.ResumeLayout(false);
            pnlGerente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGerente;
        private Label lblSenha;
        private Label lblGmail;
        private TextBox txtSenha;
        private TextBox txtGmail;
        private Button btnFinalizar;
        private Label lblErro;
    }
}