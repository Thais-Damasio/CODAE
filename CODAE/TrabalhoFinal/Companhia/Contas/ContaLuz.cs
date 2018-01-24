using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;
using System.IO;


namespace TrabalhoFinal.Companhia.Contas
{
    public sealed class ContaLuz : Conta
    {
        //Atributos
        private double contribuicao { get; set; }
        private double tarifaLuz { get; set; }
        private double taxaImposto { get; set; }
        //Construtor
        public ContaLuz(string mes, int ano, Consumidor consumidor) : base(mes, ano, consumidor)
        {
        }
        public ContaLuz()
        {
        }

        //Gets
        public double GetContribuicao()
        {
            return contribuicao;
        }
        public double GetTarifaLuz()
        {
            return tarifaLuz;
        }
        public double GetTaxaImposto()
        {
            return taxaImposto;
        }

        //Set
        public void SetContribuicao(double contribuicao)
        {
            this.contribuicao = contribuicao;
        }
        public void SetTarifaLuz(double tarifaLuz)
        {
            this.tarifaLuz = tarifaLuz;
        }
        public void SetTaxaImposto(double taxaImposto)
        {
            this.taxaImposto = taxaImposto;
        }

        //Métodos
        public override void CarregarAtributos()
        {
            string caminho;
            if (consumidor is PessoaFisica)
            {
                caminho = @"Clientes\Pessoa Física\" + ((PessoaFisica)consumidor).GetCpf() + @"\Contas\Luz\" + ano + @"\" + mes;
            }
            else
            {
                caminho = @"Clientes\Pessoa Jurídica\" + ((PessoaJuridica)consumidor).GetCnpj() + @"\Contas\Luz\" + ano + @"\" + mes;
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
                //Valor sem impostos
                ler.ReadLine();
                TotalSemImposto = double.Parse(ler.ReadLine());
                //Tarifa
                ler.ReadLine();
                tarifaLuz = double.Parse(ler.ReadLine());
                //Valor imposto
                ler.ReadLine();
                valorImposto = double.Parse(ler.ReadLine());
                //Taxa imposto
                ler.ReadLine();
                taxaImposto = double.Parse(ler.ReadLine());
                //Contribuição
                ler.ReadLine();
                contribuicao = double.Parse(ler.ReadLine());
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
        public static ContaLuz UltimaConta(Consumidor consumidor)
        {
            string caminho;
            ContaLuz conta = null;
            try
            {
                if (consumidor is PessoaFisica)
                {
                    caminho = @"Clientes\Pessoa Física\" + ((PessoaFisica)consumidor).GetCpf() + @"\Contas\Luz\Ultima Conta";
                }
                else
                {
                    caminho = @"Clientes\Pessoa Jurídica\" + ((PessoaJuridica)consumidor).GetCnpj() + @"\Contas\Luz\Ultima Conta";
                }
                FileStream arq = new FileStream(caminho, FileMode.Open);
                StreamReader ler = new StreamReader(arq);
                conta = new ContaLuz();
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
                //Valor sem impostos
                ler.ReadLine();
                conta.SetTotalSemImposto(double.Parse(ler.ReadLine()));
                //Tarifa
                ler.ReadLine();
                conta.SetTarifaLuz(double.Parse(ler.ReadLine()));
                //Valor imposto
                ler.ReadLine();
                conta.SetValorImposto(double.Parse(ler.ReadLine()));
                //Taxa imposto
                ler.ReadLine();
                conta.SetTaxaImposto(double.Parse(ler.ReadLine()));
                //Taxa do confins
                ler.ReadLine();
                conta.SetContribuicao(double.Parse(ler.ReadLine()));
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

