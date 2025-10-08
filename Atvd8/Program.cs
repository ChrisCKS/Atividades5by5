//Cálculo de média ponderada com notas e pesos fornecidos pelo usuário

float Nota1, Nota2, Nota3, Media;
int Peso1, Peso2, Peso3, SomaPesos;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
Peso1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
Nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda nota: ");
Peso2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
Nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da terceira nota: ");
Peso3 = int.Parse(Console.ReadLine());

SomaPesos = Peso1 + Peso2 + Peso3;

Media = (Nota1 * Peso1 + Nota2 * Peso2 + Nota3 * Peso3) / SomaPesos;
Console.WriteLine($"A média ponderada é: {Media}");

if (Media >= 9)
{
    Console.WriteLine("Nota A");
}
else if (Media >= 7 && Media <9)
{
    Console.WriteLine("Nota B");
}
else if(Media >= 5 && Media <7)
{
    Console.WriteLine("Nota C");
}

else
{
    Console.WriteLine("Reprovado");
}

