namespace Stand_Anna
{
    partial class Menu
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
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.mtMarcas = new MetroFramework.Controls.MetroTile();
            this.mtVendas = new MetroFramework.Controls.MetroTile();
            this.mtSair = new MetroFramework.Controls.MetroTile();
            this.mtCarros = new MetroFramework.Controls.MetroTile();
            this.mtClientes = new MetroFramework.Controls.MetroTile();
            this.mtModelos = new MetroFramework.Controls.MetroTile();
            this.PanelPrincipal = new MetroFramework.Controls.MetroPanel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.mtMarcas);
            this.panelMenu.Controls.Add(this.mtVendas);
            this.panelMenu.Controls.Add(this.mtSair);
            this.panelMenu.Controls.Add(this.mtCarros);
            this.panelMenu.Controls.Add(this.mtClientes);
            this.panelMenu.Controls.Add(this.mtModelos);
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 10;
            this.panelMenu.Location = new System.Drawing.Point(23, 63);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(181, 961);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 10;
            // 
            // mtMarcas
            // 
            this.mtMarcas.ActiveControl = null;
            this.mtMarcas.BackColor = System.Drawing.Color.LightGray;
            this.mtMarcas.Location = new System.Drawing.Point(3, 405);
            this.mtMarcas.Name = "mtMarcas";
            this.mtMarcas.Size = new System.Drawing.Size(175, 128);
            this.mtMarcas.TabIndex = 5;
            this.mtMarcas.Text = "Marcas";
            this.mtMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMarcas.TileImage = global::Stand_Anna.Properties.Resources.marcasx64;
            this.mtMarcas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMarcas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtMarcas.UseCustomBackColor = true;
            this.mtMarcas.UseCustomForeColor = true;
            this.mtMarcas.UseSelectable = true;
            this.mtMarcas.UseTileImage = true;
            this.mtMarcas.Click += new System.EventHandler(this.mtMarcas_Click);
            // 
            // mtVendas
            // 
            this.mtVendas.ActiveControl = null;
            this.mtVendas.BackColor = System.Drawing.Color.Silver;
            this.mtVendas.Location = new System.Drawing.Point(3, 271);
            this.mtVendas.Name = "mtVendas";
            this.mtVendas.Size = new System.Drawing.Size(175, 128);
            this.mtVendas.TabIndex = 4;
            this.mtVendas.Text = "Vendas";
            this.mtVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtVendas.TileImage = global::Stand_Anna.Properties.Resources.vendasx54;
            this.mtVendas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtVendas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtVendas.UseCustomBackColor = true;
            this.mtVendas.UseCustomForeColor = true;
            this.mtVendas.UseSelectable = true;
            this.mtVendas.UseTileImage = true;
            this.mtVendas.Click += new System.EventHandler(this.mtVendas_Click);
            // 
            // mtSair
            // 
            this.mtSair.ActiveControl = null;
            this.mtSair.BackColor = System.Drawing.Color.MistyRose;
            this.mtSair.Location = new System.Drawing.Point(3, 673);
            this.mtSair.Name = "mtSair";
            this.mtSair.Size = new System.Drawing.Size(175, 285);
            this.mtSair.TabIndex = 7;
            this.mtSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSair.TileImage = global::Stand_Anna.Properties.Resources.home;
            this.mtSair.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSair.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtSair.UseCustomBackColor = true;
            this.mtSair.UseCustomForeColor = true;
            this.mtSair.UseSelectable = true;
            this.mtSair.UseTileImage = true;
            this.mtSair.Click += new System.EventHandler(this.mtSair_Click);
            // 
            // mtCarros
            // 
            this.mtCarros.ActiveControl = null;
            this.mtCarros.BackColor = System.Drawing.Color.DimGray;
            this.mtCarros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtCarros.Location = new System.Drawing.Point(3, 3);
            this.mtCarros.Name = "mtCarros";
            this.mtCarros.Size = new System.Drawing.Size(175, 128);
            this.mtCarros.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtCarros.TabIndex = 2;
            this.mtCarros.Text = "Carros";
            this.mtCarros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCarros.TileImage = global::Stand_Anna.Properties.Resources.carx64;
            this.mtCarros.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCarros.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCarros.UseCustomBackColor = true;
            this.mtCarros.UseCustomForeColor = true;
            this.mtCarros.UseSelectable = true;
            this.mtCarros.UseTileImage = true;
            this.mtCarros.Click += new System.EventHandler(this.mtCarros_Click);
            // 
            // mtClientes
            // 
            this.mtClientes.ActiveControl = null;
            this.mtClientes.BackColor = System.Drawing.Color.DarkGray;
            this.mtClientes.Location = new System.Drawing.Point(3, 137);
            this.mtClientes.Name = "mtClientes";
            this.mtClientes.Size = new System.Drawing.Size(175, 128);
            this.mtClientes.TabIndex = 3;
            this.mtClientes.Text = "Clientes";
            this.mtClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtClientes.TileImage = global::Stand_Anna.Properties.Resources.clientex64;
            this.mtClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtClientes.UseCustomBackColor = true;
            this.mtClientes.UseCustomForeColor = true;
            this.mtClientes.UseSelectable = true;
            this.mtClientes.UseTileImage = true;
            this.mtClientes.Click += new System.EventHandler(this.mtClientes_Click);
            // 
            // mtModelos
            // 
            this.mtModelos.ActiveControl = null;
            this.mtModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mtModelos.Location = new System.Drawing.Point(3, 539);
            this.mtModelos.Name = "mtModelos";
            this.mtModelos.Size = new System.Drawing.Size(175, 128);
            this.mtModelos.TabIndex = 6;
            this.mtModelos.Text = "Modelos";
            this.mtModelos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtModelos.TileImage = global::Stand_Anna.Properties.Resources.modelosx64;
            this.mtModelos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModelos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtModelos.UseCustomBackColor = true;
            this.mtModelos.UseCustomForeColor = true;
            this.mtModelos.UseSelectable = true;
            this.mtModelos.UseTileImage = true;
            this.mtModelos.Click += new System.EventHandler(this.mtModelos_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackgroundImage = global::Stand_Anna.Properties.Resources.car;
            this.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelPrincipal.HorizontalScrollbarBarColor = true;
            this.PanelPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelPrincipal.HorizontalScrollbarSize = 10;
            this.PanelPrincipal.Location = new System.Drawing.Point(219, 63);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(961, 961);
            this.PanelPrincipal.TabIndex = 0;
            this.PanelPrincipal.VerticalScrollbarBarColor = true;
            this.PanelPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.PanelPrincipal.VerticalScrollbarSize = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 1054);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelPrincipal;
        private MetroFramework.Controls.MetroPanel panelMenu;
        private MetroFramework.Controls.MetroTile mtCarros;
        private MetroFramework.Controls.MetroTile mtClientes;
        private MetroFramework.Controls.MetroTile mtVendas;
        private MetroFramework.Controls.MetroTile mtMarcas;
        private MetroFramework.Controls.MetroTile mtModelos;
        private MetroFramework.Controls.MetroTile mtSair;
    }
}