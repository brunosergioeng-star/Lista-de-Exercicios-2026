/*
5. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
*/

Console.WriteLine("Digite o  peso primeira nota: ");
Double pesoPrimeiraNota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da primeira nota: ");
Double primeiraNota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da segunda nota: ");
Double pesoSegundaNota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor da segunda nota: ");
Double SegundaNota = Convert.ToDouble(Console.ReadLine());

Double Media = (pesoPrimeiraNota * primeiraNota) + (pesoSegundaNota * SegundaNota) / (primeiraNota + SegundaNota);
Console.WriteLine($"A média ponderada do aluno é: {Media}");

Console.ReadLine();