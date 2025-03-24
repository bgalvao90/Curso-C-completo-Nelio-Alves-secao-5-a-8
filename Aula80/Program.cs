using System.Windows.Markup;
using System.Globalization;
using System.Collections.Generic;



List<int> diagonalPrincipal = new List<int>();

List<int> numerosNegativos = new List<int>();

Console.Write("Digite a ordem da matriz:");
int ordemMatriz = int.Parse(Console.ReadLine());


int[,] matriz = new int[ordemMatriz,ordemMatriz];


for (int i = 0; i < ordemMatriz; i++)
{

    string[] numeros = Console.ReadLine().Split(' ');


    for( int j = 0; j < ordemMatriz; j++)
    {
        matriz[i,j] = int.Parse(numeros[j]);
        if (i == j)
            diagonalPrincipal.Add(int.Parse(numeros[j]));
        if (j < 0)
            numerosNegativos.Add(int.Parse(numeros[j]));
    }

}
Console.WriteLine("Diagonal Principal: ");

foreach (int item in diagonalPrincipal) {
    Console.WriteLine( item + " ");
}
Console.Write("Negative numbers = ");
foreach (int negative in numerosNegativos)
{
    Console.WriteLine( negative + " ");
}