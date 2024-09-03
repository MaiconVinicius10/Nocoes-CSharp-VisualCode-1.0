// usando biblioteca do sistema
using System;
//namespace pra organizar
namespace Aula02
{//classe
    class Program
    {//criando metodo menu
        static void Main(string[] args)
        {   //exibir frase
            Console.WriteLine("Fala zé");
            //se maior que 0 - exiba um resultado
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            } //senão esta funcionando sem valor
            else
            {
                Console.Write("Está funcionando");
            }

        }
    }
}
