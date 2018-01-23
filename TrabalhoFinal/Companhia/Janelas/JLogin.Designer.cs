namespace TrabalhoFinal.Companhia.Janelas
{
    partial class JLogin
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
            this.gbAcesso = new System.Windows.Forms.GroupBox();
            this.cbTipoUser = new System.Windows.Forms.ComboBox();
            this.lbTipoUser = new System.Windows.Forms.Label();
            this.lbNaoCadastrado = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.gbAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAcesso
            // 
            this.gbAcesso.BackColor = System.Drawing.Color.Transparent;
            this.gbAcesso.Controls.Add(this.cbTipoUser);
            this.gbAcesso.Controls.Add(this.lbTipoUser);
            this.gbAcesso.Controls.Add(this.lbNaoCadastrado);
            this.gbAcesso.Controls.Add(this.pbLogo);
            this.gbAcesso.Controls.Add(this.btEntrar);
            this.gbAcesso.Controls.Add(this.txtSenha);
            this.gbAcesso.Controls.Add(this.lbSenha);
            this.gbAcesso.Controls.Add(this.txtDocumento);
            this.gbAcesso.Controls.Add(this.lbDocumento);
            this.gbAcesso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcesso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbAcesso.Location = new System.Drawing.Point(25, 28);
            this.gbAcesso.Name = "gbAcesso";
            this.gbAcesso.Size = new System.Drawing.Size(642, 262);
            this.gbAcesso.TabIndex = 0;
            this.gbAcesso.TabStop = false;
            this.gbAcesso.Text = "Acesso";
            // 
            // cbTipoUser
            // 
            this.cbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUser.FormattingEnabled = true;
            this.cbTipoUser.Items.AddRange(new object[] {
            "-Selecione um item-",
            "Funcionário",
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cbTipoUser.Location = new System.Drawing.Point(120, 44);
            this.cbTipoUser.Name = "cbTipoUser";
            this.cbTipoUser.Size = new System.Drawing.Size(188, 26);
            this.cbTipoUser.TabIndex = 12;
            this.cbTipoUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            // 
            // lbTipoUser
            // 
            this.lbTipoUser.AutoSize = true;
            this.lbTipoUser.BackColor = System.Drawing.Color.Transparent;
            this.lbTipoUser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoUser.ForeColor = System.Drawing.Color.White;
            this.lbTipoUser.Location = new System.Drawing.Point(6, 47);
            this.lbTipoUser.Name = "lbTipoUser";
            this.lbTipoUser.Size = new System.Drawing.Size(104, 18);
            this.lbTipoUser.TabIndex = 11;
            this.lbTipoUser.Text = "Tipo de úsuario:";
            // 
            // lbNaoCadastrado
            // 
            this.lbNaoCadastrado.AutoSize = true;
            this.lbNaoCadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaoCadastrado.ForeColor = System.Drawing.Color.Red;
            this.lbNaoCadastrado.Location = new System.Drawing.Point(313, 86);
            this.lbNaoCadastrado.Name = "lbNaoCadastrado";
            this.lbNaoCadastrado.Size = new System.Drawing.Size(0, 13);
            this.lbNaoCadastrado.TabIndex = 6;
            this.lbNaoCadastrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(392, 31);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(212, 201);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Black;
            this.btEntrar.Location = new System.Drawing.Point(153, 173);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(119, 49);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(120, 122);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(188, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.White;
            this.lbSenha.Location = new System.Drawing.Point(6, 125);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 18);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(120, 83);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(188, 25);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.Leave += new System.EventHandler(this.CPF_Leave);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lbDocumento.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumento.ForeColor = System.Drawing.Color.White;
            this.lbDocumento.Location = new System.Drawing.Point(6, 86);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(108, 18);
            this.lbDocumento.TabIndex = 0;
            this.lbDocumento.Text = "Tipo documento:";
            // 
            // JLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(689, 320);
            this.Controls.Add(this.gbAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.JLogin_Load);
            this.gbAcesso.ResumeLayout(false);
            this.gbAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcesso;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbNaoCadastrado;
        private System.Windows.Forms.ComboBox cbTipoUser;
        private System.Windows.Forms.Label lbTipoUser;
    }
}