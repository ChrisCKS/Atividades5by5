float peso, altura, imc;
Console.WriteLine("Digite seu peso (em kg): ");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura (em metros): ");
altura = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (imc < 18.5) {
    Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 && imc <=24.9)
{
    Console.WriteLine("Peso normal");
}
else if (imc >= 25 && imc <=29.9)
{
    Console.WriteLine("Sobrepeso");
}
else
{
    Console.WriteLine("Obesidade");
}