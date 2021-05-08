using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Anna
{
    public partial class Clientes :
        MetroFramework.Forms.MetroForm
    {
        private bool editar = false;

        public Clientes()
        {
            InitializeComponent();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Listagem()
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("Select * from Cliente", Bd.Conn);
                Bd.DTA.Fill(dt);
                mgClientes.DataSource = dt;
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabListagem;
            Listagem();

        }

        private void butPesquisar_Click(object sender, EventArgs e)
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sql = new SqlDataAdapter("Select * from cliente where " + cbPesquisar.Text + " like @var1", Bd.Conn);
                sql.SelectCommand.Parameters.AddWithValue("@var1", "%" + tbTextoPesquisa.Text + "%");
                Bd.DTA = sql;
                Bd.DTA.Fill(dt);
                mgClientes.DataSource = dt;
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

        private void mgClientes_DoubleClick(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabRegisto;
            tbClienteID.Text = mgClientes.SelectedRows[0].Cells[0].Value.ToString();
            tbNome.Text = mgClientes.SelectedRows[0].Cells[1].Value.ToString();
            tbTelemovel.Text = mgClientes.SelectedRows[0].Cells[2].Value.ToString();
            tbEmail.Text = mgClientes.SelectedRows[0].Cells[3].Value.ToString();
            tbNif.Text = mgClientes.SelectedRows[0].Cells[4].Value.ToString();
            tbCC.Text = mgClientes.SelectedRows[0].Cells[5].Value.ToString();
            btDelete.Enabled = true;
            btEdit.Enabled = true;
        }

        private void Limpar()
        {
            tbNome.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbCC.Text = string.Empty;
            tbNif.Text = string.Empty;
            tbTelemovel.Text = string.Empty;
            tbClienteID.Text = string.Empty;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Limpar();
            metroPanel1.Enabled = true;
            btSave.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "update cliente set nome = @var1, telemovel = @var2, email = @var3, nif = @var4, cc = @var5 where clienteid = @var6";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbNome.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", tbTelemovel.Text);
                    Bd.Comando.Parameters.AddWithValue("@var3", tbEmail.Text);
                    Bd.Comando.Parameters.AddWithValue("@var4", tbNif.Text);
                    Bd.Comando.Parameters.AddWithValue("@var5", tbCC.Text);
                    Bd.Comando.Parameters.AddWithValue("@var6", tbClienteID.Text);

                    Bd.Comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MetroFramework.MetroMessageBox.Show(this, erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Bd.Conn.Close();
                }
                editar = false;
                btEdit.Enabled = false;
                btDelete.Enabled = false;
            }
            else
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "Insert into cliente values (@var1,@var2,@var3,@var4,@var5)";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbNome.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", tbTelemovel.Text);
                    Bd.Comando.Parameters.AddWithValue("@var3", tbEmail.Text);
                    Bd.Comando.Parameters.AddWithValue("@var4", tbNif.Text);
                    Bd.Comando.Parameters.AddWithValue("@var5", tbCC.Text);   
                    Bd.Comando.ExecuteNonQuery();
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
            Limpar();
            Listagem();
            metroTabControl1.SelectedTab = tabListagem;
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Tem a certeza que deseja deletar o registo?", "Deletar Registo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "Delete from cliente where clienteid = @var1";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbClienteID.Text);
                    Bd.Comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MetroFramework.MetroMessageBox.Show(this, erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Bd.Conn.Close();
                }

                Limpar();
                Listagem();
            }
            
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            editar = true;
            btSave.Enabled = true;
            metroPanel1.Enabled = true;
        }
    }
}
