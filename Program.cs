using System;

namespace Média_do_aluno
{
    class Program
    {
        public static double captura()
        {
            double nt1, nt2, nt3, menor;
            double media;

            Console.Write("Nota 1: ");
            nt1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota 2: ");
            nt2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota 3: ");
            nt3 = Convert.ToInt32(Console.ReadLine());

            menor = nt1;

            if (nt2 < menor)
                menor = nt2;
            if (nt3 < menor)
                menor = nt3;

            media = (nt1 + nt2 + nt3 - menor) / 2.0;
            Console.Write("Média do aluno: {0} \n\n", media.ToString());

            return media;
        }


        static void Main(string[] args)
        {
            double media_aluno, x;

            media_aluno = Program.captura();

            if (media_aluno >= 6)
            {
                Console.Write("Aprovado!");
            }

            else
            {
                Console.Write("Reprovado!");
            }

        }
    }
}
  
