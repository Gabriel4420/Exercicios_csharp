using System;
using System.Globalization;
using System.Threading;

namespace Exercicios
{
    class RecapitulacaoLogica
    {

        //Exercicos de entrada de dados

        public void Dados()
        {
            //Entrada
            Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos existem em sua casa :");
            int qtdquartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            string[] vs = Console.ReadLine().Split(' ');
            string sobrenome = vs[0];
            int idade = int.Parse(vs[1]);
            double altura = double.Parse(vs[2]);

            //Saida 
            Console.WriteLine("\n SAIDA \n\n seu nome: " + nome + "\n Quantidade de quartos: " + qtdquartos + "\n" + " R$ " + preco + "\n Sobrenome: " + sobrenome + "\n Idade: " + idade + "\n Altura: " + altura);


        }


        public void Soma()
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            x += y;

            Console.WriteLine("Soma:" + x);

        }

        public void calculoAreaCirculo()
        {
            double raio, area;

            raio = 0;

            raio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(2, raio);

            Console.WriteLine("O valor da area desse circulo é : " + area);
        }


        public void diferenca()
        {
            int a, b, c, d, dif;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            dif = (a * b - c * d);

            Console.WriteLine("Diferença = " + dif);
        }


        public void Funcionarios()
        {
            int numFuncionario;
            double salarioPerHora, horasTrabalhadas, salario;

            Console.WriteLine("\nDigite o numero do funcionario: ");
            numFuncionario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite as horas Trabalhadas : ");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor por Hora: ");
            salarioPerHora = Convert.ToDouble(Console.ReadLine());

            salario = salarioPerHora * horasTrabalhadas;

