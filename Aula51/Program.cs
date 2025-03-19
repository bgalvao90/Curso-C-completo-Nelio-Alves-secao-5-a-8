using System;
using System.Globalization;
using Aula51;

Produto p = new Produto("TV", 500.00, 10);

p.Nome = Console.ReadLine();

Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);
Console.WriteLine(p.Quantidade);
