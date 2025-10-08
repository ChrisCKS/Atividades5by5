
float N1, N2, N3, Media;

Console.WriteLine("Digite a primeira nota: ");
N1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
N2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
N3 = float.Parse(Console.ReadLine());

Media = (N1 + N2 + N3) / 3;

if (Media >= 7) {
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

Console.WriteLine("Pressione qualquer tecla");