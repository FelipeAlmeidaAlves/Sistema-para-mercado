namespace TralhoGumo2
{
    partial class RelatorioCliente
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
            pnlRelatorioCliente = new Panel();
            txtRelatorioClientes = new TextBox();
            pnlRelatorioClienteDados = new Panel();
            lblRelatorioClienteBotoesAlerta = new Label();
            btnRelatorioClienteAtualizarLista = new Button();
            btnRelatorioClienteDeletar = new Button();
            btnRelatorioClienteAtualizar = new Button();
            lblRelatorioClienteIdadeDados = new Label();
            lblRelatorioClienteTelefoneDados = new Label();
            lblRelatorioClienteCpfDados = new Label();
            lblRelatorioClienteNomeDados = new Label();
            lblRelatorioClienteIdade = new Label();
            lblRelatorioClienteTelefone = new Label();
            lblRelatorioClienteCpf = new Label();
            lblRelatorioClienteNome = new Label();
            lstRelatorioClientes = new ListBox();
            pnlRelatorioCliente.SuspendLayout();
            pnlRelatorioClienteDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRelatorioCliente
            // 
            pnlRelatorioCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioCliente.Controls.Add(txtRelatorioClientes);
            pnlRelatorioCliente.Controls.Add(pnlRelatorioClienteDados);
            pnlRelatorioCliente.Controls.Add(lstRelatorioClientes);
            pnlRelatorioCliente.Location = new Point(12, 12);
            pnlRelatorioCliente.Name = "pnlRelatorioCliente";
            pnlRelatorioCliente.Size = new Size(523, 204);
            pnlRelatorioCliente.TabIndex = 0;
            // 
            // txtRelatorioClientes
            // 
            txtRelatorioClientes.Location = new Point(3, 3);
            txtRelatorioClientes.Name = "txtRelatorioClientes";
            txtRelatorioClientes.Size = new Size(170, 23);
            txtRelatorioClientes.TabIndex = 1;
            txtRelatorioClientes.TextChanged += txtRelatorioClientes_TextChanged;
            // 
            // pnlRelatorioClienteDados
            // 
            pnlRelatorioClienteDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioClienteDados.BackColor = Color.WhiteSmoke;
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteBotoesAlerta);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioClienteAtualizarLista);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioClienteDeletar);
            pnlRelatorioClienteDados.Controls.Add(btnRelatorioClienteAtualizar);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteIdadeDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteTelefoneDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteCpfDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteNomeDados);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteIdade);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteTelefone);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteCpf);
            pnlRelatorioClienteDados.Controls.Add(lblRelatorioClienteNome);
            pnlRelatorioClienteDados.Location = new Point(194, 0);
            pnlRelatorioClienteDados.Name = "pnlRelatorioClienteDados";
            pnlRelatorioClienteDados.Size = new Size(329, 203);
            pnlRelatorioClienteDados.TabIndex = 1;
            pnlRelatorioClienteDados.Paint += panel1_Paint;
            // 
            // lblRelatorioClienteBotoesAlerta
            // 
            lblRelatorioClienteBotoesAlerta.AutoSize = true;
            lblRelatorioClienteBotoesAlerta.BackColor = Color.Yellow;
            lblRelatorioClienteBotoesAlerta.Font = new Font("Segoe UI", 9F);
            lblRelatorioClienteBotoesAlerta.ForeColor = Color.Red;
            lblRelatorioClienteBotoesAlerta.Location = new Point(69, 185);
            lblRelatorioClienteBotoesAlerta.Name = "lblRelatorioClienteBotoesAlerta";
            lblRelatorioClienteBotoesAlerta.Size = new Size(89, 15);
            lblRelatorioClienteBotoesAlerta.TabIndex = 11;
            lblRelatorioClienteBotoesAlerta.Text = "Cliente Inválido";
            lblRelatorioClienteBotoesAlerta.Visible = false;
            // 
            // btnRelatorioClienteAtualizarLista
            // 
            btnRelatorioClienteAtualizarLista.AutoSize = true;
            btnRelatorioClienteAtualizarLista.BackColor = Color.Transparent;
            btnRelatorioClienteAtualizarLista.Font = new Font("Segoe UI", 14F);
            btnRelatorioClienteAtualizarLista.ForeColor = SystemColors.ControlText;
            btnRelatorioClienteAtualizarLista.Location = new Point(5, 165);
            btnRelatorioClienteAtualizarLista.Name = "btnRelatorioClienteAtualizarLista";
            btnRelatorioClienteAtualizarLista.Size = new Size(43, 35);
            btnRelatorioClienteAtualizarLista.TabIndex = 3;
            btnRelatorioClienteAtualizarLista.Text = "🔄";
            btnRelatorioClienteAtualizarLista.UseVisualStyleBackColor = false;
            btnRelatorioClienteAtualizarLista.Click += btnRelatorioClienteAtualizarLista_Click;
            // 
            // btnRelatorioClienteDeletar
            // 
            btnRelatorioClienteDeletar.AutoSize = true;
            btnRelatorioClienteDeletar.Font = new Font("Segoe UI", 12F);
            btnRelatorioClienteDeletar.Location = new Point(251, 169);
            btnRelatorioClienteDeletar.Name = "btnRelatorioClienteDeletar";
            btnRelatorioClienteDeletar.Size = new Size(75, 31);
            btnRelatorioClienteDeletar.TabIndex = 5;
            btnRelatorioClienteDeletar.Text = "Deletar";
            btnRelatorioClienteDeletar.UseVisualStyleBackColor = true;
            btnRelatorioClienteDeletar.Click += btnRelatorioClienteDeletar_Click;
            // 
            // btnRelatorioClienteAtualizar
            // 
            btnRelatorioClienteAtualizar.AutoSize = true;
            btnRelatorioClienteAtualizar.Font = new Font("Segoe UI", 12F);
            btnRelatorioClienteAtualizar.Location = new Point(164, 169);
            btnRelatorioClienteAtualizar.Name = "btnRelatorioClienteAtualizar";
            btnRelatorioClienteAtualizar.Size = new Size(81, 31);
            btnRelatorioClienteAtualizar.TabIndex = 4;
            btnRelatorioClienteAtualizar.Text = "Atualizar";
            btnRelatorioClienteAtualizar.UseVisualStyleBackColor = true;
            btnRelatorioClienteAtualizar.Click += btnRelatorioClienteAtualizar_Click;
            // 
            // lblRelatorioClienteIdadeDados
            // 
            lblRelatorioClienteIdadeDados.BackColor = Color.White;
            lblRelatorioClienteIdadeDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioClienteIdadeDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteIdadeDados.Location = new Point(81, 104);
            lblRelatorioClienteIdadeDados.Name = "lblRelatorioClienteIdadeDados";
            lblRelatorioClienteIdadeDados.Size = new Size(54, 23);
            lblRelatorioClienteIdadeDados.TabIndex = 7;
            // 
            // lblRelatorioClienteTelefoneDados
            // 
            lblRelatorioClienteTelefoneDados.BackColor = Color.White;
            lblRelatorioClienteTelefoneDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioClienteTelefoneDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteTelefoneDados.Location = new Point(81, 72);
            lblRelatorioClienteTelefoneDados.Name = "lblRelatorioClienteTelefoneDados";
            lblRelatorioClienteTelefoneDados.Size = new Size(153, 23);
            lblRelatorioClienteTelefoneDados.TabIndex = 6;
            // 
            // lblRelatorioClienteCpfDados
            // 
            lblRelatorioClienteCpfDados.BackColor = Color.White;
            lblRelatorioClienteCpfDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioClienteCpfDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteCpfDados.Location = new Point(81, 42);
            lblRelatorioClienteCpfDados.Name = "lblRelatorioClienteCpfDados";
            lblRelatorioClienteCpfDados.Size = new Size(153, 23);
            lblRelatorioClienteCpfDados.TabIndex = 5;
            // 
            // lblRelatorioClienteNomeDados
            // 
            lblRelatorioClienteNomeDados.BackColor = Color.White;
            lblRelatorioClienteNomeDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioClienteNomeDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteNomeDados.Location = new Point(81, 11);
            lblRelatorioClienteNomeDados.Name = "lblRelatorioClienteNomeDados";
            lblRelatorioClienteNomeDados.Size = new Size(188, 23);
            lblRelatorioClienteNomeDados.TabIndex = 4;
            // 
            // lblRelatorioClienteIdade
            // 
            lblRelatorioClienteIdade.AutoSize = true;
            lblRelatorioClienteIdade.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteIdade.Location = new Point(24, 106);
            lblRelatorioClienteIdade.Name = "lblRelatorioClienteIdade";
            lblRelatorioClienteIdade.Size = new Size(51, 21);
            lblRelatorioClienteIdade.TabIndex = 3;
            lblRelatorioClienteIdade.Text = "Idade:";
            // 
            // lblRelatorioClienteTelefone
            // 
            lblRelatorioClienteTelefone.AutoSize = true;
            lblRelatorioClienteTelefone.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteTelefone.Location = new Point(5, 74);
            lblRelatorioClienteTelefone.Name = "lblRelatorioClienteTelefone";
            lblRelatorioClienteTelefone.Size = new Size(70, 21);
            lblRelatorioClienteTelefone.TabIndex = 2;
            lblRelatorioClienteTelefone.Text = "Telefone:";
            // 
            // lblRelatorioClienteCpf
            // 
            lblRelatorioClienteCpf.AutoSize = true;
            lblRelatorioClienteCpf.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteCpf.Location = new Point(35, 44);
            lblRelatorioClienteCpf.Name = "lblRelatorioClienteCpf";
            lblRelatorioClienteCpf.Size = new Size(40, 21);
            lblRelatorioClienteCpf.TabIndex = 1;
            lblRelatorioClienteCpf.Text = "CPF:";
            // 
            // lblRelatorioClienteNome
            // 
            lblRelatorioClienteNome.AutoSize = true;
            lblRelatorioClienteNome.Font = new Font("Segoe UI", 12F);
            lblRelatorioClienteNome.Location = new Point(19, 13);
            lblRelatorioClienteNome.Name = "lblRelatorioClienteNome";
            lblRelatorioClienteNome.Size = new Size(56, 21);
            lblRelatorioClienteNome.TabIndex = 0;
            lblRelatorioClienteNome.Text = "Nome:";
            // 
            // lstRelatorioClientes
            // 
            lstRelatorioClientes.FormattingEnabled = true;
            lstRelatorioClientes.ItemHeight = 15;
            lstRelatorioClientes.Location = new Point(3, 23);
            lstRelatorioClientes.Name = "lstRelatorioClientes";
            lstRelatorioClientes.Size = new Size(170, 154);
            lstRelatorioClientes.TabIndex = 2;
            lstRelatorioClientes.Visible = false;
            lstRelatorioClientes.Click += lstRelatorioClientes_Click;
            lstRelatorioClientes.SelectedIndexChanged += lstRelatorioClientes_SelectedIndexChanged;
            lstRelatorioClientes.KeyUp += lstRelatorioClientes_KeyUp;
            // 
            // RelatorioCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 228);
            Controls.Add(pnlRelatorioCliente);
            Name = "RelatorioCliente";
            Text = "RelatorioCliente";
            pnlRelatorioCliente.ResumeLayout(false);
            pnlRelatorioCliente.PerformLayout();
            pnlRelatorioClienteDados.ResumeLayout(false);
            pnlRelatorioClienteDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioCliente;
        private Panel pnlRelatorioClienteDados;
        private Label lblRelatorioClienteNome;
        private Label lblRelatorioClienteCpf;
        private Label lblRelatorioClienteTelefone;
        private Label lblRelatorioClienteIdade;
        private Label lblRelatorioClienteNomeDados;
        private Label lblRelatorioClienteIdadeDados;
        private Label lblRelatorioClienteTelefoneDados;
        private Label lblRelatorioClienteCpfDados;
        private Button btnRelatorioClienteAtualizar;
        private Button btnRelatorioClienteDeletar;
        private TextBox txtRelatorioClientes;
        private ListBox lstRelatorioClientes;
        private Button btnRelatorioClienteAtualizarLista;
        private Label lblRelatorioClienteBotoesAlerta;
    }
}