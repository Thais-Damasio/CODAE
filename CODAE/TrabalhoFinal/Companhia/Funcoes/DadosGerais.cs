using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;
using TrabalhoFinal.Companhia.Contas;
using System.IO;


namespace TrabalhoFinal.Companhia.Funcoes
{
    static class DadosGerais
    {
        //Atributos
        public static int numContas;
        static double acumulado;
        static double maiorValor;
        static double maiorMedicao;

        //Métodos
        public static int GetNumeroContas(Consumidor consumidor, string tipoConta)
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
                FileStream arq = new FileStream(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\DadosImportantes", FileMode.OpenOrCreate);
                if (arq.Length > 0)
                {
                    StreamReader ler = new StreamReader(arq);
                    ler.ReadLine(); //Nº Contas:
                    numContas = int.Parse(ler.ReadLine());
                    ler.ReadLine(); //Acumulado:
                    acumulado = double.Parse(ler.ReadLine());
                    ler.ReadLine(); //Maior Conta:
                    maiorMedicao = double.Parse(ler.ReadLine());
                    maiorValor = double.Parse(ler.ReadLine());
                    ler.Close();
                }
                else
                {
                    arq.Close();
                }
            }
            catch (DirectoryNotFoundException)
            {
                return 0;
            }
            catch (FileLoadException)
            {
                return 0;
            }
            return numContas;
        }
        public static double GetSomaTodasContas(Consumidor consumidor, string tipoConta)
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
                FileStream arq = new FileStream(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\DadosImportantes", FileMode.OpenOrCreate);
                if (arq.Length > 0)
                {
                    StreamReader ler = new StreamReader(arq);
                    ler.ReadLine(); //Nº Contas:
                    numContas = int.Parse(ler.ReadLine());
                    ler.ReadLine(); //Acumulado:
                    acumulado = double.Parse(ler.ReadLine());
                    ler.ReadLine(); //Maior Conta:
                    maiorMedicao = double.Parse(ler.ReadLine());
                    maiorValor = double.Parse(ler.ReadLine());
                    ler.Close();
                }
                {
                    arq.Close();
                }
            }
            catch (DirectoryNotFoundException)
            {
                return 0;
            }
            catch (FileLoadException)
            {
                return 0;
            }
            return acumulado;
        }
        public static double GetMaiorValor(Consumidor consumidor, string tipoConta)
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
                FileStream arq = new FileStream(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\DadosImportantes", FileMode.OpenOrCreate);
                if (arq.Length > 0)
                {
                    StreamReader ler = new StreamReader(arq);
                    ler.ReadLine(); //Nº Contas:
                    numContas = int.Parse(ler.ReadLine());
                    ler.ReadLine(); //Acumulado:
                    acumulado = double.Parse(ler.ReadLine());
                    ler.ReadLine(); //Maior Conta:
                    maiorMedicao = double.Parse(ler.ReadLine());
                    maiorValor = double.Parse(ler.ReadLine());
                    ler.Close();
                }
                {
                    arq.Close();
                }
            }
            catch (DirectoryNotFoundException)
            {
                return 0;
            }
            catch (FileLoadException)
            {
                return 0;
            }
            return maiorValor;
        }
        public static double GetMaiorMedicao(Consumidor consumidor, string tipoConta)
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
                FileStream arq = new FileStream(@"Clientes\" + tipo + @"\" + documento + @"\Contas\" + tipoConta + @"\DadosImportantes", FileMode.OpenOrCreate);
                if (arq.Length > 0)
                {
                    StreamReader ler = new StreamReader(arq);
                    ler.ReadLine(); //Nº Contas:
                    numContas = int.Parse(ler.ReadLine());
                    ler.ReadLine(); //Acumulado:
                    acumulado = double.Parse(ler.ReadLine());
                    ler.ReadLine(); //Maior Conta:
                    maiorMedicao = double.Parse(ler.ReadLine());
                    maiorValor = double.Parse(ler.ReadLine());
                    ler.Close();
                }
                {
                    arq.Close();
                }
            }
            catch (DirectoryNotFoundException)
            {
                return 0;
            }
            catch (FileLoadException)
            {
                return 0;
            }
            return maiorMedicao;
        }
    }
}
