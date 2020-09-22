using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.AccesoADatos
{
    public class RepositorioUsuario: IRepositorioUsuario<Usuario>
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        public RepositorioUsuario()
        {
            Usuarios.Add(new SupLinea(45563,28963258,"Ivana","Corbalan","IvanaC","123456"));
            Usuarios.Add(new SupCalidad(45564,25778963,"Milagros","Gomez","MilagrosL","123456"));
            Usuarios.Add(new SupCalidad(45565,27896321,"Solana","Campos","SolC","123456"));
        }

        public Usuario Agregar(Usuario item)
        {
            Usuarios.Add(item);
            return item;
        }

        public List<SupCalidad> GetSupervisoresCalidad()
        {
            try
            {
                List<SupCalidad> usuarios = new List<SupCalidad>();
                foreach(Usuario sup in Usuarios)
                {
                    if (typeof(SupCalidad).Equals(sup.GetType()))
                    {
                        usuarios.Add((SupCalidad)sup);
                    }                    
                }
                return usuarios;
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                return new List<SupCalidad>();
            }
        }

        public List<Usuario> GetTodos()
        {
            return Usuarios;
        }

        public bool Login(string usuario, string contraseña)
        {
            try
            {
                Usuario user = Usuarios.First(u => u.NombreUsuario == usuario && u.Contraseña == contraseña);
                Sesion.Instance.UsuarioLogueado = user;
                return true;
            }
            catch(System.InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                return false;
            }            
        }

        public Usuario Modificar(Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
