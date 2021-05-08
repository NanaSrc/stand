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
    public partial class Modelos :
        MetroFramework.Forms.MetroForm
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            CarregaMarcas();
            metroTabControl1.SelectedTab = tabListagem;
            Listagem();
        }

        private void CarregaMarcas()
        {
            Bd.Conn.Open();

            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("select * from marca", Bd.Conn);
                Bd.DTA.Fill(dt);
                cbMarca.DataSource = dt;
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "marca";
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbModelo.Text = string.Empty;
            cbMarca.Text = string.Empty;
            metroPanel1.Enabled = true;
            btSave.Enabled = true;
        }

        private void Listagem()
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("Select * from Modelo", Bd.Conn);
                Bd.DTA.Fill(dt);
                mgModelos.DataSource = dt;
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
                SqlDataAdapter sql = new SqlDataAdapter("Select * from modelo where " + cbPesquisar.Text + " like @var1", Bd.Conn);
                sql.SelectCommand.Parameters.AddWithValue("@var1", "%" + tbTextoPesquisa.Text + "%");
                Bd.DTA = sql;
                Bd.DTA.Fill(dt);
                mgModelos.DataSource = dt;
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Tem a certeza que deseja deletar o registo?", "Deletar Registo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "Delete from modelo where modeloid = @var1";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbModeloID.Text);
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

        private void Limpar()
        {
            tbModeloID.Text = string.Empty;
            cbMarca.Text = string.Empty;
            tbModelo.Text = string.Empty;
        }

        private void mgModelos_DoubleClick(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabRegisto;
            tbModeloID.Text = mgModelos.SelectedRows[0].Cells[0].Value.ToString();
            cbMarca.Text = mgModelos.SelectedRows[0].Cells[1].Value.ToString();
            tbModelo.Text = mgModelos.SelectedRows[0].Cells[2].Value.ToString();
            btDelete.Enabled = true;
            btEdit.Enabled = true;
        }

        bool editar = false;

        private void btEdit_Click(object sender, EventArgs e)
        {
            editar = true;
            btSave.Enabled = true;
            metroPanel1.Enabled = true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(editar == true)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "update modelo set marca = @var1, modelo = @var2 where modeloid = @var3";
                    Bd.Comando.Parameters.AddWithValue("@var1", cbMarca.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", tbModelo.Text);
                    Bd.Comando.Parameters.AddWithValue("@var3", tbModeloID.Text);
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
                    Bd.Comando.CommandText = "Insert into modelo values (@var1,@var2)";
                    Bd.Comando.Parameters.AddWithValue("@var1", cbMarca.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", tbModelo.Text);
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

    }
}
