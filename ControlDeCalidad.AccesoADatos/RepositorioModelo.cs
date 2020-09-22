using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos
{
    public class RepositorioModelo : IRepositorioModelo<Modelo>
    {
        private List<Modelo> Modelos = new List<Modelo>();
        public RepositorioModelo()
        {
            Modelos.Add(new Modelo(39,"Tenis Adapt"));
            Modelos.Add(new Modelo(36,"Nike Revolution 5"));
            Modelos.Add(new Modelo(37,"React Infinity Run"));
            Modelos.Add(new Modelo(40,"Gel Nimbus"));
            Modelos.Add(new Modelo(41,"Hovr Machina"));
        }

        public Modelo Agregar(Modelo item)
        {
            Modelos.Add(item);
            return item;
        }

        public List<Modelo> GetTodos()
        {
            return Modelos;
        }

        public Modelo Modificar(Modelo item)
        {
            throw new NotImplementedException();
        }
    }
}
