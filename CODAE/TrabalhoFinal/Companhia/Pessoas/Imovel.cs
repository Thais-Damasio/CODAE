using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoFinal.Companhia.Pessoas
{
   public class Imovel
    {
        //Atributos
        private string cidade { get; set; }
        private string estado { get; set; }
        private string bairro { get; set; }
        private string cep { get; set; }
        private int numero { get; set; }
        private string telefone { get; set; }
        private string TipoImovel { get; set; }
       
        //Construtor
        public Imovel()
        {
          
        }
        
        //Gets
        public string GetCidade()
        {
            return this.cidade;
        }
        public string GetEstado()
        {
            return this.estado;
        }
        public string GetBairro()
        {
            return this.bairro;
        }
        public string GetCep()
        {
            return this.cep;
        }
        public int GetNumero()
        {
            return this.numero;
        }
        public string GetTelefone()
        {
            return this.telefone;
        }
        public string GetTipoImovel()
        {
            return this.TipoImovel;
        }

        //Sets
        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void SetEstado(string estado)
        {
            this.estado = estado;
        }
        public void SetBairro(string bairro)
        {
             this.bairro = bairro;
        }
        public void SetCep(string cep)
        {
             this.cep = cep;
        }
        public void SetNumero(int numero)
        {
             this.numero = numero;
        }
        public void SetTelefone(string telefone)
        {
             this.telefone = telefone;
        }
        public void SetTipoImovel(string TipoImovel)
        {
             this.TipoImovel = TipoImovel;
        }
    }
}

           