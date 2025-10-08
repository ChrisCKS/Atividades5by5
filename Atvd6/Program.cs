float Produto, Total;
int FormaPagamento;

Console.WriteLine("Digite o valor do produto: ");
Produto = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a forma de pagamento: ");
Console.WriteLine("1 - À vista(10% de desconto)");
Console.WriteLine("2 - Parcelado(Sem desconto)");

FormaPagamento = int.Parse(Console.ReadLine());
if (FormaPagamento == 1)
{
    Total = Produto - (Produto * 0.10f);
    Console.WriteLine($"O valor total a ser pago é: R$ {Total}");
}
else if (FormaPagamento == 2)
{
    Total = Produto;
    Console.WriteLine($"O valor total a ser pago é: R$ {Total}");
}
else
{
    Console.WriteLine("Forma de pagamento inválida.");
}

