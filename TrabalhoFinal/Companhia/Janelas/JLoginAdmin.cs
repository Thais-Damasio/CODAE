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
    public partial class JLoginAdmin : Form
    {
        //Construtor
        public JLoginAdmin()
        {
            InitializeComponent();
        }
        private void JLoginAdmin_Load(object sender, EventArgs e)
        {
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;
        }

        //Cliques
        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = @"Administrador\Admin";
                FileStream arq = new FileStream(caminho, FileMode.OpenOrCreate);
                StreamReader ler = new StreamReader(arq);
                string nome = ler.ReadLine();
                string senha = ler.ReadLine();
                ler.Close();
                if (!ValoresPreenchidos())
                {
                    MessageBox.Show("Preencha os campos!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nome == txtNome.Text && senha == txtSenha.Text)
                {
                    Hide();
                    Limpar();
                    JCadastroFuncionario cadastrar = new JCadastroFuncionario();
                    cadastrar.ShowDialog();
                    Show();
                }
                else
                {
                    Limpar();
                    MessageBox.Show("Senha ou nome de usuário inválidos!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Erro ao acessar o administrador, contate a equipe de manutenção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Erro ao acessar o administrador, contate a equipe de manutenção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Métodos
        private bool ValoresPreenchidos()
        {
            foreach(Control c in gbDados.Controls)
            {
                if(c is TextBox && c.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void Limpar()
        {
            foreach(Control c in gbDados.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

    }
}
