using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafare_folhadepagamento
{
    class Normal : Funcionario
    {
        //Variaveis
        public Normal(string nome, int horas, double valorh)
        {
            Nome = nome;
            Horas = horas;
            ValorH = valorh;
        }
        //Função do calculo dos funcionarios normais
        public override double Salario()
        {
            return Horas * ValorH;
        }
    }
}
