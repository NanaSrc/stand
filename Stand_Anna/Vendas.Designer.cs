namespace Stand_Anna
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btEdit = new MetroFramework.Controls.MetroButton();
            this.btAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.dtData = new MetroFramework.Controls.MetroDateTime();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.mgVendas = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.butPesquisar = new System.Windows.Forms.Button();
            this.tbTextoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.tabListagem = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabRegisto = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbVendaID = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabListagem.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabRegisto.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(69, 223);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Preço:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(69, 177);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Data:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Cliente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Carro:";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Enabled = false;
            this.btDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btDelete.Location = new System.Drawing.Point(518, 228);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 27);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(518, 137);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 27);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Salvar";
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Procurar por:";
            // 
            // btEdit
            // 
            this.btEdit.Enabled = false;
            this.btEdit.Location = new System.Drawing.Point(518, 184);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 27);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Editar";
            this.btEdit.UseSelectable = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(518, 94);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Novo";
            this.btAdd.UseSelectable = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbVendaID);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.cbCliente);
            this.metroPanel1.Controls.Add(this.nudPreco);
            this.metroPanel1.Controls.Add(this.dtData);
            this.metroPanel1.Controls.Add(this.cbCarro);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 21);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(495, 308);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(158, 132);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(275, 21);
            this.cbCliente.TabIndex = 13;
            // 
            // nudPreco
            // 
            this.nudPreco.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPreco.Location = new System.Drawing.Point(158, 223);
            this.nudPreco.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPreco.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(125, 20);
            this.nudPreco.TabIndex = 12;
            this.nudPreco.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(158, 177);
            this.dtData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(125, 29);
            this.dtData.TabIndex = 11;
            // 
            // cbCarro
            // 
            this.cbCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(158, 89);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(275, 21);
            this.cbCarro.TabIndex = 10;
            // 
            // mgVendas
            // 
            this.mgVendas.AllowUserToResizeRows = false;
            this.mgVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.mgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgVendas.DefaultCellStyle = dataGridViewCellStyle14;
            this.mgVendas.EnableHeadersVisualStyles = false;
            this.mgVendas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgVendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVendas.Location = new System.Drawing.Point(3, 73);
            this.mgVendas.MultiSelect = false;
            this.mgVendas.Name = "mgVendas";
            this.mgVendas.ReadOnly = true;
            this.mgVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.mgVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgVendas.Size = new System.Drawing.Size(901, 757);
            this.mgVendas.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgVendas.TabIndex = 7;
            this.mgVendas.DoubleClick += new System.EventHandler(this.mgVendas_DoubleClick);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(169, 84);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(8, 8);
            this.metroGrid1.TabIndex = 6;
            // 
            // butPesquisar
            // 
            this.butPesquisar.Location = new System.Drawing.Point(501, 26);
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
            this.tbTextoPesquisa.Location = new System.Drawing.Point(232, 26);
            this.tbTextoPesquisa.MaxLength = 32767;
            this.tbTextoPesquisa.Name = "tbTextoPesquisa";
            this.tbTextoPesquisa.PasswordChar = '\0';
            this.tbTextoPesquisa.WaterMark = "Insira um valor";
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
            "Cliente",
            "Data"});
            this.cbPesquisar.Location = new System.Drawing.Point(93, 26);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(133, 21);
            this.cbPesquisar.TabIndex = 3;
            // 
            // tabListagem
            // 
            this.tabListagem.BackColor = System.Drawing.Color.Black;
            this.tabListagem.Controls.Add(this.mgVendas);
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
            this.tabListagem.Size = new System.Drawing.Size(907, 833);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Listagem";
            this.tabListagem.VerticalScrollbarBarColor = true;
            this.tabListagem.VerticalScrollbarHighlightOnWheel = false;
            this.tabListagem.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabListagem);
            this.metroTabControl1.Controls.Add(this.tabRegisto);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(915, 875);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.btDelete);
            this.tabRegisto.Controls.Add(this.btSave);
            this.tabRegisto.Controls.Add(this.btEdit);
            this.tabRegisto.Controls.Add(this.btAdd);
            this.tabRegisto.Controls.Add(this.metroPanel1);
            this.tabRegisto.HorizontalScrollbarBarColor = true;
            this.tabRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegisto.HorizontalScrollbarSize = 10;
            this.tabRegisto.Location = new System.Drawing.Point(4, 38);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.Size = new System.Drawing.Size(907, 833);
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.Text = "Registo";
            this.tabRegisto.VerticalScrollbarBarColor = true;
            this.tabRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegisto.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(69, 46);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "VendaID:";
            // 
            // tbVendaID
            // 
            // 
            // 
            // 
            this.tbVendaID.CustomButton.Image = null;
            this.tbVendaID.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbVendaID.CustomButton.Name = "";
            this.tbVendaID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbVendaID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbVendaID.CustomButton.TabIndex = 1;
            this.tbVendaID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbVendaID.CustomButton.UseSelectable = true;
            this.tbVendaID.CustomButton.Visible = false;
            this.tbVendaID.Enabled = false;
            this.tbVendaID.Lines = new string[0];
            this.tbVendaID.Location = new System.Drawing.Point(158, 46);
            this.tbVendaID.MaxLength = 32767;
            this.tbVendaID.Name = "tbVendaID";
            this.tbVendaID.PasswordChar = '\0';
            this.tbVendaID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVendaID.SelectedText = "";
            this.tbVendaID.SelectionLength = 0;
            this.tbVendaID.SelectionStart = 0;
            this.tbVendaID.ShortcutsEnabled = true;
            this.tbVendaID.Size = new System.Drawing.Size(75, 23);
            this.tbVendaID.TabIndex = 15;
            this.tbVendaID.UseSelectable = true;
            this.tbVendaID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbVendaID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 961);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Vendas";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabListagem.ResumeLayout(false);
            this.tabListagem.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabRegisto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btEdit;
        private MetroFramework.Controls.MetroButton btAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mgVendas;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button butPesquisar;
        private MetroFramework.Controls.MetroTextBox tbTextoPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private MetroFramework.Controls.MetroTabPage tabListagem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabRegisto;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private MetroFramework.Controls.MetroDateTime dtData;
        private System.Windows.Forms.ComboBox cbCarro;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbVendaID;
    }
}