using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;
using System.IO;

namespace TrabalhoFinal.Companhia.Contas
{
    public sealed class ContaAgua : Conta
    {
        //Atributos
        private double confins { get; set; }
        private double valorAgua { get; set; }
        private double valorEsgoto { get; set; }
        private double TarifaAgua { get; set; }
        private double TarifaEsgoto { get; set; }

        //Construtor
        public ContaAgua(string mes, int ano, Consumidor consumidor) : base(mes, ano, consumidor)
        {
        }
        public ContaAgua()
        {

        }

        //Get
        public double GetConfins()
        {
            return confins;
        }
        public double GetValorAgua()
        {
            return valorAgua;
        }
        public double GetValorEsgoto()
        {
            return valorEsgoto;
        }
        public double GetTarifaAgua()
        {
            return TarifaAgua;
        }
        public double GetTarifaEsgoto()
        {
            return TarifaEsgoto;
        }

        //Set
        public void SetConfins(double confins)
        {
            this.confins = confins;
        }
        public void SetValorAgua(double valorAgua)
        {
            this.valorAgua = valorAgua;
        }
        public void SetValorEsgoto(double valorEsgoto)
        {
            this.valorEsgoto = valorEsgoto;
        }
        public void SetTarifaAgua(double tarifaAgua)
        {
            this.TarifaAgua = TarifaAgua;
        }
        public void SetTarifaEsgoto(double tarifaEsgoto)
        {
            this.TarifaEsgoto = TarifaEsgoto;
        }

        //Métodos
        public override void CarregarAtributos()
        {
            string caminho;
            if (consumidor is PessoaFisica)
            {
                caminho = @"Clientes\Pessoa Física\" + ((PessoaFisica)consumidor).GetCpf() + @"\Contas\Água\" + ano + @"\" + mes;
            }
            else
            {
                caminho = @"Clientes\Pessoa Jurídica\" + ((PessoaJuridica)consumidor).GetCnpj() + @"\Contas\Água\" + ano + @"\" + mes;
            }
            try
            {
                FileStream arq = new FileStream(caminho, FileMode.Open);
                StreamReader ler = new StreamReader(arq);
                //Medição Total
                ler.ReadLine();
                medicaoTotal = double.Parse(ler.ReadLine());
                //Mês
                ler.ReadLine();
                mes = ler.ReadLine();
                //Ano
                ler.ReadLine();
                ano = int.Parse(ler.ReadLine());
                //Consumo do mês
                ler.ReadLine();
                consumoMes = double.Parse(ler.ReadLine());
                //Medição Anterior
                ler.ReadLine();
                medicaoAnterior = double.Parse(ler.ReadLine());
                //Valor Água
                ler.ReadLine();
                valorAgua = double.Parse(ler.ReadLine());
                //Valor Esgoto
                ler.ReadLine();
                valorEsgoto = double.Parse(ler.ReadLine());
                //Tarifa Água
                ler.ReadLine();
                TarifaAgua = double.Parse(ler.ReadLine());
                //Tarifa Esgoto
                ler.ReadLine();
                TarifaEsgoto = double.Parse(ler.ReadLine());
                //Total sem imposto
                ler.ReadLine();
                TotalSemImposto = double.Parse(ler.ReadLine());
                //Taxa do confins
                ler.ReadLine();
                confins = double.Parse(ler.ReadLine());
                //valor com imposto
                ler.ReadLine();
                valorImposto = double.Parse(ler.ReadLine());
                //Total a pagar
                ler.ReadLine();
                valorTotal = double.Parse(ler.ReadLine());
                ler.Close();
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Arquivo não encontrado!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Erro no carregamento do arquivo!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static ContaAgua UltimaConta(Consumidor consumidor)
        {
            string caminho;
            ContaAgua conta = null;
            try
            {
                if (consumidor is PessoaFisica)
                {
                    caminho = @"Clientes\Pessoa Física\" + ((PessoaFisica)consumidor).GetCpf() + @"\Contas\Água\Ultima Conta";
                }
                else
                {
                    caminho = @"Clientes\Pessoa Jurídica\" + ((PessoaJuridica)consumidor).GetCnpj() + @"\Contas\Água\Ultima Conta";
                }
                FileStream arq = new FileStream(caminho, FileMode.Open);
                StreamReader ler = new StreamReader(arq);
                conta = new ContaAgua();
                //Medição Total
                ler.ReadLine();
                conta.SetMedicaoTotal(double.Parse(ler.ReadLine()));
                //Mês
                ler.ReadLine();
                conta.SetMes(ler.ReadLine());
                //Ano
                ler.ReadLine();
                conta.SetAno(int.Parse(ler.ReadLine()));
                //Consumo do mês
                ler.ReadLine();
                conta.SetConsumoMes(double.Parse(ler.ReadLine()));
                //Medição Anterior
                ler.ReadLine();
                conta.SetMedicaoAnterior(double.Parse(ler.ReadLine()));
                //Valor Água
                ler.ReadLine();
                conta.SetValorAgua(double.Parse(ler.ReadLine()));
                //Valor Esgoto
                ler.ReadLine();
                conta.SetValorEsgoto(double.Parse(ler.ReadLine()));
                //Tarifa Água
                ler.ReadLine();
                conta.SetTarifaAgua(double.Parse(ler.ReadLine()));
                //Tarifa Esgoto
                ler.ReadLine();
                conta.SetTarifaEsgoto(double.Parse(ler.ReadLine()));
                //Total sem imposto
                ler.ReadLine();
                conta.SetTotalSemImposto(double.Parse(ler.ReadLine()));
                //Taxa do confins
                ler.ReadLine();
                conta.SetConfins(double.Parse(ler.ReadLine()));
                //valor com imposto
                ler.ReadLine();
                conta.SetValorImposto(double.Parse(ler.ReadLine()));
                //Total a pagar
                ler.ReadLine();
                conta.SetValorTotal(double.Parse(ler.ReadLine()));
                ler.Close();
            }
            catch (FileNotFoundException)
            {
                return null;
            }
            catch (DirectoryNotFoundException)
            {
                return null;
            }
            return conta;
        }
    }
}