using System;

namespace NovoSaber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new Aluno();
            a.Nome = "Bill Gates";
            a.Telefone = "84 9999 9999";
            a.Matricula = "1234-1234";

            var p = new Professor();
            p.Nome = "Linus Torvalds";
            p.Telefone = "84 9090 0909";
            p.Email = "git@linux.org";

            var d = new Disciplina();
            d.Titulo = "Matematica";
            d.Professor = p;
            d.Aluno = a;

            var nu1  = new NotaUnidade();
            nu1.nt = 2;
            nu1.ntt = 5;
            nu1.np = 7;
            
            var nu2  = new NotaUnidade();
            nu2.nt = 8.1f;
            nu2.ntt = 5.5f;
            nu2.np = 7.4f;
            
            var av = new Avaliacao();
            av.nu1 = nu1;
            av.nu2 = nu2;

            var resultado = av.Resultado();
            Console.WriteLine(
                String.Format("O aluno {0} ficou com resultado \"{1}\" pois tirou nota {2} e nota {3} em suas respectivas unidades ficando com média {4}",
                    a,
                    resultado,
                    av.MediaPonderada(av.nu1),
                    av.MediaPonderada(av.nu2),
                    av.MediaAritimetica()
                )
            );
        }
    }
}
