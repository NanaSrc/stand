namespace Stand_Anna
{
    partial class Marca
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
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabRegisto = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.butPesquisar = new System.Windows.Forms.Button();
            this.tbTextoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.mgMarcas = new MetroFramework.Controls.MetroGrid();
            this.tabListagem = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroPanel1.SuspendLayout();
            this.tabRegisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgMarcas)).BeginInit();
            this.tabListagem.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Enabled = false;
            this.btDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btDelete.Location = new System.Drawing.Point(574, 114);
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
            this.btSave.Location = new System.Drawing.Point(574, 65);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 27);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Salvar";
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(574, 20);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Novo";
            this.btAdd.UseSelectable = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbMarca);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 20);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(565, 168);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbMarca
            // 
            // 
            // 
            // 
            this.tbMarca.CustomButton.Image = null;
            this.tbMarca.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbMarca.CustomButton.Name = "";
            this.tbMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMarca.CustomButton.TabIndex = 1;
            this.tbMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMarca.CustomButton.UseSelectable = true;
            this.tbMarca.CustomButton.Visible = false;
            this.tbMarca.Lines = new string[0];
            this.tbMarca.Location = new System.Drawing.Point(134, 65);
            this.tbMarca.MaxLength = 32767;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.PasswordChar = '\0';
            this.tbMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMarca.SelectedText = "";
            this.tbMarca.SelectionLength = 0;
            this.tbMarca.SelectionStart = 0;
            this.tbMarca.ShortcutsEnabled = true;
            this.tbMarca.Size = new System.Drawing.Size(381, 23);
            this.tbMarca.TabIndex = 3;
            this.tbMarca.UseSelectable = true;
            this.tbMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Marca:";

            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.btDelete);
            this.tabRegisto.Controls.Add(this.btSave);
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(169, 84);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(8, 8);
            this.metroGrid1.TabIndex = 6;
            // 
            // butPesquisar
            // 
            this.butPesquisar.Location = new System.Drawing.Point(360, 26);
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
            this.tbTextoPesquisa.Location = new System.Drawing.Point(91, 26);
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
            // mgMarcas
            // 
            this.mgMarcas.AllowUserToResizeRows = false;
            this.mgMarcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.mgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgMarcas.DefaultCellStyle = dataGridViewCellStyle17;
            this.mgMarcas.EnableHeadersVisualStyles = false;
            this.mgMarcas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgMarcas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgMarcas.Location = new System.Drawing.Point(0, 73);
            this.mgMarcas.MultiSelect = false;
            this.mgMarcas.Name = "mgMarcas";
            this.mgMarcas.ReadOnly = true;
            this.mgMarcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.mgMarcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgMarcas.Size = new System.Drawing.Size(904, 760);
            this.mgMarcas.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgMarcas.TabIndex = 7;
            this.mgMarcas.DoubleClick += new System.EventHandler(this.mgMarcas_DoubleClick);
            // 
            // tabListagem
            // 
            this.tabListagem.BackColor = System.Drawing.Color.Black;
            this.tabListagem.Controls.Add(this.mgMarcas);
            this.tabListagem.Controls.Add(this.metroGrid1);
            this.tabListagem.Controls.Add(this.butPesquisar);
            this.tabListagem.Controls.Add(this.tbTextoPesquisa);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-3, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Procurar por:";
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
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 961);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Marca";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marca_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabRegisto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgMarcas)).EndInit();
            this.tabListagem.ResumeLayout(false);
            this.tabListagem.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox tbMarca;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage tabRegisto;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button butPesquisar;
        private MetroFramework.Controls.MetroTextBox tbTextoPesquisa;
        private MetroFramework.Controls.MetroGrid mgMarcas;
        private MetroFramework.Controls.MetroTabPage tabListagem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}