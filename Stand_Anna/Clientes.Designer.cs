namespace Stand_Anna
{
    partial class Clientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
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
            this.mgClientes = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.butPesquisar = new System.Windows.Forms.Button();
            this.tbTextoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabRegisto = new MetroFramework.Controls.MetroTabPage();
            this.btAdd = new MetroFramework.Controls.MetroButton();
            this.btEdit = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbClienteID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbCC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbNif = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbTelemovel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.tabImprimir = new MetroFramework.Controls.MetroTabPage();
            this.btImprimirFicha = new MetroFramework.Controls.MetroButton();
            this.btImprimirLista = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabRegisto.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabImprimir.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabListagem);
            this.metroTabControl1.Controls.Add(this.tabRegisto);
            this.metroTabControl1.Controls.Add(this.tabImprimir);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(915, 883);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabListagem
            // 
            this.tabListagem.BackColor = System.Drawing.Color.Black;
            this.tabListagem.Controls.Add(this.mgClientes);
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
            this.tabListagem.Size = new System.Drawing.Size(907, 841);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Listagem";
            this.tabListagem.VerticalScrollbarBarColor = true;
            this.tabListagem.VerticalScrollbarHighlightOnWheel = false;
            this.tabListagem.VerticalScrollbarSize = 10;
            // 
            // mgClientes
            // 
            this.mgClientes.AllowUserToResizeRows = false;
            this.mgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgClientes.EnableHeadersVisualStyles = false;
            this.mgClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgClientes.Location = new System.Drawing.Point(3, 73);
            this.mgClientes.MultiSelect = false;
            this.mgClientes.Name = "mgClientes";
            this.mgClientes.ReadOnly = true;
            this.mgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgClientes.Size = new System.Drawing.Size(901, 763);
            this.mgClientes.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgClientes.TabIndex = 7;
            this.mgClientes.DoubleClick += new System.EventHandler(this.mgClientes_DoubleClick);
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
            this.butPesquisar.Location = new System.Drawing.Point(500, 28);
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
            this.tbTextoPesquisa.Location = new System.Drawing.Point(231, 28);
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
            "Nome",
            "CC",
            "NIF"});
            this.cbPesquisar.Location = new System.Drawing.Point(92, 28);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(133, 21);
            this.cbPesquisar.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Procurar por:";
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.btAdd);
            this.tabRegisto.Controls.Add(this.btEdit);
            this.tabRegisto.Controls.Add(this.btDelete);
            this.tabRegisto.Controls.Add(this.metroPanel1);
            this.tabRegisto.Controls.Add(this.btSave);
            this.tabRegisto.HorizontalScrollbarBarColor = true;
            this.tabRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegisto.HorizontalScrollbarSize = 10;
            this.tabRegisto.Location = new System.Drawing.Point(4, 38);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.Size = new System.Drawing.Size(907, 841);
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.Text = "Registo";
            this.tabRegisto.VerticalScrollbarBarColor = true;
            this.tabRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegisto.VerticalScrollbarSize = 10;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(637, 125);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Novo";
            this.btAdd.UseSelectable = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Enabled = false;
            this.btEdit.Location = new System.Drawing.Point(637, 228);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 27);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Editar";
            this.btEdit.UseSelectable = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Enabled = false;
            this.btDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btDelete.Location = new System.Drawing.Point(637, 281);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 27);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbClienteID);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.tbCC);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.tbNif);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.tbEmail);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.tbTelemovel);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.tbNome);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(624, 383);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbClienteID
            // 
            // 
            // 
            // 
            this.tbClienteID.CustomButton.Image = null;
            this.tbClienteID.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbClienteID.CustomButton.Name = "";
            this.tbClienteID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbClienteID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbClienteID.CustomButton.TabIndex = 1;
            this.tbClienteID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbClienteID.CustomButton.UseSelectable = true;
            this.tbClienteID.CustomButton.Visible = false;
            this.tbClienteID.Enabled = false;
            this.tbClienteID.Lines = new string[0];
            this.tbClienteID.Location = new System.Drawing.Point(151, 41);
            this.tbClienteID.MaxLength = 32767;
            this.tbClienteID.Name = "tbClienteID";
            this.tbClienteID.PasswordChar = '\0';
            this.tbClienteID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClienteID.SelectedText = "";
            this.tbClienteID.SelectionLength = 0;
            this.tbClienteID.SelectionStart = 0;
            this.tbClienteID.ShortcutsEnabled = true;
            this.tbClienteID.Size = new System.Drawing.Size(381, 23);
            this.tbClienteID.TabIndex = 13;
            this.tbClienteID.UseSelectable = true;
            this.tbClienteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClienteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(62, 41);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "ClienteID:";
            // 
            // tbCC
            // 
            // 
            // 
            // 
            this.tbCC.CustomButton.Image = null;
            this.tbCC.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbCC.CustomButton.Name = "";
            this.tbCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCC.CustomButton.TabIndex = 1;
            this.tbCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCC.CustomButton.UseSelectable = true;
            this.tbCC.CustomButton.Visible = false;
            this.tbCC.Lines = new string[0];
            this.tbCC.Location = new System.Drawing.Point(151, 315);
            this.tbCC.MaxLength = 12;
            this.tbCC.Name = "tbCC";
            this.tbCC.PasswordChar = '\0';
            this.tbCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCC.SelectedText = "";
            this.tbCC.SelectionLength = 0;
            this.tbCC.SelectionStart = 0;
            this.tbCC.ShortcutsEnabled = true;
            this.tbCC.Size = new System.Drawing.Size(381, 23);
            this.tbCC.TabIndex = 11;
            this.tbCC.UseSelectable = true;
            this.tbCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCC.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(62, 315);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(29, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "CC:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // tbNif
            // 
            // 
            // 
            // 
            this.tbNif.CustomButton.Image = null;
            this.tbNif.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbNif.CustomButton.Name = "";
            this.tbNif.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNif.CustomButton.TabIndex = 1;
            this.tbNif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNif.CustomButton.UseSelectable = true;
            this.tbNif.CustomButton.Visible = false;
            this.tbNif.Lines = new string[0];
            this.tbNif.Location = new System.Drawing.Point(151, 255);
            this.tbNif.MaxLength = 9;
            this.tbNif.Name = "tbNif";
            this.tbNif.PasswordChar = '\0';
            this.tbNif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNif.SelectedText = "";
            this.tbNif.SelectionLength = 0;
            this.tbNif.SelectionStart = 0;
            this.tbNif.ShortcutsEnabled = true;
            this.tbNif.Size = new System.Drawing.Size(381, 23);
            this.tbNif.TabIndex = 9;
            this.tbNif.UseSelectable = true;
            this.tbNif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(62, 255);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Nif:";
            // 
            // tbEmail
            // 
            // 
            // 
            // 
            this.tbEmail.CustomButton.Image = null;
            this.tbEmail.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbEmail.CustomButton.Name = "";
            this.tbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmail.CustomButton.TabIndex = 1;
            this.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmail.CustomButton.UseSelectable = true;
            this.tbEmail.CustomButton.Visible = false;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(151, 196);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(381, 23);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.UseSelectable = true;
            this.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Email:";
            // 
            // tbTelemovel
            // 
            // 
            // 
            // 
            this.tbTelemovel.CustomButton.Image = null;
            this.tbTelemovel.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbTelemovel.CustomButton.Name = "";
            this.tbTelemovel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTelemovel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTelemovel.CustomButton.TabIndex = 1;
            this.tbTelemovel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTelemovel.CustomButton.UseSelectable = true;
            this.tbTelemovel.CustomButton.Visible = false;
            this.tbTelemovel.Lines = new string[0];
            this.tbTelemovel.Location = new System.Drawing.Point(151, 140);
            this.tbTelemovel.MaxLength = 9;
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.PasswordChar = '\0';
            this.tbTelemovel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTelemovel.SelectedText = "";
            this.tbTelemovel.SelectionLength = 0;
            this.tbTelemovel.SelectionStart = 0;
            this.tbTelemovel.ShortcutsEnabled = true;
            this.tbTelemovel.Size = new System.Drawing.Size(381, 23);
            this.tbTelemovel.TabIndex = 5;
            this.tbTelemovel.UseSelectable = true;
            this.tbTelemovel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTelemovel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Telemóvel:";
            // 
            // tbNome
            // 
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(151, 90);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.ShortcutsEnabled = true;
            this.tbNome.Size = new System.Drawing.Size(381, 23);
            this.tbNome.TabIndex = 3;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nome:";
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(637, 177);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 27);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Salvar";
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tabImprimir
            // 
            this.tabImprimir.Controls.Add(this.btImprimirFicha);
            this.tabImprimir.Controls.Add(this.btImprimirLista);
            this.tabImprimir.HorizontalScrollbarBarColor = true;
            this.tabImprimir.HorizontalScrollbarHighlightOnWheel = false;
            this.tabImprimir.HorizontalScrollbarSize = 10;
            this.tabImprimir.Location = new System.Drawing.Point(4, 38);
            this.tabImprimir.Name = "tabImprimir";
            this.tabImprimir.Size = new System.Drawing.Size(907, 841);
            this.tabImprimir.TabIndex = 2;
            this.tabImprimir.Text = "Imprimir";
            this.tabImprimir.VerticalScrollbarBarColor = true;
            this.tabImprimir.VerticalScrollbarHighlightOnWheel = false;
            this.tabImprimir.VerticalScrollbarSize = 10;
            // 
            // btImprimirFicha
            // 
            this.btImprimirFicha.Location = new System.Drawing.Point(344, 265);
            this.btImprimirFicha.Name = "btImprimirFicha";
            this.btImprimirFicha.Size = new System.Drawing.Size(220, 92);
            this.btImprimirFicha.TabIndex = 3;
            this.btImprimirFicha.Text = "Imprimir ficha de cliente";
            this.btImprimirFicha.UseSelectable = true;
            // 
            // btImprimirLista
            // 
            this.btImprimirLista.Location = new System.Drawing.Point(344, 112);
            this.btImprimirLista.Name = "btImprimirLista";
            this.btImprimirLista.Size = new System.Drawing.Size(220, 92);
            this.btImprimirLista.TabIndex = 2;
            this.btImprimirLista.Text = "Imprimir lista de clientes";
            this.btImprimirLista.UseSelectable = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 961);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Clientes";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabListagem.ResumeLayout(false);
            this.tabListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabRegisto.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabImprimir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabListagem;
        private System.Windows.Forms.Button butPesquisar;
        private MetroFramework.Controls.MetroTextBox tbTextoPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabRegisto;
        private MetroFramework.Controls.MetroGrid mgClientes;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox tbCC;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbNif;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbEmail;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbTelemovel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btEdit;
        private MetroFramework.Controls.MetroButton btAdd;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroTextBox tbClienteID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTabPage tabImprimir;
        private MetroFramework.Controls.MetroButton btImprimirFicha;
        private MetroFramework.Controls.MetroButton btImprimirLista;
    }
}

