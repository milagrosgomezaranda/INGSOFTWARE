﻿using ControlDeCalidad.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVOperacionACargoLinea : IVista
    {
        void DevolverOperacionACargo(OrdenProduccion ordenProduccion);
    }
}
