float N1, N2;

Console.WriteLine("Digite o primeiro número: ");
N1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: "); 
N2 = float.Parse(Console.ReadLine());
if (N1 > N2) {
    Console.WriteLine("O primeiro número é maior.");
}
else if (N2 > N1)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}