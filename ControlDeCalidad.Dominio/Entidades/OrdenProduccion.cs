using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class OrdenProduccion
    {
        public int NumeroOperacion { get; set; }
        public Modelo Modelo { get; set; }
        public EstadoOP EstadoOP { get; set; }
        public LineaTrabajo LineaTrabajo { get; set; }
        public Objetivo Objetivo { get; set; }
        public List<Par> Pares = new List<Par>();
        public Turno Turno { get; set; }
        public InformePrimera InformePrimera { get; set; }
        public InformeSegunda InformeSegunda { get; set; }
        public SupCalidad SupCalidad { get; set; }
        public bool Asignado
        {
            get
            {
                if (SupCalidad == null)
                {
                    return false;
                }
                else
                {
                    if ((SupCalidad)Sesion.Instance.UsuarioLogueado == SupCalidad)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        public OrdenProduccion()
        {
            Random rnd = new Random();
            Objetivo = new Objetivo();
            EstadoOP = EstadoOP.EnProceso;
            int horaInicio = rnd.Next(0,23);
            Turno = new Turno();
            Turno.HoraInicio = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day, horaInicio, 0,0);
            Turno.HoraFin = Turno.HoraInicio.AddHours(8);

            InformePrimera = new InformePrimera();
            InformeSegunda = new InformeSegunda();
        }

        public void AgregarReproceso(Par par)
        {
            par.Description = "Reproceso";
            Pares.Add(par);
        }

        public void AgregarParSegunda(Par par)
        {
            par.Description = "Segunda";
            Pares.Add(par);
            InformeSegunda.AgregarPar();
        }

        public void AgregarParPrimera(Par par)
        {
            par.Description = "Primera";
            Pares.Add(par);
            InformePrimera.AgregarPar();
        }

        public void AgregarLinea(SupLinea supLinea)
        {
            LineaTrabajo = new LineaTrabajo(supLinea);
        }

        public void AgregarSupervisorCalidad(SupCalidad supCalidad)
        {
            SupCalidad = supCalidad;
        }
    }
}
