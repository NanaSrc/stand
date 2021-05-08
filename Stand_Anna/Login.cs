using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Anna
{
    public partial class Login :
        MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUtilizador.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Insira o utilizador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUtilizador.Focus();
            }
            else if (string.IsNullOrEmpty(tbSenha.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Insira a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSenha.Focus();
            }
            else
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "select * from login where utilizador  = @var1 and password = @var2";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbUtilizador.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", tbSenha.Text);
                    SqlDataReader reader = Bd.Comando.ExecuteReader();

                    if (reader.Read())
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Dados incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbUtilizador.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MetroFramework.MetroMessageBox.Show(this, erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Bd.Conn.Close();
                }
            }
        }

        private void mtEsconde_CheckedChanged(object sender, EventArgs e)
        {
            if (mtEsconde.Checked)
            {
                tbSenha.PasswordChar = '\0';
            }
            else
            {
                tbSenha.PasswordChar = '\u25cf';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = '\u25cf';
            if (Properties.Settings.Default.lembrar == true)
            {
                tbUtilizador.Text = Properties.Settings.Default.utilizador;
                tbSenha.Text = Properties.Settings.Default.senha;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cLembrar.Checked)
            {
                tbSenha.PasswordChar = '\u25cf';
                if (Properties.Settings.Default.lembrar == true)
                {
                    Properties.Settings.Default.utilizador = tbUtilizador.Text;
                    Properties.Settings.Default.senha = tbSenha.Text;
                }
            }
            else
            {
                Properties.Settings.Default.utilizador = null;
                Properties.Settings.Default.senha = null;
            }
            Properties.Settings.Default.lembrar = cLembrar.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
