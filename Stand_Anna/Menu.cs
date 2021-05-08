using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Anna
{
    public partial class Menu : 
        MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mtVendas_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Vendas novo = new Vendas();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();
        }

        private void mtCarros_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Carros novo = new Carros();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();
        }

        private void mtClientes_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Clientes novo = new Clientes();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();
        }

        private void mtMarcas_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Marca novo = new Marca();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();
        }

        private void mtModelos_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Modelos novo = new Modelos();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();
        }

        private void mtSair_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
