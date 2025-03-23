using Aula71;

Console.Write("How many room will be rented? ");
int n = int.Parse(Console.ReadLine());
Quartos[] vetor = new Quartos[10];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Rent " + (i + 1));
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int quarto = int.Parse(Console.ReadLine());

    vetor[quarto] = new Quartos { Nome = nome, Email = email, Quarto = quarto };
    Console.WriteLine();
}

Console.WriteLine("Busy rooms:");
for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] != null)
    {
        vetor[i].ExibirDetalhes();
        Console.WriteLine();
    }
}
