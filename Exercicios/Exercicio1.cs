// Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida

namespace ExerciciosBasicos.Exercicios;

public class Exercicio1
{
    public static void Executar()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine() ?? "";
        string mensagemBoasVindas = $"Bem-vindo(a), {nome}!";
        Console.WriteLine(mensagemBoasVindas);
    }
    
}