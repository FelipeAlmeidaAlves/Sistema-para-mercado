namespace TralhoGumo2
{
    partial class RelatorioVendedor
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
            pnlRelatorioVendedor = new Panel();
            pnlRelatorioVendedorDados = new Panel();
            lblRelatorioVendedorBotoesAlerta = new Label();
            btnRelatorioVendedorAtualizarLista = new Button();
            btnRelatorioVendedorDeletar = new Button();
            btnRelatorioVendedorAtualizar = new Button();
            lblRelatorioVendedorPerfilDados = new Label();
            lblRelatorioVendedorTelefoneDados = new Label();
            lblRelatorioVendedorEmailDados = new Label();
            lblRelatorioVendedorNomeDados = new Label();
            lblRelatorioVendedorPerfil = new Label();
            lblRelatorioVendedorTelefone = new Label();
            lblRelatorioVendedorEmail = new Label();
            lblRelatorioVendedorNome = new Label();
            lstRelatorioVendedor = new ListBox();
            txtRelatorioVendedor = new TextBox();
            pnlRelatorioVendedor.SuspendLayout();
            pnlRelatorioVendedorDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRelatorioVendedor
            // 
            pnlRelatorioVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRelatorioVendedor.BackColor = SystemColors.Control;
            pnlRelatorioVendedor.Controls.Add(pnlRelatorioVendedorDados);
            pnlRelatorioVendedor.Controls.Add(lstRelatorioVendedor);
            pnlRelatorioVendedor.Controls.Add(txtRelatorioVendedor);
            pnlRelatorioVendedor.Location = new Point(12, 12);
            pnlRelatorioVendedor.Name = "pnlRelatorioVendedor";
            pnlRelatorioVendedor.Size = new Size(523, 204);
            pnlRelatorioVendedor.TabIndex = 0;
            // 
            // pnlRelatorioVendedorDados
            // 
            pnlRelatorioVendedorDados.BackColor = Color.WhiteSmoke;
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorBotoesAlerta);
            pnlRelatorioVendedorDados.Controls.Add(btnRelatorioVendedorAtualizarLista);
            pnlRelatorioVendedorDados.Controls.Add(btnRelatorioVendedorDeletar);
            pnlRelatorioVendedorDados.Controls.Add(btnRelatorioVendedorAtualizar);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorPerfilDados);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorTelefoneDados);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorEmailDados);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorNomeDados);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorPerfil);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorTelefone);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorEmail);
            pnlRelatorioVendedorDados.Controls.Add(lblRelatorioVendedorNome);
            pnlRelatorioVendedorDados.Location = new Point(194, 0);
            pnlRelatorioVendedorDados.Name = "pnlRelatorioVendedorDados";
            pnlRelatorioVendedorDados.Size = new Size(329, 204);
            pnlRelatorioVendedorDados.TabIndex = 2;
            // 
            // lblRelatorioVendedorBotoesAlerta
            // 
            lblRelatorioVendedorBotoesAlerta.AutoSize = true;
            lblRelatorioVendedorBotoesAlerta.BackColor = Color.Yellow;
            lblRelatorioVendedorBotoesAlerta.Font = new Font("Segoe UI", 9F);
            lblRelatorioVendedorBotoesAlerta.ForeColor = Color.Red;
            lblRelatorioVendedorBotoesAlerta.Location = new Point(56, 185);
            lblRelatorioVendedorBotoesAlerta.Name = "lblRelatorioVendedorBotoesAlerta";
            lblRelatorioVendedorBotoesAlerta.Size = new Size(102, 15);
            lblRelatorioVendedorBotoesAlerta.TabIndex = 11;
            lblRelatorioVendedorBotoesAlerta.Text = "Vendedor Inválido";
            lblRelatorioVendedorBotoesAlerta.Visible = false;
            // 
            // btnRelatorioVendedorAtualizarLista
            // 
            btnRelatorioVendedorAtualizarLista.AutoSize = true;
            btnRelatorioVendedorAtualizarLista.BackColor = Color.Transparent;
            btnRelatorioVendedorAtualizarLista.Font = new Font("Segoe UI", 14F);
            btnRelatorioVendedorAtualizarLista.ForeColor = SystemColors.ControlText;
            btnRelatorioVendedorAtualizarLista.Location = new Point(5, 165);
            btnRelatorioVendedorAtualizarLista.Name = "btnRelatorioVendedorAtualizarLista";
            btnRelatorioVendedorAtualizarLista.Size = new Size(43, 35);
            btnRelatorioVendedorAtualizarLista.TabIndex = 3;
            btnRelatorioVendedorAtualizarLista.Text = "🔄";
            btnRelatorioVendedorAtualizarLista.UseVisualStyleBackColor = false;
            btnRelatorioVendedorAtualizarLista.Click += btnRelatorioVendedorAtualizarLista_Click;
            // 
            // btnRelatorioVendedorDeletar
            // 
            btnRelatorioVendedorDeletar.AutoSize = true;
            btnRelatorioVendedorDeletar.Font = new Font("Segoe UI", 12F);
            btnRelatorioVendedorDeletar.Location = new Point(251, 169);
            btnRelatorioVendedorDeletar.Name = "btnRelatorioVendedorDeletar";
            btnRelatorioVendedorDeletar.Size = new Size(75, 31);
            btnRelatorioVendedorDeletar.TabIndex = 5;
            btnRelatorioVendedorDeletar.Text = "Deletar";
            btnRelatorioVendedorDeletar.UseVisualStyleBackColor = true;
            btnRelatorioVendedorDeletar.Click += btnRelatorioVendedorDeletar_Click;
            // 
            // btnRelatorioVendedorAtualizar
            // 
            btnRelatorioVendedorAtualizar.AutoSize = true;
            btnRelatorioVendedorAtualizar.Font = new Font("Segoe UI", 12F);
            btnRelatorioVendedorAtualizar.Location = new Point(164, 169);
            btnRelatorioVendedorAtualizar.Name = "btnRelatorioVendedorAtualizar";
            btnRelatorioVendedorAtualizar.Size = new Size(81, 31);
            btnRelatorioVendedorAtualizar.TabIndex = 4;
            btnRelatorioVendedorAtualizar.Text = "Atualizar";
            btnRelatorioVendedorAtualizar.UseVisualStyleBackColor = true;
            btnRelatorioVendedorAtualizar.Click += btnRelatorioVendedorAtualizar_Click;
            // 
            // lblRelatorioVendedorPerfilDados
            // 
            lblRelatorioVendedorPerfilDados.BackColor = Color.White;
            lblRelatorioVendedorPerfilDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioVendedorPerfilDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorPerfilDados.Location = new Point(81, 104);
            lblRelatorioVendedorPerfilDados.Name = "lblRelatorioVendedorPerfilDados";
            lblRelatorioVendedorPerfilDados.Size = new Size(114, 23);
            lblRelatorioVendedorPerfilDados.TabIndex = 7;
            // 
            // lblRelatorioVendedorTelefoneDados
            // 
            lblRelatorioVendedorTelefoneDados.BackColor = Color.White;
            lblRelatorioVendedorTelefoneDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioVendedorTelefoneDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorTelefoneDados.Location = new Point(81, 72);
            lblRelatorioVendedorTelefoneDados.Name = "lblRelatorioVendedorTelefoneDados";
            lblRelatorioVendedorTelefoneDados.Size = new Size(153, 23);
            lblRelatorioVendedorTelefoneDados.TabIndex = 6;
            // 
            // lblRelatorioVendedorEmailDados
            // 
            lblRelatorioVendedorEmailDados.BackColor = Color.White;
            lblRelatorioVendedorEmailDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioVendedorEmailDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorEmailDados.Location = new Point(81, 42);
            lblRelatorioVendedorEmailDados.Name = "lblRelatorioVendedorEmailDados";
            lblRelatorioVendedorEmailDados.Size = new Size(153, 23);
            lblRelatorioVendedorEmailDados.TabIndex = 5;
            // 
            // lblRelatorioVendedorNomeDados
            // 
            lblRelatorioVendedorNomeDados.BackColor = Color.White;
            lblRelatorioVendedorNomeDados.BorderStyle = BorderStyle.FixedSingle;
            lblRelatorioVendedorNomeDados.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorNomeDados.Location = new Point(81, 11);
            lblRelatorioVendedorNomeDados.Name = "lblRelatorioVendedorNomeDados";
            lblRelatorioVendedorNomeDados.Size = new Size(188, 23);
            lblRelatorioVendedorNomeDados.TabIndex = 4;
            // 
            // lblRelatorioVendedorPerfil
            // 
            lblRelatorioVendedorPerfil.AutoSize = true;
            lblRelatorioVendedorPerfil.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorPerfil.Location = new Point(24, 106);
            lblRelatorioVendedorPerfil.Name = "lblRelatorioVendedorPerfil";
            lblRelatorioVendedorPerfil.Size = new Size(48, 21);
            lblRelatorioVendedorPerfil.TabIndex = 3;
            lblRelatorioVendedorPerfil.Text = "Perfil:";
            // 
            // lblRelatorioVendedorTelefone
            // 
            lblRelatorioVendedorTelefone.AutoSize = true;
            lblRelatorioVendedorTelefone.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorTelefone.Location = new Point(5, 74);
            lblRelatorioVendedorTelefone.Name = "lblRelatorioVendedorTelefone";
            lblRelatorioVendedorTelefone.Size = new Size(70, 21);
            lblRelatorioVendedorTelefone.TabIndex = 2;
            lblRelatorioVendedorTelefone.Text = "Telefone:";
            // 
            // lblRelatorioVendedorEmail
            // 
            lblRelatorioVendedorEmail.AutoSize = true;
            lblRelatorioVendedorEmail.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorEmail.Location = new Point(24, 44);
            lblRelatorioVendedorEmail.Name = "lblRelatorioVendedorEmail";
            lblRelatorioVendedorEmail.Size = new Size(51, 21);
            lblRelatorioVendedorEmail.TabIndex = 1;
            lblRelatorioVendedorEmail.Text = "Email:";
            // 
            // lblRelatorioVendedorNome
            // 
            lblRelatorioVendedorNome.AutoSize = true;
            lblRelatorioVendedorNome.Font = new Font("Segoe UI", 12F);
            lblRelatorioVendedorNome.Location = new Point(19, 13);
            lblRelatorioVendedorNome.Name = "lblRelatorioVendedorNome";
            lblRelatorioVendedorNome.Size = new Size(56, 21);
            lblRelatorioVendedorNome.TabIndex = 0;
            lblRelatorioVendedorNome.Text = "Nome:";
            // 
            // lstRelatorioVendedor
            // 
            lstRelatorioVendedor.FormattingEnabled = true;
            lstRelatorioVendedor.ItemHeight = 15;
            lstRelatorioVendedor.Location = new Point(3, 25);
            lstRelatorioVendedor.Name = "lstRelatorioVendedor";
            lstRelatorioVendedor.Size = new Size(170, 154);
            lstRelatorioVendedor.TabIndex = 2;
            lstRelatorioVendedor.Visible = false;
            lstRelatorioVendedor.Click += lstRelatorioVendedor_Click;
            lstRelatorioVendedor.KeyUp += lstRelatorioVendedor_KeyUp;
            // 
            // txtRelatorioVendedor
            // 
            txtRelatorioVendedor.Location = new Point(3, 3);
            txtRelatorioVendedor.Name = "txtRelatorioVendedor";
            txtRelatorioVendedor.Size = new Size(170, 23);
            txtRelatorioVendedor.TabIndex = 1;
            txtRelatorioVendedor.TextChanged += txtRelatorioVendedor_TextChanged;
            // 
            // RelatorioVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 228);
            Controls.Add(pnlRelatorioVendedor);
            Name = "RelatorioVendedor";
            Text = "RelatorioVendedor";
            pnlRelatorioVendedor.ResumeLayout(false);
            pnlRelatorioVendedor.PerformLayout();
            pnlRelatorioVendedorDados.ResumeLayout(false);
            pnlRelatorioVendedorDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRelatorioVendedor;
        private ListBox lstRelatorioVendedor;
        private TextBox txtRelatorioVendedor;
        private Panel pnlRelatorioVendedorDados;
        private Label lblRelatorioVendedorBotoesAlerta;
        private Button btnRelatorioVendedorAtualizarLista;
        private Button btnRelatorioVendedorDeletar;
        private Button btnRelatorioVendedorAtualizar;
        private Label lblRelatorioVendedorPerfilDados;
        private Label lblRelatorioVendedorTelefoneDados;
        private Label lblRelatorioVendedorEmailDados;
        private Label lblRelatorioVendedorNomeDados;
        private Label lblRelatorioVendedorPerfil;
        private Label lblRelatorioVendedorTelefone;
        private Label lblRelatorioVendedorEmail;
        private Label lblRelatorioVendedorNome;
    }
}