using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitProva7
{
    internal class Biblioteca
    {
        string nome, indirizzo;
        int orarioApertura, orarioChiusura;
        public Biblioteca(string nome, string indirizzo, int orarioApertura, int orarioChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }

    }
}
