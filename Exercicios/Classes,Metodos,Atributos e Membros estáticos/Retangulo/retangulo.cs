using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Exercicios;

namespace Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Retangulo
{
    class retangulo
    {
        RecapitulacaoLogica rep = new RecapitulacaoLogica();


        public double Largura { get; set; }
        public double Altura { get; set; }

        public void animacao()
        {
            Console.Write("BEM");

            Thread.Sleep(500);

            Console.Clear();

            Console.Write("   VINDO");

            Thread.Sleep(400);

            Console.Clear();

            Console.Write("         A CALCULADORA ");

            Thread.Sleep(300);

            Console.Clear();

            Console.Write("                       DE TRIANGULOS");
            Thread.Sleep(200);

            Console.Clear();

            rep.carregando();
        }

        public void Leitura()
        {

            animacao();

            Console.Write("Digite a largura do triangulo: ");
            Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite a Altura do triangulo: ");
            Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area();

            perimetro();

            diagonal();

            Console.WriteLine("Area: "+area().ToString("F2" ,CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }


        public double area()
        {
            return Largura * Altura;
        }

        public double perimetro()
        {
            return (Altura + Largura) * 2;
        }

        public double diagonal()
        {
            double diag, result;
            diag = Math.Pow(Altura, 2) + Math.Pow(Largura, 2);
            result = Math.Sqrt(diag);
            

            return result;
        }


    }
}
