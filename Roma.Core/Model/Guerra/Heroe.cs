using System;
using System.Collections.Generic;

namespace Roma.Core.Model
{
    public class Heroe : IGuerra
    {
        public string Nombre { get; private set; }
        public string Epoca { get; private set; }
        public int FuerzaTerrestre { get; private set; }
        public int FuerzaMaritima { get; private set; }
        public int FlotasNecesarias { get; private set; }
        public IEnumerable<int> Desastre { get; private set; }
        public IEnumerable<int> Rechazo { get; private set; }
        public int Botin { get; private set; }
        public TipoGuerra Tipo { get; private set; }
        public bool Sequia => false;

        public Heroe(string nombre, string epoca, int fuerzaTerrestre, IEnumerable<int> desastre, IEnumerable<int> retirada, TipoGuerra tipo)
        {
            Nombre = nombre;
            Epoca = epoca;
            FuerzaTerrestre = fuerzaTerrestre;
            FuerzaMaritima = 0;
            FlotasNecesarias = 0;
            Desastre = desastre;
            Rechazo = retirada;
            Botin = 0;
            Tipo = tipo;
        }
    }
}
