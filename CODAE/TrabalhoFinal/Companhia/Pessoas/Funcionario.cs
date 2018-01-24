using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace TrabalhoFinal.Companhia.Pessoas
{
    public class Funcionario : Pessoa
    {
        //Atributos
        private string cpf { get; set; }
        private string rg { get; set; }
        private string sexo { get; set; }
        public static double CodFun = 1;

        //Construtor
        public Funcionario(string cpf)
        {
            this.cpf = cpf;
            CodFun++;
        }

        //Gets
        public string GetCpf()
        {
            return this.cpf;
        }
        public string GetRG()
        {
            return this.rg;
        }
        public string GetSexo()
        {
            return this.sexo;
        }

        //Sets
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void SetRG(string rg)
        {
            this.rg = rg;
        }
        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        //Métodos
        public override void CarregarAtributos()
        {
            string texto = (@"Funcionários\" + cpf + @"\Dados Pessoais\" + cpf);
            FileStream funcionario = new FileStream(texto, FileMode.Open);
            StreamReader ler = new StreamReader(funcionario);

            ler.ReadLine();
            //Senha
            senha = ler.ReadLine();
            ler.ReadLine();
            //Cpf
            cpf = ler.ReadLine();
            ler.ReadLine();
            //Nome
            nome = ler.ReadLine();
            ler.ReadLine();
            //Sexo
            sexo = ler.ReadLine();
            ler.ReadLine();
            //Rg
            rg = ler.ReadLine();
            ler.ReadLine();
            //Nascimento
            nascimento = ler.ReadLine();
            ler.ReadLine();
            //Estado
            endereco.SetEstado(ler.ReadLine());
            ler.ReadLine();
            //Cidade
            endereco.SetCidade(ler.ReadLine());
            ler.ReadLine();
            //Bairro
            endereco.SetBairro(ler.ReadLine());
            ler.ReadLine();
            //CEP
            endereco.SetCep(ler.ReadLine());
            ler.ReadLine();
            //Nº
            endereco.SetNumero(Convert.ToInt32(ler.ReadLine()));
            ler.ReadLine();
            //Telefone
            endereco.SetTelefone(ler.ReadLine());
            ler.ReadLine();
            //Residencia
            endereco.SetTipoImovel(ler.ReadLine());
            ler.Close();

            imagem = new Bitmap(@"Funcionários\" + cpf + @"\Dados Pessoais\" + nome + ".jpg");
        }
    }
}

