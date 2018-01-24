using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;

namespace TrabalhoFinal.Companhia.Funcoes
{
    public static class CalculoEnergia
    {
        public static double ValorConsumo(double consumo, Imovel imovel)
        {
            double valor;
            if(imovel.GetTipoImovel() == "Casa")
            {
                valor = consumo * 0.46;
            }
            else
            {
                valor = consumo * 0.41;
            }
            return valor; 
        }
        public static double ValorImposto(double consumo, double valor, Imovel imovel)
        {
            if(imovel.GetTipoImovel() == "Casa")
            {
                if (consumo >= 90)
                {
                    return valor * 00.4285;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return valor * 00.2195;
            }
        }
        public static double Tarifa(double consumo, Imovel imovel)
        {
            if (imovel.GetTipoImovel() == "Casa")
            {
                return 0.46;
            }
            else
            {
                return 0.41;
            }
        }
        public static double ImpostoPercentual(double consumo, double valor, Imovel imovel)
        {
            if (imovel.GetTipoImovel() == "Casa")
            {
                if (consumo >= 90)
                {
                    return 00.4285;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 00.2195;
            }
        }
        public static double Contribuicao()
        {
            return 13.25;
        }
    }
}
