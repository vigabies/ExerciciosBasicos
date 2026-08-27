
/*1.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.*/

namespace ExerciciosBasicos.Exercicios;

public static class Exercicio6
{
    public static void Executar()
    {
        DateTime dataAtual = DateTime.Now; //DataTime é uma estrutura de dados que representa uma data e hora. A propriedade Now retorna a data e hora atual do sistema.
        // Formato completo
        string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"); //ToString é um método que converte o valor de um objeto em uma representação de string.
        Console.WriteLine($"Formato completo: {formatoCompleto}");
        // Apenas a data no formato "01/03/2024"
        string apenasData = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine($"Apenas a data: {apenasData}");
        // Apenas a hora no formato de 24 horas
        string apenasHora = dataAtual.ToString("HH:mm:ss");
        Console.WriteLine($"Apenas a hora: {apenasHora}");
        // A data com o mês por extenso
        string mesPorExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine($"Data com o mês por extenso: {mesPorExtenso}");
    }
}