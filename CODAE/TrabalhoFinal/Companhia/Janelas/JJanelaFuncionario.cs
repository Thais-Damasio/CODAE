using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal.Companhia.Contas;
using TrabalhoFinal.Companhia.Pessoas;
using TrabalhoFinal.Companhia.Funcoes;
using System.IO;


namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JJanelaFuncionario : Form
    {
        ///Atributos
        Consumidor consumidor;
        Funcionario funcionario;

        ///Construtor
        public JJanelaFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;           
        }
        private void JJanelaFuncionario_Load(object sender, EventArgs e)
        {
            //Form
            funcionario.CarregarAtributos();
            pbFuncionario.Image = funcionario.GetImagem();
            lbMensagem.Text += funcionario.GetNome() + "!";
            Image fundo = new Bitmap(@"Administrador\Imagens\Fundo1.jpg");
            BackgroundImage = fundo;

            //Tab 1
            cbClassificacaoTab1.SelectedIndex = 0;

            //Tab 2
            cbClassificacaoTab2.SelectedIndex = 0;
            gbNovaConta.Visible = false;
            gbAtributosClientes.Visible = false;
            cbMes.SelectedIndex = 0;

            //Tab 3
            DateTime hoje = DateTime.Now;
            dtNascimento.Value = hoje;
            cbClassificacaoTab3.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            pbFoto.Load(@"Administrador\User.png");
            Directory.CreateDirectory("Clientes");

        }              

        ///Eventos Form
        private void SomenteNumeros_Leave(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void lkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Close();
            }
        }


        //////////////////////////// --- TAB 1 --- ////////////////////////////

        ///Cliques
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (cbClassificacaoTab1.SelectedIndex == 1)
            {
                if (!Directory.Exists(@"Clientes\Pessoa Física\" + txtDocumentoTab1.Text))
                {
                    MessageBox.Show("CPF não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparTab1();
                }
                else
                {
                    PessoaFisica PessoaFisica = new PessoaFisica(txtDocumentoTab1.Text);
                    PessoaFisica.CarregarAtributos();
                    JConsultaCliente ConsultaCliente = new JConsultaCliente(PessoaFisica);
                    this.Hide();
                    ConsultaCliente.ShowDialog();
                    this.Close();
                }
            }
            else if (cbClassificacaoTab1.SelectedIndex == 2)
            {
                if (!Directory.Exists(@"Clientes\" + @"Pessoa Jurídica\" + txtDocumentoTab1.Text))
                {
                    MessageBox.Show("CPF não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparTab1();
                }
                else
                {
                    PessoaJuridica PessoaJuridica = new PessoaJuridica(txtDocumentoTab1.Text);
                    PessoaJuridica.CarregarAtributos();
                    JConsultaCliente jConsultaCliente = new JConsultaCliente(PessoaJuridica);
                    this.Hide();
                    jConsultaCliente.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        ///Métodos
        private void LimparTab1()
        {
            foreach (Control c in gbConsultar.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }

        ///Eventos
        private void cbTipoUsuarioTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassificacaoTab1.SelectedIndex == 1)
            {
                txtDocumentoTab1.Enabled = true;
                txtDocumentoTab1.Text = "";
                txtDocumentoTab1.Mask = "000.000.000-00";

            }
            else if (cbClassificacaoTab1.SelectedIndex == 2)
            {
                txtDocumentoTab1.Enabled = true;
                txtDocumentoTab1.Text = "";
                txtDocumentoTab1.Mask = "00.000.000-0000-00";
            }
            else
            {
                LimparTab1();
                txtDocumentoTab1.Mask = "";
                txtDocumentoTab1.Enabled = false;
            }
        }


        //////////////////////////// --- TAB 2 --- ////////////////////////////

        ///Cliques
        private void btSalvarConta_Click(object sender, EventArgs e)
        {
            string caminho;
            //Gerar caminho
            if (rdAgua.Checked)
            {
                caminho = @"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + txtDocumentoTab2.Text + @"\Contas\Água\";
            }
            else
            {
                caminho = @"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + txtDocumentoTab2.Text + @"\Contas\Luz\";
            }

            //Salvar Conta
            if (!ValoresPreenchidosTab2())
            {
                MessageBox.Show("Preencha os campos vazios!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(caminho + txtAno.Text + @"\" + cbMes.SelectedItem + ".txt"))
            {
                MessageBox.Show("Conta já registrada!", "Arquivo Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                caminho += txtAno.Text + @"\";
                Directory.CreateDirectory(caminho);
                EscreverContasArquivo(caminho);
            }

        }

        ///Metodo tab2
        private bool ValoresPreenchidosTab2()
        {
            bool preenchidos = true;
            if (cbMes.SelectedIndex == 0)
            {
                return false;
            }
            foreach (Control c in gbNovaConta.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        preenchidos = false;
                        break;
                    }
                }
                else if (c is MaskedTextBox)
                {
                    if (!(((MaskedTextBox)c).MaskCompleted))
                    {
                        preenchidos = false;
                        break;
                    }
                }
            }
            return preenchidos;
        }
        private void EscreverContasArquivo(string caminho)
        {
            double valor;
            if (rdAgua.Checked)
            {
                valor = ContaDeAgua(caminho);
            }
            else
            {
                valor = ContaDeLuz(caminho);
            }
            DadosGeraisConta(valor, double.Parse(txtConsumo.Text));
            MessageBox.Show("Conta registrada com sucesso!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTab2();
        }
        private double ContaDeAgua(string caminho)
        {
            //Escrever conta          
            FileStream arq = new FileStream(caminho + @"\" + cbMes.SelectedItem, FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);
            escrever.WriteLine("Consumo Registrado:");
            escrever.WriteLine(txtConsumo.Text);
            escrever.WriteLine("Mês:");
            escrever.WriteLine(cbMes.SelectedItem);
            escrever.WriteLine("Ano:");
            escrever.WriteLine(txtAno.Text);
            escrever.WriteLine("Consumo mês:");
            double medicaoAnterior;
            if (ContaAgua.UltimaConta(consumidor) == null)
            {
                medicaoAnterior = 0;
            }
            else
            {
                medicaoAnterior = ContaAgua.UltimaConta(consumidor).GetMedicaoTotal();
            }
            double consumoMes = double.Parse(txtConsumo.Text) - medicaoAnterior;
            double valorAgua = CalculoAgua.ValorAgua(consumoMes, consumidor.GetImovel());
            double ValorEsgoto = CalculoAgua.ValorEsgoto(consumoMes, consumidor.GetImovel());
            double valorTotal = valorAgua + ValorEsgoto;
            escrever.WriteLine(consumoMes);
            escrever.WriteLine("Medição Anterior: ");
            escrever.WriteLine(medicaoAnterior);
            escrever.WriteLine("Valor Água:");
            escrever.WriteLine(valorAgua);
            escrever.WriteLine("Valor Esgoto:");
            escrever.WriteLine(ValorEsgoto);
            escrever.WriteLine("Tarifa Água: (m³)");
            escrever.WriteLine(CalculoAgua.TarifaAgua(consumoMes, consumidor.GetImovel()));
            escrever.WriteLine("Tarifa Esgoto: (m³)");
            escrever.WriteLine(CalculoAgua.TarifaEsgoto(consumoMes, consumidor.GetImovel()));
            escrever.WriteLine("Total sem impostos:");
            escrever.WriteLine(valorTotal);
            escrever.WriteLine("Taxa de imposto: (CONFINS)");
            escrever.WriteLine(CalculoAgua.ImpostoPercentual());
            escrever.WriteLine("Valor imposto: ");
            double valorImposto = CalculoAgua.ValorImposto(valorTotal);
            escrever.WriteLine(valorImposto);
            escrever.WriteLine("Total:");
            double valorConta = valorImposto + valorTotal;
            escrever.WriteLine(valorConta);
            escrever.Close();

            //Escrever Última Conta
            string ultimaConta;
            ultimaConta = File.ReadAllText(caminho + @"\" + cbMes.SelectedItem);
            string ContaUltima = @"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + txtDocumentoTab2.Text + @"\Contas\Água\Ultima Conta";
            FileStream UltimaConta = new FileStream(ContaUltima, FileMode.Create);
            StreamWriter escrevendo = new StreamWriter(UltimaConta);
            escrevendo.WriteLine(ultimaConta);
            escrevendo.Close();
            return valorConta;
        }
        private double ContaDeLuz(string caminho)
        {
            string ultimaConta;
            FileStream arq = new FileStream(caminho + @"\" + cbMes.SelectedItem, FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);
            escrever.WriteLine("Consumo Registrado:");
            escrever.WriteLine(txtConsumo.Text);
            escrever.WriteLine("Mês:");
            escrever.WriteLine(cbMes.SelectedItem);
            escrever.WriteLine("Ano:");
            escrever.WriteLine(txtAno.Text);
            escrever.WriteLine("Consumo mês:");
            double medicaoAnterior;
            if (ContaLuz.UltimaConta(consumidor) == null)
            {
                medicaoAnterior = 0;
            }
            else
            {
                medicaoAnterior = ContaLuz.UltimaConta(consumidor).GetMedicaoTotal();
            }
            double consumoMes = double.Parse(txtConsumo.Text) - medicaoAnterior;
            double valor = CalculoEnergia.ValorConsumo(consumoMes, consumidor.GetImovel());
            escrever.WriteLine(consumoMes);
            escrever.WriteLine("Medição Anterior:");
            escrever.WriteLine(medicaoAnterior);
            escrever.WriteLine("Valor sem impostos:");
            escrever.WriteLine(valor);
            escrever.WriteLine("Tarifa");
            escrever.WriteLine(CalculoEnergia.Tarifa(consumoMes, consumidor.GetImovel()));
            escrever.WriteLine("Valor imposto:");
            double valorImposto = CalculoEnergia.ValorImposto(consumoMes, valor, consumidor.GetImovel());
            escrever.WriteLine(valorImposto);
            escrever.WriteLine("Taxa imposto:");
            escrever.WriteLine(CalculoEnergia.ImpostoPercentual(consumoMes, valor, consumidor.GetImovel()));
            escrever.WriteLine("Contribuição:");
            escrever.WriteLine(CalculoEnergia.Contribuicao());
            escrever.WriteLine("Total:");
            double valorConta = valorImposto + valor + CalculoEnergia.Contribuicao();
            escrever.WriteLine(valorConta);
            escrever.Close();

            //Ultima Conta
            ultimaConta = File.ReadAllText(caminho + @"\" + cbMes.SelectedItem);
            string ContaUltima = @"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + txtDocumentoTab2.Text + @"\Contas\Luz\Ultima Conta";
            FileStream UltimaConta = new FileStream(ContaUltima, FileMode.OpenOrCreate);
            StreamWriter escrevendo = new StreamWriter(UltimaConta);
            escrevendo.WriteLine(ultimaConta);
            escrevendo.Close();
            return valorConta;
        }
        private void LimparTab2()
        {
            pbCliente.Image = null;
            gbAtributosClientes.Visible = false;
            cbMes.SelectedIndex = 0;
            foreach (Control c in gbNovaConta.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = string.Empty;
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
        private void DadosGeraisConta(double valorConta, double consumo)
        {
            //Atributos
            int numContas = 0;
            double acumulado = 0, valor = 0, medicao = 0;
            RadioButton radio;
            string documento;
            if (consumidor is PessoaFisica)
            {
                documento = ((PessoaFisica)consumidor).GetCpf();
            }
            else
            {
                documento = ((PessoaJuridica)consumidor).GetCnpj();
            }
            if (rdAgua.Checked)
            {
                radio = rdAgua;
            }
            else
            {
                radio = rdLuz;
            }
            FileStream arq = new FileStream(@"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + documento + @"\Contas\" + radio.Text + @"\DadosImportantes", FileMode.OpenOrCreate);
            if (arq.Length > 0)
            {
                StreamReader ler = new StreamReader(arq);
                ler.ReadLine(); //Nº Contas:
                numContas = int.Parse(ler.ReadLine());
                ler.ReadLine(); //Acumulado:
                acumulado = double.Parse(ler.ReadLine());
                ler.ReadLine(); //Maior Conta:
                medicao = double.Parse(ler.ReadLine());
                valor = double.Parse(ler.ReadLine());
                ler.Close();
                if (valor < valorConta)
                {
                    arq.Close();
                    FileStream arq2 = new FileStream(@"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + documento + @"\Contas\" + radio.Text + @"\DadosImportantes", FileMode.OpenOrCreate);
                    StreamWriter escrever = new StreamWriter(arq2);
                    escrever.WriteLine("Nº Contas:");
                    escrever.WriteLine(numContas + 1);
                    escrever.WriteLine("Acumulado:");
                    escrever.WriteLine(acumulado + valorConta);
                    escrever.WriteLine("Maior Conta:");
                    escrever.WriteLine(consumo);
                    escrever.WriteLine(valorConta);
                    escrever.Close();
                }
                else
                {
                    arq.Close();
                    FileStream arq2 = new FileStream(@"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + documento + @"\Contas\" + radio.Text + @"\DadosImportantes", FileMode.OpenOrCreate);
                    StreamWriter escrever = new StreamWriter(arq2);
                    escrever.WriteLine("Nº Contas:");
                    escrever.WriteLine(numContas + 1);
                    escrever.WriteLine("Acumulado:");
                    escrever.WriteLine(acumulado + valorConta);
                    escrever.WriteLine("Maior Conta:");
                    escrever.WriteLine(medicao);
                    escrever.WriteLine(valor);
                    escrever.Close();
                }
            }
            else
            {
                arq.Close();
                FileStream arq2 = new FileStream(@"Clientes\" + cbClassificacaoTab2.SelectedItem + @"\" + documento + @"\Contas\" + radio.Text + @"\DadosImportantes", FileMode.OpenOrCreate);
                StreamWriter escrever = new StreamWriter(arq2);
                escrever.WriteLine("Nº Contas:");
                escrever.WriteLine(numContas + 1);
                escrever.WriteLine("Acumulado:");
                escrever.WriteLine(acumulado + valorConta);
                escrever.WriteLine("Maior Conta:");
                escrever.WriteLine(consumo);
                escrever.WriteLine(valorConta);
                escrever.Close();
            }
        }

        //Evento tab2
        private void cbTipoUsuarioTab2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbClassificacaoTab2.SelectedIndex == 1)
            {
                txtDocumentoTab2.Mask = "000.000.000-00";
                gbNovaConta.Visible = true;
                lbCliente.Text = "CPF:";
            }
            else if (cbClassificacaoTab2.SelectedIndex == 2)
            {
                txtDocumentoTab2.Mask = "00.000.000-0000-00";
                gbNovaConta.Visible = true;
                lbCliente.Text = "CNPJ:";
            }
            else
            {
                LimparTab2();
                gbNovaConta.Visible = false;
            }
        }
        private void BuscarCliente_Leave(object sender, EventArgs e)
        {
            gbAtributosClientes.Visible = false;
            //Gerar Caminho
            string cliente;
            if (cbClassificacaoTab2.SelectedIndex == 1)
            {
                cliente = @"Pessoa Física\";
            }
            else
            {
                cliente = @"Pessoa Jurídica\";
            }
            //Carregar cliente
            if (!Directory.Exists(@"Clientes\" + cliente + txtDocumentoTab2.Text))
            {
                MessageBox.Show("Cliente não possui cadastro no sistema!", "Cliente Não Registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumentoTab2.Text = "";
            }
            else
            {
                if (cbClassificacaoTab2.SelectedIndex == 1)
                {
                    consumidor = new PessoaFisica(txtDocumentoTab2.Text);
                    consumidor.CarregarAtributos();
                }
                else
                {
                    consumidor = new PessoaJuridica(txtDocumentoTab2.Text);
                    consumidor.CarregarAtributos();
                }
                gbAtributosClientes.Visible = true;
                MostrandoCliente();
            }
        }
        private void ConversaoUnidade_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAgua.Checked)
            {
                lbConversao.Text = "m³";
            }
            else
            {
                lbConversao.Text = "Kw";
            }
        }


        //////////////////////////// --- TAB 3 --- ////////////////////////////

        ///Cliques Tab 3
        private void btEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagens | *.jpg; *.png";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Load(abrir.FileName);
            }
        }
        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            if (cbClassificacaoTab3.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione a classificação do consumidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValoresPreenchidosTab3())
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbMaxCaracteres.Text != "")
            {
                MessageBox.Show("Senha deve conter máximo 6 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbResultSenha.Text != "")
            {
                MessageBox.Show("Senhas divergentes digitadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path;
                if (cbClassificacaoTab3.SelectedIndex == 1)
                {
                    path = @"Clientes\Pessoa Física\" + txtCPF.Text;
                }
                else
                {
                    path = @"Clientes\Pessoa Jurídica\" + txtCNPJ.Text;
                }
                EscreverArqTexto(path);
                MessageBox.Show("Cliente salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparForm();
            }
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        ///Métodos Tab 3
        private void LimparForm()
        {
            GroupBox grupo = null;
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                grupo = gbPessoaFisica;
            }
            else if (cbClassificacaoTab3.SelectedIndex == 2)
            {
                grupo = gbPessoaJuridica;
            }
            if (grupo != null)
            {
                foreach (Control c in grupo.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            cbClassificacaoTab3.SelectedIndex = 0;
            foreach (Control c in gbDadosGerais.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            dtNascimento.Value = DateTime.Now;
            pbFoto.Load(@"Administrador\User.png");
        }
        private bool ValoresPreenchidosTab3()
        {
            bool preenchidos = true;
            GroupBox grupo = null;
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                grupo = gbPessoaFisica;
            }
            else if (cbClassificacaoTab3.SelectedIndex == 2)
            {
                grupo = gbPessoaJuridica;
            }
            if (grupo != null)
            {
                foreach (Control c in grupo.Controls)
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
            }
            foreach (Control c in gbDadosGerais.Controls)
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
            if (lbErroCNPJ.Text != "" || lbErroCPF.Text != "")
            {
                preenchidos = false;
            }
            return preenchidos;
        }
        private void EscreverArqTexto(string path)
        {
            string arquivo;
            Directory.CreateDirectory(path);
            path += @"\Dados Pessoais";
            Directory.CreateDirectory(path);
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                arquivo = txtCPF.Text;
            }
            else
            {
                arquivo = txtCNPJ.Text;
            }
            FileStream arq = new FileStream(path + @"\" + arquivo, FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);

            escrever.WriteLine("Senha: ");
            escrever.WriteLine(txtSenha.Text);
            escrever.WriteLine("Classificação: ");
            escrever.WriteLine(cbClassificacaoTab3.SelectedItem);
            escrever.WriteLine("Nome: ");
            escrever.WriteLine(txtNome.Text);
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                if (rbFeminino.Checked)
                {
                    escrever.WriteLine("Sexo: ");
                    escrever.WriteLine(rbFeminino.Text);
                }
                else
                {
                    escrever.WriteLine("Sexo: ");
                    escrever.WriteLine(rbMasculino.Text);
                }
                escrever.WriteLine("CPF: ");
                escrever.WriteLine(txtCPF.Text);
                escrever.WriteLine("RG: ");
                escrever.WriteLine(txtRG.Text);
            }
            else
            {
                escrever.WriteLine("CNPJ: ");
                escrever.WriteLine(txtCNPJ.Text);
            }
            escrever.WriteLine("Nascimento: ");
            escrever.WriteLine(dtNascimento.Value.Date.ToShortDateString());
            escrever.WriteLine("Estado: ");
            escrever.WriteLine(cbEstado.SelectedItem);
            escrever.WriteLine("Cidade: ");
            escrever.WriteLine(txtCidade.Text);
            escrever.WriteLine("Bairro: ");
            escrever.WriteLine(txtBairro.Text);
            escrever.WriteLine("CEP: ");
            escrever.WriteLine(txtCEP.Text);
            escrever.WriteLine("Nº: ");
            escrever.WriteLine(txtNumero.Text);
            escrever.WriteLine("Telefone: ");
            escrever.WriteLine(txtTelefone.Text);
            escrever.WriteLine("Tipo Residência: ");
            escrever.WriteLine(cbTipoResidencia.SelectedItem);
            escrever.Close();
            pbFoto.Image.Save(path + @"\" + txtNome.Text + ".jpg");
        }
        private void LimparGrupoNaoSelecionado(GroupBox grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }

        ///Eventos Tab 3
        private void cbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                cbTipoResidencia.SelectedIndex = 1;
                gbPessoaFisica.Visible = true;
                gbPessoaJuridica.Visible = false;
                LimparGrupoNaoSelecionado(gbPessoaJuridica);
            }
            else if (cbClassificacaoTab3.SelectedIndex == 2)
            {
                cbTipoResidencia.SelectedIndex = 2;
                gbPessoaJuridica.Visible = true;
                gbPessoaFisica.Visible = false;
                LimparGrupoNaoSelecionado(gbPessoaFisica);
            }
            else
            {
                cbTipoResidencia.SelectedIndex = 0;
                gbPessoaJuridica.Visible = false;
                gbPessoaFisica.Visible = false;
            }
        }
        private void MaxCaraceter_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length < 6)
            {
                lbMaxCaracteres.Text = "Máximo de 6 \ncaracateres!";
            }
            else
            {
                lbMaxCaracteres.Text = "";
            }
            if (txtSenhaConferir.Text != txtSenha.Text && txtSenhaConferir.Text != "")
            {
                lbResultSenha.Text = "Senhas \n divergentes!";
            }
        }
        private void SenhaDivergente_Leave(object sender, EventArgs e)
        {
            if (txtSenhaConferir.Text != txtSenha.Text)
            {
                lbResultSenha.Text = "Senhas \n divergentes!";
            }
            else
            {
                lbResultSenha.Text = "";
            }
        }
        private void ValidacaoCadastroNacional_Leave(object sender, EventArgs e)
        {
            string caminho;
            if (cbClassificacaoTab3.SelectedIndex == 1)
            {
                caminho = @"Clientes\Pessoa Física\";
            }
            else
            {
                caminho = @"Clientes\Pessoa Jurídica\";
            }
            MaskedTextBox cadastroNacional = (MaskedTextBox)sender;
            if (Directory.Exists(caminho + cadastroNacional.Text))
            {
                if (cadastroNacional.Parent == gbPessoaFisica)
                {
                    lbErroCPF.Text = "Cpf já cadastrado!";
                }
                else
                {
                    lbErroCNPJ.Text = "CNPJ já cadastrado!";
                }
            }
            else
            {
                if (cadastroNacional.Parent == gbPessoaFisica)
                {
                    lbErroCPF.Text = "";
                }
                else
                {
                    lbErroCNPJ.Text = "";
                }
            }
        }


        //////////////////////////////////////////////////////////////////////
    }
}
