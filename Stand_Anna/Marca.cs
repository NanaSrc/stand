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
    public partial class Marca :
        MetroFramework.Forms.MetroForm
    {
        public Marca()
        {
            InitializeComponent();
        }


        private void Marca_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabListagem;
            Listagem();
        }

        private void Listagem()
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("Select * from Marca", Bd.Conn);
                Bd.DTA.Fill(dt);
                mgMarcas.DataSource = dt;
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

        private void butPesquisar_Click(object sender, EventArgs e)
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sql = new SqlDataAdapter("Select * from Marca where Marca like @var1", Bd.Conn);
                sql.SelectCommand.Parameters.AddWithValue("@var1", "%" + tbTextoPesquisa.Text + "%");
                Bd.DTA = sql;
                Bd.DTA.Fill(dt);
                mgMarcas.DataSource = dt;
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

        private void mgMarcas_DoubleClick(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabRegisto;
            tbMarca.Text = mgMarcas.SelectedRows[0].Cells[0].Value.ToString();
            btDelete.Enabled = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Tem a certeza que deseja deletar o registo?", "Deletar Registo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "Delete from marca where marca = @var1";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbMarca.Text);
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

                tbMarca.Text = string.Empty;
                Listagem();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbMarca.Text = string.Empty;
            metroPanel1.Enabled = true;
            btSave.Visible = true;
            btSave.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Bd.Conn.Open();
            try
            {
                Bd.Comando = Bd.Conn.CreateCommand();
                Bd.Comando.CommandText = "Insert into marca values (@var1)";
                Bd.Comando.Parameters.AddWithValue("@var1", tbMarca.Text);
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

            tbMarca.Text = string.Empty;
            Listagem();
        }

    }
}
