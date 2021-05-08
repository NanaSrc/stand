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
    public partial class Vendas :
        MetroFramework.Forms.MetroForm
    {
        private bool editar = false;

        public Vendas()
        {
            InitializeComponent();
        }

        private void Listagem()
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("Select * from venda", Bd.Conn);
                Bd.DTA.Fill(dt);
                mgVendas.DataSource = dt;
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
                    Bd.Comando.CommandText = "Delete from venda where vendaid = @var1";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbVendaID.Text);
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            Limpar();
            metroPanel1.Enabled = true;
            btSave.Enabled = true;
        }

        private void Limpar()
        {
            tbVendaID.Text = string.Empty;
            cbCarro.Text = string.Empty;
            cbCliente.Text = string.Empty;
            dtData.Text = DateTime.Now.ToString();
            nudPreco.Value = 500;
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabListagem;
            Listagem();
            CarregaCarros();
            CarregaClientes();
        }
    

        private void butPesquisar_Click(object sender, EventArgs e)
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sql = new SqlDataAdapter("Select * from venda where " + cbPesquisar.Text + " like @var1", Bd.Conn);
                sql.SelectCommand.Parameters.AddWithValue("@var1", "%" + tbTextoPesquisa.Text + "%");
                Bd.DTA = sql;
                Bd.DTA.Fill(dt);
                mgVendas.DataSource = dt;
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

        private void mgVendas_DoubleClick(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabRegisto;
            tbVendaID.Text = mgVendas.SelectedRows[0].Cells[0].Value.ToString();
            cbCarro.Text = mgVendas.SelectedRows[0].Cells[1].Value.ToString();
            cbCliente.Text = mgVendas.SelectedRows[0].Cells[2].Value.ToString();
            dtData.Text = mgVendas.SelectedRows[0].Cells[3].Value.ToString();
            nudPreco.Value = Convert.ToDecimal(mgVendas.SelectedRows[0].Cells[4].Value.ToString());
            btDelete.Enabled = true;
            btEdit.Enabled = true;
        }

        private void CarregaCarros()
        {
            Bd.Conn.Open();

            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("select * from carro", Bd.Conn);
                Bd.DTA.Fill(dt);
                cbCarro.DataSource = dt;
                cbCarro.DisplayMember = "carroid";
                cbCarro.ValueMember = "carroid";
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

        private void CarregaClientes()
        {
            Bd.Conn.Open();

            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("select * from cliente", Bd.Conn);
                Bd.DTA.Fill(dt);
                cbCliente.DataSource = dt;
                cbCliente.DisplayMember = "nome";
                cbCliente.ValueMember = "clienteid";
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            editar = true;
            btSave.Enabled = true;
            metroPanel1.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {
                Bd.Conn.Open();
                try
                {
                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "update venda set carro = @var1, cliente = @var2, data = @var3, preco = @var4 where vendaid = @var5";
                    Bd.Comando.Parameters.AddWithValue("@var1", cbCarro.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var2", cbCliente.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var3", Convert.ToDateTime(dtData.Text));
                    Bd.Comando.Parameters.AddWithValue("@var4", nudPreco.Value);
                    Bd.Comando.Parameters.AddWithValue("@var5", tbVendaID.Text);

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
                    Bd.Comando.Parameters.AddWithValue("@var1", cbCarro.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var2", cbCliente.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var3", dtData.Text);
                    Bd.Comando.Parameters.AddWithValue("@var4", nudPreco.Value);
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
