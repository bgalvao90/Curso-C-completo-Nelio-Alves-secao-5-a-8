internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Digite o número de linhas e colunas da matriz: ");
        string[] line = Console.ReadLine().Split(' ');
        
        int m = int.Parse(line[0]);
        int n = int.Parse(line[1]);

        int[,] matriz = new int[m, n];

        Console.WriteLine("Digite os números da coluna:");
        for (int i = 0; i < m; i++)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(numeros[j]);
            }
        }

        Console.Write("Digite um número que contem na matriz:");
        int x = int.Parse(Console.ReadLine());


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] == x)
                {
                    Console.WriteLine($"Posição = {i + 1} , {j + 1} : ");
                    if (j > 0)
                    {
                        Console.WriteLine("Número a esquerda: " + matriz[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Número a acima: " + matriz[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Número a direita: " + matriz[i, j + 1]);
                    }
                    if (i < n - 1)
                    {
                        Console.WriteLine("Número a abaixo: " + matriz[i + 1, j]);
                    }
                }
            }
        }
    }
}
