using System;
using System.Globalization;
using System.Threading;

namespace Exercicios.Classes_Metodos_Atributos_e_Membros_estáticos.Produto
{
    public class Produto
    {
        //atributo privativo
        private string _nome;
        //props auto incrementadas
        public double Preco { get; private set; }

        public int Quantidade { get; set; }
        //construtores
        public Produto(string nome, double preco, int quantidade)
		{
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
		}

        public Produto()
		{

		}
        //props customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }



        //Métodos 


        public double valorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void Escrita()
        {
            RecapitulacaoLogica r = new RecapitulacaoLogica();

            r.carregando();
            
            int qde;
                        
            Console.Write("Insira o nome do produto: ");
            Nome = Console.ReadLine();
            
            Console.Write("Preço : ");
            Preco = double.Parse(Console.ReadLine());
            
           
            Console.WriteLine("Dados do produto = "+ToString());

            Console.Write("Quer Adicionar quantos produtos : ");
            qde = int.Parse(Console.ReadLine());

            AdicionarProdutos(qde);

            Console.WriteLine("Dados do produto = " + ToString());

        }

        public override string ToString()
        {
            return"Nome do produto: "+ Nome
                + " , Preço do Produto : $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , " 
                + Quantidade
                +" unidades , Total: $ "
                +valorEmEstoque().ToString("F2",CultureInfo.InvariantCulture)


                
                ;
            
        }


        public void AdicionarProdutos(int quantidade)
        {
            
            char resp;
          

            Quantidade += quantidade;

            

            Console.WriteLine("valor Atualizado do estoque: "+valorEmEstoque().ToString("F2",CultureInfo.InvariantCulture));

            Thread.Sleep(4000);

            Console.Clear();

            Console.WriteLine("Quer continuar no programa?[Y/N] ");
            resp = char.Parse( Console.ReadLine());

            if (resp == 'Y')
                Escrita();
            else
                Console.Clear();



        }

        public void RemoverProdutos(int quantidade)
        {

            char resp;


            Quantidade -= quantidade;



            Console.WriteLine("valor Atualizado do estoque: " + valorEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Thread.Sleep(4000);

            Console.Clear();


            Console.WriteLine("Quer continuar no programa?[Y/N] ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 'Y')
                Escrita();
            else
                Console.Clear();



        }



    }
}
