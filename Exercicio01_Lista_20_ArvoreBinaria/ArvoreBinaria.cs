using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Lista_20_ArvoreBinaria
{
    public class ArvoreBinaria
    {
        private No raiz;

        public ArvoreBinaria()
        {
            raiz = null;

        }

        public void Insere(long id, object elemento)
        {

            No novoNo = new No(id, elemento, null, null);

            if (raiz == null)
            {

                raiz = novoNo;

            }
            else
            {
                No atual = raiz;

                No pai;
                while (true)
                {
                    pai = atual;

                    if (id < atual.Id)
                    {
                        atual = atual.Esquerda;

                        if (atual == null)
                        {
                            pai.Esquerda = novoNo;
                            return;
                        }


                    }
                    else
                    {
                        atual = atual.Direita;
                        if (atual == null)
                        {
                            pai.Direita = novoNo;
                            return;

                        }

                    }


                }

            }

        }

        private void PreFixado(No atual)
        {
            if (atual != null)
            {

                Console.WriteLine($"Id:{atual.Id}, Elemento {atual.Elemento} ");

                PreFixado(atual.Esquerda);

                PreFixado(atual.Direita);
            }

        }

        private void PosFixado(No atual)
        {
            PosFixado(atual.Esquerda);
            PosFixado(atual.Direita);

            Console.WriteLine($"Id: {atual.Id}, Elemento {atual.Elemento}");

        }

        public void ImprimeElementosArvore()
        {
            Console.WriteLine("Elementos da árvore (caminhamento pré-fixado):");
            PreFixado(raiz);
        }

    }

}
