using ControlDeCalidad.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Interfaces
{
    public interface IRepositorioOrdenProduccion<T>: IRepositorio<T>
    {
        bool TieneLineaIniciada();
        T GetOperacionACargo();
        List<OrdenProduccion> GetOrdenProduccionParaSupCalidad();
    }
}
