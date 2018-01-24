using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal.Companhia.Pessoas;
using System.IO;
using TrabalhoFinal.Companhia.Contas;

namespace TrabalhoFinal.Companhia.Janelas
{
    public partial class JMostrarConta : Form
    {
        Consumidor consumidor;
        string ano, mes, TipoConta;
        public JMostrarConta(Consumidor consumidor, string ano, string mes, string TipoConta)
        {
            InitializeComponent();
            this.consumidor = consumidor;
            this.ano = ano;
            this.mes = mes;
            this.TipoConta = TipoConta;

        }

        private void JMostrarConta_Load(object sender, EventArgs e)
        {
            if (TipoConta == "Luz")
            {
                lb_TipoConta.Text = "Conta de Luz";
            }
            else
            {
                lb_TipoConta.Text = "Conta de Água";
            }
            SetarDados();
        }
        public void SetarDados()
        {
            if (consumidor is PessoaFisica)
            {
                if (TipoConta == "Luz")
                {
                    gbAgua.Visible = false;
                    txt_nome.Text = consumidor.GetNome();
                    ContaLuz contaLuz = new ContaLuz(mes, Convert.ToInt32(ano), consumidor);
                    txt_mes.Text = Convert.ToString(contaLuz.GetMes());
                    txt_ano.Text = Convert.ToString(contaLuz.GetAno());
                    txt_MedicaoAnteriorConta.Text = Convert.ToString(contaLuz.GetMedicaoAnterior());
                    txt_ConsumoMesConta.Text = Convert.ToString(contaLuz.GetConsumoMes());
                    txt_MedicaoTotalConta.Text = Convert.ToString(contaLuz.GetMedicaoTotal());
                    txt_impostoConta.Text = Convert.ToString(contaLuz.GetValorImposto());
                    txt_ValorSemImpostoConta.Text = Convert.ToString(contaLuz.GetTotalSemImposto());
                    txt_ValorReaisConta.Text = Convert.ToString(contaLuz.GetValorTotal());

                    txt_ContribuicaoLuz.Text = Convert.ToString(contaLuz.GetContribuicao());
                    txt_TarifaLuz.Text = Convert.ToString(contaLuz.GetTarifaLuz());
                    txt_TaxaImpostoLuz.Text = Convert.ToString(contaLuz.GetTaxaImposto());


                }
                else if (TipoConta == "Água")
                {
                    gbLuz.Visible = false;
                    txt_nome.Text = consumidor.GetNome();
                    ContaAgua contaAgua = new ContaAgua(mes, Convert.ToInt32(ano), consumidor);
                    txt_mes.Text = Convert.ToString(contaAgua.GetMes());
                    txt_ano.Text = Convert.ToString(contaAgua.GetAno());
                    txt_MedicaoAnteriorConta.Text = Convert.ToString(contaAgua.GetMedicaoAnterior());
                    txt_ConsumoMesConta.Text = Convert.ToString(contaAgua.GetConsumoMes());
                    txt_MedicaoTotalConta.Text = Convert.ToString(contaAgua.GetMedicaoTotal());
                    txt_impostoConta.Text = Convert.ToString(contaAgua.GetValorImposto());
                    txt_ValorSemImpostoConta.Text = Convert.ToString(contaAgua.GetTotalSemImposto());
                    txt_ValorReaisConta.Text = Convert.ToString(contaAgua.GetValorTotal());

                    txt_ValorEsgoto.Text = Convert.ToString(contaAgua.GetValorEsgoto());
                    txt_TarifaAgua.Text = Convert.ToString(contaAgua.GetTarifaAgua());
                    txt_TarifaEsgoto.Text = Convert.ToString(contaAgua.GetTarifaEsgoto());

                }

            }
            else if (consumidor is PessoaJuridica)
            {
                if (TipoConta == "Luz")

                {
                    txt_nome.Text = consumidor.GetNome();
                    gbAgua.Visible = false;
                    ContaLuz contaLuz = new ContaLuz(mes, Convert.ToInt32(ano), consumidor);
                    txt_mes.Text = Convert.ToString(contaLuz.GetMes());
                    txt_ano.Text = Convert.ToString(contaLuz.GetAno());
                    txt_MedicaoAnteriorConta.Text = Convert.ToString(contaLuz.GetMedicaoAnterior());
                    txt_ConsumoMesConta.Text = Convert.ToString(contaLuz.GetConsumoMes());
                    txt_MedicaoTotalConta.Text = Convert.ToString(contaLuz.GetMedicaoTotal());
                    txt_impostoConta.Text = Convert.ToString(contaLuz.GetValorImposto());
                    txt_ValorSemImpostoConta.Text = Convert.ToString(contaLuz.GetTotalSemImposto());
                    txt_ValorReaisConta.Text = Convert.ToString(contaLuz.GetValorTotal());

                    txt_ContribuicaoLuz.Text = Convert.ToString(contaLuz.GetContribuicao());
                    txt_TarifaLuz.Text = Convert.ToString(contaLuz.GetTarifaLuz());
                    txt_TaxaImpostoLuz.Text = Convert.ToString(contaLuz.GetTaxaImposto());
                }
                else if (TipoConta == "Água")
                {
                    txt_nome.Text = consumidor.GetNome();
                    gbLuz.Visible = false;
                    ContaAgua contaAgua = new ContaAgua(mes, Convert.ToInt32(ano), consumidor);
                    txt_mes.Text = Convert.ToString(contaAgua.GetMes());
                    txt_ano.Text = Convert.ToString(contaAgua.GetAno());
                    txt_MedicaoAnteriorConta.Text = Convert.ToString(contaAgua.GetMedicaoAnterior());
                    txt_ConsumoMesConta.Text = Convert.ToString(contaAgua.GetConsumoMes());
                    txt_MedicaoTotalConta.Text = Convert.ToString(contaAgua.GetMedicaoTotal());
                    txt_impostoConta.Text = Convert.ToString(contaAgua.GetValorImposto());
                    txt_ValorSemImpostoConta.Text = Convert.ToString(contaAgua.GetTotalSemImposto());
                    txt_ValorReaisConta.Text = Convert.ToString(contaAgua.GetValorTotal());
                }


            }
        }
    }
}




