using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafare_folhadepagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando lista e mandando o numero de funcionarios
            List<Funcionario>
            list = new List<Funcionario>();
            Console.WriteLine("Entre com o número de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //características dos funcionarios
                Console.WriteLine($"Funcionario#{i}: ");
                Console.Write("Tercerizado (S/N): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valorh = double.Parse(Console.ReadLine());
                //informação do tercerizado
                if (ch == 'S')
                {
                    Console.WriteLine("Adicional Despesas: ");
                    double adicional = double.Parse(Console.ReadLine());
                    list.Add(new Tercerizado(nome, horas, valorh, adicional));
                }
                //Mandando a lista do funcionario normal
                if (ch == 'N')
                {
                    list.Add(new Normal(nome, horas, valorh));
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine();
            //pagamento de todos os funcionarios
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario forma in list)
            {
                Console.WriteLine(forma.Nome + " - " + forma.Salario().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
