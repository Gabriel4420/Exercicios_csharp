using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Cotacao
{
    class Cotacao
    {
        public void recolhimentoInformacoes()
        {
            Console.WriteLine("Qual a cotação em Dolares: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversordeMoedas.DolarparaReal(qtd, cotacao);

            Console.WriteLine("O valor a ser pago é : " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    internal class ConversordeMoedas
    {
        public static double iof = 6.0;

        internal static double DolarparaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total += total * iof / 100.0;
        }
    }
}
