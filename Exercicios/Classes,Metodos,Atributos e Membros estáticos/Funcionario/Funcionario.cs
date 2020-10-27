using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Funcionario
{
    class Funcionario
    {
        public string Nome { get; set; }

        public double SalarioBruto { get; set; }

        public double Imposto { get; set; }

        // Métodos 

        public double SalarioLiquido()
        {
            double salario;
            return salario= SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumentarSalario, salarioAtual;

            

            porcentagem /= 100;

            aumentarSalario = porcentagem * SalarioBruto;

            salarioAtual = aumentarSalario + SalarioLiquido();
            

            Console.Write("Dados Atualizados \n " + Nome + " , Salario após promoção: R$ " + salarioAtual.ToString("F2",CultureInfo.InvariantCulture) );

        }


        public void LerDados()
        {
            double porc;

            RecapitulacaoLogica REP = new RecapitulacaoLogica();

            animacao();

            REP.carregando();

            Console.Write("Digite o nome do funcionario: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o salario Bruto: ");
            SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite o imposto : ");
            Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario : "+Nome+", Salario: "+SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            AumentarSalario(porc);


        }


        public void animacao()
        {
            Console.Write("BEM");

            Thread.Sleep(500);

            Console.Clear();

            Console.Write("   VINDO");

            Thread.Sleep(400);

            Console.Clear();

            Console.Write("         AO cADASTRO ");

            Thread.Sleep(300);

            Console.Clear();

            Console.Write("                       DE FUNCIONARIOS");
            Thread.Sleep(200);

            Console.Clear();
        }

    }
}
