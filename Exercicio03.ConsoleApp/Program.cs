// 3. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.WriteLine("Digite o valor da temperatura em graus Celcius: ");
double Celcius = Convert.ToDouble(Console.ReadLine());

double conversao = Celcius * 1.8 + 32;
Console.WriteLine($"A temperatura convertida para Fahrenheit é: {conversao}");
Console.ReadLine();
