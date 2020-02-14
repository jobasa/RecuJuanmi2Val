using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(int ID, string Nombre, string Apellido, string Email, int Edad)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Edad = Edad;
            
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public cuenta cuenta { get; set; }
    }
}