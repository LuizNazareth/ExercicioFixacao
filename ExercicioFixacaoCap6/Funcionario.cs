using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoCap6
{
    class Funcionario
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Funcionario(string id, string nome, double salario) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void aumentoSalarial(double x)
        {
            this.Salario += this.Salario * x/100;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + ", nome: " + this.Nome + ", salario" + this.Salario;
        }
    }
}
