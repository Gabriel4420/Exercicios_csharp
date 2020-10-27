using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Escola
{
    class Escola
    {
        //Atributos 

        public string Nome { get; set; }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }



        //Métodos 

        public void NotaFinal()
        {
            double notaFinal;

            notaFinal = Nota1 + Nota2 + Nota3;

            
            

            Console.Write("NOTA FINAL: "+notaFinal.ToString("F2",CultureInfo.InvariantCulture));

            if(notaFinal < 60.0)
                Console.WriteLine(" \nREPROVADO \nFALTARAM "+(60.0-notaFinal) +" PONTOS");
            else
            {
                Console.WriteLine("\nAPROVADO");
            }


        }

        public void LerDados()
        {
            RecapitulacaoLogica REP = new RecapitulacaoLogica();

            animacao();

            REP.carregando();

            Console.Write("Digite o nome do Aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a 1° nota : ");
            Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite a 2° nota : ");
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a 3° nota : ");
            Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            NotaFinal();

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

            Console.Write("                       DE ALUNOS");
            Thread.Sleep(200);

            Console.Clear();
        }


    }
}
