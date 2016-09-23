using System;

namespace NovoSaber
{
    public class Avaliacao
    {
        public int Id { get; set; }

        public NotaUnidade nu1 { get; set; }
        public NotaUnidade nu2 { get; set; }
        public Disciplina Disciplina { get; set; }

        public float MediaPonderada(NotaUnidade nu) {
            return ((nu.nt * 1) + (nu.ntt * 2) + (nu.np * 7)) / 10;
        }

        public float MediaAritimetica() {
            return (MediaPonderada(this.nu1) + MediaPonderada(this.nu2)) / 2;
        }

        public String Resultado() {
            var notaFinal = MediaAritimetica();
            var resultado = "Reprovado";

            if (notaFinal >= 5 && notaFinal < 7) {
                resultado = "Recuperação";
            } else if (notaFinal >= 7) {
                resultado = "Aprovado";
            }

            return resultado;
        }
    }
}
