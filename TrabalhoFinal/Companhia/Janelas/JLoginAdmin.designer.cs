namespace TrabalhoFinal.Companhia.Janelas
{
    partial class JLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JLoginAdmin));
            this.lbUser = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUser.Location = new System.Drawing.Point(56, 51);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(102, 18);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Administrador:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(56, 72);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 25);
            this.txtNome.TabIndex = 1;
            // 
            // gbDados
            // 
            this.gbDados.BackColor = System.Drawing.Color.Transparent;
            this.gbDados.Controls.Add(this.btEntrar);
            this.gbDados.Controls.Add(this.txtSenha);
            this.gbDados.Controls.Add(this.lbSenha);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lbUser);
            this.gbDados.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbDados.Location = new System.Drawing.Point(44, 33);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(383, 218);
            this.gbDados.TabIndex = 2;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Black;
            this.btEntrar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEntrar.Location = new System.Drawing.Point(149, 173);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(88, 33);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(56, 129);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(270, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSenha.Location = new System.Drawing.Point(56, 108);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 18);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // JLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(476, 296);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.JLoginAdmin_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.TextBox txtSenha;
    }
}