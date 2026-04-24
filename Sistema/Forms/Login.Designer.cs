namespace TralhoGumo2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPrincipal = new Panel();
            lblAlerta = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblSenha);
            pnlPrincipal.Controls.Add(lblUsuario);
            pnlPrincipal.Controls.Add(lblAlerta);
            pnlPrincipal.Controls.Add(txtSenha);
            pnlPrincipal.Controls.Add(txtLogin);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(442, 204);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.BackColor = Color.Yellow;
            lblAlerta.Font = new Font("Segoe UI", 15F);
            lblAlerta.ForeColor = Color.Red;
            lblAlerta.Location = new Point(204, 154);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(165, 28);
            lblAlerta.TabIndex = 4;
            lblAlerta.Text = "Dados incorretos.";
            lblAlerta.Visible = false;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 25F);
            txtSenha.Location = new Point(123, 89);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(300, 52);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "admin";
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 25F);
            txtLogin.Location = new Point(123, 27);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(300, 52);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "admin@admin";
            txtLogin.TextChanged += txtLogin_TextChanged;
            txtLogin.KeyUp += txtLogin_KeyUp;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 20F);
            lblUsuario.Location = new Point(3, 42);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(114, 37);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 20F);
            lblSenha.Location = new Point(22, 104);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(95, 37);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 228);
            Controls.Add(pnlPrincipal);
            Name = "Login";
            Text = "Login";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblAlerta;
        private Label lblSenha;
        private Label lblUsuario;
    }
}
