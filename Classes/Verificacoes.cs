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
		public void ValoresFat(Empresas empresas)
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

        public void PorteFat(Empresas empresas)
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
                    empresas.Porte = "Empresas de pequeno porte - EPP";
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

        public void VerificarRegime(Empresas empresas)
        {
            string regime = empresas.Regime;
            try
            {
                if (regime == "Simples Nacional")
                {
                    Console.WriteLine($"Regime: {empresas.Regime} \nA empresa pode se enquadrar nos portes: " +
                        $"Microempreendedor | Microempresa - ME | Empresas de pequeno porte - EPP\n");
                }
                else if (regime == "Lucro Presumido")
                {
                    Console.WriteLine($"Regime: {empresas.Regime} \nA empresa pode se enquadrar nos portes: " +
                        $" Empresas de pequeno porte - EPP | Médio Porte\n");
                }
                else if (regime == "Lucro Real")
                {
                    Console.WriteLine($"Regime: {empresas.Regime} \nA empresa pode se enquadrar nos portes: " +
                        $"Médio Porte | Grande porte\n");
                }
                else
                {
                    Console.WriteLine("REGIME INVÁLIDO!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
