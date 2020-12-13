using System;
using System.Globalization;

namespace Projeto
{
    public class Calculadora
    {
        public void Inicio()
        {

            double n1 = 0.0;
            double n2 = 0.0;
            double resultado = 0.0;

            Calculadora calc;
            calc = new Calculadora();

            Console.WriteLine("Digite um valor:");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual operação você deseja fazer?");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Soma(ref n1, out n2, out resultado);
                    break;
                case "-":
                    Subtracao(ref n1, out n2, out resultado);
                    break;
                case "x":
                    Multiplicacao(ref n1, out n2, out resultado);
                    break;
                case "/":
                    Divisao(ref n1, out n2, out resultado);
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    Console.ReadLine();
                    break;
            }
        }
    public void Soma(ref double n1, out double n2, out double resultado)
        {
            Console.WriteLine("Digite o Segundo valor:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 + n2);

            Console.WriteLine("Resultado = " + resultado);
        }
        public void Subtracao(ref double n1,  out double n2, out double resultado)
        {
            Console.WriteLine("Digite o Segundo valor:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 - n2);

            Console.WriteLine("Resultado = " + resultado);
        }
        public void Multiplicacao(ref double n1, out double n2, out double resultado)
        {
            Console.WriteLine("Digite o Segundo valor:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 * n2);

            Console.WriteLine("Resultado = "+ resultado);
        }
        public void Divisao(ref double n1, out double n2, out double resultado)
        {
            Console.WriteLine("Digite o Segundo valor:");
            n2 = double.Parse(Console.ReadLine());
            resultado = 0.0;
            if (n2 == 0)
            {
                Console.WriteLine("Operação Inválida! Impossivel dividir por 0!");
            }
            else
            {
                resultado = (n1 / n2);

                Console.WriteLine("Resultado = " + resultado);
            }
            
        }
    }
}