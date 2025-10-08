//Cálculo do tipo de triângulo com base nos lados fornecidos pelo usuário

float Lado1, Lado2, Lado3;

Console.WriteLine("Digite o valor do primeiro lado do triângulo: ");
Lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado do triângulo: ");
Lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do terceiro lado do triângulo: ");
Lado3 = float.Parse(Console.ReadLine());

if (Lado1 < (Lado2 + Lado3) && Lado2 < (Lado1 + Lado3) && Lado3 < (Lado1 + Lado2))
{
    if (Lado1 == Lado2 && Lado2 == Lado3)
    {
        Console.WriteLine("O triângulo é equilátero.");
    }
    else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
    {
        Console.WriteLine("O triângulo é isósceles.");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno.");
    }
}
else
{
    Console.WriteLine("Os valores não formam um triângulo.");
}