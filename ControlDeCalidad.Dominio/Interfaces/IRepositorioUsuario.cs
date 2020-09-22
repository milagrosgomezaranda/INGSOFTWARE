using ControlDeCalidad.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Interfaces
{
    public interface IRepositorioUsuario<T>: IRepositorio<T>
    {
        bool Login(string usuario, string contraseña);
        List<SupCalidad> GetSupervisoresCalidad();
    }
}
