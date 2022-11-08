using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaKatia11
{
    internal class Vendedor : Funcionamento
    {
        public string Regiao { get; set; }

        public override string Name
        {

            get;
        }

        //public double Calcular(int comissao)
        //{
        //    return Salario * comissao / 100;
        //}
    }
}
