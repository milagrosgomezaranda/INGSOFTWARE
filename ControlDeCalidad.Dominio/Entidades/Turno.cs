using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Turno
    {
        private DateTime _horaInicio;
        private DateTime _horaFin;
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio 
        {
            get
            {
                return Convert.ToDateTime(_horaInicio.ToString("hh:mm"));
            } 
            set
            {
                _horaInicio = value;
            } 
        }
        public DateTime HoraFin
        {
            get
            {
                return Convert.ToDateTime(_horaFin.ToString("hh:mm"));
            }
            set
            {
                _horaFin = value;
            }
        }
    }
}
