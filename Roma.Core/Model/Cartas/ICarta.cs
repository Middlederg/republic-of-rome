using System.Text;
using System.Threading.Tasks;

namespace Roma.Core.Model
{
    public interface ICarta
    {
        string Nombre { get; }
        string Descripcion { get; }
        int NumCartas { get; }
        void RealizarAccion();
    }
}
