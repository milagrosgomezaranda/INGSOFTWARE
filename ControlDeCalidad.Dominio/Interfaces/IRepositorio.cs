using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> GetTodos();
        T Agregar(T item);
        T Modificar(T item);
    }
}
