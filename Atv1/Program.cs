/*1. Faça um programa que leia três números, verifique (usando if e else) e 
 * mostre o maior e o menor deles;  (Não utilize estrutura de repetição)
 */
Console.WriteLine("Digite o 1° Número: ");
decimal n1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o 2° Número: ");
decimal n2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o 3° Número: ");
decimal n3 = Convert.ToDecimal(Console.ReadLine());

decimal maior=0, menor=0;
/*{Comparação do Maior Número}*/
if (n1 > n2 && n1 > n3) 
{
maior = n1;
}
else if (n2 > n1 && n2> n3)
{
maior = n2;
}
else if(n3 > n1 && n3 > n2)
{
maior = n3;
}
/*{Comparaçãdo do Menor Número}*/
if (n1 < n2 && n1 < n3)
{
    menor = n1;
}
else if (n2 < n1 && n2 < n3)
{
    menor = n2;
}
else if (n3 < n1 && n3 < n2)
{
    menor = n3;
}
if (n1 == n2 && n2 == n3)
{
    Console.WriteLine("Não existe numero maior ou menor, ambos são iguais");
    return;
}

Console.WriteLine("O Maior Valor foi: " + maior);
Console.WriteLine("O Menor Valor foi: " + menor);

    
