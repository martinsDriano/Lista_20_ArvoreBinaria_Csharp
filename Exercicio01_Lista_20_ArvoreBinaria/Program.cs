using Exercicio01_Lista_20_ArvoreBinaria;



class Program 
{
    static void Main(string[] args)
    {

        ArvoreBinaria game01 = new ArvoreBinaria();

        game01.Insere(50, "Golpe Rápido");
        game01.Insere(30, "Defesa Básica");
        game01.Insere(70, "Bola de Fogo");
        game01.Insere(20, "Concentração");
        game01.Insere(40, "Contra-Ataque");
        game01.Insere(60, "Escudo Mágico");
        game01.Insere(80, "Fúria Flamejante");

        game01.ImprimeElementosArvore();

    }





}

