namespace Stand_Anna
{
    partial class Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtEsconde = new MetroFramework.Controls.MetroToggle();
            this.tbUtilizador = new MetroFramework.Controls.MetroTextBox();
            this.tbSenha = new MetroFramework.Controls.MetroTextBox();
            this.cLembrar = new MetroFramework.Controls.MetroCheckBox();
            this.btEntrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(160, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Utilizador:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(160, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Senha:";
            // 
            // mtEsconde
            // 
            this.mtEsconde.AutoSize = true;
            this.mtEsconde.Location = new System.Drawing.Point(446, 170);
            this.mtEsconde.Name = "mtEsconde";
            this.mtEsconde.Size = new System.Drawing.Size(80, 17);
            this.mtEsconde.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtEsconde.TabIndex = 4;
            this.mtEsconde.Text = "Off";
            this.mtEsconde.UseSelectable = true;
            this.mtEsconde.CheckedChanged += new System.EventHandler(this.mtEsconde_CheckedChanged);
            // 
            // tbUtilizador
            // 
            // 
            // 
            // 
            this.tbUtilizador.CustomButton.Image = null;
            this.tbUtilizador.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbUtilizador.CustomButton.Name = "";
            this.tbUtilizador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUtilizador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUtilizador.CustomButton.TabIndex = 1;
            this.tbUtilizador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUtilizador.CustomButton.UseSelectable = true;
            this.tbUtilizador.CustomButton.Visible = false;
            this.tbUtilizador.Lines = new string[0];
            this.tbUtilizador.Location = new System.Drawing.Point(249, 118);
            this.tbUtilizador.MaxLength = 32767;
            this.tbUtilizador.Name = "tbUtilizador";
            this.tbUtilizador.PasswordChar = '\0';
            this.tbUtilizador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUtilizador.SelectedText = "";
            this.tbUtilizador.SelectionLength = 0;
            this.tbUtilizador.SelectionStart = 0;
            this.tbUtilizador.ShortcutsEnabled = true;
            this.tbUtilizador.Size = new System.Drawing.Size(191, 23);
            this.tbUtilizador.TabIndex = 5;
            this.tbUtilizador.UseSelectable = true;
            this.tbUtilizador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUtilizador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSenha
            // 
            // 
            // 
            // 
            this.tbSenha.CustomButton.Image = null;
            this.tbSenha.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbSenha.CustomButton.Name = "";
            this.tbSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSenha.CustomButton.TabIndex = 1;
            this.tbSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSenha.CustomButton.UseSelectable = true;
            this.tbSenha.CustomButton.Visible = false;
            this.tbSenha.Lines = new string[0];
            this.tbSenha.Location = new System.Drawing.Point(249, 168);
            this.tbSenha.MaxLength = 32767;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '\0';
            this.tbSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSenha.SelectedText = "";
            this.tbSenha.SelectionLength = 0;
            this.tbSenha.SelectionStart = 0;
            this.tbSenha.ShortcutsEnabled = true;
            this.tbSenha.Size = new System.Drawing.Size(191, 23);
            this.tbSenha.TabIndex = 6;
            this.tbSenha.UseSelectable = true;
            this.tbSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cLembrar
            // 
            this.cLembrar.AutoSize = true;
            this.cLembrar.Location = new System.Drawing.Point(87, 339);
            this.cLembrar.Name = "cLembrar";
            this.cLembrar.Size = new System.Drawing.Size(120, 15);
            this.cLembrar.Style = MetroFramework.MetroColorStyle.Purple;
            this.cLembrar.TabIndex = 7;
            this.cLembrar.Text = "Lembrar Utilizador";
            this.cLembrar.UseSelectable = true;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(160, 232);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(366, 67);
            this.btEntrar.TabIndex = 8;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseSelectable = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.cLembrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUtilizador);
            this.Controls.Add(this.mtEsconde);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle mtEsconde;
        private MetroFramework.Controls.MetroTextBox tbUtilizador;
        private MetroFramework.Controls.MetroTextBox tbSenha;
        private MetroFramework.Controls.MetroCheckBox cLembrar;
        private MetroFramework.Controls.MetroButton btEntrar;
    }
}