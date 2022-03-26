using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Aluno
    {
        public string Nome { get; private set; }
        public integer RA { get; private set; }

        public decimal PrimeiraNota { get; private set; }

        public decimal SegundaNota { get; private set; }
        public integer Frequencia { get; private set; }

        public Aluno(string nome, integer ra, decimal nota, integer frequencia)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            RA = ra ?? throw new ArgumentNullException(nameof(ra));
            PrimeiraNota = primeiraNota ?? throw new ArgumentNullException(nameof(primeiraNota));
            SegundaNota = segundaNota ?? throw new ArgumentNullException(nameof(segundaNota));
            Frequencia = frequencia ?? throw new ArgumentNullException(nameof(frequencia));
        }
        public override string ToString()
           => $"Nome: {Nome} \n RA: {RA} \n Nota: {Nota} \n Frequência: {Frequencia} ";
    }
}
