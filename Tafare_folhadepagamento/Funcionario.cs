using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafare_folhadepagamento
{
    abstract class Funcionario
    {
        //Variaveis
        public String Nome { get; set; }
        public int Horas { get; set; }
        public double ValorH { get; set; }

        public Funcionario(string nome, int horas, double valorh)
        {
            Nome = nome;
            Horas = horas;
            ValorH = valorh;
        }

        //Função do salario.
        public abstract double Salario();
    }
}
