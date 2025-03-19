using Aula60;
using System.Globalization;
ContaBancaria conta = new ContaBancaria();

Console.Write("Digite o número da conta: ");
conta.NumeroConta = Console.ReadLine().ToUpper();
Console.Write("Digite o nome do titular: ");
conta.Titular = Console.ReadLine().ToUpper();
Console.Write("Haverá depósito inicial (s/n)? ");
string DepInicial = Console.ReadLine().ToUpper();

if(DepInicial == "S") {
    Console.Write("Entre o valor de depósito inicial: ");
double valor = double.Parse(Console.ReadLine());
conta.Depositar(valor);
}
else
    conta.Saldo = 0;

Console.WriteLine("Dados da conta:");
Console.Write(conta);
conta.ExibirSaldo();




    //if (opcao == "DEPOSITAR")
    //{
    //    Console.Clear();
    //    Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
    //    Console.WriteLine("Digite o valor a ser depositado: ");
    //    double valor = double.Parse(Console.ReadLine());
    //    conta.Depositar(valor);
    //    Console.Clear();
    //    Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
    //    Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
    //    opcao = Console.ReadLine().ToUpper();

    //}
    //else if (opcao == "SACAR")
    //{
    //    Console.Clear();
    //    Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
    //    Console.WriteLine("Digite o valor a ser sacado: ");
    //    double valor = double.Parse(Console.ReadLine());
    //    conta.Sacar(valor);
    //    Console.Clear();
    //    Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
    //    Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
    //    opcao = Console.ReadLine().ToUpper();
    //}
    //else if (opcao == "EXIBIR SALDO")
    //{
    //    Console.Clear();
    //    Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
    //    conta.ExibirSaldo();
    //    Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
    //    opcao = Console.ReadLine().ToUpper();
    //}
    //else if (opcao == "SAIR")
    //{
    //    Console.WriteLine("Obrigado por utilizar nossos serviços");
    //}
    //else
    //{
    //    Console.WriteLine("Opção inválida");
    //    Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
    //    opcao = Console.ReadLine().ToUpper();
    //}

