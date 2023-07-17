using System;
using System.Collections.Generic;

namespace Roma.Core.Model
{
    public class Provincia
    {
        public string Nombre { get; }
        public string Origen { get; }
        public int Year { get; private set; }
        public bool Desarrollada { get; private set; }
        public Formula Expoliar { get; }
        public Formula ExpoliarDesarrollada { get; }
        public Formula Tributar { get; }
        public Formula TributarDesarrollada { get; }

        public Provincia(string nombre, string origen, Formula expoliar, Formula expoliarDesarrollada, Formula tributo, Formula tributoDesarrollada)
        {
            Nombre = nombre;
            Origen = origen;
            Year = 1;
            Desarrollada = false;
            Expoliar = expoliar;
            ExpoliarDesarrollada = expoliarDesarrollada;
            Tributar = tributo;
            TributarDesarrollada = tributoDesarrollada;
        }

        public void NuevoSenador() => Year = 1;
        public int Expolio() => Desarrollada ? ExpoliarDesarrollada.Resultado() : Expoliar.Resultado();
        public string ExpolioText() => Desarrollada ? ExpoliarDesarrollada.ToString() : Expoliar.ToString();
        public int Tributo() => Desarrollada ? TributarDesarrollada.Resultado() : Tributar.Resultado();
        public string TributoText() => Desarrollada ? TributarDesarrollada.ToString() : Tributar.ToString();

        public bool Desarrollar(bool expoliadaPreviamente)
        {
            if (Desarrollada)
                throw new ArgumentOutOfRangeException("no se puede desarrollar una Provincia que ya está desarrollada");

            Desarrollada = expoliadaPreviamente ? R.Instance.LanzarDados6() == 6 : R.Instance.LanzarDados6() >= 5;
            return Desarrollada;
        }
    }
}
