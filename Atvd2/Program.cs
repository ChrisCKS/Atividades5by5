int Number;

Console.WriteLine("Digite um número inteiro:");
Number = int.Parse(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}