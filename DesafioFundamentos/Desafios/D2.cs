namespace DesafioFundamentos.Desafios;

public class D2
{
    public static void Desafio()
    {
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        if (nome is null || nome == "")
        {
            nome = "Usuário Desconhecido";
            Console.WriteLine(nome);
            return;
        }

        Console.WriteLine("Digite seu sobrenome: ");
        string? sobrenome = Console.ReadLine();

        Console.WriteLine(nome + " " + sobrenome);
    }
}
