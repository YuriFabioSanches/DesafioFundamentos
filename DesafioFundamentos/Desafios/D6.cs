namespace DesafioFundamentos.Desafios;

public class D6
{
    public static void Desafio()
    {
        DateTime date = DateTime.Now;

        Console.WriteLine(date.ToString("dddd dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("HH:mm"));
        Console.WriteLine(date.ToString("dd/MMMM/yyyy"));
    }
}
