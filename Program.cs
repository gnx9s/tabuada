Console.WriteLine("-- Tabuada --");

Console.Write("Digite um número para calcular a tabuada (Inclui valores negativos)... ");
    int numero = int.Parse(Console.ReadLine()!);

Console.Write("Você quer multiplicar esse valor por números positivos ou negativos? (responda com P ou N) ");
bool resposta = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "P";

if (resposta)
    {
        Console.WriteLine($"Tabuada do {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
    
    else
    {
        Console.WriteLine($"Tabuada negativa do {numero}:");

        for (int multiplicador = -1; multiplicador >= -10; multiplicador--)
        {
            int resultado = numero * multiplicador;
            Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
        }
    }

Console.WriteLine();
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

