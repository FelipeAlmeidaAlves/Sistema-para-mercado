namespace TralhoGumo2
{
    partial class CadastroVendedor
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
            lblVendedorSalvo = new Label();
            lblVendedorPerfilAlerta = new Label();
            lblVendedorRepetirSenhaAlerta = new Label();
            lblVendedorSenhaAlerta = new Label();
            lblVendedorTelefoneAlerta = new Label();
            lblVendedorEmailAlerta = new Label();
            lblVendedorNomeAlerta = new Label();
            grpVendedorPerfil = new GroupBox();
            rdbOperador = new RadioButton();
            rdbGerente = new RadioButton();
            rdbVendedor = new RadioButton();
            btnSalvar = new Button();
            lblPerfil = new Label();
            txtSenha2 = new TextBox();
            lblSenha2 = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mskTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panel1.SuspendLayout();
            grpVendedorPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblVendedorSalvo);
            panel1.Controls.Add(lblVendedorPerfilAlerta);
            panel1.Controls.Add(lblVendedorRepetirSenhaAlerta);
            panel1.Controls.Add(lblVendedorSenhaAlerta);
            panel1.Controls.Add(lblVendedorTelefoneAlerta);
            panel1.Controls.Add(lblVendedorEmailAlerta);
            panel1.Controls.Add(lblVendedorNomeAlerta);
            panel1.Controls.Add(grpVendedorPerfil);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(lblPerfil);
            panel1.Controls.Add(txtSenha2);
            panel1.Controls.Add(lblSenha2);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(mskTelefone);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 416);
            panel1.TabIndex = 0;
            // 
            // lblVendedorSalvo
            // 
            lblVendedorSalvo.AutoSize = true;
            lblVendedorSalvo.BackColor = Color.Green;
            lblVendedorSalvo.Font = new Font("Segoe UI", 10F);
            lblVendedorSalvo.ForeColor = Color.Blue;
            lblVendedorSalvo.Location = new Point(194, 390);
            lblVendedorSalvo.Name = "lblVendedorSalvo";
            lblVendedorSalvo.Size = new Size(122, 19);
            lblVendedorSalvo.TabIndex = 22;
            lblVendedorSalvo.Text = "Salvo com sucesso";
            lblVendedorSalvo.Visible = false;
            // 
            // lblVendedorPerfilAlerta
            // 
            lblVendedorPerfilAlerta.AutoSize = true;
            lblVendedorPerfilAlerta.BackColor = Color.Yellow;
            lblVendedorPerfilAlerta.ForeColor = Color.Red;
            lblVendedorPerfilAlerta.Location = new Point(253, 134);
            lblVendedorPerfilAlerta.Name = "lblVendedorPerfilAlerta";
            lblVendedorPerfilAlerta.Size = new Size(79, 15);
            lblVendedorPerfilAlerta.TabIndex = 21;
            lblVendedorPerfilAlerta.Text = "Perfil Inválido";
            lblVendedorPerfilAlerta.Visible = false;
            // 
            // lblVendedorRepetirSenhaAlerta
            // 
            lblVendedorRepetirSenhaAlerta.AutoSize = true;
            lblVendedorRepetirSenhaAlerta.BackColor = Color.Yellow;
            lblVendedorRepetirSenhaAlerta.ForeColor = Color.Red;
            lblVendedorRepetirSenhaAlerta.Location = new Point(23, 379);
            lblVendedorRepetirSenhaAlerta.Name = "lblVendedorRepetirSenhaAlerta";
            lblVendedorRepetirSenhaAlerta.Size = new Size(149, 15);
            lblVendedorRepetirSenhaAlerta.TabIndex = 20;
            lblVendedorRepetirSenhaAlerta.Text = "Senha diferente na anterior";
            lblVendedorRepetirSenhaAlerta.Visible = false;
            // 
            // lblVendedorSenhaAlerta
            // 
            lblVendedorSenhaAlerta.AutoSize = true;
            lblVendedorSenhaAlerta.BackColor = Color.Yellow;
            lblVendedorSenhaAlerta.ForeColor = Color.Red;
            lblVendedorSenhaAlerta.Location = new Point(23, 303);
            lblVendedorSenhaAlerta.Name = "lblVendedorSenhaAlerta";
            lblVendedorSenhaAlerta.Size = new Size(83, 15);
            lblVendedorSenhaAlerta.TabIndex = 19;
            lblVendedorSenhaAlerta.Text = "Senha Inválida";
            lblVendedorSenhaAlerta.Visible = false;
            // 
            // lblVendedorTelefoneAlerta
            // 
            lblVendedorTelefoneAlerta.AutoSize = true;
            lblVendedorTelefoneAlerta.BackColor = Color.Yellow;
            lblVendedorTelefoneAlerta.ForeColor = Color.Red;
            lblVendedorTelefoneAlerta.Location = new Point(23, 226);
            lblVendedorTelefoneAlerta.Name = "lblVendedorTelefoneAlerta";
            lblVendedorTelefoneAlerta.Size = new Size(96, 15);
            lblVendedorTelefoneAlerta.TabIndex = 18;
            lblVendedorTelefoneAlerta.Text = "Telefone Inválido";
            lblVendedorTelefoneAlerta.Visible = false;
            // 
            // lblVendedorEmailAlerta
            // 
            lblVendedorEmailAlerta.AutoSize = true;
            lblVendedorEmailAlerta.BackColor = Color.Yellow;
            lblVendedorEmailAlerta.ForeColor = Color.Red;
            lblVendedorEmailAlerta.Location = new Point(23, 150);
            lblVendedorEmailAlerta.Name = "lblVendedorEmailAlerta";
            lblVendedorEmailAlerta.Size = new Size(81, 15);
            lblVendedorEmailAlerta.TabIndex = 17;
            lblVendedorEmailAlerta.Text = "Email Inválido";
            lblVendedorEmailAlerta.Visible = false;
            // 
            // lblVendedorNomeAlerta
            // 
            lblVendedorNomeAlerta.AutoSize = true;
            lblVendedorNomeAlerta.BackColor = Color.Yellow;
            lblVendedorNomeAlerta.ForeColor = Color.Red;
            lblVendedorNomeAlerta.Location = new Point(23, 63);
            lblVendedorNomeAlerta.Name = "lblVendedorNomeAlerta";
            lblVendedorNomeAlerta.Size = new Size(85, 15);
            lblVendedorNomeAlerta.TabIndex = 16;
            lblVendedorNomeAlerta.Text = "Nome Inválido";
            lblVendedorNomeAlerta.Visible = false;
            // 
            // grpVendedorPerfil
            // 
            grpVendedorPerfil.Controls.Add(rdbOperador);
            grpVendedorPerfil.Controls.Add(rdbGerente);
            grpVendedorPerfil.Controls.Add(rdbVendedor);
            grpVendedorPerfil.Location = new Point(253, 31);
            grpVendedorPerfil.Name = "grpVendedorPerfil";
            grpVendedorPerfil.Size = new Size(133, 100);
            grpVendedorPerfil.TabIndex = 6;
            grpVendedorPerfil.TabStop = false;
            // 
            // rdbOperador
            // 
            rdbOperador.AutoSize = true;
            rdbOperador.Location = new Point(6, 44);
            rdbOperador.Name = "rdbOperador";
            rdbOperador.Size = new Size(75, 19);
            rdbOperador.TabIndex = 8;
            rdbOperador.TabStop = true;
            rdbOperador.Text = "Operador";
            rdbOperador.UseVisualStyleBackColor = true;
            // 
            // rdbGerente
            // 
            rdbGerente.AutoSize = true;
            rdbGerente.Location = new Point(6, 19);
            rdbGerente.Name = "rdbGerente";
            rdbGerente.Size = new Size(66, 19);
            rdbGerente.TabIndex = 7;
            rdbGerente.TabStop = true;
            rdbGerente.Text = "Gerente";
            rdbGerente.UseVisualStyleBackColor = true;
            // 
            // rdbVendedor
            // 
            rdbVendedor.AutoSize = true;
            rdbVendedor.Location = new Point(6, 69);
            rdbVendedor.Name = "rdbVendedor";
            rdbVendedor.Size = new Size(75, 19);
            rdbVendedor.TabIndex = 9;
            rdbVendedor.TabStop = true;
            rdbVendedor.Text = "Vendedor";
            rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(322, 382);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerfil.Location = new Point(243, 0);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(59, 28);
            lblPerfil.TabIndex = 13;
            lblPerfil.Text = "Perfil:";
            // 
            // txtSenha2
            // 
            txtSenha2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha2.Location = new Point(23, 347);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.PasswordChar = '*';
            txtSenha2.Size = new Size(212, 29);
            txtSenha2.TabIndex = 5;
            txtSenha2.KeyUp += txtSenha2_KeyUp;
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha2.Location = new Point(3, 316);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(144, 28);
            lblSenha2.TabIndex = 8;
            lblSenha2.Text = "Repita a Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(23, 271);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(212, 29);
            txtSenha.TabIndex = 4;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(3, 240);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(142, 28);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Digite a Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(23, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 34);
            txtEmail.TabIndex = 2;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(3, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefone.Location = new Point(23, 194);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(133, 29);
            mskTelefone.TabIndex = 3;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(3, 163);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(88, 28);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(23, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(212, 29);
            txtNome.TabIndex = 1;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(3, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // CadastroVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 440);
            Controls.Add(panel1);
            Name = "CadastroVendedor";
            Text = "CadastroVendedor";
            FormClosing += CadastroVendedor_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpVendedorPerfil.ResumeLayout(false);
            grpVendedorPerfil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskTelefone;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha2;
        private Label lblSenha2;
        private TextBox txtSenha;
        private Label lblSenha;
        private RadioButton rdbVendedor;
        private RadioButton rdbOperador;
        private RadioButton rdbGerente;
        private Label lblPerfil;
        private Button btnSalvar;
        private GroupBox grpVendedorPerfil;
        private Label lblVendedorNomeAlerta;
        private Label lblVendedorRepetirSenhaAlerta;
        private Label lblVendedorSenhaAlerta;
        private Label lblVendedorTelefoneAlerta;
        private Label lblVendedorEmailAlerta;
        private Label lblVendedorPerfilAlerta;
        private Label lblVendedorSalvo;
    }
}