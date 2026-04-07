/* 9. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo
de A! e o seu resultado.
a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
b. Pesquise sobre “fatorial”
*/

int A, fatorial = 1;

Console.WriteLine("Digite um valor para A:  ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write(A + "! = ");

for (int i = A; i >= 1; i--)
{
    Console.Write(i + " ");
    fatorial *= i;

    if (i > 1)
    {
        Console.WriteLine("X ");
    }
}

Console.Write("= " + fatorial);

Console.ReadLine();
