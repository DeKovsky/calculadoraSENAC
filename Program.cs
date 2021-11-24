using System;

namespace uc03DesafioCalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int num1, num2, operacao, calculo;
            float calculo2;
            char continuar;
            
        
            
            Console.WriteLine("Seja bem vindo a nossa calculadora!");
            Console.WriteLine("Por gentileza, nos informe seu nome:");
            nome = Console.ReadLine();

            do{
                Console.WriteLine("Qual a operação que você deseja realizar?");
                Console.WriteLine("Digite - 1 - para SOMA, - 2 - para SUBTRAÇÃO, - 3 - para MULTIPLICAÇÃO, - 4 - para DIVISÃO, - 5 - para POTENCIAÇÃO ou - 6 - para PORCENTAGEM:");
                operacao = int.Parse(Console.ReadLine());

                switch(operacao){
                    case 1:
                    Console.WriteLine("Digite o 1º número que deseja somar:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número que deseja somar:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo = num1 + num2;
                    Console.WriteLine(nome + ", o resultado da soma de: " + num1 + " + " + num2 + " = " + calculo);
                    break;

                    case 2:
                    Console.WriteLine("Digite o 1º número que deseja realizar a subtração:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número que deseja realizar a subtração:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo = num1 - num2;
                    Console.WriteLine(nome + ", o resultado da subtração de: " + num1 + " - " + num2 + " = " + calculo);
                    break;

                    case 3:
                    Console.WriteLine("Digite o 1º número que deseja realizar a multiplicação:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número que deseja realizar a multiplicação:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo = num1 * num2;
                    Console.WriteLine(nome + ", o resultado da multiplicação de: " + num1 + " x " + num2 + " = " + calculo);
                    break;

                    case 4:
                    Console.WriteLine("Digite o 1º número, que corresponde ao dividendo:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número, que corresponde ao divisor:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo2 = num1 / num2;
                    Console.WriteLine(nome + ", o resultado da divisão de:" + num1 + " / " + num2 + " = " + calculo2);
                    break;

                    case 5:
                    Console.WriteLine("Digite o 1º número, que é a base da potenciaçâo:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número, que é o expoente:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo = num1 - num2;
                    Console.WriteLine(nome + ", a potência de " + num1 + " - " + num2 + " = " + calculo);
                    break;

                    case 6:
                    Console.WriteLine("Digite o 1º número, que representa a porcentagem que você deseja aplicar (sem colocar o simbolo de porcentagem [%]):");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número, que aplicar a porcentagem digitada acima:");
                    num2 = int.Parse(Console.ReadLine());
                    calculo2 = (num2 * num1) / 100;
                    Console.WriteLine(nome + ", " + num1 + "% de " + num2 + " = " + calculo2);
                    break;
                }
                
                Console.WriteLine("Deseja continuar? (S) Sim ou (N) Não");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's' || continuar == 'S');       
        
        Console.WriteLine(nome + ", muito obrigado por ter participado do nosso projeto!");
        Console.WriteLine("Tenha um bom dia!");
        Console.WriteLine("By DeKovsky!");   
        }
    }
}
