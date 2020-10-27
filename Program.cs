using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            string EmprestimoDig, ParcelaDig, RendaMensalDig;
            int parcelas;
            decimal valor, rendaMensal, EmprestimoParcela, valorMaximoParcela;
            bool valorValido, rendaMensalValido, parcelasValido, creditoAprovado;

            Console.Clear();
            Console.WriteLine("-- Análise de Crédito --");

            Console.Write("Qual o valor estimado?    ");
            EmprestimoDig = Console.ReadLine();

            Console.Write("Em quantas parcelas?      ");
            ParcelaDig = Console.ReadLine();

            Console.Write("Informe sua renda mensal ? ");
            RendaMensalDig = Console.ReadLine();

            valorValido = Decimal.TryParse(EmprestimoDig, out valor);
            parcelasValido = Int32.TryParse(ParcelaDig, out parcelas);
            rendaMensalValido = Decimal.TryParse(RendaMensalDig, out rendaMensal);

            Console.WriteLine("---");

            if (!valorValido || !parcelasValido ||   !rendaMensalValido)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você digitou algum valor inválido. Tente novamente.");
            }
            else
            {
                EmprestimoParcela = valor / parcelas;
                valorMaximoParcela = rendaMensal * 0.3m;
                

                Console.WriteLine($"Valor da parcela...: {EmprestimoParcela:C}");
                Console.WriteLine($"Parcela máxima.....: {valorMaximoParcela:C}");

                creditoAprovado = EmprestimoParcela <= valorMaximoParcela;

                if (creditoAprovado)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns, seu crédito foi aprovado! :)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desculpe, seu crédito não foi aprovado. :(");
                }
            }            

                    Console.ResetColor();
                    Console.WriteLine("Obrigado por ultilizar nossos servicos!");
        }
    }
}
