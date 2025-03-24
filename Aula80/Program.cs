using System.Windows.Markup;
using System.Globalization;
using System.Collections.Generic;



//List<int> diagonalPrincipal = new List<int>();


Console.Write("Digite a ordem da matriz:");
int ordemMatriz = int.Parse(Console.ReadLine());

int count = 0;
int[,] matriz = new int[ordemMatriz,ordemMatriz];


for (int i = 0; i < ordemMatriz; i++)
{

    string[] numeros = Console.ReadLine().Split(' ');


    for( int j = 0; j < ordemMatriz; j++)
    {
        matriz[i,j] = int.Parse(numeros[j]);
        //if (i == j)
        //    diagonalPrincipal.Add(int.Parse(numeros[j]));
    }

}

Console.WriteLine("Main diagonal: ");
for (int i = 0; i  < ordemMatriz; i++)
{
    Console.Write(matriz[i,i] + " ");
}
Console.WriteLine();


Console.WriteLine("Secundary diagonal: ");
for (int i = 0; i < ordemMatriz; i++)
{
    Console.Write(matriz[i, ordemMatriz - 1 -i] + " ");
}

//foreach (int item in diagonalPrincipal) {
//    Console.Write( item + " ");
//}

Console.WriteLine();


for  (int i = 0;i < ordemMatriz; i++)
{
    for (int j = 0; j < ordemMatriz; j++)
    {
        if (matriz[i, j] < 0 )
        {
           count++;

        }
            
    }
}
Console.WriteLine("Negative numbers = " + count);

Console.ReadLine();