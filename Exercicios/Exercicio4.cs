//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

namespace ExerciciosBasicos.Exercicios;

public class Exercicio4
{
    public static void Executar()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string input = Console.ReadLine() ?? ""; //o ?? signfica que se o usuário não digitar nada, será considerado uma string vazia.
        int quantidadeCaracteres = input.Length;
        Console.WriteLine($"A quantidade de caracteres inseridos é: {quantidadeCaracteres}");
    }
}
