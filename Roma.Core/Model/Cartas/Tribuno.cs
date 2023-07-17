using System;

namespace Roma.Core.Model
{
    public class Tribuno : ICarta
    {
        public string Nombre => "Tribuno";
        public string Descripcion => "Puede proponer iniciativas cuando no tiene el turno, o puede vetar iniciativas de otras facciones";
        public int NumCartas => 9;
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
