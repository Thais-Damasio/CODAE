namespace TrabalhoFinal.Companhia.Janelas
{
    partial class JMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JMenu));
            this.btLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbMensagem1 = new System.Windows.Forms.Label();
            this.lbMensagem2 = new System.Windows.Forms.Label();
            this.Administrador = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btAdministrador = new System.Windows.Forms.Button();
            this.btSobre = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogin.BackgroundImage")));
            this.btLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(44, 152);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(108, 107);
            this.btLogin.TabIndex = 4;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Location = new System.Drawing.Point(365, 47);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(335, 318);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lbMensagem1
            // 
            this.lbMensagem1.AutoSize = true;
            this.lbMensagem1.BackColor = System.Drawing.Color.Transparent;
            this.lbMensagem1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMensagem1.Location = new System.Drawing.Point(218, 9);
            this.lbMensagem1.Name = "lbMensagem1";
            this.lbMensagem1.Size = new System.Drawing.Size(463, 22);
            this.lbMensagem1.TabIndex = 0;
            this.lbMensagem1.Text = "Seja Bem-Vindo (a) ao sistema de gerenciamento da CODAE!!";
            // 
            // lbMensagem2
            // 
            this.lbMensagem2.AutoSize = true;
            this.lbMensagem2.BackColor = System.Drawing.Color.Transparent;
            this.lbMensagem2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMensagem2.Location = new System.Drawing.Point(309, 31);
            this.lbMensagem2.Name = "lbMensagem2";
            this.lbMensagem2.Size = new System.Drawing.Size(277, 22);
            this.lbMensagem2.TabIndex = 1;
            this.lbMensagem2.Text = "Faça login para ter acesso ao sistema";
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = true;
            this.Administrador.BackColor = System.Drawing.Color.Transparent;
            this.Administrador.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.Color.White;
            this.Administrador.Location = new System.Drawing.Point(158, 65);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(70, 22);
            this.Administrador.TabIndex = 3;
            this.Administrador.Text = "ADMIN";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(163, 193);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 22);
            this.login.TabIndex = 5;
            this.login.Text = "LOGIN";
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.btAdministrador);
            this.gbMenu.Controls.Add(this.btLogin);
            this.gbMenu.Controls.Add(this.login);
            this.gbMenu.Controls.Add(this.btSobre);
            this.gbMenu.Controls.Add(this.info);
            this.gbMenu.Controls.Add(this.pbLogo);
            this.gbMenu.Controls.Add(this.Administrador);
            this.gbMenu.Location = new System.Drawing.Point(70, 66);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(737, 400);
            this.gbMenu.TabIndex = 8;
            this.gbMenu.TabStop = false;
            // 
            // btAdministrador
            // 
            this.btAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btAdministrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdministrador.BackgroundImage")));
            this.btAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdministrador.FlatAppearance.BorderSize = 0;
            this.btAdministrador.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdministrador.ForeColor = System.Drawing.Color.Transparent;
            this.btAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdministrador.Location = new System.Drawing.Point(44, 24);
            this.btAdministrador.Name = "btAdministrador";
            this.btAdministrador.Size = new System.Drawing.Size(108, 107);
            this.btAdministrador.TabIndex = 2;
            this.btAdministrador.UseVisualStyleBackColor = false;
            this.btAdministrador.Click += new System.EventHandler(this.btAdministrador_Click);
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.Transparent;
            this.btSobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSobre.BackgroundImage")));
            this.btSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSobre.FlatAppearance.BorderSize = 0;
            this.btSobre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Location = new System.Drawing.Point(44, 280);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(108, 107);
            this.btSobre.TabIndex = 6;
            this.btSobre.UseVisualStyleBackColor = false;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(163, 321);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(65, 22);
            this.info.TabIndex = 7;
            this.info.Text = "SOBRE";
            // 
            // JMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.lbMensagem2);
            this.Controls.Add(this.lbMensagem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODAE";
            this.Load += new System.EventHandler(this.JMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbMensagem1;
        private System.Windows.Forms.Label lbMensagem2;
        private System.Windows.Forms.Label Administrador;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btAdministrador;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Label info;
    }
}

