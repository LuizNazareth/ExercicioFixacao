using System;
using System.Globalization;

namespace ExercicioFixacaoCap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Funcionarios?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            int i = 0;
            do
            {
                Console.WriteLine("Digite o id, nome e salario do funcionario: ");
                string ident = Console.ReadLine();
                string nome = Console.ReadLine();
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                i++;

                Funcionario f = new Funcionario(ident, nome, salario);

                list.Add(f);

            } while (i < n);

            Console.WriteLine("Qual o Id e o valor de aumento do funcionário?");

            string id = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());

            int j = 0;
            int k = 0;

            foreach(Funcionario f in list)
            {
                if(f.Id == id)
                {
                    int index = j;
                    k++;
                    list[index].aumentoSalarial(valor);
                }
                j++;
            }
            if(k == 0)
            {
                Console.WriteLine("Id não encontrado");
            }
            else
            {
                Console.WriteLine("Listagem atualizada dos funcionarios: ");
                foreach(Funcionario f in list)
                {
                    Console.WriteLine(f.ToString());
                }
            }
        }
    }
}
