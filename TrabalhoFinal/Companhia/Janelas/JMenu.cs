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
    public partial class JMenu : Form
    {
        //Construtor
        public JMenu()
        {
            InitializeComponent();
        }
        private void JMenu_Load(object sender, EventArgs e)
        {
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;
            Image logo = new Bitmap(@"Administrador\Imagens\Codae2.png");
            pbLogo.Image = logo;
        }

        //Botoões
        private void btLogin_Click(object sender, EventArgs e)
        {
            JLogin login = new JLogin();
            Hide();
            login.ShowDialog();
            Show();
        }
        private void btAdministrador_Click(object sender, EventArgs e)
        {
            JLoginAdmin admin = new JLoginAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
        private void btSobre_Click(object sender, EventArgs e)
        {
            JSobre sobre = new JSobre();
            this.Hide();
            sobre.ShowDialog();
            this.Show();
        }
    }
}
