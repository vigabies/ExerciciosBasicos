/* 1. Crie um programa com 2 valores do tipo double já declarados que retorne:
    -A soma entre esses dois números;
    -A subtração entre os dois números;
    -A multiplicação entre os dois números;
    -A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    -A média entre os dois números. 
Você pode ir além e permitir que o usuário insira dois números aleatórios!*/


namespace ExerciciosBasicos.Exercicios;

public class Exercicio3()
{
    public static void Executar()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double multiplicacao = numero1 * numero2;
        double divisao = (numero2 != 0) ? numero1 / numero2 : 0;
        double media = (numero1 + numero2) / 2;
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        if (numero2 != 0)
            Console.WriteLine($"Divisão: {divisao}");
        else
            Console.WriteLine("Divisão: Não é possível dividir por zero.");
        Console.WriteLine($"Média: {media}");
    }
}