using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace TrabalhoFinal.Companhia.Pessoas
{
    public class PessoaFisica : Consumidor
    {
        //Atributos
        private string sexo { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }

        //Construtor
        public PessoaFisica(string cpf)
        {
            this.cpf = cpf;
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
            string texto = (@"Clientes\Pessoa Física\" + cpf + @"\Dados Pessoais\" + cpf);

            FileStream cliente = new FileStream(texto, FileMode.Open);
            StreamReader ler = new StreamReader(cliente);

            //Senha
            ler.ReadLine();
            senha = ler.ReadLine();
            //Classificação
            ler.ReadLine();
            endereco.SetTipoImovel(ler.ReadLine());
            //Nome
            ler.ReadLine();
            nome = ler.ReadLine();
            //Sexo
            ler.ReadLine();
            sexo = ler.ReadLine();
            //Cpf
            ler.ReadLine();
            cpf = ler.ReadLine();
            //Rg
            ler.ReadLine();
            rg = ler.ReadLine();
            //Nascimento
            ler.ReadLine();
            nascimento = ler.ReadLine();
            //Estado
            ler.ReadLine();
            endereco.SetEstado(ler.ReadLine());
            //Cidade
            ler.ReadLine();
            endereco.SetCidade(ler.ReadLine());
            //Bairro
            ler.ReadLine();
            endereco.SetBairro(ler.ReadLine());
            //CEP
            ler.ReadLine();
            endereco.SetCep(ler.ReadLine());
            //Número
            ler.ReadLine();
            endereco.SetNumero(Convert.ToInt32(ler.ReadLine()));
            //Telefone
            ler.ReadLine();
            endereco.SetTelefone(ler.ReadLine());
            //Tipo Residência
            ler.ReadLine();
            endereco.SetTipoImovel(ler.ReadLine());
            ler.Close();
            imagem = new Bitmap(@"Clientes\Pessoa Física\" + cpf + @"\Dados Pessoais\" + nome + ".jpg");
        }
    }
}
