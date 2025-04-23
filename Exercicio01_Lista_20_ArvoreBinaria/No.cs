using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Lista_20_ArvoreBinaria
{
    public class No
    {
        public long Id { get; set; } // Id identificação

        public object Elemento { get; set; }// elemento da árvore

        public No Esquerda { get; set; }

        public No Direita { get; set; }

        public No(long nivelHabilidade, object nomeHabilidade, No esquerda, No direita)
        {
            Id = nivelHabilidade;
            Elemento = nomeHabilidade;
            Esquerda = esquerda;
            Direita = direita;

        }

    }

}
