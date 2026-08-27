/*1.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    -A placa deve ter 7 caracteres alfanuméricos;
    -Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    -Os quatro últimos caracteres são números;

Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.*/

namespace ExerciciosBasicos.Exercicios;

public class Exercicio5
{
    public static void Executar()
    {
        Console.WriteLine("Digite a placa do veículo (formato ABC1234):");
        string placa = Console.ReadLine() ?? "";//significado que se o usuário não digitar nada, a variável placa recebe uma string vazia
        bool placaValida = ValidarPlaca(placa); //ValidarPlaca é um método que recebe uma string e retorna um booleano, true ou false, dependendo se a placa é válida ou não
        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso"); // ? é o operador ternário, que funciona como um if, se a condição for verdadeira, ele retorna o valor antes dos dois pontos, se for falsa, ele retorna o valor depois dos dois pontos
    }
    private static bool ValidarPlaca(string placa) // função que valida a placa, recebendo uma string e retornando um booleano
    {
        if (placa.Length != 7)
            return false;
        for (int i = 0; i < 3; i++) //significa que o loop vai de 0 até 2, ou seja, vai verificar os três primeiros caracteres da placa, o i++ significa que a cada iteração do loop, o valor de i é incrementado em 1
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }
        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }
        return true;
    }
}
