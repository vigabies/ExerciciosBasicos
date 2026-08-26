// Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

namespace ExerciciosBasicos.Exercicios;

public class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("Digite seu primeiro nome:");

        string nome = Console.ReadLine() ?? "";

        Console.WriteLine("Digite seu sobrenome:");

        string sobrenome = Console.ReadLine() ?? "";

        string nomeCompleto = nome + " " + sobrenome;

        Console.WriteLine("Nome completo: " + nomeCompleto);
    }
}