            Console.WriteLine("\nSalario = R$ " + salario.ToString("F"));

        }


        public void Compras()
        {

            int cod, numPecas, cod2, numPecas2;
            double valorUnitario, valorUnitario2, total;

            Console.WriteLine("\nDigite o codigo da peça : ");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade de peças desejada : ");
            numPecas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o valor Unitario : ");
            valorUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o codigo da peça 2 : ");
            cod2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade de peças desejada 2 : ");
            numPecas2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o valor Unitario 2 : ");
            valorUnitario2 = Convert.ToDouble(Console.ReadLine());


            valorUnitario *= numPecas;
            valorUnitario2 *= numPecas2;



            total = valorUnitario + valorUnitario2;



            Console.WriteLine("\nVALOR A SER PAGO = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
        //Exercicios de Switch

        public void Trigonometria()
        {
            int x;
            double a, b, c, triagRet, circle, trapezio, quadrado, retangulo;



            Console.WriteLine("|------Menu------------| \n|[1]Triangulo Retangulo| \n|[2]Circulo            |  \n|[3]Trapézio           | \n|[4]Quadrado           | \n|[5]Retangulo          |\n|----------------------|\nDigite o numero do programa que quer rodar: ");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("\nDigite o valor da Base: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor da Altura: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    triagRet = a * c / 2;

                    Console.WriteLine("Area do Triangulo Retângulo: " + triagRet);

                    break;
                case 2:
                    Console.WriteLine("\nDigite o valor do Raio: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    circle = Math.PI * Math.Pow(2, c);

                    Console.WriteLine("\nArea do Circulo : " + circle.ToString("F3", CultureInfo.InvariantCulture));

                    break;

                case 3:
                    Console.WriteLine("\nDigite o valor da Base B: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor da Base b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor da Altura ");
                    c = Convert.ToDouble(Console.ReadLine());

                    trapezio = ((a + b) / 2) * c;

                    Console.WriteLine("\nValor da Area do Trapézio : " + trapezio.ToString("F3", CultureInfo.InvariantCulture));


                    break;

                case 4:
                    Console.WriteLine("\nDigite o valor do lado L: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    quadrado = Math.Pow(2, b);

                    Console.WriteLine("\nValor da area do Quadrado: " + quadrado.ToString("F2"));

                    break;

                case 5:
                    Console.WriteLine("\nDigite o valor da Base : ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor da Altura: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    retangulo = a * b;

                    Console.WriteLine("\n Area do triangulo : {0:2F}", retangulo);

                    break;
                default:
                    Console.WriteLine("\n");
                    Console.Out.WriteLine();
                    break;


            }





        }

        public void mataBarata()
        {
            double a, b, c;

            Console.WriteLine("\nDigite o valor da Base B: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o valor da Base b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o valor da Altura ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area do Triangulo Retângulo: " + (a * c) / 2);
            Console.WriteLine("\nArea do Circulo : " + Math.PI * Math.Pow(c, 2));
            Console.WriteLine("\nValor da Area do Trapézio : " + ((a + b) / 2) * c);
            Console.WriteLine("\nValor da area do Quadrado: " + Math.Pow(2, b));
            Console.WriteLine("\nArea do triangulo : " + a * b);


        }

        //Exercicios de Lógica condicional
        public void ParOuImpar()
        {
            double x;

            Console.WriteLine("Digite um numero: ");
            x = double.Parse(Console.ReadLine());

            if (x % 2 != 0)
                Console.WriteLine("o numero " + x + "é impar");
            else
                Console.WriteLine("O numero " + x + " é par");

        }


        public void multipleCondition()
        {
            int hora;

            hora = int.Parse(Console.ReadLine());

            if (hora == 2)
                Console.WriteLine("ta na madruga");
            else if (hora == 14)
                Console.WriteLine("Tarde !");
            else if (hora == 20)
                Console.Write("holy shit");


        }

        public void Negativado()
        {
            int x = int.Parse(Console.ReadLine());

            Console.Clear();

            carregando();

            if (x < 0)
                Console.WriteLine("\nO valor digitado é negativo");
            else
                Console.WriteLine("\nO valor digitado não é Negativo");

        }

        public void MultiplosEntreSi()
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.Clear();
            if (a % b == 0 || b % a == 0)
            {
                carregando();

                Console.WriteLine("\nSão Multiplos entre si");

            }

            else
            {
                carregando();

                Console.WriteLine("\nNão São Multiplos entre si");
            }



        }


        public void Campeonato()
        {
            /*
                PROBLEMATICA - LEIA A HORA INICIAL E A HORA FINAL DE UM DETERMINADO JOGO, A SEGUIR CALCULE A DURAÇAO DO JOGO
                SABENDO QUE O MESMO PODE COMEÇAR EM 1 DIA E TERMINAR NO OUTRO.
                DURAÇÃO MIN: 1  HORA
                DURAÇÃO MAX: 24 HORAS
             
             
             
             */

            string[] valores = Console.ReadLine().Split(' ');

            int horainicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horainicial < horaFinal)
                duracao = horaFinal - horainicial;
            else
                duracao = 24 - horainicial + horaFinal;

            if (duracao > 1)
                Console.WriteLine("O JOGO DUROU " + duracao + " HORAS");
            else
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA");

        }


        public void banquinhaCachorroQuente()
        {
            int cod, qtd;
            double preco = 0, total;

            Console.WriteLine("\n Cod Especificação    Preço    \n");
            Console.WriteLine("\n [1] Cachorro Quente  4,00     \n");
            Console.WriteLine("\n [2] X-Salada         4,50     \n");
            Console.WriteLine("\n [3] X-Bacon          5,00     \n");
            Console.WriteLine("\n [4] Torrada Simples  2,00     \n");
            Console.WriteLine("\n [5] Refrigerante     1,50     \n");

            Console.WriteLine("\nDigite o código do produto:");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o quantidade desejada:");
            qtd = int.Parse(Console.ReadLine());

            if (cod == 1) { preco = 4.00; total = preco * qtd; Console.WriteLine("\nFicou " + total + " R$\n"); }

            else if (cod == 2) { preco = 4.50; total = preco * qtd; Console.WriteLine("\nFicou " + total + " R$\n"); }
            else if (cod == 3) { preco = 5.00; total = preco * qtd; Console.WriteLine("\nFicou " + total + " R$\n"); }
            else if (cod == 4) { preco = 2.00; total = preco * qtd; Console.WriteLine("\nFicou " + total + " R$\n"); }
            else { preco = 1.50; total = preco * qtd; Console.WriteLine("\nFicou " + total + " R$\n"); }


        }


        public void intervalo()
        {
            double x;

            Console.Write("Digite um numero : ");
            x = double.Parse(Console.ReadLine());

            if (x >= 0 && x <= 25)
            {
                Console.WriteLine("intervalo[0-25]");
            }
            else if (x >= 25 && x <= 50)
            {
                Console.WriteLine("intervalo[25-50]");
            }
            else if (x >= 50 && x <= 75)
            {
                Console.WriteLine("intervalo[50-75]");
            }
            else if (x >= 75 && x <= 100)
            {
                Console.WriteLine("intervalo[75-100]");
            }
            else
            {
                Console.WriteLine("intervalo inexistente");
            }

        }

        public void exercicio7()
        {
            double eixoX, eixoY;

            string[] valores = Console.ReadLine().Split(' ');

            Console.WriteLine("Digite o valor do eixo X: ");
            eixoX = double.Parse(valores[0], CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do eixo Y: ");
            eixoY = double.Parse(valores[1], CultureInfo.InvariantCulture);


            if (eixoX == 0.0)
                Console.WriteLine("eixo Y");
            else if (eixoY == 0.0)
            {
                Console.WriteLine("eixo X");
            }


            if (eixoX < 0 && eixoY >= 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoY < 0.0 && eixoX < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoY > 0.0 && eixoX >= 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX == 0.0 && eixoY == 0.0)
            {
                Console.WriteLine("eixo Origem");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }


        // Exercicios while - lógica de repetição

        public void password()
        {
            int senha;


            Console.WriteLine("Digite sua senha : ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2019)
            {

                Console.WriteLine("Acesso Negado");
                Console.WriteLine("Digite sua senha : ");
                senha = int.Parse(Console.ReadLine());


            }


            Console.WriteLine("\nAcesso Permitido");




        }


        public void quad()
        {
            int eixoX, eixoY;

            Console.WriteLine("Digite o valor do eixo X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');

            eixoX = int.Parse(valores[0]);

            eixoY = int.Parse(valores[1]);



            while (eixoX != 0 && eixoY != 0)
            {


                if (eixoX < 0 && eixoY >= 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (eixoY < 0 && eixoX < 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (eixoY > 0 && eixoX > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (eixoX > 0 && eixoY < 0)
                {
                    Console.WriteLine("Q4");
                }


                valores = Console.ReadLine().Split(' ');

                eixoX = int.Parse(valores[0]);

                eixoY = int.Parse(valores[1]);


            }



        }

        public void carregando()
        {
            Console.WriteLine("Loading.");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Loading..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading.");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Loading..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading.");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Loading..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(500);
        }

        //união de camadas lógicas - switch with elif
        public void postoGasosa()
        {
            int combustivel, alcool = 0, diesel = 0, gasolina = 0;

            carregando();


            Console.Write("Por favor informe o combustivel de sua preferência: ");
            combustivel = int.Parse(Console.ReadLine());

            while (combustivel < 4)
            {
                if (combustivel == 1)
                {
                    alcool++;
                    Console.WriteLine("Alcool:" + alcool);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (combustivel == 2)
                {
                    gasolina++;
                    Console.WriteLine("Gasolina:" + gasolina);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (combustivel == 3)
                {
                    diesel++;
                    Console.WriteLine("Diesel:" + diesel);
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                Console.Write("Por favor informe o combustivel de sua preferência: ");
                combustivel = int.Parse(Console.ReadLine());


            }
            if (combustivel == 8)
            {
                Console.WriteLine("Muito Obrigado");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("diesel: " + diesel);
            }

        }
    }
}
