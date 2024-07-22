namespace DesafioFundamentos.Desafios;

public class D4
{
    public static void Desafio()
    {
        Console.WriteLine("Digite uma ou mais palavras para saber o número de caracteres: ");
        string? text = Console.ReadLine();
        int count = 0;

        if(text.Count() == 0)
            Console.WriteLine("Sua palavra possui 0 caracteres");
        else
        {
            for (int i = 0; i < text.Count(); i++)
            {
                if (text[i] != ' ')
                    count++;
            }
            Console.WriteLine($"Sua palavra possui {count} caracter(es)");
        }
    }
}
