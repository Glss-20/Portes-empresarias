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
        public string Cnpj { get; set; }
        public double FaturamentoAnual { get; set; }
        public string Porte { get; set; }
        public DateTime Constituicao { get; set; }
        public int QtdFuncionarios { get; set; } // Fazer verificação através do numero de funcionarios
        public string Regime { get; set; } // Fazer verificação através do regime tributario
        
        public Empresas()
        {

        }

        public Empresas(string razaoSocial, string cnpj, double faturamentoAnual, string Porte, DateTime constituicao, int qtdFuncionarios, string regime)
        { 
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.FaturamentoAnual = 0;
            this.Porte = "Indefinido";
            this.Regime = regime;
            this.Constituicao = constituicao;
            this.QtdFuncionarios = qtdFuncionarios;
            
        }

        public void TelaInicial()
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("PROGRAMA - PORTE EMPRESARIAL");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Preencha os dados da empresa:");
            
            //CRIAR TRATAMENTO DE EXCEÇÕES
            Console.Write("Razão social: ");
            RazaoSocial = Console.ReadLine();
            Console.Write("CNPJ: "); // MANIPULAR O FORMATO
            Cnpj = Console.ReadLine();
            Console.Write("Data de constituição (DD/MM/YYYY): ");
            Constituicao = DateTime.Parse(Console.ReadLine()); // TIRAR A HORA
            Console.Write("Quantidade de funcionários: ");
            QtdFuncionarios = int.Parse(Console.ReadLine());
            Console.Write("Regime tributário: ");
            Regime = Console.ReadLine(); // CRIAR ENUM??
        }
        
        public void TelaSecundaria()
        {
            int cont = 1;
            while (cont == 1)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Selecione sua opção: \n1 - Exibir dados da empresa; \n2 - Verificar porte; \n3 - Sair do programa; \n");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExibirDados();
                        break;
                    case 2:
                        TelaFaturamento();
                        break;
                    case 3:
                        cont = 0;
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void TelaFaturamento()
        {
            while (true)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Escolha sua opção para verificar o porte:\n" +
                    "1 - Através do faturamento;\n" +
                    "2 - Através do Regime Tributário;\n" +
                    "3 - Através da quantidade de funcionários;\n" +
                    "4 - Sair do verificador de porte; \n");

                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(new string('=', 40));

                if (opcao == 4)
                {
                    break;
                }
                else
                {
                    VerificarOpcao(opcao);
                }
            }
        }

        public void VerificarOpcao(int opcao)
        {
            Verificacoes verificacoes = new Verificacoes();
            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine();
                    verificacoes.ValoresFat(this);

                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"Faturamento anual registrado: R${FaturamentoAnual}");
                    Console.WriteLine(new string('-', 40));
                    verificacoes.PorteFat(this);
                    Console.WriteLine($"Porte da empresa: {Porte}\n");
                    break;

                case 2:
                    verificacoes.VerificarRegime(this);

                    break;
                case 3:
                    //VerificarFuncionarios();

                    break;
            }
        }

        public void ExibirDados() // FAZER EM FORMA DE TABELA BONITIN, TUDO DO MESMO TAMANHO
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("DADOS DA EMPRESA");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Razão social = {RazaoSocial}");
            Console.WriteLine($"CNPJ = {Cnpj}");
            Console.WriteLine($"Data de constituição = {Constituicao}");
            Console.WriteLine($"Regime = {Regime}");
            Console.WriteLine($"Quantidade de funcionários = {QtdFuncionarios}");
            Console.WriteLine($"Porte: {Porte}");
            Console.WriteLine($"Faturamento anual: {FaturamentoAnual}\n");           
        }
    }
}
