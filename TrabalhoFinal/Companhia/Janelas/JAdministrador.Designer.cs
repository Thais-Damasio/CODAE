namespace TrabalhoFinal.Companhia.Janelas
{
    partial class JAdministrador
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
            this.btCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btEditarCadastro = new System.Windows.Forms.Button();
            this.btConfiguracoesGerais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarFuncionario
            // 
            this.btCadastrarFuncionario.Location = new System.Drawing.Point(66, 109);
            this.btCadastrarFuncionario.Name = "btCadastrarFuncionario";
            this.btCadastrarFuncionario.Size = new System.Drawing.Size(125, 117);
            this.btCadastrarFuncionario.TabIndex = 0;
            this.btCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btCadastrarFuncionario.Click += new System.EventHandler(this.btCadastrarFuncionario_Click);
            // 
            // btEditarCadastro
            // 
            this.btEditarCadastro.Location = new System.Drawing.Point(240, 109);
            this.btEditarCadastro.Name = "btEditarCadastro";
            this.btEditarCadastro.Size = new System.Drawing.Size(125, 117);
            this.btEditarCadastro.TabIndex = 1;
            this.btEditarCadastro.UseVisualStyleBackColor = true;
            this.btEditarCadastro.Click += new System.EventHandler(this.btEditarCadastro_Click);
            // 
            // btConfiguracoesGerais
            // 
            this.btConfiguracoesGerais.Location = new System.Drawing.Point(414, 109);
            this.btConfiguracoesGerais.Name = "btConfiguracoesGerais";
            this.btConfiguracoesGerais.Size = new System.Drawing.Size(125, 117);
            this.btConfiguracoesGerais.TabIndex = 2;
            this.btConfiguracoesGerais.UseVisualStyleBackColor = true;
            // 
            // JAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 356);
            this.Controls.Add(this.btConfiguracoesGerais);
            this.Controls.Add(this.btEditarCadastro);
            this.Controls.Add(this.btCadastrarFuncionario);
            this.Name = "JAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.JAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarFuncionario;
        private System.Windows.Forms.Button btEditarCadastro;
        private System.Windows.Forms.Button btConfiguracoesGerais;
    }
}