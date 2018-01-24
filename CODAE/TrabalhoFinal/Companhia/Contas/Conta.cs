using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;

namespace TrabalhoFinal.Companhia.Contas
{
    public abstract class Conta
    {
        //Atributos
        protected double consumoMes { get; set; } /// Consumo referente ao mês
        protected double medicaoTotal { get; set; } /// Consumo acumulado de todos os meses
        protected double medicaoAnterior { get; set; } //medicao do mês anterior 
        protected Consumidor consumidor; ///Dono da conta
        protected string mes { get; set; } ///mês referente a conta
        protected int ano { get; set; } //Ano da conta
        protected double TotalSemImposto { get; set; } //Valor sem adição de impostos
        protected double valorImposto { get; set; } //Quanto tem de imposto
        protected double valorTotal { get; set; } //O valor com imposto

        //Construtor
        public Conta(string mes, int ano, Consumidor consumidor)
        {
            this.mes = mes;
            this.ano = ano;
            this.consumidor = consumidor;
            CarregarAtributos();
        }
        public Conta()
        {

        }

        //Gets
        public double GetConsumoMes()
        {
            return this.consumoMes;
        }
        public double GetMedicaoTotal()
        {
            return medicaoTotal;
        }
        public Consumidor GetConsumidor()
        {
            return consumidor;
        }
        public string GetMes()
        {
            return this.mes;
        }
        public int GetAno()
        {
            return this.ano;
        }
        public double GetValorTotal()
        {
            return valorTotal;
        }
        public double GetMedicaoAnterior()
        {
            return medicaoAnterior;
        }
        public double GetTotalSemImposto()
        {
            return TotalSemImposto;
        }
        public double GetValorImposto()
        {
            return valorImposto;
        }

        //Sets
        public void SetConsumoMes(double consumoMes) //<==
        {
            this.consumoMes = consumoMes;
        }
        public void SetMedicaoTotal(double medicaoTotal)
        {
            this.medicaoTotal = medicaoTotal;
        } //<==
        public void SetConsumidor(Consumidor consumidor)
        {
            this.consumidor = consumidor;
        }
        public void SetMes(string mes)
        {
            this.mes = mes;
        }
        public void SetAno(int ano)
        {
            this.ano = ano;
        }
        public void SetValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        public void SetMedicaoAnterior(double medicaoAnterior)
        {
            this.medicaoAnterior = medicaoAnterior;
        } //<==
        public void SetTotalSemImposto(double totalSemImpostos)
        {
            this.TotalSemImposto = totalSemImpostos;
        }
        public void SetValorImposto(double valorImposto) //<==
        {
            this.valorImposto = valorImposto;
        }

        //Métodos
        public abstract void CarregarAtributos();
    }
}
