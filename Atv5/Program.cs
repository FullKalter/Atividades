/*5. Escreva um programa que lê o tamanho do lado de um quadrado e imprime um quadrado daquele tamanho com asteriscos. 
* Seu programa deve usar laços de repetição e funcionar para quadrados com lados de todos os tamanhos entre 1 e 20.
*Por exemplo, para lado igual a 5:
            * * * * *
            * * * * *
            * * * * *
            * * * * *
            * * * * *
*/
using System.Text;

int T = 21;
while (T > 20 || T < 1)
{
    Console.WriteLine("Digite o Tamanhodo quadrado (entre 1 e 20):");
    T = int.Parse(Console.ReadLine());
}

if (T < 1 || T > 20)
{
    Console.WriteLine("\nTamanho inválido.O Tamanho deve estar entre 1 e 20");
    return;
}

for (int i = 0; i < T; i++)
{
    for (int j = 0; j < T; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
/*
using System.Text;

int T = 21;
while (T > 20 || T < 1)
{
    Console.WriteLine("Digite o Tamanhodo quadrado (entre 1 e 20):");
    T = int.Parse(Console.ReadLine());
}

StringBuilder linha = new StringBuilder();
StringBuilder quadrado = new StringBuilder();

for (int i = 1;i < T; i++)
{
    linha.Append("* ");
}

for(int i = 1;i < T; i++)
{
    quadrado.AppendLine(linha.ToString());
}

Console.WriteLine(quadrado);
*/
