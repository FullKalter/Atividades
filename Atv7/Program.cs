/*
7.Faça um programa para calcular n! (Fatorial de n), sendo que o valor inteiro de n é fornecido pelo usuário. Sabe-se que: 

N! = 1 * 2 * 3 * … (n – 1) *n

0! = 1, por definição;
*/
int n,fatorial = 1;
Console.WriteLine("Digite o valor de N:");
n = Convert.ToInt32(Console.ReadLine());

if(n != 0)
{
    for(int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }
}

Console.WriteLine("Resultado fatorial: " + fatorial);
