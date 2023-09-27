/* 4.Faça um programa que leia um valor n, inteiro e positivo, calcule e mostre a seguinte soma:
 * S = 1 + 1/2 + 1/3 + 1/4 + … +1/n.
 */
int numero = -1;
decimal soma = 1;

while (numero < 0)
{
    Console.WriteLine("Digite um Número inteiro e positivo");
    numero = Convert.ToInt32(Console.ReadLine());
}

for (int i = 2;i <= numero; i++)
{
    soma += 1.0m / Convert.ToDecimal(i);
}

Console.WriteLine($"O Resultado da Soma é: {soma}");

