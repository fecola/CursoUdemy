using System.Globalization;

namespace CursoUdemy
{

    internal class Program
    {

        static void Main(String[] args)
        {


            Funcionarios func;
            int idFunc;
            bool idExiste = false;

            List<Funcionarios> listaFunc = new List<Funcionarios>();

            Console.Write("Quantos funcionarios serao registrados: ");
            int qtdFuncs = int.Parse(Console.ReadLine());


            for (int c = 1; c <= qtdFuncs; c++)
            {
                Console.WriteLine("\nFuncionario #" + c);

                while (!idExiste)
                {
                    Console.Write("Id: ");
                    idFunc = int.Parse(Console.ReadLine());

                    idExiste = listaFunc.Find(func => func.ID == idFunc);
                }
                

            }


        }

    }

}
