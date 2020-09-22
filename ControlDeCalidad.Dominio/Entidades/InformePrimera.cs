using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class InformePrimera
    {
        public DateTime Fecha { get; set; }
        public int CantidadPares { get; set; }
        public int TotalPares { get; set; }
        public Dictionary<int, int> Horas = new Dictionary<int, int>();
        public InformePrimera()
        {
            Fecha = DateTime.Now;
        }
        public void AgregarPar()
        {
            TimeSpan horaActual = DateTime.Now.Subtract(Fecha);
            if (horaActual.Hours == Horas.Count + 1)
            {
                CantidadPares++;
                Horas.Add(CantidadPares, horaActual.Hours);
                CantidadPares = 0;
            }
            else
            {
                CantidadPares++;
            }
            TotalPares++;
        }
    }
}
