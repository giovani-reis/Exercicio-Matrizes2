using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeMatrizes12
{
    internal class Posição
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }
        public int Valor { get; set; }

        public Posição()
        {
        }

        public Posição(int linha, int coluna, int valor)
        {
            Linha = linha;
            Coluna = coluna;
            Valor = valor;
        }

        public override string ToString()
        {
            return Linha+","+Coluna+": "+Valor;
        }
    }
}
