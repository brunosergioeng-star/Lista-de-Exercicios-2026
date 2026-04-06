/*6. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
*/

Console.WriteLine("Digite o valor para A");
Double valorA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor para B");
Double valorB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor para C");
Double valorC = Convert.ToDouble(Console.ReadLine());

Double soma = valorA + valorB;

if (valorA + valorB < 1 valorC)
{
    Console.WriteLine("A soma de A + B é menor que C: " + soma);
}
else
{
    Console.WriteLine("A soma de A + B não é menor que C!");
}

Console.ReadLine();
