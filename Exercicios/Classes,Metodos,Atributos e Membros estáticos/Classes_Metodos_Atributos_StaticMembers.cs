using System;
using System.Globalization;
using System.Threading;
using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Calculadora;

namespace Exercicios
{
    class Classes_Metodos_Atributos_StaticMembers
    {

        public void exercicio1()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triangulo X: ");


            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
                Console.WriteLine("Maior Area: X ");
            else
                Console.WriteLine("Maior Area: Y");
        }



    }

    

}


namespace Exercicios
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;


        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa();

        public void imprimirTela()
        {
            Console.WriteLine("Bem vindo ao Comparador de Idades !!!!");

            Thread.Sleep(1500);

            Console.Clear();

            RecapitulacaoLogica rep = new RecapitulacaoLogica();

            rep.carregando();




            Console.WriteLine("informe o nome da pessoa ");
            p.Nome = Console.ReadLine();

            Console.Write("Informe a idade da pessoa: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            Console.WriteLine("\n informe o nome da pessoa ");
            p2.Nome = Console.ReadLine();

            Console.Write("Informe a idade da pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());



            if (p.Idade>p2.Idade)
                Console.WriteLine("Mais velhoª : "+p.Nome);
            else
                Console.WriteLine("Mais velhoª : " + p2.Nome);




        }
    }

    public class Pessoa
    {
        public string Nome;
        public int Idade;


       
       
        

        
    }

    public class ProgramTriangulo
    {
        
        public void Triangulo()
        {
            

            Console.Write("Entre com o valor do raio : ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);

            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência : " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }


        
    }


}