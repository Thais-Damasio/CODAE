using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JAdministrador : Form
    {
        //Construtor
        public JAdministrador()
        {
            InitializeComponent();
        }
        private void JAdministrador_Load(object sender, EventArgs e)
        {
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;
        }

        //Cliques
        private void btCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            JCadastroFuncionario cadastrar = new JCadastroFuncionario();
            Hide();
            cadastrar.ShowDialog();
            Show();
        }
        private void btEditarCadastro_Click(object sender, EventArgs e)
        {
        }
    }
}
