using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal.Companhia.Janelas;
using TrabalhoFinal.Companhia.Funcoes;
using System.IO;

namespace TrabalhoFinal
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JMenu());
        }
    }
}
