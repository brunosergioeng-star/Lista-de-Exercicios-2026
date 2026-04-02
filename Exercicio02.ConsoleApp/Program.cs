/*2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
O programa deve solicitar ao usuário:
a. A quilometragem inicial do veículo no início da viagem.
b. A quilometragem final ao término da viagem.
c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.WriteLine("Digite a quilometragem informada no painel do veiculo, no incio da viagem");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quilometragem informada no painel do veiculo, no final da viagem");
double kmFinal = Convert.ToDouble(Console.ReadLine());

double deslocamento = kmInicial - kmFinal;

Console.WriteLine("A distância percorrida durante a viagem foi: " + deslocamento);

Console.WriteLine("Informe o volume do tanque ou quantos litros foram abastecidos");
double tanque = Convert.ToDouble(Console.ReadLine());

double consumoMedio = deslocamento / tanque;

Console.WriteLine($"O consumo médio na viagem foi: {consumoMedio} Km/L");
Console.ReadLine();