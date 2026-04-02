// 1. Crie um programa para calcular o volume de uma caixa retangular



using System.Diagnostics;

Console.WriteLine("Digite um valor para o comprimeto da caixa: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um valor para o altura da caixa: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um valor para o largura da caixa: ");
double largura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * altura * largura;

Console.WriteLine($"O volume da caixa solicitada é: {volume:F2}");

Console.ReadLine();