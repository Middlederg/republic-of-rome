using System;

namespace Roma.Core.Model
{
    public class Habilidad
    {
        public TipoHabilidad Tipo { get; set; }
        public TipoGuerra? GuerraRelacionada { get; set; }

        public Habilidad(TipoHabilidad tipo, TipoGuerra? guerraRelacionada = null)
        {
            Tipo = tipo;
            GuerraRelacionada = guerraRelacionada;
        }


    }



}
