/*2.Faça um programa que leia três números e mostre-os em ordem decrescente.  
 * (Não utilize estrutura de repetição)
 */
Console.WriteLine("Digite o 1° Número: ");
decimal n1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o 2° Número: ");
decimal n2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o 3° Número: ");
decimal n3 = Convert.ToDecimal(Console.ReadLine());

decimal altoValor = 0, medioValor = 0, baixoValor = 0;
/*{Comparação de Alto Valor}*/
if (n1 > n2 && n1 > n3)
{
    altoValor = n1;
}
else if (n2 > n1 && n2 > n3)
{
    altoValor = n2;
}
else if (n3 > n1 && n3 > n2)
{
    altoValor = n3;
}
/*{Comparação de Médio Valor}*/
if(n1 > baixoValor && n1 < altoValor)
{
    medioValor = n1;
}
else if(n2 > baixoValor && n2 < altoValor)
{
    medioValor = n2;
}
else if(n3 > baixoValor && n3 < altoValor)
{
    medioValor = n3;
}
/*{Comparação de Baixo Valor}*/
if (n1 < n2 && n1 < n3)
{
    baixoValor = n1;
}
else if (n2 < n1 && n2 < n3)
{
    baixoValor = n2;
}
else if (n3 < n1 && n3 < n2)
{
    baixoValor = n3;
}
if (n1 == n2 && n2 == n3)
{
    Console.WriteLine("Não existe valores para serem comparados, ambos são iguais");
    return;
}

Console.WriteLine("\n     " + "[" + altoValor + "]" +
                  "\n     " + "[" + medioValor + "]" +
                  "\n     " + "[" + baixoValor + "]");

