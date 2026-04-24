namespace TralhoGumo2
{
    partial class CadastroCategoria
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
            btnCategoriaSalvar = new Button();
            pnlCadastroCategoria = new Panel();
            lblCategoriaSalva = new Label();
            lblCategoriaNomeAlerta = new Label();
            txtCategoriaNome = new TextBox();
            lblCategoriaNome = new Label();
            pnlCadastroCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // btnCategoriaSalvar
            // 
            btnCategoriaSalvar.AutoSize = true;
            btnCategoriaSalvar.Font = new Font("Segoe UI", 12F);
            btnCategoriaSalvar.Location = new Point(140, 90);
            btnCategoriaSalvar.Name = "btnCategoriaSalvar";
            btnCategoriaSalvar.Size = new Size(75, 31);
            btnCategoriaSalvar.TabIndex = 1;
            btnCategoriaSalvar.Text = "Salvar";
            btnCategoriaSalvar.UseVisualStyleBackColor = true;
            btnCategoriaSalvar.Click += btnCategoriaSalvar_Click;
            // 
            // pnlCadastroCategoria
            // 
            pnlCadastroCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCategoria.Controls.Add(lblCategoriaSalva);
            pnlCadastroCategoria.Controls.Add(lblCategoriaNomeAlerta);
            pnlCadastroCategoria.Controls.Add(txtCategoriaNome);
            pnlCadastroCategoria.Controls.Add(lblCategoriaNome);
            pnlCadastroCategoria.Controls.Add(btnCategoriaSalvar);
            pnlCadastroCategoria.Location = new Point(12, 12);
            pnlCadastroCategoria.Name = "pnlCadastroCategoria";
            pnlCadastroCategoria.Size = new Size(218, 124);
            pnlCadastroCategoria.TabIndex = 1;
            // 
            // lblCategoriaSalva
            // 
            lblCategoriaSalva.AutoSize = true;
            lblCategoriaSalva.BackColor = Color.Green;
            lblCategoriaSalva.Font = new Font("Segoe UI", 10F);
            lblCategoriaSalva.ForeColor = Color.Blue;
            lblCategoriaSalva.Location = new Point(12, 98);
            lblCategoriaSalva.Name = "lblCategoriaSalva";
            lblCategoriaSalva.Size = new Size(122, 19);
            lblCategoriaSalva.TabIndex = 17;
            lblCategoriaSalva.Text = "Salvo com sucesso";
            lblCategoriaSalva.Visible = false;
            // 
            // lblCategoriaNomeAlerta
            // 
            lblCategoriaNomeAlerta.AutoSize = true;
            lblCategoriaNomeAlerta.BackColor = Color.Yellow;
            lblCategoriaNomeAlerta.ForeColor = Color.Red;
            lblCategoriaNomeAlerta.Location = new Point(3, 78);
            lblCategoriaNomeAlerta.Name = "lblCategoriaNomeAlerta";
            lblCategoriaNomeAlerta.Size = new Size(85, 15);
            lblCategoriaNomeAlerta.TabIndex = 3;
            lblCategoriaNomeAlerta.Text = "Nome inválido";
            lblCategoriaNomeAlerta.Visible = false;
            // 
            // txtCategoriaNome
            // 
            txtCategoriaNome.Font = new Font("Segoe UI", 12F);
            txtCategoriaNome.Location = new Point(3, 46);
            txtCategoriaNome.Name = "txtCategoriaNome";
            txtCategoriaNome.Size = new Size(147, 29);
            txtCategoriaNome.TabIndex = 0;
            txtCategoriaNome.TextChanged += txtCategoriaNome_TextChanged;
            txtCategoriaNome.KeyUp += txtCategoriaNome_KeyUp;
            // 
            // lblCategoriaNome
            // 
            lblCategoriaNome.AutoSize = true;
            lblCategoriaNome.Font = new Font("Segoe UI", 15F);
            lblCategoriaNome.Location = new Point(3, 15);
            lblCategoriaNome.Name = "lblCategoriaNome";
            lblCategoriaNome.Size = new Size(70, 28);
            lblCategoriaNome.TabIndex = 1;
            lblCategoriaNome.Text = "Nome:";
            // 
            // CadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 148);
            Controls.Add(pnlCadastroCategoria);
            Name = "CadastroCategoria";
            Text = "CadastroCategoria";
            FormClosing += CadastroCategoria_FormClosing;
            pnlCadastroCategoria.ResumeLayout(false);
            pnlCadastroCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategoriaSalvar;
        private Panel pnlCadastroCategoria;
        private TextBox txtCategoriaNome;
        private Label lblCategoriaNome;
        private Label lblCategoriaNomeAlerta;
        private Label lblCategoriaSalva;
    }
}