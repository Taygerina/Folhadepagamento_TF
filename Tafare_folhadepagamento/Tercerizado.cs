using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafare_folhadepagamento
{
    class Tercerizado : Funcionario
    {
        //Variaveis
        public double Adicional { get; set; }

        public Tercerizado(string nome, int horas, double valorh, double adicional) : base(nome, horas, valorh)
        {
            Nome = nome;
            Horas = horas;
            ValorH = valorh;
            Adicional = adicional;
        }
        //Função do calculo do pagamento tercerizado
        public override double Salario()
        {
            Adicional = Adicional * 110 / 100;
            return Horas * ValorH + Adicional;
        }
    }
}
