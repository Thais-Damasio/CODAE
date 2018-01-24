using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Companhia.Pessoas;

namespace TrabalhoFinal.Companhia.Funcoes
{
    public static class CalculoAgua
    {
        public static double ValorAgua(double consumo, Imovel imovel)
        {
            if(imovel.GetTipoImovel() == "Casa")
            {
                if(consumo >= 0 && consumo <= 6)
                {
                    return 10.08;
                }
                else if(consumo <= 10)
                {
                    return consumo * 2.241;
                }
                else if(consumo <= 15)
                {
                    return consumo * 5.447;
                }
                else if(consumo <= 20)
                {
                    return consumo * 5.461;
                }
                else if(consumo <= 40)
                {
                    return consumo * 5.487;
                }
                else
                {
                    return consumo * 10.066;
                }
            }
            else
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return 25.79;
                }
                else if (consumo <= 10)
                {
                    return consumo * 4.299;
                }
                else if (consumo <= 40)
                {
                    return consumo * 8.221;
                }
                else if (consumo <= 100)
                {
                    return consumo * 8.288;
                }
                else
                { 
                    return consumo * 8.329;
                }
            }
        }
        public static double ValorEsgoto(double consumo, Imovel imovel)
        {
            if (imovel.GetTipoImovel() == "Casa")
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return 5.05;
                }
                else if (consumo <= 10)
                {
                    return consumo * 1.122;
                }
                else if (consumo <= 15)
                {
                    return consumo * 2.274;
                }
                else if (consumo <= 20)
                {
                    return consumo * 2.731;
                }
                else if (consumo <= 40)
                {
                    return consumo * 2.744;
                }
                else
                {
                    return consumo * 5.035;
                }
            }
            else
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return 12.90;
                }
                else if (consumo <= 10)
                {
                    return consumo * 2.149;
                }
                else if (consumo <= 40)
                {
                    return consumo * 4.111;
                }
                else if (consumo <= 100)
                {
                    return consumo * 4.144;
                }
                else
                {
                    return consumo * 4.165;
                }
            }
        }
        public static double TarifaAgua(double consumo, Imovel imovel)
        {
            if (imovel.GetTipoImovel() == "Casa")
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return double.NaN;
                }
                else if (consumo <= 10)
                {
                    return 2.241;
                }
                else if (consumo <= 15)
                {
                    return 5.447;
                }
                else if (consumo <= 20)
                {
                    return 5.461;
                }
                else if (consumo <= 40)
                {
                    return 5.487;
                }
                else
                {
                    return 10.066;
                }
            }
            else
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return double.NaN;
                }
                else if (consumo <= 10)
                {
                    return 4.299;
                }
                else if (consumo <= 40)
                {
                    return 8.221;
                }
                else if (consumo <= 100)
                {
                    return 8.288;
                }
                else
                {
                    return 8.329;
                }
            }
        }
        public static double TarifaEsgoto(double consumo, Imovel imovel)
        {
            if (imovel.GetTipoImovel() == "Casa")
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return double.NaN;
                }
                else if (consumo <= 10)
                {
                    return 1.122;
                }
                else if (consumo <= 15)
                {
                    return 2.274;
                }
                else if (consumo <= 20)
                {
                    return 2.731;
                }
                else if (consumo <= 40)
                {
                    return 2.744;
                }
                else
                {
                    return 5.035;
                }
            }
            else
            {
                if (consumo >= 0 && consumo <= 6)
                {
                    return double.NaN;
                }
                else if (consumo <= 10)
                {
                    return 2.149;
                }
                else if (consumo <= 40)
                {
                    return 4.111;
                }
                else if (consumo <= 100)
                {
                    return 4.144;
                }
                else
                {
                    return 4.165;
                }

            }
        }
        public static double ValorImposto(double valorTotal)
        {
            return valorTotal * 0.03;
        }
        public static double ImpostoPercentual()
        {
            return 0.03;
        }
    }
}
