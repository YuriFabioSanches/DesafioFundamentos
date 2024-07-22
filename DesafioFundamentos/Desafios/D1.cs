namespace DesafioFundamentos.Desafios;

public class D1
{
    public static void Desafio()
    {
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();

        if (nome is null || nome == "")
            nome = "Usuário";

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
    }
}
