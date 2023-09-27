/*3.Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de Renda, que depende do salário 
 * bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do salário bruto, mas não é descontado (é a empresa 
 * que deposita.)
O salário líquido corresponde ao salário bruto menos os descontos O programa deverá pedir ao usuário o valor da sua hora e a quantidade de 
horas trabalhadas no mês.

a. Desconto do IR;
b.Salário Bruto ate R$900,00 (inclusive) – Isento;
c.Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
d.Salario bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
e.Salário bruto acima de 2500 – Desconto de 20%. 
Imprima na tela as informações, dispostas conforme o exemplo abaixo, no exemplo valor da hora é 5 e a quantidade de horas é 220.  
 
Salário bruto (5 * 220): R$ 1100,00 
( – ) IR(5 %): R$ 55,00 
( – ) Sindicato(3 % ): R$ 33,00
FGTS ( 11%): R$ 121,00
Total de descontos : R$ 165,00 
Salário Líquido: R$ 1.012,00
*/
int quantidadeHoras;
decimal salarioBruto, impostoRenda = 0, sindicato, fgts, totalDesconto,
    salarioLiquido, valorHora;
string percentualIR;

Console.WriteLine("Digite o valor da Hora:");
valorHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a Quantidade de Horas Trabaladas:");
quantidadeHoras = Convert.ToInt32(Console.ReadLine());

salarioBruto = valorHora * quantidadeHoras;

if (salarioBruto <= 900)
{
    impostoRenda = 0;
    percentualIR = "0 %";
}
else if (salarioBruto <= 1500)
{
    impostoRenda = salarioBruto * 0.05m;
    percentualIR = "5 %";
}
else if (salarioBruto <= 2500)
{
    impostoRenda = salarioBruto * 0.1m;
    percentualIR = "10 %";
}
else
{
    impostoRenda = salarioBruto * 0.2m;
    percentualIR = "20 %";
}

sindicato = salarioBruto * 0.03m;

fgts = salarioBruto * 0.11m;

totalDesconto = impostoRenda + sindicato;
salarioLiquido = salarioBruto - totalDesconto;


Console.WriteLine($"Salário bruto ({quantidadeHoras} * R$ {valorHora}) \t\t\t " + 
    $": R$ {salarioBruto}");
Console.WriteLine($"( - ) IR ({percentualIR}) \t\t\t\t\t : R$ {impostoRenda}");
Console.WriteLine($"( - ) Sindicato(3 %)  \t\t\t\t : R$ {sindicato}");
Console.WriteLine($"FGTS (11 %)  \t\t\t\t\t : R$ {fgts}");
Console.WriteLine($"Total de Descontos \t\t\t\t : R$ {totalDesconto}");
Console.WriteLine($"Salário Líquido \t\t\t\t : R$ {salarioLiquido}");
