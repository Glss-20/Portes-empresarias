using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Porte_Empresarial
{
    public class Empresas
    {
        public string RazaoSocial { get; set; }
        public int Cnpj { get; set; }
        public double FaturamentoAnual { get; set; }
        public string Porte { get; set; }
        public DateTime Constituicao { get; set; }
        public int QtdFuncionarios { get; set; } // Fazer verificação através do numero de funcionarios
        public string Regime { get; set; } // Fazer verificação através do regime tributario
        
        public Empresas()
        {

        }

        public Empresas(string razaoSocial, int cnpj, double faturamentoAnual, string Porte, DateTime constituicao, int qtdFuncionarios, string regime)
        { 
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.FaturamentoAnual = faturamentoAnual;
            this.Porte = Porte;
            this.Regime = regime;
            this.Constituicao = constituicao;
            this.QtdFuncionarios = qtdFuncionarios;
        }

        //public double InserirFaturamento()
        //{
        //    double total = 0;
        //    int cont = 0;
        //    while (cont < 12)
        //    {
        //        try
        //        {
        //            Console.Write($"Valor do faturamento do {cont}º mês: ");
        //            double fat = double.Parse(Console.ReadLine());
        //            total += fat;
        //            cont++;
        //        }
        //        catch (FormatException e)
        //        {
        //            Console.WriteLine("Valor do faturamento incompatível!");
        //        }
        //    }

        //    return total;
        //}

        //public void VerificarPorte(double faturamento_anual)
        //{
        //    try
        //    {
        //        if (faturamento_anual > 0 && faturamento_anual <= 81000)
        //        {
        //            Porte = "Microempreendedor";

        //        }
        //        else if (faturamento_anual > 81000 && faturamento_anual <= 360000)
        //        {
        //            Porte = "Microempresa - ME";

        //        }
        //        else if (faturamento_anual > 360000 && faturamento_anual <= 4800000)
        //        {
        //            Porte = "Empresa de pequeno porte - EPP";
        //        }
        //        else if (faturamento_anual > 4800000 && faturamento_anual <= 300000000)
        //        {
        //            Porte = "Médio porte - ME";
        //        }
        //        else if (faturamento_anual > 300000000)
        //        {
        //            Porte = "Grande porte";
        //        }
        //        else
        //        {
        //            Console.WriteLine("Valor inválido!");
        //        }
        //    }

        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Valor do faturamento incompatível");
        //    }
        //}

        public void VerificarOpcao(int opcao)
        {
            Verificacoes verificacoes = new Verificacoes();

            switch (opcao)
            {
                case 1:
                    verificacoes.Faturamento(this);
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"Faturamento anual registrado: {this.FaturamentoAnual}");
                    Console.WriteLine(new string('-', 40));
                    verificacoes.VerificarFaturamento(this);
                    Console.WriteLine($"Porte da empresa: {this.Porte}");
                    Console.WriteLine(new string('-', 40));
                    break;
                case 2:
                    //    //    VerRegime();

                    break;
                case 3:
                    //    //    VerFuncionarios();

                    break;
            }
        }

        public void ExibirDados()
        {

        }
       
        public void TelaInicial()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("PROGRAMA - PORTE EMPRESARIAL");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('=', 30));

            int opcao = 0;
            Console.WriteLine("Escolha sua opção:\n" +
                "1 - Verificar porte empresarial através do faturamento;\n" +
                "2 - Verificar porte empresarial através do Regime Tributário;\n" +
                "3 - Verificar porte empresarial através da quantidade de funcionários;\n");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            VerificarOpcao(opcao);
        }

        //Console.WriteLine("Data de constituição (DD/MM/YYYY)");
        //DateTime date = DateTime.Parse(Console.ReadLine());
    }
}
