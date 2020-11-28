using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos
{
    public class RepositorioOrdenProduccion : IRepositorioOrdenProduccion<OrdenProduccion>
    {
        private readonly static RepositorioOrdenProduccion _instance = new RepositorioOrdenProduccion();
        public List<OrdenProduccion> OrdenProducciones = new List<OrdenProduccion>();

        private RepositorioOrdenProduccion()
        {
            RepositorioColor colores = new RepositorioColor();
            RepositorioModelo modelos = new RepositorioModelo();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                OrdenProduccion orden = new OrdenProduccion();
                orden.NumeroOperacion = GetNumeroOrden();
                orden.AgregarLinea(null);
                int indexColor = rnd.Next(0, colores.GetTodos().Count);
                int indexModelo = rnd.Next(0, modelos.GetTodos().Count);
                orden.Modelo = modelos.GetTodos()[indexModelo];
                orden.Modelo.Color = colores.GetTodos()[indexColor];
                OrdenProducciones.Add(orden);
            }
        }

        public static RepositorioOrdenProduccion Instance
        {
            get
            {
                return _instance;
            }
        }

        public OrdenProduccion Agregar(OrdenProduccion item)
        {
            item.NumeroOperacion = GetNumeroOrden();
            OrdenProducciones.Add(item);
            return item;
        }

        public OrdenProduccion GetOperacionACargo()
        {
            try
            {
                if (Sesion.Instance.UsuarioLogueado.GetType().Equals(typeof(SupCalidad)))
                {
                    SupCalidad supCalidad = (SupCalidad)Sesion.Instance.UsuarioLogueado;
                    return OrdenProducciones.First(x => x.EstadoOP != EstadoOP.Finalizada && x.SupCalidad != null && x.SupCalidad.Nombre == supCalidad.Nombre && 
                    x.SupCalidad.Apellido == supCalidad.Apellido &&
                    x.SupCalidad.Documento == supCalidad.Documento &&
                    x.SupCalidad.NombreUsuario == supCalidad.NombreUsuario);
                }
                else
                {
                    if (Sesion.Instance.UsuarioLogueado.GetType().Equals(typeof(SupLinea)))
                    {
                        SupLinea supLinea = (SupLinea)Sesion.Instance.UsuarioLogueado;
                        return OrdenProducciones.First(x => x.LineaTrabajo.SupLinea == supLinea && x.EstadoOP != EstadoOP.Finalizada);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (System.InvalidOperationException ex)
            {
                return null;
            }
        }

        public List<OrdenProduccion> GetOrdenProduccionParaSupCalidad()
        {
            if (Sesion.Instance.UsuarioLogueado.GetType().Equals(typeof(SupCalidad)))
            {
                SupCalidad supCalidad = (SupCalidad)Sesion.Instance.UsuarioLogueado;
                return OrdenProducciones.Where(x => x.SupCalidad == null && x.EstadoOP != EstadoOP.Finalizada).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<OrdenProduccion> GetTodos()
        {
            return OrdenProducciones;
        }

        public OrdenProduccion Modificar(OrdenProduccion item)
        {
            List<OrdenProduccion> ordenes = new List<OrdenProduccion>();
            foreach (OrdenProduccion orden in OrdenProducciones)
            {
                if (orden.NumeroOperacion == item.NumeroOperacion)
                {
                    ordenes.Add(item);
                }
                else
                {
                    ordenes.Add(orden);
                }
            }
            OrdenProducciones = ordenes;
            return item;
        }

        public bool TieneLineaIniciada()
        {
            OrdenProduccion orden = GetOperacionACargo();
            return (orden != null) ? true : false;
        }

        private int GetNumeroOrden()
        {
            int NumeroOrden;
            if (OrdenProducciones.Count == 0)
            {
                NumeroOrden = 1;
            }
            else
            {
                OrdenProduccion orden = OrdenProducciones.Last<OrdenProduccion>();
                NumeroOrden = orden.NumeroOperacion + 1;
            }
            return NumeroOrden;
        }
    }
}
