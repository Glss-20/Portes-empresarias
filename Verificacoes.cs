using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Porte_Empresarial;

namespace Porte_Empresarial
{
	public class Verificacoes
	{
		public void Faturamento (Empresas empresas)
		{
            double total = 0;
            int cont = 0;
            while (cont < 12)
            {
                try
                {
                    Console.Write($"Valor do faturamento do {cont + 1}º mês: ");
                    double fat = double.Parse(Console.ReadLine());
                    total += fat;
                    cont++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor do faturamento incompatível!");
                }
            }
            empresas.FaturamentoAnual = total;
        }

        public void VerificarFaturamento(Empresas empresas)
        {
            double fat = empresas.FaturamentoAnual;

            try
            {
                if (fat > 0 && fat <= 81000)
                {
                    empresas.Porte = "Microempreendedor";
                }
                else if (fat > 81000 && fat <= 360000)
                {
                    empresas.Porte = "Microempresa - ME";
                }
                else if (fat > 360000 && fat <= 4800000)
                {
                    empresas.Porte = "empresas de pequeno porte- EPP";
                }
                else if (fat > 4800000 && fat <= 300000000)
                {
                    empresas.Porte = "Médio Porte";
                }
                else if (fat > 300000000)
                {
                    empresas.Porte = "Grande porte";
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Valor do faturamento incompatível");
            }
        }
    }
}
