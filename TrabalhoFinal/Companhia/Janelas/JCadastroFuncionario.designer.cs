namespace TrabalhoFinal.Companhia.Janelas
{
    partial class JCadastroFuncionario
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
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbTipoResidencia = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbTipoResidencia = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbCaminho = new System.Windows.Forms.Label();
            this.btEscolherImagem = new System.Windows.Forms.Button();
            this.lbCarregarFoto = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.lbCPFIncompleto = new System.Windows.Forms.Label();
            this.lbMaxCaracteres = new System.Windows.Forms.Label();
            this.lbResultSenha = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.txtSenhaConferir = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbSenhaConferir = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbEndereco.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEndereco
            // 
            this.gbEndereco.BackColor = System.Drawing.Color.Transparent;
            this.gbEndereco.Controls.Add(this.txtTelefone);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.lbCEP);
            this.gbEndereco.Controls.Add(this.lbTipoResidencia);
            this.gbEndereco.Controls.Add(this.cbEstado);
            this.gbEndereco.Controls.Add(this.cbTipoResidencia);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lbEstado);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.lbTelefone);
            this.gbEndereco.Controls.Add(this.lbNumero);
            this.gbEndereco.Controls.Add(this.lbBairro);
            this.gbEndereco.Controls.Add(this.lbCidade);
            this.gbEndereco.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbEndereco.Location = new System.Drawing.Point(393, 304);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(393, 191);
            this.gbEndereco.TabIndex = 1;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(20, 150);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(103, 25);
            this.txtTelefone.TabIndex = 11;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(20, 99);
            this.txtCEP.Mask = "00.000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(80, 25);
            this.txtCEP.TabIndex = 5;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.BackColor = System.Drawing.Color.Transparent;
            this.lbCEP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCEP.Location = new System.Drawing.Point(17, 78);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(35, 18);
            this.lbCEP.TabIndex = 4;
            this.lbCEP.Text = "CEP:";
            // 
            // lbTipoResidencia
            // 
            this.lbTipoResidencia.AutoSize = true;
            this.lbTipoResidencia.BackColor = System.Drawing.Color.Transparent;
            this.lbTipoResidencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTipoResidencia.Location = new System.Drawing.Point(179, 129);
            this.lbTipoResidencia.Name = "lbTipoResidencia";
            this.lbTipoResidencia.Size = new System.Drawing.Size(102, 18);
            this.lbTipoResidencia.TabIndex = 12;
            this.lbTipoResidencia.Text = "Tipo Residência";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(263, 100);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(58, 26);
            this.cbEstado.TabIndex = 9;
            // 
            // cbTipoResidencia
            // 
            this.cbTipoResidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoResidencia.FormattingEnabled = true;
            this.cbTipoResidencia.Items.AddRange(new object[] {
            "Casa",
            "Comércio"});
            this.cbTipoResidencia.Location = new System.Drawing.Point(181, 150);
            this.cbTipoResidencia.Name = "cbTipoResidencia";
            this.cbTipoResidencia.Size = new System.Drawing.Size(140, 26);
            this.cbTipoResidencia.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(181, 50);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(140, 25);
            this.txtBairro.TabIndex = 3;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEstado.Location = new System.Drawing.Point(260, 78);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(51, 18);
            this.lbEstado.TabIndex = 8;
            this.lbEstado.Text = "Estado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(146, 99);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(55, 25);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(20, 50);
            this.txtCidade.MaxLength = 20;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(130, 25);
            this.txtCidade.TabIndex = 1;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTelefone.Location = new System.Drawing.Point(16, 129);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(59, 18);
            this.lbTelefone.TabIndex = 10;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNumero.Location = new System.Drawing.Point(143, 78);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(61, 18);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Número:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.Transparent;
            this.lbBairro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbBairro.Location = new System.Drawing.Point(179, 29);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(49, 18);
            this.lbBairro.TabIndex = 2;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.BackColor = System.Drawing.Color.Transparent;
            this.lbCidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCidade.Location = new System.Drawing.Point(17, 29);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(53, 18);
            this.lbCidade.TabIndex = 0;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbCaminho
            // 
            this.lbCaminho.AutoSize = true;
            this.lbCaminho.BackColor = System.Drawing.Color.Transparent;
            this.lbCaminho.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaminho.ForeColor = System.Drawing.Color.Transparent;
            this.lbCaminho.Location = new System.Drawing.Point(81, 303);
            this.lbCaminho.MaximumSize = new System.Drawing.Size(204, 36);
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(0, 18);
            this.lbCaminho.TabIndex = 4;
            // 
            // btEscolherImagem
            // 
            this.btEscolherImagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEscolherImagem.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscolherImagem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEscolherImagem.Location = new System.Drawing.Point(185, 247);
            this.btEscolherImagem.Name = "btEscolherImagem";
            this.btEscolherImagem.Size = new System.Drawing.Size(93, 34);
            this.btEscolherImagem.TabIndex = 2;
            this.btEscolherImagem.Text = "Escolher...";
            this.btEscolherImagem.UseVisualStyleBackColor = false;
            this.btEscolherImagem.Click += new System.EventHandler(this.btEscolherImagem_Click);
            // 
            // lbCarregarFoto
            // 
            this.lbCarregarFoto.AutoSize = true;
            this.lbCarregarFoto.BackColor = System.Drawing.Color.Transparent;
            this.lbCarregarFoto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarregarFoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCarregarFoto.Location = new System.Drawing.Point(88, 255);
            this.lbCarregarFoto.Name = "lbCarregarFoto";
            this.lbCarregarFoto.Size = new System.Drawing.Size(91, 18);
            this.lbCarregarFoto.TabIndex = 3;
            this.lbCarregarFoto.Text = "Carregar foto:";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalvar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSalvar.Location = new System.Drawing.Point(60, 442);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(93, 34);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.gbFuncionario.Controls.Add(this.dtNascimento);
            this.gbFuncionario.Controls.Add(this.lbNascimento);
            this.gbFuncionario.Controls.Add(this.txtRG);
            this.gbFuncionario.Controls.Add(this.lbCPFIncompleto);
            this.gbFuncionario.Controls.Add(this.lbMaxCaracteres);
            this.gbFuncionario.Controls.Add(this.lbResultSenha);
            this.gbFuncionario.Controls.Add(this.txtCPF);
            this.gbFuncionario.Controls.Add(this.rbMasculino);
            this.gbFuncionario.Controls.Add(this.rbFeminino);
            this.gbFuncionario.Controls.Add(this.txtSenhaConferir);
            this.gbFuncionario.Controls.Add(this.txtSenha);
            this.gbFuncionario.Controls.Add(this.txtNome);
            this.gbFuncionario.Controls.Add(this.lbSenhaConferir);
            this.gbFuncionario.Controls.Add(this.lbSenha);
            this.gbFuncionario.Controls.Add(this.lbCPF);
            this.gbFuncionario.Controls.Add(this.lbRG);
            this.gbFuncionario.Controls.Add(this.lbSexo);
            this.gbFuncionario.Controls.Add(this.lbNome);
            this.gbFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFuncionario.Location = new System.Drawing.Point(393, 12);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(393, 281);
            this.gbFuncionario.TabIndex = 0;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(20, 190);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(103, 25);
            this.dtNascimento.TabIndex = 11;
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lbNascimento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNascimento.Location = new System.Drawing.Point(17, 169);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(83, 18);
            this.lbNascimento.TabIndex = 10;
            this.lbNascimento.Text = "Nascimento:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(20, 141);
            this.txtRG.Mask = "00.000.000";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(84, 25);
            this.txtRG.TabIndex = 6;
            this.txtRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCPFIncompleto
            // 
            this.lbCPFIncompleto.AutoSize = true;
            this.lbCPFIncompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPFIncompleto.ForeColor = System.Drawing.Color.Red;
            this.lbCPFIncompleto.Location = new System.Drawing.Point(328, 125);
            this.lbCPFIncompleto.Name = "lbCPFIncompleto";
            this.lbCPFIncompleto.Size = new System.Drawing.Size(0, 13);
            this.lbCPFIncompleto.TabIndex = 9;
            this.lbCPFIncompleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaxCaracteres
            // 
            this.lbMaxCaracteres.AutoSize = true;
            this.lbMaxCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxCaracteres.ForeColor = System.Drawing.Color.Red;
            this.lbMaxCaracteres.Location = new System.Drawing.Point(128, 235);
            this.lbMaxCaracteres.Name = "lbMaxCaracteres";
            this.lbMaxCaracteres.Size = new System.Drawing.Size(0, 13);
            this.lbMaxCaracteres.TabIndex = 16;
            this.lbMaxCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultSenha
            // 
            this.lbResultSenha.AutoSize = true;
            this.lbResultSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultSenha.ForeColor = System.Drawing.Color.Red;
            this.lbResultSenha.Location = new System.Drawing.Point(327, 235);
            this.lbResultSenha.Name = "lbResultSenha";
            this.lbResultSenha.Size = new System.Drawing.Size(0, 13);
            this.lbResultSenha.TabIndex = 17;
            this.lbResultSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(219, 141);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(102, 25);
            this.txtCPF.TabIndex = 8;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.Leave += new System.EventHandler(this.CPFValidacao_Leave);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbMasculino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbMasculino.Location = new System.Drawing.Point(110, 95);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(88, 22);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.BackColor = System.Drawing.Color.Transparent;
            this.rbFeminino.Checked = true;
            this.rbFeminino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbFeminino.Location = new System.Drawing.Point(20, 95);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(82, 22);
            this.rbFeminino.TabIndex = 3;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = false;
            // 
            // txtSenhaConferir
            // 
            this.txtSenhaConferir.Location = new System.Drawing.Point(219, 239);
            this.txtSenhaConferir.MaxLength = 6;
            this.txtSenhaConferir.Name = "txtSenhaConferir";
            this.txtSenhaConferir.PasswordChar = '*';
            this.txtSenhaConferir.Size = new System.Drawing.Size(102, 25);
            this.txtSenhaConferir.TabIndex = 15;
            this.txtSenhaConferir.Leave += new System.EventHandler(this.SenhaDiferente_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(20, 239);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(102, 25);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.Leave += new System.EventHandler(this.SenhaMenor_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 46);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 25);
            this.txtNome.TabIndex = 1;
            // 
            // lbSenhaConferir
            // 
            this.lbSenhaConferir.AutoSize = true;
            this.lbSenhaConferir.BackColor = System.Drawing.Color.Transparent;
            this.lbSenhaConferir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSenhaConferir.Location = new System.Drawing.Point(216, 218);
            this.lbSenhaConferir.Name = "lbSenhaConferir";
            this.lbSenhaConferir.Size = new System.Drawing.Size(99, 18);
            this.lbSenhaConferir.TabIndex = 14;
            this.lbSenhaConferir.Text = "Conferir senha:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSenha.Location = new System.Drawing.Point(17, 218);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 18);
            this.lbSenha.TabIndex = 12;
            this.lbSenha.Text = "Senha:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCPF.Location = new System.Drawing.Point(216, 119);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(35, 18);
            this.lbCPF.TabIndex = 7;
            this.lbCPF.Text = "CPF:";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.BackColor = System.Drawing.Color.Transparent;
            this.lbRG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRG.Location = new System.Drawing.Point(17, 120);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(30, 18);
            this.lbRG.TabIndex = 5;
            this.lbRG.Text = "RG:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.BackColor = System.Drawing.Color.Transparent;
            this.lbSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSexo.Location = new System.Drawing.Point(17, 74);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(38, 18);
            this.lbSexo.TabIndex = 2;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNome.Location = new System.Drawing.Point(17, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 18);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.Location = new System.Drawing.Point(91, 41);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(185, 197);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 16;
            this.pbFoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Location = new System.Drawing.Point(207, 442);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(93, 34);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // JCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.lbCaminho);
            this.Controls.Add(this.btEscolherImagem);
            this.Controls.Add(this.lbCarregarFoto);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.JCadastroFuncionario_Load);
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lbTipoResidencia;
        private System.Windows.Forms.ComboBox cbTipoResidencia;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbCaminho;
        private System.Windows.Forms.Button btEscolherImagem;
        private System.Windows.Forms.Label lbCarregarFoto;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.TextBox txtSenhaConferir;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbSenhaConferir;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbResultSenha;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbMaxCaracteres;
        private System.Windows.Forms.Label lbCPFIncompleto;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lbNascimento;
    }
}