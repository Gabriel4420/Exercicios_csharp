using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Escola;
using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Funcionario;
using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Produto;
using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Retangulo;
using Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Cotacao;
using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            RecapitulacaoLogica ed = new RecapitulacaoLogica();

            Classes_Metodos_Atributos_StaticMembers cm = new Classes_Metodos_Atributos_StaticMembers();

            Produto p = new Produto("Tv",500.0,100);

            Produto p2 = new Produto();

            Triangulo tri = new Triangulo();

            retangulo ret = new retangulo();

            Funcionario funcionario = new Funcionario();

            Escola escola = new Escola();

            ProgramTriangulo triangulo = new ProgramTriangulo();

            Cotacao cot = new Cotacao();

            p2.Escrita();

            
            
            Console.ReadKey();
        }
    }
}
