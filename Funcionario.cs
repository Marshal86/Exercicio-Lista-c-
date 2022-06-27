using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exlist
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double _salario { get;  private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            _salario = salario;
        }

        public void Salario (double porcentagem)
        {
            _salario =_salario + _salario * porcentagem / 100.0;

        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + _salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
