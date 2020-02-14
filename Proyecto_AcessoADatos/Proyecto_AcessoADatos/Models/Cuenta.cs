using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class cuenta
    {
        public cuenta()
        {

        }

        public cuenta(int ID, string Num_tarjeta_vinculada, decimal Saldo_actual, string Nombre_banco, int ID_Usuario)
        {
            this.ID = ID;
            this.Num_tarjeta_vinculada = Num_tarjeta_vinculada;
            this.Saldo_actual = Saldo_actual;
            this.Nombre_banco = Nombre_banco;
            this.UsuarioId = ID_Usuario;


        }

        public int ID { get; set; }
        public string Num_tarjeta_vinculada { get; set; }
        public decimal Saldo_actual { get; set; }
        public string Nombre_banco { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}