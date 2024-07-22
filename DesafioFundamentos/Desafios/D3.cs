namespace DesafioFundamentos.Desafios;

public class D3
{
    public static void Desafio()
    {
        string? input1;
        string? input2;
        double value1 = 0;
        double value2 = 0;
        bool aux = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite um número aleatório: ");
            input1 = Console.ReadLine();

            if (Double.TryParse(input1, out double value))
            {
                Console.Clear();
                Console.WriteLine("O primeiro número é: " + value);
                aux = true;
                value1 = value;
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite um número válido.");
                Console.ReadKey();
            }
        } while (!aux);

        aux = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite um segundo número aleatório: ");
            input2 = Console.ReadLine();

            if (Double.TryParse(input2, out double value))
            {
                Console.Clear();
                Console.WriteLine("O segundo número é: " + value);
                aux = true;
                value2 = value;
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite um número válido.");
                Console.ReadKey();
            }
        } while (!aux);

        Console.Clear() ;

        Console.WriteLine($"Soma dos valores: {value1 + value2}");
        Console.WriteLine($"Subtração dos valores: {value1 - value2}");
        Console.WriteLine($"Multiplicação dos valores: {value1 * value2}");
        if (value2 != 0)
            Console.WriteLine($"Divisão dos valores: {value1 / value2}");
        else
            Console.WriteLine("Impossível divisão por 0");
        Console.WriteLine($"Média dos valores: {(value1 + value2) / 2}");

    }
}
