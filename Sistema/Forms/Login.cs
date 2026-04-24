using TrabalhoGuisso;

namespace TralhoGumo2
{
    public partial class Login : Form
    {
        private static Login _instance;
        private Login()
        {
            InitializeComponent();
        }

        public static Login GetInstance() 
        {
            if (_instance == null) 
            {
                _instance = new Login();
            }
            return _instance;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                List<Vendedor> vend = VendedorRepository.FindAllWithCredencial();
                foreach (Vendedor v in vend) 
                {
                    if (txtLogin.Text == v.Gmail && Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT) == v.Credencial.SenhaHash) 
                    {
                        txtLogin.Focus();
                        Hide();
                        Sistema.GetInstance(v).Show(); ;
                        txtSenha.Clear();
                        txtLogin.Clear();
                        
                        return;
                    }
                }
                txtSenha.Clear();
                txtLogin.Clear();
                txtLogin.Focus();
                lblAlerta.Visible = true;
            }
        }
    }
}
