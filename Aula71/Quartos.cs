using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71
{
    class Quartos
    {
        public string Nome {  get;  set; }
        public string Email {  get;  set; }
        public int Quarto { get;  set; }



        public void ExibirDetalhes()
        {
            Console.Write($"{Quarto}: {Nome}, {Email}");
        }


    }
}
