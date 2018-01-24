using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace TrabalhoFinal.Companhia.Pessoas
{
    public class PessoaJuridica : Consumidor
    {
        //Atributos
        private string cnpj { get; set; }

        //Construtor
        public PessoaJuridica (string cnpj)
        {
            this.cnpj = cnpj;
        }

        //Gets
        public string GetCnpj()
        {
            return this.cnpj;
        }
        
        //Sets
        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        //Métodos
        public override void CarregarAtributos()
        {
            string texto = (@"Clientes\Pessoa Jurídica\" + cnpj + @"\Dados Pessoais\" + cnpj);

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
            //CNPJ
            ler.ReadLine();
            cnpj = ler.ReadLine();
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
            ler.Close();
            imagem = new Bitmap(@"Clientes\Pessoa Jurídica\" + cnpj + @"\Dados Pessoais\" + nome + ".jpg");
        }
    }
}
