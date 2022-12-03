using System.Globalization;

namespace CursoUdemy
{

    internal class Program
    {

        static void Main(String[] args)
        {

            int idFunc = 0;
            bool idExiste;
            Funcionarios func;

            List<Funcionarios> listaFunc = new List<Funcionarios>();

            Console.Write("Quantos funcionarios serao registrados: ");
            int qtdFuncs = int.Parse(Console.ReadLine());


            for (int c = 1; c <= qtdFuncs; c++)
            {
                idExiste = false;

                Console.WriteLine("\nFuncionario #" + c);
                while (!idExiste)
                {
                    Console.Write("Id: ");

                    try
                    {
                        idFunc = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Esperava um número e não texto");
                    }

                    func = listaFunc.Find(f => f.ID == idFunc);
                    if (func == null)
                    {
                        idExiste = true;
                    }
                    else
                    {
                        idExiste = false;
                        Console.WriteLine("Id de funcionário já existe, informe outro");
                    }

                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFunc.Add(new Funcionarios(idFunc, nome, salario));

            }


            Console.Write("\n\nInforme o ID do funcionario que tera aumento de salário: ");
            idFunc = int.Parse(Console.ReadLine());


            func = listaFunc.Find(f => f.ID == idFunc);
            if (func != null)
            {
                Console.Write("\nInforma a porcentagem de aumento: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.AumentarSalario(perc);
            } else
            {
                Console.WriteLine("Funcionario não encontrado!");
            }

            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach(Funcionarios f in listaFunc)
            {
                Console.WriteLine(f.ToString());
            }

        }

    }

}
