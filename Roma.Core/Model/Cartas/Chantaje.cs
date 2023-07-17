using System;

namespace Roma.Core.Model.Cartas
{
    public class Chantaje : ICarta
    {
        public string Nombre => "Chantaje";
        public string Descripcion => "Impide el uso de talentos para defenderse en un intento de persuasión. Si falla, la popularidad e influencia del senador bajan 2d6";
        public int NumCartas => 1;
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
