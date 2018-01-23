using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal.Companhia.Pessoas;
using System.IO;
using TrabalhoFinal.Companhia.Funcoes;
using TrabalhoFinal.Companhia.Contas;

namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JConsultaCliente : Form
    {
        ///Atributos
        Consumidor consumidor;
        public JConsultaCliente(Consumidor consumidor)
        {
            InitializeComponent();
            this.consumidor = consumidor;
            //combo_Mes.Enabled = false;
        }
        private void JConsultaCliente_Load(object sender, EventArgs e)
        {
            //Form
            MostrandoCliente();
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;

            //Tab 1
            LerConta();

            //Tab 2
            InformacoesAdicionaisAgua();
            InformacoesAdicionaisLuz();
            rdAgua.Checked = true;
            rdAguaDados.Checked = true;
        }


        ///Métodos Form
        private void LerConta()
        {
            ContaAgua agua = ContaAgua.UltimaConta(consumidor);
            if (agua == null)
            {
                MessageBox.Show("O cliente não possui contas\nde ÁGUA cadastradas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConsumoUltimaAgua.Text = "---------------";
                txtMesUltimaAgua.Text = "---------------";
                txtValorUltimaAgua.Text = "---------------";
            }
            else
            {
                txtConsumoUltimaAgua.Text = agua.GetConsumoMes().ToString() + "m³";
                txtMesUltimaAgua.Text = agua.GetMes();
                txtValorUltimaAgua.Text = agua.GetValorTotal().ToString();
            }

            ContaLuz luz = ContaLuz.UltimaConta(consumidor);
            if (luz == null)
            {
                MessageBox.Show("O cliente não possui contas\nde LUZ cadastradas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorUltimaLuz.Text = "---------------";
                txtMesUltimaLuz.Text = "---------------";
                txtConsumoUltimaLuz.Text = "---------------";
            }
            else
            {
                txtConsumoUltimaLuz.Text = luz.GetConsumoMes().ToString() + "Kw";
                txtMesUltimaLuz.Text = luz.GetMes().ToString();
                txtValorUltimaLuz.Text = luz.GetValorTotal().ToString();
            }
        }
        private void CarregarComboAno(string tipoConta, ComboBox ano)
        {
            ano.Items.Clear();
            string tipo, documento;
            if (consumidor is PessoaFisica)
            {
                tipo = "Pessoa Física";
                documento = ((PessoaFisica)consumidor).GetCpf();
            }
            else
            {
                tipo = "Pessoa Jurídica";
                documento = ((PessoaJuridica)consumidor).GetCnpj();
            }
            try
            {
                DirectoryInfo pastas = new DirectoryInfo(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\");
                if (pastas.Exists)
                {
                    ano.Items.Add("-Selecionar-");
                    foreach (DirectoryInfo di in pastas.GetDirectories())
                    {
                        ano.Items.Add(di.Name);
                    }
                }
                else
                {
                    ano.Items.Add("-Vazio-");
                }
            }
            catch (DirectoryNotFoundException)
            {
                ano.Items.Add("-Vazio-");
            }
            ano.SelectedIndex = 0;
        }
        private void CarregarComboMes(string tipoConta, ComboBox mes, ComboBox ano)
        {
            string tipo, documento;
            if (consumidor is PessoaFisica)
            {
                tipo = "Pessoa Física";
                documento = ((PessoaFisica)consumidor).GetCpf();
            }
            else
            {
                tipo = "Pessoa Jurídica";
                documento = ((PessoaJuridica)consumidor).GetCnpj();
            }
            try
            {
                DirectoryInfo pasta = new DirectoryInfo(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\" + ano.SelectedItem.ToString());
                if (pasta.Exists)
                {
                    mes.Items.Add("-Selecionar-");
                    foreach (FileInfo di in pasta.GetFiles())
                    {
                        mes.Items.Add(Path.GetFileNameWithoutExtension(di.Name));
                    }
                }
                else
                {
                    mes.Items.Add("-Vazio-");
                }
            }
            catch (FileNotFoundException)
            {
                mes.Items.Add("-Vazio-");
            }
            mes.SelectedIndex = 0;
        }

        ///////////////////////////////////// Tab Conta ////////////////////////////////////

        ///Cliques
        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            if (rdAgua.Checked)
            {
                PesquisarContaAgua();
            }
            else if (rdLuz.Checked)
            {
                PesquisarContaLuz();
            }
        }

        //Métodos
        private void PesquisarContaAgua()
        {
            if (consumidor is PessoaFisica)
            {
                PessoaFisica PessoaFisica = (PessoaFisica)consumidor;
                if (File.Exists(@"Clientes\" + @"Pessoa Física\" + PessoaFisica.GetCpf() + @"\Contas" + @"\Água\" + cbAno.SelectedItem + @"\" + cbMes.SelectedItem))
                {
                    JMostrarConta mostrarConta = new JMostrarConta(PessoaFisica, cbAno.SelectedItem.ToString(), cbMes.SelectedItem.ToString(), "Água");
                    this.Hide();
                    mostrarConta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Cliente não possui conta registrada no mês ou ano escolhido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (consumidor is PessoaJuridica)
            {
                PessoaJuridica PessoaJuridica = (PessoaJuridica)consumidor;
                if (Directory.Exists(@"Clientes\" + @"Pessoa Física\" + PessoaJuridica.GetCnpj() + @"\Contas" + @"\Água\" + cbAno.SelectedItem + @"\" + cbMes.SelectedItem))
                {
                    JMostrarConta mostrarConta = new JMostrarConta(PessoaJuridica, cbAno.SelectedItem.ToString(), cbMes.SelectedItem.ToString(), "Água");
                    this.Hide();
                    mostrarConta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Cliente não possui conta registrada no mês ou ano escolhido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PesquisarContaLuz()
        {
            if (consumidor is PessoaFisica)
            {
                PessoaFisica PessoaFisica = (PessoaFisica)consumidor;
                if (File.Exists(@"Clientes\" + @"Pessoa Física\" + PessoaFisica.GetCpf() + @"\Contas" + @"\Luz\" + cbAno.SelectedItem + @"\" + cbMes.SelectedItem))
                {
                    JMostrarConta mostrarConta = new JMostrarConta(PessoaFisica, cbAno.SelectedItem.ToString(), cbMes.SelectedItem.ToString(), "Luz");
                    this.Hide();
                    mostrarConta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Cliente não possui conta registrada no mês ou ano escolhido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (consumidor is PessoaJuridica)
            {
                PessoaJuridica PessoaJuridica = (PessoaJuridica)consumidor;
                if (File.Exists(@"Clientes\" + @"Pessoa Física\" + PessoaJuridica.GetCnpj() + @"\Contas" + @"\Luz\" + cbAno.SelectedItem + @"\" + cbMes.SelectedItem))
                {
                    JMostrarConta mostrarConta = new JMostrarConta(PessoaJuridica, cbAno.SelectedItem.ToString(), cbMes.SelectedItem.ToString(), "Luz");
                    this.Hide();
                    mostrarConta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Cliente não possui conta registrada no mês ou ano escolhido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MostrandoCliente()
        {
            pbCliente.Image = consumidor.GetImagem();
            if (consumidor is PessoaFisica)
            {
                lb1Nome.Text = "Nome:";
                lb1.Text = consumidor.GetNome();
                lb2Documento.Text = "CPF:";
                lb2.Text = ((PessoaFisica)consumidor).GetCpf();
                lb3Idade.Text = "Idade:";
                int idade = DateTime.Now.Year - DateTime.Parse(consumidor.GetNascimento()).Year;
                if (DateTime.Now.Month < DateTime.Parse(consumidor.GetNascimento()).Month || DateTime.Now.Month == DateTime.Parse(consumidor.GetNascimento()).Month && DateTime.Now.Day < DateTime.Parse(consumidor.GetNascimento()).Day)
                {
                    idade--;
                }
                lb3.Text = idade.ToString();
                lb4Endereco.Text = "Endereço: ";
                lb4.Text = consumidor.GetImovel().GetBairro() + ", " + consumidor.GetImovel().GetCidade() + " - " + consumidor.GetImovel().GetEstado();
                lb5CEP.Text = "CEP:";
                lb5.Text = consumidor.GetImovel().GetCep();
                lb6Sexo.Visible = true;
                lb6.Visible = true;
                lb6Sexo.Text = "Sexo:";
                lb6.Text = ((PessoaFisica)consumidor).GetSexo();
            }
            else
            {
                lb1Nome.Text = "Razão Social:";
                lb1.Text = consumidor.GetNome();
                lb2Documento.Text = "CNPJ:";
                lb2.Text = ((PessoaJuridica)consumidor).GetCnpj();
                lb3Idade.Text = "Fundação:";
                int idade = DateTime.Now.Year - DateTime.Parse(consumidor.GetNascimento()).Year;
                if (DateTime.Now.Month < DateTime.Parse(consumidor.GetNascimento()).Month || DateTime.Now.Month == DateTime.Parse(consumidor.GetNascimento()).Month && DateTime.Now.Day < DateTime.Parse(consumidor.GetNascimento()).Day)
                {
                    idade--;
                }
                lb3.Text = idade.ToString();
                lb4Endereco.Text = "Endereço: ";
                lb4.Text = consumidor.GetImovel().GetBairro() + ", " + consumidor.GetImovel().GetCidade() + " - " + consumidor.GetImovel().GetEstado();
                lb5CEP.Text = "CEP:";
                lb5.Text = consumidor.GetImovel().GetCep();
                lb6Sexo.Visible = false;
                lb6.Visible = false;
            }
        }

        ///Eventos
        private void CarregarTabContas_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                CarregarComboAno(((RadioButton)sender).Text, cbAno);
            }
        }
        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMes.Items.Clear();
            if (cbAno.SelectedIndex != 0)
            {
                if (rdAgua.Checked)
                {
                    CarregarComboMes("Água", cbMes, cbAno);
                }
                else
                {
                    CarregarComboMes("Luz", cbMes, cbAno);
                }
            }
            else
            {
                cbMes.Items.Add("-Vazio-");
                cbMes.SelectedIndex = 0;
            }
        }


        ///////////////////////////////// Tab Dados Gerais /////////////////////////////////

        ///Cliques
        private void bt_VisualizarComparacao_Click(object sender, EventArgs e)
        {
            if (ValoresPreenchidosDadosGerais())
            {
                if (rdAguaDados.Checked)
                {
                    CompararDoisMesesAgua();
                }
                else if (rdLuzDados.Checked)
                {
                    CompararDoisMesesLuz();
                }
            }
            else
            {
                MessageBox.Show("Informe os valores corretamente!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///Métodos
        private bool ValoresPreenchidosDadosGerais()
        {
            if (cb1Ano.SelectedIndex == 0 || cb2Ano.SelectedIndex == 0 || cb1Mes.SelectedIndex == 0 || cb2Mes.SelectedIndex == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CompararDoisMesesAgua()
        {
            ContaAgua conta = new ContaAgua(cb1Mes.Text, int.Parse(cb1Ano.Text), consumidor);
            ContaAgua conta2 = new ContaAgua(cb2Mes.Text, int.Parse(cb2Ano.Text), consumidor);

            if (conta == null)
            {
                MessageBox.Show("O cliente não possui contas de água no primeiro ano ou mês inseridos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (conta2 == null)
            {
                MessageBox.Show("O cliente não possui contas de ÁGUA no segundo ano ou mês inseridos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double variacaoConsumo = conta.GetConsumoMes() - conta2.GetConsumoMes();
                double variacaoReais = conta.GetValorTotal() - conta.GetValorTotal();
                txt_variacaoConsumo.Text = "R$" + variacaoConsumo.ToString();
                lb_TextoVariacaoConsumo.Text = "Variação do consumo (" + cb1Mes.SelectedItem + " e " + cb2Mes.SelectedItem + "):";
                txt_Reais.Text = "R$" + variacaoReais.ToString();
                lb_Reais.Text = "Variação em reais (" + cb1Mes.SelectedItem + " e " + cb2Mes.SelectedItem + "):";
            }
        }
        private void CompararDoisMesesLuz()
        {
            ContaLuz conta = new ContaLuz(cb1Mes.Text, int.Parse(cb1Ano.Text), consumidor);
            ContaLuz conta2 = new ContaLuz(cb2Mes.Text, int.Parse(cb2Ano.Text), consumidor);

            if (conta == null)
            {
                MessageBox.Show("O cliente não possui contas de luz no primeiro ano ou mês inseridos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (conta2 == null)
            {
                MessageBox.Show("O cliente não possui contas de luz no segundo ano ou mês inseridos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double variacaoConsumo = conta.GetConsumoMes() - conta2.GetConsumoMes();
                double variacaoReais = conta.GetValorTotal() - conta.GetValorTotal();
                txt_variacaoConsumo.Text = "R$" + variacaoConsumo.ToString();
                lb_TextoVariacaoConsumo.Text = "Variação do consumo (" + cb1Mes.SelectedItem + " e " + cb2Mes.SelectedItem + "):";
                txt_Reais.Text = "R$" + variacaoReais.ToString();
                lb_Reais.Text = "Variação em reais (" + cb1Mes.SelectedItem + " e " + cb2Mes.SelectedItem + "):";
            }
        }
        private void InformacoesAdicionaisAgua()
        {
            double NumeroContas, SomaTodasContas;

            NumeroContas = DadosGerais.GetNumeroContas(consumidor, "Água");
            SomaTodasContas = DadosGerais.GetSomaTodasContas(consumidor, "Água");

            if (NumeroContas == 0)
            {
                txtValorMedioAgua.Text = "----------";
                txtMaiorReaisAgua.Text = "----------";
                txtMaiorConsumoAgua.Text = "----------";
            }
            else
            {
                txtValorMedioAgua.Text = (Convert.ToString(SomaTodasContas / NumeroContas));
                txtMaiorReaisAgua.Text = (Convert.ToString(DadosGerais.GetMaiorValor(consumidor, "Água")));
                txtMaiorConsumoAgua.Text = (Convert.ToString(DadosGerais.GetMaiorMedicao(consumidor, "Água")));
            }
        }
        private void InformacoesAdicionaisLuz()
        {
            double NumeroContas, SomaTodasContas;

            NumeroContas = DadosGerais.GetNumeroContas(consumidor, "Luz");
            SomaTodasContas = DadosGerais.GetSomaTodasContas(consumidor, "Luz");
            if (NumeroContas == 0)
            {
                txtValorMedioLuz.Text = "----------";
                txtMaiorReaisLuz.Text = "----------";
                txtMaiorConsumoLuz.Text = "----------";
            }
            else
            {
                txtValorMedioLuz.Text = (Convert.ToString(SomaTodasContas / NumeroContas));
                txtMaiorReaisLuz.Text = (Convert.ToString(DadosGerais.GetMaiorValor(consumidor, "Luz")));
                txtMaiorConsumoLuz.Text = (Convert.ToString(DadosGerais.GetMaiorMedicao(consumidor, "Luz")));
            }
        }

        //Eventos
        private void CarregarTabDadosGerais_CheckedChange(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                CarregarComboAno(((RadioButton)sender).Text, cb1Ano);
                CarregarComboAno(((RadioButton)sender).Text, cb2Ano);
            }
        }
        private void cb1Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb1Mes.Items.Clear();
            if (cb1Ano.SelectedIndex != 0)
            {
                if (rdAguaDados.Checked)
                {
                    CarregarComboMes("Água", cb1Mes, cb1Ano);
                }
                else
                {
                    CarregarComboMes("Luz", cb1Mes, cb1Ano);
                }
            }
            else
            {
                cb1Mes.Items.Add("- Vazio -");
                cb1Mes.SelectedIndex = 0;
            }
        }
        private void cb2Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb2Mes.Items.Clear();
            if (cb2Ano.SelectedIndex != 0)
            {
                if (rdAguaDados.Checked)
                {
                    CarregarComboMes("Água", cb2Mes, cb2Ano);
                }
                else
                {
                    CarregarComboMes("Luz", cb2Mes, cb2Ano);
                }
            }
            else
            {
                cb2Mes.Items.Add("- Vazio -");
                cb2Mes.SelectedIndex = 0;
            }
        }
    }
}




