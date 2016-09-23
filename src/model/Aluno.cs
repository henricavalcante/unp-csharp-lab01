using System;

namespace NovoSaber
{
    public class Aluno
    {
        public String Nome { get; set; }
        public String Matricula { get; set; }
        public String Telefone { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
