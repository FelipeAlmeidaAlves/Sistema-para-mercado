using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TralhoGumo2.Forms
{
    public partial class ClientesInadimplentes : Form
    {
        private static ClientesInadimplentes _instance;
        private ClientesInadimplentes()
        {
            InitializeComponent();
            List<Cliente> lst = new List<Cliente>();

            foreach (Compra co in CompraRepository.FindAllWCliente())
            {
                if (co.Estado == Estado.Pendente)
                {
                    if (lst.Contains(co.Cliente) == false)
                    {
                        lst.Add(co.Cliente);
                    }
                }
            }

            lstClientesInadimplestes.DataSource = lst;
            lstClientesInadimplestes.DisplayMember = "Nome";
        }
        public static ClientesInadimplentes GetInstance()
        {
            _instance = new ClientesInadimplentes();
            return _instance;
        }

        private void ClientesInadimplentes_Load(object sender, EventArgs e)
        {

        }

        private void btnEncontrarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientesInadimplestes.SelectedItem != null)
            {
                lblErro.Visible = false;
                RelatorioCliente.SetCliente(ClienteRepository.FindByName(lstClientesInadimplestes.Text));
                RelatorioCliente.GetInstance().Show();
            }
            else
            {
                lblErro.Visible = true;
            }
        }

        private void lstClientesInadimplestes_KeyUp(object sender, KeyEventArgs e)
        {
            if (lstClientesInadimplestes.SelectedItem != null && e.KeyCode == Keys.Enter) 
            {
                btnEncontrarCliente.Focus();
            }
        }
    }
}
