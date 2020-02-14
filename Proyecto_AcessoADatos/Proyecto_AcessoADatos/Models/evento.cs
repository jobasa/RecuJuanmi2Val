using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class Evento
    {
        public Evento(int ID_Equipo, string Equipo_Local, string Equipo_visitante)
        {
            this.EventoId = ID_Equipo;
            this.Equipo_Local = Equipo_Local;
            this.Equipo_visitante = Equipo_visitante;
        }

        public Evento()
        {

        }


        public int EventoId { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_visitante { get; set; }
        public List<Mercado> Mercados { get; set; }
    }

    /*public class eventoDTO
    {
        public eventoDTO(string Equipo_Local, string Equipo_visitante)
        {
            this.Equipo_Local = Equipo_Local;
            this.Equipo_visitante = Equipo_visitante;
        }

        public string Equipo_Local { get; set; }
        public string Equipo_visitante { get; set; }
    }*/
}