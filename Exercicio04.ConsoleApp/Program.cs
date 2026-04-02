/*4. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
base e o total de vendas. A comissão é calculada com um percentual (informado pelo
usuário) sobre o total de vendas.
*/

Console.WriteLine("Informe o valor do salario: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da comissao: ");
double comissao = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a porcentagem para comições: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());
double comissaoPorcentagem = comissao * (porcentagem / 100);

double salarioComissao = salario + comissaoPorcentagem;
Console.WriteLine($"O valor do salario mensal com comissão é: {salarioComissao}");
Console.ReadLine();
