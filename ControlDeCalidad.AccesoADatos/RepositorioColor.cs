using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos
{
    public class RepositorioColor : IRepositorioColor<Color>
    {
        private List<Color> Colores = new List<Color>();
        public RepositorioColor()
        {
            Colores.Add(new Color("Azul"));
            Colores.Add(new Color("Rojo"));
            Colores.Add(new Color("Blanco"));
        }

        public Color Agregar(Color item)
        {
            Colores.Add(item);
            return item;
        }

        public List<Color> GetTodos()
        {
            return Colores;
        }

        public Color Modificar(Color item)
        {
            throw new NotImplementedException();
        }
    }
}
