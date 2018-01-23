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
    public partial class JSobre : Form
    {
        public JSobre()
        {
            InitializeComponent();
        }
        private void JSobre_Load(object sender, EventArgs e)
        {
            try
            {
                txtSobre.Text = File.ReadAllText(@"Administrador\Sobre", Encoding.Default);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o arquivo! Contate o Administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o arquivo! Contate o Administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
