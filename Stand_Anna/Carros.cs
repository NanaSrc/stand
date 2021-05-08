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
    public partial class Carros :
        MetroFramework.Forms.MetroForm
    {
        private bool editar = false;
        List<Image> fotos = new List<Image>();

        public Carros()
        {
            InitializeComponent();
        }

        private void Carros_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabListagem;
            Listagem();
            CarregaMarcas();
        }

        private void Listagem()
        {
            Bd.Conn.Open();
            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("Select * from Carro", Bd.Conn);
                Bd.DTA.Fill(dt);
                mgCarros.DataSource = dt;
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

        private void CarregaMarcas()
        {
            Bd.Conn.Open();

            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("select * from marca", Bd.Conn);
                Bd.DTA.Fill(dt);
                Bd.Conn.Close();
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

        private void CarregaModelos()
        {
            Bd.Conn.Open();

            try
            {
                DataTable dt = new DataTable();
                Bd.DTA = new SqlDataAdapter("select * from modelo where marca = @var1", Bd.Conn);
                Bd.DTA.SelectCommand.Parameters.AddWithValue("@var1", cbMarca.Text);
                Bd.DTA.Fill(dt);
                cbModelo.DataSource = dt;
                cbModelo.DisplayMember = "modelo";
                cbModelo.ValueMember = "modeloid";
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
                SqlDataAdapter sql = new SqlDataAdapter("Select * from carro where " + cbPesquisar.Text + " like @var1", Bd.Conn);
                sql.SelectCommand.Parameters.AddWithValue("@var1", "%" + tbTextoPesquisa.Text + "%");
                Bd.DTA = sql;
                Bd.DTA.Fill(dt);
                mgCarros.DataSource = dt;
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

        private void mgCarros_DoubleClick(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabRegisto;
            tbCarroID.Text = mgCarros.SelectedRows[0].Cells[0].Value.ToString();
            cbMarca.SelectedValue = mgCarros.SelectedRows[0].Cells[1].Value.ToString();
            cbModelo.SelectedValue = mgCarros.SelectedRows[0].Cells[2].Value.ToString();
            cbCarrocaria.SelectedValue = mgCarros.SelectedRows[0].Cells[3].Value.ToString();
            nudAno.Text = mgCarros.SelectedRows[0].Cells[4].Value.ToString();
            cbCombustivel.SelectedValue = mgCarros.SelectedRows[0].Cells[5].Value.ToString();
            cbEstado.Text = mgCarros.SelectedRows[0].Cells[6].Value.ToString();
            tbCor.Text = mgCarros.SelectedRows[0].Cells[7].Value.ToString();
            nudKm.Text = mgCarros.SelectedRows[0].Cells[8].Value.ToString();
            nudLugares.Text = mgCarros.SelectedRows[0].Cells[9].Value.ToString();
            nudPortas.Text = mgCarros.SelectedRows[0].Cells[10].Value.ToString();
            nudCilindrada.Text = mgCarros.SelectedRows[0].Cells[11].Value.ToString();
            nudPotencia.Text = mgCarros.SelectedRows[0].Cells[12].Value.ToString();
            nudPreco.Text = mgCarros.SelectedRows[0].Cells[13].Value.ToString();
            tbDescricao.Text = mgCarros.SelectedRows[0].Cells[14].Value.ToString();
            tbMatricula.Text = mgCarros.SelectedRows[0].Cells[16].Value.ToString();

            string estado = mgCarros.SelectedRows[0].Cells[15].Value.ToString();
            if (estado == "Em stock")
                rbStock.Enabled = true;
            else if (estado == "Reservado")
                rbReservado.Enabled = true;
            else if (estado == "Vendido")
                rbVendido.Enabled = true;

            Bd.Conn.Open();

            try
            {
                Bd.Comando = Bd.Conn.CreateCommand();
                Bd.Comando.CommandText = "Select * from foto where carroID = @var1";
                Bd.Comando.Parameters.AddWithValue("@var1", mgCarros.SelectedRows[0].Cells[0].Value);
                SqlDataReader sqlDataReader = Bd.Comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    List<PictureBox> fotos = new List<PictureBox>();
                    if (! string.IsNullOrEmpty (sqlDataReader[2].ToString()))
                    {
                        byte[] foto = (byte[])sqlDataReader[2];
                        MemoryStream stream = new MemoryStream(foto);
                        PictureBox picture = new PictureBox();
                        Image image = Image.FromStream(stream);
                        picture.Height = 200;
                        picture.Width = 200;
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Image = image;
                        tableFotos.Controls.Add(picture);
                        fotos.Add(picture);
                    }
                    foreach (PictureBox pic in fotos)
                    {
                        tableFotos.Controls.Add(pic);
                    }
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

            btDelete.Enabled = true;
            btEdit.Enabled = true;
            metroPanel1.Enabled = true;
        }

        private void Limpar()
        {
            tbCarroID.Text = string.Empty;
            cbMarca.SelectedValue = string.Empty;
            cbModelo.SelectedValue = string.Empty;
            cbCarrocaria.SelectedValue = string.Empty;
            nudAno.Value = 1920;
            cbCombustivel.SelectedValue = string.Empty;
            cbEstado.Text = string.Empty;
            tbCor.Text = string.Empty;
            nudKm.Text = string.Empty;
            nudLugares.Value = 1;
            nudPortas.Value = 2;
            nudCilindrada.Value = 200;
            nudPotencia.Value = 2;
            nudPreco.Value = 500;
            tbDescricao.Text = string.Empty;
            tbMatricula.Text = string.Empty;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Limpar();
            metroPanel1.Enabled = true;
            btSave.Enabled = true;
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
                    Bd.Comando.CommandText = "Delete from carro where carroid = @var1";
                    Bd.Comando.Parameters.AddWithValue("@var1", tbCarroID.Text);
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
                    string estadoNeg = "";
                    if (rbStock.Checked)
                        estadoNeg = "Em stock";
                    if (rbVendido.Checked)
                        estadoNeg = "Vendido";
                    if (rbReservado.Checked)
                        estadoNeg = "Reservado";

                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "update carro set marca = @var1, modeloid = @var2, carrocaria = @var3, ano = @var4, combustivel = @var5, estado = @var6, cor = @var7, km = @var8, lugares = @var9, portas = @var10, cilindrada = @var11, potencia = @var12, preco = @var13, descricao = @var14, matricula = @var15, estadonegocio = @var16 where carroid = @var17";
                    Bd.Comando.Parameters.AddWithValue("@var1", cbMarca.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", cbModelo.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var3", cbCarrocaria.Text);
                    Bd.Comando.Parameters.AddWithValue("@var4", nudAno.Value);
                    Bd.Comando.Parameters.AddWithValue("@var5", cbCombustivel.Text);
                    Bd.Comando.Parameters.AddWithValue("@var6", cbEstado.Text);
                    Bd.Comando.Parameters.AddWithValue("@var7", tbCor.Text);
                    Bd.Comando.Parameters.AddWithValue("@var8", nudKm.Value);
                    Bd.Comando.Parameters.AddWithValue("@var9", nudLugares.Value);
                    Bd.Comando.Parameters.AddWithValue("@var10", nudPortas.Value);
                    Bd.Comando.Parameters.AddWithValue("@var11", nudCilindrada.Value);
                    Bd.Comando.Parameters.AddWithValue("@var12", nudPotencia.Value);
                    Bd.Comando.Parameters.AddWithValue("@var13", nudPreco.Value);
                    Bd.Comando.Parameters.AddWithValue("@var14", tbDescricao.Text);
                    Bd.Comando.Parameters.AddWithValue("@var15", tbMatricula.Text);
                    Bd.Comando.Parameters.AddWithValue("@var16", estadoNeg);
                    Bd.Comando.Parameters.AddWithValue("@var17", tbCarroID.Text);


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
                    string estadoNeg = "";
                    if (rbStock.Checked)
                        estadoNeg = "Em stock";
                    if (rbVendido.Checked)
                        estadoNeg = "Vendido";
                    if (rbReservado.Checked)
                        estadoNeg = "Reservado";

                    Bd.Comando = Bd.Conn.CreateCommand();
                    Bd.Comando.CommandText = "insert into carro values (@var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8, @var9, @var10, @var11, @var12, @var13, @var14, @var15, @var16)" + "Select scope_identity()";
                    Bd.Comando.Parameters.AddWithValue("@var1", cbMarca.Text);
                    Bd.Comando.Parameters.AddWithValue("@var2", cbModelo.SelectedValue);
                    Bd.Comando.Parameters.AddWithValue("@var3", cbCarrocaria.Text);
                    Bd.Comando.Parameters.AddWithValue("@var4", nudAno.Value);
                    Bd.Comando.Parameters.AddWithValue("@var5", cbCombustivel.Text);
                    Bd.Comando.Parameters.AddWithValue("@var6", cbEstado.Text);
                    Bd.Comando.Parameters.AddWithValue("@var7", tbCor.Text);
                    Bd.Comando.Parameters.AddWithValue("@var8", nudKm.Value);
                    Bd.Comando.Parameters.AddWithValue("@var9", nudLugares.Value);
                    Bd.Comando.Parameters.AddWithValue("@var10", nudPortas.Value);
                    Bd.Comando.Parameters.AddWithValue("@var11", nudCilindrada.Value);
                    Bd.Comando.Parameters.AddWithValue("@var12", nudPotencia.Value);
                    Bd.Comando.Parameters.AddWithValue("@var13", nudPreco.Value);
                    Bd.Comando.Parameters.AddWithValue("@var14", estadoNeg);
                    Bd.Comando.Parameters.AddWithValue("@var15", tbDescricao.Text);
                    Bd.Comando.Parameters.AddWithValue("@var16", tbMatricula.Text);
                    int ultimoid = Convert.ToInt32(Bd.Comando.ExecuteScalar());
                    Bd.Comando.ExecuteNonQuery();

                    ImageConverter converter = new ImageConverter();
                    if(fotos.Count > 0)
                    {
                        byte[] imagem = new byte[] { };
                        foreach (var img in fotos)
                        {
                            imagem = (byte[])
                            converter.ConvertTo(img, typeof(byte[]));
                            Bd.Comando = Bd.Conn.CreateCommand();
                            Bd.Comando.CommandText = "Insert into foto values(@var1, @var2)";
                            Bd.Comando.Parameters.AddWithValue("@var1", tbCarroID.Text);
                            Bd.Comando.Parameters.AddWithValue("@var2", imagem);
                            Bd.Comando.ExecuteNonQuery();
                        }
                        
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
            Limpar();
            Listagem();
            metroTabControl1.SelectedTab = tabListagem;
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaModelos();
        }

        private void btCarregaFotos_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Imagens | *.jpg | *.png | *.gif";
            if(result == DialogResult.OK)
            {
                foreach(string file in openFileDialog1.FileNames)
                {
                    PictureBox pic = new PictureBox();
                    Image image = Image.FromFile(file);
                    pic.Height = 200;
                    pic.Width = 200;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = image;
                    tableFotos.Controls.Add(pic);
                }
            }
        }

        private void mgCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
