
#region Exercício_1
/*

float quantMin;
float quantMax;
float quantMedia;

Console.WriteLine("Calcula Estoque Médio\n\nDigite a quantidade mínima de estoque:  ");
while (!float.TryParse(Console.ReadLine(), out quantMin)) 
{
    Console.WriteLine("Digite um número válido:");
}

Console.WriteLine("\nDigite a quantidade máxima de estoque:  ");
while (!float.TryParse(Console.ReadLine(), out quantMax))
{
    Console.WriteLine("Digite um número válido:");
}

quantMedia = (quantMin + quantMax)/2;

Console.WriteLine("\nA quantidade média de estoque é: " + quantMedia);
*/
#endregion

#region Exercício_2
float cotacaoDolar, valorDolar, valorReal;

Console.WriteLine("Conversor de Dólar para Real\nComo está a cotação do Dólar hoje? (Em Reais. Utilize vírgulas para separar as casas decimais)");
while (!float.TryParse(Console.ReadLine(), out cotacaoDolar)) 
    {
    Console.WriteLine("Digite um valor válido:\n");
    }
Console.WriteLine("\nDigite um valor em Dólares: ");
while (!float.TryParse(Console.ReadLine(), out valorDolar)) 
    {
    Console.WriteLine("\nDigite um valor válido:\n");
    }

valorReal = valorDolar * cotacaoDolar;

Console.WriteLine($"\n{valorDolar} Dólares é igual à {valorReal:F2} Reais");
#endregion