using System;

namespace Roma.Core.Model
{
    public class Asesino : ICarta
    {
        public string Nombre => "Asesino";
        public string Descripcion => "Aumenta la posibilidad del asesinato en 1. Efeto acumulativo con otros guardaespaldas y asesinos";
        public int NumCartas => 1;
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
