using System;

namespace Roma.Core.Model.Cartas
{
    public class Guardaespaldas : ICarta
    {
        public string Nombre => "Guardaespaldas";
        public string Descripcion => "Reduce la posibilidad de asesinato en 1. Si el asesino no es atrapado, Se realiza una nueva tirada que solo le afecta a él";
        public int NumCartas => 1;
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
