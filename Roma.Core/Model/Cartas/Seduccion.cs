using System;

namespace Roma.Core.Model
{
    public class Seduccion : ICarta
    {
        public string Nombre => "Seducción";
        public int NumCartas => 1;
        public string Descripcion => "Impide el uso de talentos para defenderse en un intento de persuasión";
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
