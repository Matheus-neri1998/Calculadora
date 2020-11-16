using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual a operação deseja realizar? \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine().ToLower();

            // Pedir o primeiro número
            Console.WriteLine("Digite o primeiro número :");
            float num1 =  float.Parse( Console.ReadLine() );

            //  Pedir o segundo número
            Console.WriteLine("Digite o segundo número :");
            float num2 =  float.Parse( Console.ReadLine() );

            // Fazer o cálculo
            float resultado = 0;

            // if(operacao == "Soma")
            // {
            //     resultado = num1 + num2;

            // }
            // else if(operacao == "Subtracao" || operacao == "subtracao" ) 
            // {
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicacao"){
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }
            // else
            // {
            //     Console.WriteLine("Operação inválida");
            // }

            switch(operacao){

                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                    resultado = num1 - num2;
                    break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    break;

                case "divisao":
                    resultado = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Operação inválida! :( ");
                    break;

            }

            // Mostrar o resultado

            // Concatenção
            // Console.WriteLine("Calculo : "+ num1+" com "+ num2+" = "+ resultado);

            // Interpolação
            Console.WriteLine($"Calculo : {num1} com {num2} = {resultado} ");



        }
    }
}
