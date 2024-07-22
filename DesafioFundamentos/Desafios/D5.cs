namespace DesafioFundamentos.Desafios;

public class D5
{
    public static void Desafio()
    {
        Console.WriteLine(" ---- Verificação de placa de carro ----");
        Console.WriteLine("Digite sua placa: ");
        string? plate = Console.ReadLine();

        if (plate.Count() == 7)
        {
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(plate[i]))
                {
                    Console.WriteLine("Falso");
                    return;
                }
            }

            for (int i = 3; i < plate.Count(); i++)
            {
                if (!char.IsDigit(plate[i]))
                {
                    Console.WriteLine("Falso");
                    return;
                }
            }
            
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
}
