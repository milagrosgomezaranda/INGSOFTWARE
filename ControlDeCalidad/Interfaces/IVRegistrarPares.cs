using ControlDeCalidad.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVRegistrarPares : IVista
    {
        void SetOrdenProduccion(OrdenProduccion ordenProduccion);
        void LimpiarVentana();
        void PoblarComboBox(List<Defectos> pieIzquierdo, List<Defectos> pieDerecho);
    }
}
