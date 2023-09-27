/*
 *6.Faça um programa que receba o valor de um carro e mostre uma tabela com os seguintes dados: preço final,
quantidade de parcelas e valor da parcela. Considere o seguinte: 
O preço final para compra à vista tem um desconto de 20%;
A quantidades de parcelas pode ser: 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60. 
Os percentuais de acréscimo seguem a tabela a seguir.  

Quantidade de Parcelas => Percentual de acréscimo sobre o preço final
6 => 3%
12 => 6%
18 => 9%
24 => 12%
30 => 15%
36 => 18%
42 => 21%
48 => 24%
54 => 27%
60 => 30%
*/
using System.Text;

decimal valorCarro, valorFinal;
int quantidadeParcelas;

Console.WriteLine("Digite o Valor do carro: ");
valorCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parcelas: \n" +
    "Quantidade disponiveis: 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60.");
quantidadeParcelas = Convert.ToInt32(Console.ReadLine());

if(quantidadeParcelas == 1)
{
    valorFinal = valorCarro - (valorCarro * 0.2m);
}
else
{
    decimal percentualAcrescimo = (quantidadeParcelas / 2.0m) / 100.0m;
    valorFinal = valorCarro + (valorCarro * percentualAcrescimo);
}

StringBuilder sb = new StringBuilder();
sb.AppendLine($"O preço final do veiculo: R$ {valorFinal}");
sb.AppendLine($"A quantidade de parcelas escolhidas foi: {quantidadeParcelas}");
sb.AppendLine($"O valor da parcela é: R$ {(valorFinal / quantidadeParcelas)}");

Console.WriteLine(sb.ToString());
