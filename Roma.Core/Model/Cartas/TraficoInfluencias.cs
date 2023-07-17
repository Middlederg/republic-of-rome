using System;

namespace Roma.Core.Model
{
    public class TraficoInfluencias : ICarta
    {
        public string Nombre => "Tráfico de influencias";
        public int NumCartas => 1;
        public string Descripcion => "Durante la fase de revueltas, descarta esta carta para robar una carta a otro jugador";
        public void RealizarAccion()
        {
            throw new NotImplementedException();
        }
    }
}
