using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrabalhoFinal.Companhia.Pessoas
{
    public abstract class Pessoa
    {
        //Atributos
        protected string nome { get; set; }
        protected string nascimento { get; set; }
        protected string senha { get; set; }
        protected Imovel endereco = new Imovel();
        protected Image imagem;

        //Construtor
        public Pessoa()
        {

        }

        //Gets
        public string GetNome()
        {
            return this.nome;
        }
        public string GetNascimento()
        {
            return this.nascimento;
        }
        public Imovel GetImovel()
        {
            return this.endereco;
        }
        public string GetSenha()
        {
            return this.senha;
        }
        public Image GetImagem()
        {
            return imagem;
        }

        //Sets
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }
        public void SetEndereco(Imovel endereco)
        {
            this.endereco = endereco;
        }
        public void SetSenha(string senha)
        {
            this.senha = senha;
        }
        public void SetImagem(Image imagem)
        {
            this.imagem = imagem;
        }

        //Métodos
        public abstract void CarregarAtributos();
    }
}
