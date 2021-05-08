namespace Stand_Anna
{
    partial class Carros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabListagem = new MetroFramework.Controls.MetroTabPage();
            this.mgCarros = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.butPesquisar = new System.Windows.Forms.Button();
            this.tbTextoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabRegisto = new MetroFramework.Controls.MetroTabPage();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tbCarroID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.rbReservado = new System.Windows.Forms.RadioButton();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.nudPotencia = new System.Windows.Forms.NumericUpDown();
            this.nudCilindrada = new System.Windows.Forms.NumericUpDown();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.nudLugares = new System.Windows.Forms.NumericUpDown();
            this.nudPortas = new System.Windows.Forms.NumericUpDown();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.tbCor = new MetroFramework.Controls.MetroTextBox();
            this.cbCarrocaria = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.tbMatricula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btEdit = new MetroFramework.Controls.MetroButton();
            this.tabFotos = new MetroFramework.Controls.MetroTabPage();
            this.btCarregaFotos = new MetroFramework.Controls.MetroButton();
            this.tableFotos = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroTabControl1.SuspendLayout();
            this.tabListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabRegisto.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.tabFotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabListagem);
            this.metroTabControl1.Controls.Add(this.tabRegisto);
            this.metroTabControl1.Controls.Add(this.tabFotos);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(927, 908);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabListagem
            // 
            this.tabListagem.BackColor = System.Drawing.Color.Black;
            this.tabListagem.Controls.Add(this.mgCarros);
            this.tabListagem.Controls.Add(this.metroGrid1);
            this.tabListagem.Controls.Add(this.butPesquisar);
            this.tabListagem.Controls.Add(this.tbTextoPesquisa);
            this.tabListagem.Controls.Add(this.cbPesquisar);
            this.tabListagem.Controls.Add(this.metroLabel1);
            this.tabListagem.HorizontalScrollbarBarColor = true;
            this.tabListagem.HorizontalScrollbarHighlightOnWheel = false;
            this.tabListagem.HorizontalScrollbarSize = 10;
            this.tabListagem.Location = new System.Drawing.Point(4, 38);
            this.tabListagem.Name = "tabListagem";
            this.tabListagem.Size = new System.Drawing.Size(919, 866);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Listagem";
            this.tabListagem.VerticalScrollbarBarColor = true;
            this.tabListagem.VerticalScrollbarHighlightOnWheel = false;
            this.tabListagem.VerticalScrollbarSize = 10;
            // 
            // mgCarros
            // 
            this.mgCarros.AllowUserToResizeRows = false;
            this.mgCarros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCarros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgCarros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgCarros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCarros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgCarros.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgCarros.EnableHeadersVisualStyles = false;
            this.mgCarros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgCarros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCarros.Location = new System.Drawing.Point(8, 70);
            this.mgCarros.MultiSelect = false;
            this.mgCarros.Name = "mgCarros";
            this.mgCarros.ReadOnly = true;
            this.mgCarros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCarros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgCarros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgCarros.Size = new System.Drawing.Size(911, 755);
            this.mgCarros.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgCarros.TabIndex = 7;
            this.mgCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgCarros_CellContentClick);
            this.mgCarros.DoubleClick += new System.EventHandler(this.mgCarros_DoubleClick);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(169, 84);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(8, 8);
            this.metroGrid1.TabIndex = 6;
            // 
            // butPesquisar
            // 
            this.butPesquisar.Location = new System.Drawing.Point(500, 25);
            this.butPesquisar.Name = "butPesquisar";
            this.butPesquisar.Size = new System.Drawing.Size(75, 23);
            this.butPesquisar.TabIndex = 5;
            this.butPesquisar.Text = "Pesquisar";
            this.butPesquisar.UseVisualStyleBackColor = true;
            this.butPesquisar.Click += new System.EventHandler(this.butPesquisar_Click);
            // 
            // tbTextoPesquisa
            // 
            // 
            // 
            // 
            this.tbTextoPesquisa.CustomButton.Image = null;
            this.tbTextoPesquisa.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.tbTextoPesquisa.CustomButton.Name = "";
            this.tbTextoPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTextoPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTextoPesquisa.CustomButton.TabIndex = 1;
            this.tbTextoPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTextoPesquisa.CustomButton.UseSelectable = true;
            this.tbTextoPesquisa.CustomButton.Visible = false;
            this.tbTextoPesquisa.Lines = new string[0];
            this.tbTextoPesquisa.Location = new System.Drawing.Point(231, 25);
            this.tbTextoPesquisa.MaxLength = 32767;
            this.tbTextoPesquisa.Name = "tbTextoPesquisa";
            this.tbTextoPesquisa.PasswordChar = '\0';
            this.tbTextoPesquisa.PromptText = "Insira um valor";
            this.tbTextoPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTextoPesquisa.SelectedText = "";
            this.tbTextoPesquisa.SelectionLength = 0;
            this.tbTextoPesquisa.SelectionStart = 0;
            this.tbTextoPesquisa.ShortcutsEnabled = true;
            this.tbTextoPesquisa.Size = new System.Drawing.Size(263, 23);
            this.tbTextoPesquisa.TabIndex = 4;
            this.tbTextoPesquisa.UseSelectable = true;
            this.tbTextoPesquisa.WaterMark = "Insira um valor";
            this.tbTextoPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTextoPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Items.AddRange(new object[] {
            "Marca",
            "Modelo"});
            this.cbPesquisar.Location = new System.Drawing.Point(92, 25);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(133, 21);
            this.cbPesquisar.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Procurar por:";
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.btSave);
            this.tabRegisto.Controls.Add(this.btDelete);
            this.tabRegisto.Controls.Add(this.btAdd);
            this.tabRegisto.Controls.Add(this.metroPanel1);
            this.tabRegisto.Controls.Add(this.btEdit);
            this.tabRegisto.HorizontalScrollbarBarColor = true;
            this.tabRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegisto.HorizontalScrollbarSize = 10;
            this.tabRegisto.Location = new System.Drawing.Point(4, 38);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.Size = new System.Drawing.Size(919, 866);
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.Text = "Registo";
            this.tabRegisto.VerticalScrollbarBarColor = true;
            this.tabRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegisto.VerticalScrollbarSize = 10;
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(640, 644);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 27);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Salvar";
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Enabled = false;
            this.btDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btDelete.Location = new System.Drawing.Point(351, 644);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 27);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(208, 644);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Novo";
            this.btAdd.UseSelectable = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbDescricao);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.tbCarroID);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.rbVendido);
            this.metroPanel1.Controls.Add(this.rbReservado);
            this.metroPanel1.Controls.Add(this.rbStock);
            this.metroPanel1.Controls.Add(this.nudPotencia);
            this.metroPanel1.Controls.Add(this.nudCilindrada);
            this.metroPanel1.Controls.Add(this.nudPreco);
            this.metroPanel1.Controls.Add(this.nudLugares);
            this.metroPanel1.Controls.Add(this.nudPortas);
            this.metroPanel1.Controls.Add(this.nudKm);
            this.metroPanel1.Controls.Add(this.nudAno);
            this.metroPanel1.Controls.Add(this.tbCor);
            this.metroPanel1.Controls.Add(this.cbCarrocaria);
            this.metroPanel1.Controls.Add(this.cbEstado);
            this.metroPanel1.Controls.Add(this.cbCombustivel);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cbModelo);
            this.metroPanel1.Controls.Add(this.cbMarca);
            this.metroPanel1.Controls.Add(this.tbMatricula);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(8, 19);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(902, 619);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbDescricao
            // 
            // 
            // 
            // 
            this.tbDescricao.CustomButton.Image = null;
            this.tbDescricao.CustomButton.Location = new System.Drawing.Point(568, 2);
            this.tbDescricao.CustomButton.Name = "";
            this.tbDescricao.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.tbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescricao.CustomButton.TabIndex = 1;
            this.tbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescricao.CustomButton.UseSelectable = true;
            this.tbDescricao.CustomButton.Visible = false;
            this.tbDescricao.Lines = new string[0];
            this.tbDescricao.Location = new System.Drawing.Point(191, 458);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.PasswordChar = '\0';
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.SelectedText = "";
            this.tbDescricao.SelectionLength = 0;
            this.tbDescricao.SelectionStart = 0;
            this.tbDescricao.ShortcutsEnabled = true;
            this.tbDescricao.Size = new System.Drawing.Size(640, 74);
            this.tbDescricao.TabIndex = 36;
            this.tbDescricao.UseSelectable = true;
            this.tbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(73, 458);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(68, 19);
            this.metroLabel17.TabIndex = 35;
            this.metroLabel17.Text = "Descrição:";
            // 
            // tbCarroID
            // 
            // 
            // 
            // 
            this.tbCarroID.CustomButton.Image = null;
            this.tbCarroID.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.tbCarroID.CustomButton.Name = "";
            this.tbCarroID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCarroID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCarroID.CustomButton.TabIndex = 1;
            this.tbCarroID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCarroID.CustomButton.UseSelectable = true;
            this.tbCarroID.CustomButton.Visible = false;
            this.tbCarroID.Enabled = false;
            this.tbCarroID.Lines = new string[0];
            this.tbCarroID.Location = new System.Drawing.Point(193, 61);
            this.tbCarroID.MaxLength = 32767;
            this.tbCarroID.Name = "tbCarroID";
            this.tbCarroID.PasswordChar = '\0';
            this.tbCarroID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCarroID.SelectedText = "";
            this.tbCarroID.SelectionLength = 0;
            this.tbCarroID.SelectionStart = 0;
            this.tbCarroID.ShortcutsEnabled = true;
            this.tbCarroID.Size = new System.Drawing.Size(156, 23);
            this.tbCarroID.TabIndex = 34;
            this.tbCarroID.UseSelectable = true;
            this.tbCarroID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCarroID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(71, 62);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 33;
            this.metroLabel16.Text = "Carro ID:";
            // 
            // rbVendido
            // 
            this.rbVendido.AutoSize = true;
            this.rbVendido.Location = new System.Drawing.Point(767, 583);
            this.rbVendido.Name = "rbVendido";
            this.rbVendido.Size = new System.Drawing.Size(64, 17);
            this.rbVendido.TabIndex = 32;
            this.rbVendido.Text = "Vendido";
            this.rbVendido.UseVisualStyleBackColor = true;
            // 
            // rbReservado
            // 
            this.rbReservado.AutoSize = true;
            this.rbReservado.Location = new System.Drawing.Point(418, 583);
            this.rbReservado.Name = "rbReservado";
            this.rbReservado.Size = new System.Drawing.Size(77, 17);
            this.rbReservado.TabIndex = 31;
            this.rbReservado.Text = "Reservado";
            this.rbReservado.UseVisualStyleBackColor = true;
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Checked = true;
            this.rbStock.Location = new System.Drawing.Point(69, 583);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(69, 17);
            this.rbStock.TabIndex = 30;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Em stock";
            this.rbStock.UseVisualStyleBackColor = true;
            // 
            // nudPotencia
            // 
            this.nudPotencia.Location = new System.Drawing.Point(738, 100);
            this.nudPotencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPotencia.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPotencia.Name = "nudPotencia";
            this.nudPotencia.Size = new System.Drawing.Size(95, 20);
            this.nudPotencia.TabIndex = 29;
            this.nudPotencia.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudCilindrada
            // 
            this.nudCilindrada.Location = new System.Drawing.Point(738, 391);
            this.nudCilindrada.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCilindrada.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCilindrada.Name = "nudCilindrada";
            this.nudCilindrada.Size = new System.Drawing.Size(93, 20);
            this.nudCilindrada.TabIndex = 28;
            this.nudCilindrada.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(738, 340);
            this.nudPreco.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nudPreco.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(93, 20);
            this.nudPreco.TabIndex = 27;
            this.nudPreco.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudLugares
            // 
            this.nudLugares.Location = new System.Drawing.Point(738, 291);
            this.nudLugares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLugares.Name = "nudLugares";
            this.nudLugares.Size = new System.Drawing.Size(93, 20);
            this.nudLugares.TabIndex = 26;
            this.nudLugares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPortas
            // 
            this.nudPortas.Location = new System.Drawing.Point(738, 245);
            this.nudPortas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPortas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPortas.Name = "nudPortas";
            this.nudPortas.Size = new System.Drawing.Size(95, 20);
            this.nudPortas.TabIndex = 25;
            this.nudPortas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudKm
            // 
            this.nudKm.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKm.Location = new System.Drawing.Point(738, 196);
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(95, 20);
            this.nudKm.TabIndex = 24;
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(738, 146);
            this.nudAno.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(95, 20);
            this.nudAno.TabIndex = 23;
            this.nudAno.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // tbCor
            // 
            // 
            // 
            // 
            this.tbCor.CustomButton.Image = null;
            this.tbCor.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.tbCor.CustomButton.Name = "";
            this.tbCor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCor.CustomButton.TabIndex = 1;
            this.tbCor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCor.CustomButton.UseSelectable = true;
            this.tbCor.CustomButton.Visible = false;
            this.tbCor.Lines = new string[0];
            this.tbCor.Location = new System.Drawing.Point(193, 345);
            this.tbCor.MaxLength = 32767;
            this.tbCor.Name = "tbCor";
            this.tbCor.PasswordChar = '\0';
            this.tbCor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCor.SelectedText = "";
            this.tbCor.SelectionLength = 0;
            this.tbCor.SelectionStart = 0;
            this.tbCor.ShortcutsEnabled = true;
            this.tbCor.Size = new System.Drawing.Size(288, 23);
            this.tbCor.TabIndex = 22;
            this.tbCor.UseSelectable = true;
            this.tbCor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCarrocaria
            // 
            this.cbCarrocaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrocaria.FormattingEnabled = true;
            this.cbCarrocaria.Items.AddRange(new object[] {
            "Citadino",
            "Sedan",
            "Utilitário",
            "Carrinha",
            "Coupé",
            "Cabrio",
            "Monovolume",
            "SUV",
            "Pick-up",
            "Clássico",
            "Outro"});
            this.cbCarrocaria.Location = new System.Drawing.Point(195, 205);
            this.cbCarrocaria.Name = "cbCarrocaria";
            this.cbCarrocaria.Size = new System.Drawing.Size(286, 21);
            this.cbCarrocaria.TabIndex = 21;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Novo",
            "Semi-novo",
            "Usado"});
            this.cbEstado.Location = new System.Drawing.Point(193, 300);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(288, 21);
            this.cbEstado.TabIndex = 20;
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Items.AddRange(new object[] {
            "Diesel",
            "Gasolina",
            "Elétrico",
            "GPL",
            "Híbrido",
            "Outro"});
            this.cbCombustivel.Location = new System.Drawing.Point(193, 254);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(286, 21);
            this.cbCombustivel.TabIndex = 19;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(618, 391);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(72, 19);
            this.metroLabel15.TabIndex = 18;
            this.metroLabel15.Text = "Cilindrada:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(618, 149);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(36, 19);
            this.metroLabel14.TabIndex = 17;
            this.metroLabel14.Text = "Ano:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(618, 292);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(77, 19);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "Nº Lugares:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(618, 248);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(69, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "Nº Portas:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(620, 199);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(31, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Km:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(73, 297);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Estado:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(618, 341);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Preço:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(618, 103);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Potência:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(72, 392);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Matrícula:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(72, 251);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Combustível:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(73, 346);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Cor:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(73, 202);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Carroçaria:";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(193, 155);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(286, 21);
            this.cbModelo.TabIndex = 7;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(193, 109);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(286, 21);
            this.cbMarca.TabIndex = 6;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // tbMatricula
            // 
            // 
            // 
            // 
            this.tbMatricula.CustomButton.Image = null;
            this.tbMatricula.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.tbMatricula.CustomButton.Name = "";
            this.tbMatricula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMatricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMatricula.CustomButton.TabIndex = 1;
            this.tbMatricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMatricula.CustomButton.UseSelectable = true;
            this.tbMatricula.CustomButton.Visible = false;
            this.tbMatricula.Lines = new string[0];
            this.tbMatricula.Location = new System.Drawing.Point(193, 392);
            this.tbMatricula.MaxLength = 32767;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.PasswordChar = '\0';
            this.tbMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMatricula.SelectedText = "";
            this.tbMatricula.SelectionLength = 0;
            this.tbMatricula.SelectionStart = 0;
            this.tbMatricula.ShortcutsEnabled = true;
            this.tbMatricula.Size = new System.Drawing.Size(288, 23);
            this.tbMatricula.TabIndex = 5;
            this.tbMatricula.UseSelectable = true;
            this.tbMatricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMatricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(71, 152);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Modelo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Marca:";
            // 
            // btEdit
            // 
            this.btEdit.Enabled = false;
            this.btEdit.Location = new System.Drawing.Point(495, 644);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(87, 27);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Editar";
            this.btEdit.UseSelectable = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tabFotos
            // 
            this.tabFotos.Controls.Add(this.btCarregaFotos);
            this.tabFotos.Controls.Add(this.tableFotos);
            this.tabFotos.HorizontalScrollbarBarColor = true;
            this.tabFotos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFotos.HorizontalScrollbarSize = 10;
            this.tabFotos.Location = new System.Drawing.Point(4, 38);
            this.tabFotos.Name = "tabFotos";
            this.tabFotos.Size = new System.Drawing.Size(919, 866);
            this.tabFotos.TabIndex = 2;
            this.tabFotos.Text = "Fotos";
            this.tabFotos.VerticalScrollbarBarColor = true;
            this.tabFotos.VerticalScrollbarHighlightOnWheel = false;
            this.tabFotos.VerticalScrollbarSize = 10;
            // 
            // btCarregaFotos
            // 
            this.btCarregaFotos.Location = new System.Drawing.Point(381, 29);
            this.btCarregaFotos.Name = "btCarregaFotos";
            this.btCarregaFotos.Size = new System.Drawing.Size(132, 27);
            this.btCarregaFotos.TabIndex = 11;
            this.btCarregaFotos.Text = "Carregar fotos";
            this.btCarregaFotos.UseSelectable = true;
            this.btCarregaFotos.Click += new System.EventHandler(this.btCarregaFotos_Click);
            // 
            // tableFotos
            // 
            this.tableFotos.ColumnCount = 3;
            this.tableFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.Location = new System.Drawing.Point(8, 82);
            this.tableFotos.Name = "tableFotos";
            this.tableFotos.RowCount = 3;
            this.tableFotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFotos.Size = new System.Drawing.Size(908, 738);
            this.tableFotos.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 961);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Carros";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Carros";
            this.Load += new System.EventHandler(this.Carros_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabListagem.ResumeLayout(false);
            this.tabListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabRegisto.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.tabFotos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabListagem;
        private MetroFramework.Controls.MetroGrid mgCarros;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button butPesquisar;
        private MetroFramework.Controls.MetroTextBox tbTextoPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabRegisto;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btEdit;
        private MetroFramework.Controls.MetroButton btAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbMarca;
        private MetroFramework.Controls.MetroTextBox tbMatricula;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.RadioButton rbReservado;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.NumericUpDown nudPotencia;
        private System.Windows.Forms.NumericUpDown nudCilindrada;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.NumericUpDown nudLugares;
        private System.Windows.Forms.NumericUpDown nudPortas;
        private System.Windows.Forms.NumericUpDown nudKm;
        private System.Windows.Forms.NumericUpDown nudAno;
        private MetroFramework.Controls.MetroTextBox tbCor;
        private System.Windows.Forms.ComboBox cbCarrocaria;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTabPage tabFotos;
        private MetroFramework.Controls.MetroButton btCarregaFotos;
        private System.Windows.Forms.TableLayoutPanel tableFotos;
        private MetroFramework.Controls.MetroTextBox tbCarroID;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel17;
    }
}