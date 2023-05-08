using System;
using System.Collections.Specialized;
using System.Globalization;

namespace ExercicioProposto {
    class Program {
        static void Main(string[] args) {

            /* 
             1) Calcula 2 numeros

             int a, b, soma;

             Console.WriteLine("Entre com o primeiro numero: ");
             a = int.Parse(Console.ReadLine()!);
             Console.WriteLine("Entre com o segundo numero: ");
             b = int.Parse(Console.ReadLine()!);

             soma = a + b;

             Console.WriteLine("O resultado da soma é: " + soma);

             */

            /*

            2) Calcula a área de um círculo

            double raio;
            double resultado;

            Console.WriteLine("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            resultado = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A área do circulo é: " + resultado.ToString("F4", CultureInfo.InvariantCulture));

            */

            /*
            3) Diferenca de valores.
             int n1, n2, n3, n4;
             float diferenca;

             Console.WriteLine("Digite o primeiro valor: ");
             n1 = int.Parse(Console.ReadLine()!);
             Console.WriteLine("Digite o segundo valor: ");
             n2 = int.Parse(Console.ReadLine()!);
             Console.WriteLine("Digite o terceiro valor: ");
             n3 = int.Parse(Console.ReadLine()!);
             Console.WriteLine("Digite o quarto valor: ");
             n4 = int.Parse(Console.ReadLine()!);

             diferenca = (n1 * n2) - (n3 * n4);

             Console.WriteLine(diferenca);
            */

            /* 4) lÊ cod e calcula horas trabalhadas pelo valor da hora e mostra salario. 

            int cod;
            int horasTrab;
            double valorPorHora;
            double salario;

            Console.WriteLine("Digite o código do funcionário: ");
            cod = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            horasTrab = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            valorPorHora = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            salario = horasTrab * valorPorHora;

            Console.WriteLine(cod);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
              5) Calcula valor total das peças

            int cod1, cod2, qtdPeca1, qtdPeca2;
            float precoPeca1, precoPeca2, valorTot;

            Console.WriteLine("Digite o codigo do primeiro produto: ");
            cod1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a quantidade de peças que deseja: ");
            qtdPeca1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor unitário de cada peça: ");
            precoPeca1 = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite o codigo do segundo produto: ");
            cod2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a quantidade de peças que deseja: ");
            qtdPeca2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor unitário de cada peça: ");
            precoPeca2 = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            valorTot = (qtdPeca1*precoPeca1)+(qtdPeca2*precoPeca2);

            Console.WriteLine("VALOR A PAGAR: " + valorTot.ToString("F2", CultureInfo.InvariantCulture));

            */

            /*
             6) programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.

            double a, b, c;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine()!.Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) / 2 * c;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine(triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(retangulo.ToString("F3", CultureInfo.InvariantCulture));

            */

            //IF ELSE

            /* 1) Numero negativo ou positivo

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine()!);

            if(num < 0) {
                Console.WriteLine("NEGATIVO!");
            }
            else {
                Console.WriteLine("POSITIVO!");
            } */

            /* 2) PAR OU IMPAR.
             Console.WriteLine("Digite um número inteiro: ");
             int num = int.Parse(Console.ReadLine()!);

             if(num%2 == 0) {
                 Console.WriteLine("PAR!");

             }
             else {
                 Console.WriteLine("IMPAR!");
             }
            */

            /* 3) MULTIPLOS 

            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine()!);

            if(a%b == 0 || b%a==0){
                Console.WriteLine($"Os números {a} e {b} são múltiplos");
            }
            else {
                Console.WriteLine($"Os números {a} e {b} não são múltiplos!");
            }
            */

            /* 4) DURACAO DE UM JOGO
            Console.WriteLine("Digite a hora de inicio e fim do jogo na mesma linha: ");
            string[] valores = Console.ReadLine()!.Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if(horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + "HORAS");
            */

            /* 5) LEITURA DE CODIGO E QUANTIDADE
            Console.WriteLine("Digite o código e a quantidade do produto: ");
            string[] valores = Console.ReadLine()!.Split(' ');
            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double total = 0.00;

            if(cod == 1) {
                total = qtd * 4.00;
            }
            else if(cod == 2){
                total = qtd * 4.50;
            }
            else if (cod == 3) {
                total = qtd * 5.00;
            }
            else if (cod == 4) {
                total = qtd * 2.00;
            }
            else{
                total = qtd * 1.50;
            }

            Console.WriteLine("TOTAL: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* 6) LEITURA DE VALORES E MOSTRAR INTERVALO.

            Console.WriteLine("DIGITE UM VALOR DE 0 A 100: ");
            double valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.00) {
                Console.WriteLine("Fora de intervalo!");
            }
            else if (valor <= 50) {
                Console.WriteLine("Intervalo (25,50)");
            }
            else if (valor <= 75) {
                Console.WriteLine("Intervalo (50,75");
            }
            else if (valor <= 100) {
                Console.WriteLine("Intervalo (75,100)");
            }
            else{

                Console.WriteLine("Intervalo (0,25)");
            }
            */
            /* 7) Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
            de um ponto em um plano.

            Console.WriteLine("DIGITE O VALOR DE X E Y");
            string[] valores = Console.ReadLine()!.Split(' ');

            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");

            }
            else if (x< 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
            */

            /* 8) CALCULAR IMPOSTO DE RENDA
            Console.WriteLine("Digite o valor do seu salário: ");
            double sal = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double imposto;

            if(sal <= 2000.00) {

                imposto = 0.0;
            }
            else if(sal <= 3000.00) {
                imposto = (sal - 2000.00) * 0.08;

            }
            else if(sal <= 4500.00) {
                imposto = (sal - 3000.0) * 0.18 + 1000.00 * 0.08;

            }
            else {
                imposto = (sal - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            }
            if(imposto == 0.0) {
                Console.WriteLine("ISENTO!");
            }
            else {
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            */
            /* CRIANDO UMA FUNÇÃO
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine()!);
            int n2 = int.Parse(Console.ReadLine()!);
            int n3 = int.Parse(Console.ReadLine()!);

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " +  resultado);

            }

            static int Maior(int a, int b, int c) {
            int m;
            if(a > b && a > c) {
                m = a;
            }
            else if(b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
            */
            /*
             Estrutura WHILE
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Clear();

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Clear();
            }
            Console.WriteLine("Número negativo!");
            */
            /* 1) Verificador de senha
            int senha = 2002;
            int senhaDigitada;

            Console.Write("Digite a senha: ");
            senhaDigitada = int.Parse(Console.ReadLine()!);

            while(senhaDigitada != senha) {
                Console.WriteLine("Senha inválida");
                Console.Write("Digite a senha: ");
                senhaDigitada = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Acecsso permitido!");
            */

            /*
             2) a ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos
            Console.WriteLine("Digite os valores de X e Y: ");
            string[] valores = Console.ReadLine()!.Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine()!.Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            */
            /* 3)
            int alcool = 0, gasolina = 0, diesel = 0;
            int comb;

            Console.WriteLine("Digite o tipo de combustivel: ");
            comb = int.Parse(Console.ReadLine()!);
            Console.Clear();

            while(comb != 4) {
                if(comb == 1) {
                    alcool++;
                }
                else if(comb == 2) {
                    gasolina++;
                }
                else {
                    diesel++;
                }
                Console.WriteLine("Digite o tipo de combustivel: ");
                comb = int.Parse(Console.ReadLine()!);
                Console.Clear();
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcol: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            */

            /* 1) ESTRUTURA IF
              Console.WriteLine("Digite um valor inteiro: ");
            int X = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= X; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
            */
            /*
            Console.WriteLine("Digite o valor da repetição: ");
            int n = int.Parse(Console.ReadLine()!);

            int cIn = 0;
            int cOut = 0;

            for(int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine()!);
                if(x >= 10 && x <= 20) {
                    cIn++;
                }
                else {
                    cOut++;

                }

            }
            Console.WriteLine("In: " + cIn);
            Console.WriteLine("Out: " + cOut);

            */


        }
    }

}
