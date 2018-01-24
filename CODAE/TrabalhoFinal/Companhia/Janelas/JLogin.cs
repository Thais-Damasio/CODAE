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
using TrabalhoFinal.Companhia.Pessoas;


namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JLogin : Form
    {
        //Construtor
        public JLogin()
        {
            InitializeComponent();
        }
        private void JLogin_Load(object sender, EventArgs e)
        {
            cbTipoUser.SelectedIndex = 0;
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;
            Image logo = new Bitmap(@"Administrador\Imagens\Codae1.png");
            pbLogo.Image = logo;
        }

        //Cliques
        private void Entrar_Click(object sender, EventArgs e)
        {
            //funcionario = 1
            //pessoa fisica = 2
            //pessoa juridica = 3
            if (cbTipoUser.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um tipo de usuário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbTipoUser.SelectedIndex == 1)
            {
                if (!Directory.Exists(@"Funcionários\" + txtDocumento.Text))
                {
                    MessageBox.Show("Funcionário não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
                else
                {
                    CarregarFuncionario();
                }
            }
            else if (cbTipoUser.SelectedIndex == 2)
            {
                if (!Directory.Exists(@"Clientes\Pessoa Física\" + txtDocumento.Text))
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
                else
                {
                    CarregarCliente();
                }
            }
            else if (cbTipoUser.SelectedIndex == 3)
            {
                if (!Directory.Exists(@"Clientes\Pessoa Jurídica\" + txtDocumento.Text))
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
                else
                {
                    CarregarCliente();
                }
            }
            else if (CamposVazios())
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Eventos
        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa após cada seleção
            txtDocumento.Text = "";
            txtDocumento.Text = "";
            lbNaoCadastrado.Text = "";
            //Define máscara de acordo com o tipo de usuário
            if (cbTipoUser.SelectedIndex == 1 || cbTipoUser.SelectedIndex == 2)
            {
                txtDocumento.Enabled = true;
                txtSenha.Enabled = true;
                txtDocumento.Mask = "000.000.000-00";
                lbDocumento.Text = "CPF:";
            }
            else if (cbTipoUser.SelectedIndex == 3)
            {
                txtDocumento.Enabled = true;
                txtSenha.Enabled = true;
                txtDocumento.Mask = "00.000.000-0000-00";
                lbDocumento.Text = "CNPJ:";
            }
            else
            {
                Limpar();
                lbDocumento.Text = "Tipo documento:";
                txtDocumento.Enabled = false;
                txtSenha.Enabled = false;
                txtDocumento.Mask = "";
                lbNaoCadastrado.Text = "";
            }
        }
        private void CPF_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text != "")
            {
                if (cbTipoUser.SelectedIndex == 1)
                {
                    if (!Directory.Exists(@"Funcionários\" + txtDocumento.Text))
                    {
                        lbNaoCadastrado.Text = "Funcionário\nnão cadastrado!";
                    }
                    else
                    {
                        lbNaoCadastrado.Text = "";
                    }
                }
                else if (cbTipoUser.SelectedIndex == 2)
                {
                    if (!Directory.Exists(@"Clientes\Pessoa Física\" + txtDocumento.Text))
                    {
                        lbNaoCadastrado.Text = "Cliente\nnão cadastrado!";
                    }
                    else
                    {
                        lbNaoCadastrado.Text = "";
                    }
                }
                else if (cbTipoUser.SelectedIndex == 3)
                {
                    if (!Directory.Exists(@"Clientes\Pessoa Jurídica\" + txtDocumento.Text))
                    {
                        lbNaoCadastrado.Text = "Cliente\nnão cadastrado!";
                    }
                    else
                    {
                        lbNaoCadastrado.Text = "";
                    }
                }
                else
                {
                    Limpar();
                    lbNaoCadastrado.Text = "";
                }
            }
            else
            {
                lbNaoCadastrado.Text = "";
            }
        }

        //Métodos
        private void Limpar()
        {
            foreach (Control c in gbAcesso.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = string.Empty;
                }
            }
            lbNaoCadastrado.Text = string.Empty;
        }
        private void CarregarFuncionario()
        {
            Funcionario funcionario = new Funcionario(txtDocumento.Text);
            funcionario.CarregarAtributos();
            //Confere senha
            if (funcionario.GetSenha() == txtSenha.Text)
            {
                JJanelaFuncionario janelaFun = new JJanelaFuncionario(funcionario);
                this.Hide();
                janelaFun.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult Mensagem = MessageBox.Show("Senha incorreta!", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (Mensagem == DialogResult.Retry)
                {
                    txtSenha.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void CarregarCliente()
        {
            if (cbTipoUser.SelectedIndex == 2)
            {
                PessoaFisica pf = new PessoaFisica(txtDocumento.Text);
                pf.CarregarAtributos();
                //Confere senha
                if (pf.GetSenha() == txtSenha.Text)
                {
                    JConsultaCliente consulta = new JConsultaCliente(pf);
                    Hide();
                    consulta.ShowDialog();
                    Close();
                }
                else
                {
                    DialogResult Mensagem = MessageBox.Show("Senha Incorreta!", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (Mensagem == DialogResult.Retry)
                    {
                        txtSenha.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else if (cbTipoUser.SelectedIndex == 3)
            {
                PessoaJuridica pj = new PessoaJuridica(txtDocumento.Text);
                pj.CarregarAtributos();
                //Confere senha
                if (pj.GetSenha() == txtSenha.Text)
                {
                    JConsultaCliente consulta = new JConsultaCliente(pj);
                    Hide();
                    consulta.ShowDialog();
                    Close();
                }
                else
                {
                    DialogResult Mensagem = MessageBox.Show("Senha Incorreta!", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (Mensagem == DialogResult.Retry)
                    {
                        txtSenha.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private bool CamposVazios()
        {
            foreach (Control c in gbAcesso.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        return true;
                    }
                }
                else if (c is MaskedTextBox)
                {
                    if (!((MaskedTextBox)c).MaskCompleted)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

