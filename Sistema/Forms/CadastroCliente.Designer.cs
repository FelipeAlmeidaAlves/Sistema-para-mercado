namespace TralhoGumo2
{
    partial class CadastroCliente
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
            pnlCadastroCliente = new Panel();
            lblClienteSalvo = new Label();
            mskClienteCpf = new MaskedTextBox();
            lblClienteNascimentoAlerta = new Label();
            lblClienteTelefoneAlerta = new Label();
            lblClienteEnderecoAlerta = new Label();
            lblClienteCpfAlerta = new Label();
            lblClienteNomeAlerta = new Label();
            btnClienteSalvar = new Button();
            txtClienteEndereco = new TextBox();
            lblClienteEndereco = new Label();
            txtClienteNome = new TextBox();
            mskClienteTelefone = new MaskedTextBox();
            lblClienteNascimento = new Label();
            dtpClienteNascimento = new DateTimePicker();
            lblClienteTelefone = new Label();
            lblClienteCpf = new Label();
            lblClienteNome = new Label();
            pnlCadastroCliente.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCliente.Controls.Add(lblClienteSalvo);
            pnlCadastroCliente.Controls.Add(mskClienteCpf);
            pnlCadastroCliente.Controls.Add(lblClienteNascimentoAlerta);
            pnlCadastroCliente.Controls.Add(lblClienteTelefoneAlerta);
            pnlCadastroCliente.Controls.Add(lblClienteEnderecoAlerta);
            pnlCadastroCliente.Controls.Add(lblClienteCpfAlerta);
            pnlCadastroCliente.Controls.Add(lblClienteNomeAlerta);
            pnlCadastroCliente.Controls.Add(btnClienteSalvar);
            pnlCadastroCliente.Controls.Add(txtClienteEndereco);
            pnlCadastroCliente.Controls.Add(lblClienteEndereco);
            pnlCadastroCliente.Controls.Add(txtClienteNome);
            pnlCadastroCliente.Controls.Add(mskClienteTelefone);
            pnlCadastroCliente.Controls.Add(lblClienteNascimento);
            pnlCadastroCliente.Controls.Add(dtpClienteNascimento);
            pnlCadastroCliente.Controls.Add(lblClienteTelefone);
            pnlCadastroCliente.Controls.Add(lblClienteCpf);
            pnlCadastroCliente.Controls.Add(lblClienteNome);
            pnlCadastroCliente.Location = new Point(12, 12);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(269, 432);
            pnlCadastroCliente.TabIndex = 0;
            // 
            // lblClienteSalvo
            // 
            lblClienteSalvo.AutoSize = true;
            lblClienteSalvo.BackColor = Color.Green;
            lblClienteSalvo.Font = new Font("Segoe UI", 10F);
            lblClienteSalvo.ForeColor = Color.Blue;
            lblClienteSalvo.Location = new Point(62, 405);
            lblClienteSalvo.Name = "lblClienteSalvo";
            lblClienteSalvo.Size = new Size(122, 19);
            lblClienteSalvo.TabIndex = 16;
            lblClienteSalvo.Text = "Salvo com sucesso";
            lblClienteSalvo.Visible = false;
            // 
            // mskClienteCpf
            // 
            mskClienteCpf.Font = new Font("Segoe UI", 12F);
            mskClienteCpf.Location = new Point(14, 106);
            mskClienteCpf.Mask = "000\\.000\\.000-00";
            mskClienteCpf.Name = "mskClienteCpf";
            mskClienteCpf.Size = new Size(207, 29);
            mskClienteCpf.TabIndex = 2;
            mskClienteCpf.TextChanged += mskClienteCpf_TextChanged;
            mskClienteCpf.KeyUp += mskClienteCpf_KeyUp;
            // 
            // lblClienteNascimentoAlerta
            // 
            lblClienteNascimentoAlerta.AutoSize = true;
            lblClienteNascimentoAlerta.BackColor = Color.Yellow;
            lblClienteNascimentoAlerta.ForeColor = Color.Red;
            lblClienteNascimentoAlerta.Location = new Point(14, 370);
            lblClienteNascimentoAlerta.Name = "lblClienteNascimentoAlerta";
            lblClienteNascimentoAlerta.Size = new Size(158, 15);
            lblClienteNascimentoAlerta.TabIndex = 14;
            lblClienteNascimentoAlerta.Text = "Data de Nascimento Inválida";
            lblClienteNascimentoAlerta.Visible = false;
            // 
            // lblClienteTelefoneAlerta
            // 
            lblClienteTelefoneAlerta.AutoSize = true;
            lblClienteTelefoneAlerta.BackColor = Color.Yellow;
            lblClienteTelefoneAlerta.ForeColor = Color.Red;
            lblClienteTelefoneAlerta.Location = new Point(14, 292);
            lblClienteTelefoneAlerta.Name = "lblClienteTelefoneAlerta";
            lblClienteTelefoneAlerta.Size = new Size(96, 15);
            lblClienteTelefoneAlerta.TabIndex = 13;
            lblClienteTelefoneAlerta.Text = "Telefone Inválido";
            lblClienteTelefoneAlerta.Visible = false;
            // 
            // lblClienteEnderecoAlerta
            // 
            lblClienteEnderecoAlerta.AutoSize = true;
            lblClienteEnderecoAlerta.BackColor = Color.Yellow;
            lblClienteEnderecoAlerta.ForeColor = Color.Red;
            lblClienteEnderecoAlerta.Location = new Point(14, 216);
            lblClienteEnderecoAlerta.Name = "lblClienteEnderecoAlerta";
            lblClienteEnderecoAlerta.Size = new Size(101, 15);
            lblClienteEnderecoAlerta.TabIndex = 12;
            lblClienteEnderecoAlerta.Text = "Endereço Inválido";
            lblClienteEnderecoAlerta.Visible = false;
            // 
            // lblClienteCpfAlerta
            // 
            lblClienteCpfAlerta.AutoSize = true;
            lblClienteCpfAlerta.BackColor = Color.Yellow;
            lblClienteCpfAlerta.ForeColor = Color.Red;
            lblClienteCpfAlerta.Location = new Point(14, 138);
            lblClienteCpfAlerta.Name = "lblClienteCpfAlerta";
            lblClienteCpfAlerta.Size = new Size(73, 15);
            lblClienteCpfAlerta.TabIndex = 11;
            lblClienteCpfAlerta.Text = "CPF Inválido";
            lblClienteCpfAlerta.Visible = false;
            // 
            // lblClienteNomeAlerta
            // 
            lblClienteNomeAlerta.AutoSize = true;
            lblClienteNomeAlerta.BackColor = Color.Yellow;
            lblClienteNomeAlerta.ForeColor = Color.Red;
            lblClienteNomeAlerta.Location = new Point(14, 63);
            lblClienteNomeAlerta.Name = "lblClienteNomeAlerta";
            lblClienteNomeAlerta.Size = new Size(85, 15);
            lblClienteNomeAlerta.TabIndex = 10;
            lblClienteNomeAlerta.Text = "Nome Inválido";
            lblClienteNomeAlerta.Visible = false;
            // 
            // btnClienteSalvar
            // 
            btnClienteSalvar.AutoSize = true;
            btnClienteSalvar.Font = new Font("Segoe UI", 12F);
            btnClienteSalvar.Location = new Point(190, 391);
            btnClienteSalvar.Name = "btnClienteSalvar";
            btnClienteSalvar.Size = new Size(76, 38);
            btnClienteSalvar.TabIndex = 6;
            btnClienteSalvar.Text = "Salvar";
            btnClienteSalvar.UseVisualStyleBackColor = true;
            btnClienteSalvar.Click += btnClienteSalvar_Click;
            // 
            // txtClienteEndereco
            // 
            txtClienteEndereco.Font = new Font("Segoe UI", 12F);
            txtClienteEndereco.Location = new Point(14, 184);
            txtClienteEndereco.Name = "txtClienteEndereco";
            txtClienteEndereco.Size = new Size(207, 29);
            txtClienteEndereco.TabIndex = 3;
            txtClienteEndereco.TextChanged += txtClienteEndereco_TextChanged;
            txtClienteEndereco.KeyUp += txtClienteEndereco_KeyUp;
            // 
            // lblClienteEndereco
            // 
            lblClienteEndereco.AutoSize = true;
            lblClienteEndereco.Font = new Font("Segoe UI", 15F);
            lblClienteEndereco.Location = new Point(3, 151);
            lblClienteEndereco.Name = "lblClienteEndereco";
            lblClienteEndereco.Size = new Size(97, 28);
            lblClienteEndereco.TabIndex = 3;
            lblClienteEndereco.Text = "Endereço:";
            // 
            // txtClienteNome
            // 
            txtClienteNome.Font = new Font("Segoe UI", 12F);
            txtClienteNome.Location = new Point(14, 31);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(207, 29);
            txtClienteNome.TabIndex = 1;
            txtClienteNome.TextChanged += txtClienteNome_TextChanged;
            txtClienteNome.KeyUp += txtClienteNome_KeyUp;
            // 
            // mskClienteTelefone
            // 
            mskClienteTelefone.Font = new Font("Segoe UI", 12F);
            mskClienteTelefone.Location = new Point(14, 259);
            mskClienteTelefone.Mask = "(00) 00000-0000";
            mskClienteTelefone.Name = "mskClienteTelefone";
            mskClienteTelefone.Size = new Size(132, 29);
            mskClienteTelefone.TabIndex = 4;
            mskClienteTelefone.MaskInputRejected += mskClienteTelefone_MaskInputRejected;
            mskClienteTelefone.KeyUp += mskClienteTelefone_KeyUp;
            // 
            // lblClienteNascimento
            // 
            lblClienteNascimento.AutoSize = true;
            lblClienteNascimento.Font = new Font("Segoe UI", 15F);
            lblClienteNascimento.Location = new Point(3, 307);
            lblClienteNascimento.Name = "lblClienteNascimento";
            lblClienteNascimento.Size = new Size(120, 28);
            lblClienteNascimento.TabIndex = 5;
            lblClienteNascimento.Text = "Nascimento:";
            // 
            // dtpClienteNascimento
            // 
            dtpClienteNascimento.CustomFormat = "";
            dtpClienteNascimento.Font = new Font("Segoe UI", 12F);
            dtpClienteNascimento.Format = DateTimePickerFormat.Short;
            dtpClienteNascimento.Location = new Point(14, 338);
            dtpClienteNascimento.Name = "dtpClienteNascimento";
            dtpClienteNascimento.Size = new Size(132, 29);
            dtpClienteNascimento.TabIndex = 5;
            dtpClienteNascimento.ValueChanged += dtpClienteNascimento_ValueChanged;
            dtpClienteNascimento.KeyUp += dtpClienteNascimento_KeyUp;
            // 
            // lblClienteTelefone
            // 
            lblClienteTelefone.AutoSize = true;
            lblClienteTelefone.Font = new Font("Segoe UI", 15F);
            lblClienteTelefone.Location = new Point(3, 228);
            lblClienteTelefone.Name = "lblClienteTelefone";
            lblClienteTelefone.Size = new Size(88, 28);
            lblClienteTelefone.TabIndex = 2;
            lblClienteTelefone.Text = "Telefone:";
            // 
            // lblClienteCpf
            // 
            lblClienteCpf.AutoSize = true;
            lblClienteCpf.Font = new Font("Segoe UI", 15F);
            lblClienteCpf.Location = new Point(3, 75);
            lblClienteCpf.Name = "lblClienteCpf";
            lblClienteCpf.Size = new Size(49, 28);
            lblClienteCpf.TabIndex = 1;
            lblClienteCpf.Text = "CPF:";
            // 
            // lblClienteNome
            // 
            lblClienteNome.AutoSize = true;
            lblClienteNome.Font = new Font("Segoe UI", 15F);
            lblClienteNome.Location = new Point(3, 0);
            lblClienteNome.Name = "lblClienteNome";
            lblClienteNome.Size = new Size(70, 28);
            lblClienteNome.TabIndex = 0;
            lblClienteNome.Text = "Nome:";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 456);
            Controls.Add(pnlCadastroCliente);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            FormClosing += CadastroCliente_FormClosing;
            Load += CadastroCliente_Load;
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroCliente;
        private Label lblClienteEndereco;
        private Label lblClienteTelefone;
        private Label lblClienteCpf;
        private Label lblClienteNome;
        private TextBox txtClienteNome;
        private MaskedTextBox mskClienteTelefone;
        private Label lblClienteNascimento;
        private DateTimePicker dtpClienteNascimento;
        private TextBox txtClienteEndereco;
        private Button btnClienteSalvar;
        private Label lblClienteNomeAlerta;
        private Label lblClienteTelefoneAlerta;
        private Label lblClienteEnderecoAlerta;
        private Label lblClienteCpfAlerta;
        private Label lblClienteNascimentoAlerta;
        private MaskedTextBox mskClienteCpf;
        private Label lblClienteSalvo;
    }
}