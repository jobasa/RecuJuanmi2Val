using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class Apuestas
    {
        public Apuestas(int Id, float Dinero_apostado, decimal Cuota, string Tipo_apuesta, int ID_MERCADO, int ID_USUARIOS)
        {
            this.Id = Id;
            this.Dinero_apostado = Dinero_apostado;
            this.Cuota = Cuota;
            this.Tipo_apuesta = Tipo_apuesta;
            this.ID_MERCADO = ID_MERCADO;
            this.ID_USUARIOS = ID_USUARIOS;
        }



        public int Id { get; set; }
        public float Dinero_apostado { get; set; }
        public decimal Cuota { get; set; }
        public string Tipo_apuesta { get; set; }
        public int ID_MERCADO { get; set; }
        public int ID_USUARIOS { get; set; }
        public Mercado mercado { get; set; }
    }

    public class ApuestasDTO
    {
        public ApuestasDTO(string Tipo_apuesta, decimal Cuota, float Dinero_apostado, int ID_MERCADO, int ID_USUARIOS)
        {
            this.Tipo_apuesta = Tipo_apuesta;
            this.Cuota = Cuota;
            this.Dinero_apostado = Dinero_apostado;
            this.ID_MERCADO = ID_MERCADO;
            this.ID_USUARIOS = ID_USUARIOS;
        }

        public string Tipo_apuesta { get; set; }
        public decimal Cuota { get; set; }
        public float Dinero_apostado { get; set; }
        public int ID_MERCADO { get; set; }
        public int ID_USUARIOS { get; set; }




    }


}