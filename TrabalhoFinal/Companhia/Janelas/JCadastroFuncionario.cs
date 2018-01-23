using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JCadastroFuncionario : Form
    {
        //Construtor
        public JCadastroFuncionario()
        {
            InitializeComponent();
        }
        private void JCadastroFuncionario_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            dtNascimento.Value = hoje;
            cbEstado.SelectedIndex = 0;
            cbTipoResidencia.SelectedIndex = 0;
            pbFoto.Load(@"Administrador\User.png");

            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;

        }

        //Cliques
        private void btEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog EscolherFoto = new OpenFileDialog();
            EscolherFoto.Filter = "Imagens|*.jpg;*.png";
            if (EscolherFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Load(EscolherFoto.FileName);
                lbCaminho.Text = EscolherFoto.FileName;
            }
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (lbResultSenha.Text != "")
            {
                MessageBox.Show("Senhas divergentes!", "Senha Divergente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbMaxCaracteres.Text != "")
            {
                MessageBox.Show("Senha deve conter 6 caracteres!", "Senha Curta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lbCPFIncompleto.Text != "")
            {
                MessageBox.Show("CPF já cadastrado!", "Funcionário Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValoresPreenchidos())
            {
                MessageBox.Show("Existem valores a serem preenchidos!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Directory.CreateDirectory("Funcionários");
                Directory.CreateDirectory(@"Funcionários\" + txtCPF.Text);
                Directory.CreateDirectory(@"Funcionários\" + txtCPF.Text + @"\Dados Pessoais");
                pbFoto.Image.Save(@"Funcionários\" + txtCPF.Text + @"\Dados Pessoais\" + txtNome.Text + ".jpg");
                EscreverArqTexto();
                MessageBox.Show("Funcionário salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparForm();
            }
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        //Métodos
        private bool ValoresPreenchidos()
        {
            bool preenchidos = true;
            foreach (Control c in gbFuncionario.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        preenchidos = false;
                    }
                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox mascara = (MaskedTextBox)c;
                    if (!mascara.MaskCompleted)
                    {
                        preenchidos = false;
                    }
                }
            }
            foreach (Control c in gbEndereco.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        preenchidos = false;
                    }
                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox mascara = (MaskedTextBox)c;
                    if (!mascara.MaskCompleted)
                    {
                        preenchidos = false;
                    }
                }
            }
            return preenchidos;
        }
        private void EscreverArqTexto()
        {
            string sexo;
            string path = @"Funcionários\" + txtCPF.Text + @"\Dados Pessoais\" + txtCPF.Text;
            if (rbFeminino.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "Masculino";
            }
            FileStream arq = new FileStream(path, FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);

            escrever.WriteLine("Senha:");
            escrever.WriteLine(txtSenha.Text);
            escrever.WriteLine("CPF:");
            escrever.WriteLine(txtCPF.Text);
            escrever.WriteLine("Nome:");
            escrever.WriteLine(txtNome.Text);
            escrever.WriteLine("Sexo:");
            escrever.WriteLine(sexo);
            escrever.WriteLine("RG:");
            escrever.WriteLine(txtRG.Text);
            escrever.WriteLine("Nascimento:");
            escrever.WriteLine(dtNascimento.Value.Date.ToShortDateString());
            escrever.WriteLine("Estado:");
            escrever.WriteLine(cbEstado.SelectedItem);
            escrever.WriteLine("Cidade:");
            escrever.WriteLine(txtCidade.Text);
            escrever.WriteLine("Bairro:");
            escrever.WriteLine(txtBairro.Text);
            escrever.WriteLine("CEP:");
            escrever.WriteLine(txtCEP.Text);
            escrever.WriteLine("Nº:");
            escrever.WriteLine(txtNumero.Text);
            escrever.WriteLine("Telefone:");
            escrever.WriteLine(txtTelefone.Text);
            escrever.WriteLine("Residência:");
            escrever.WriteLine(cbTipoResidencia.SelectedItem);
            escrever.Close();

        }
        private void LimparForm()
        {
            DateTime hoje = DateTime.Now.Date;
            dtNascimento.Value = hoje;
            foreach (Control c in gbEndereco.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in gbFuncionario.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            cbEstado.SelectedIndex = 0;
            cbTipoResidencia.SelectedIndex = 0;
            pbFoto.Load(@"Administrador\User.png");
        }

        //Eventos
        private void SenhaDiferente_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenhaConferir.Text)
            {
                lbResultSenha.Text = "Senhas\ndivergentes!";
            }
            else
            {
                lbResultSenha.Text = "";
            }
        }
        private void SenhaMenor_Leave(object sender, EventArgs e)
        {
            if (txtSenha.TextLength < 6)
            {
                lbMaxCaracteres.Text = "Senha deve\nter 6 caracteres!";
            }
            else
            {
                lbMaxCaracteres.Text = "";
            }
        }
        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CPFValidacao_Leave(object sender, EventArgs e)
        {
            if (Directory.Exists(@"Funcionários\" + txtCPF.Text))
            {
                lbCPFIncompleto.Text = "CPF \njá existe!";
            }
            else if (!txtCPF.MaskCompleted)
            {
                lbCPFIncompleto.Text = "CPF \nincompleto!";
            }
            else
            {
                lbCPFIncompleto.Text = "";
            }
        }
    }
}
