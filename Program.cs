using System;
using Porte_Empresarial;

namespace Porte_Empresarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresas empresa = new Empresas();
            empresa.TelaInicial();

            Console.ReadLine(); // Aguarda a interação do usuário antes de fecha

            Verificacoes verificacoes = new Verificacoes();
        }
    }
}
