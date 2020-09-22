using ControlDeCalidad.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaIniciarOP: IVista
    {
        void PoblarModelos(List<Modelo> modelos);
        void PoblarColores(List<Color> colores);
        void PoblarSupervisorCalidad(List<SupCalidad> usuarios);
    }
}
