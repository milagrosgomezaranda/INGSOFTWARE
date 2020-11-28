using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos
{
    public class RepositorioDefectos : IRepositorioDefectos<Defectos>
    {
        private List<Defectos> Defectos = new List<Defectos>();
        public RepositorioDefectos()
        {
            Defectos.Add(new Defectos("Exceso pegamento"));
            Defectos.Add(new Defectos("Suela débil"));
            Defectos.Add(new Defectos("Tamaño incorrecto"));
            Defectos.Add(new Defectos("Punta estrecha"));
            Defectos.Add(new Defectos("Punta afilada"));
        }

        public Defectos Agregar(Defectos item)
        {
            Defectos.Add(item);
            return item;
        }

        public List<Defectos> GetTodos()
        {
            return Defectos;
        }

        public Defectos Modificar(Defectos item)
        {
            throw new NotImplementedException();
        }
    }
}
