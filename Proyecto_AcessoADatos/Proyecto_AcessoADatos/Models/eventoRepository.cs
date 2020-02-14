using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class EventoRepository
    {
        /*private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySql.Data.MySqlClient.MySqlConnection con = new MySqlConnection(connString);
            return con;
        }*/
        internal List<Evento> Retrieve()
        {
            //Hacer un GET
            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos.ToList();
            }

            return eventos;
            //Devuelve todos los registros
           // MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "Select(m.tipo_mercado,m.Cuota_over,m.Cuota_under) from mercado m";

           // con.Open();
           // MySqlDataReader res = command.ExecuteReader();

            //evento e = null;


            //Devolver objeto evento. Se devolvera un registro y lo añadira a la lista
           /* if (res.Read()){
                e = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2));
            }

            con.Close();
            return e;*/
        }

        internal void Update (int ID_Equipo, string Equipo_Local, string Equipo_visitante)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Evento evento = context.Eventos
                    .Where(s => s.EventoId == ID_Equipo)
                    .FirstOrDefault();
                evento.Equipo_Local = Equipo_Local;
                evento.Equipo_visitante = Equipo_visitante;
                context.Update(evento);
                context.SaveChanges();
            }
        }

        internal void Delete (int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Evento e = context.Eventos
                    .Where(s => s.EventoId == id)
                    .FirstOrDefault();
                context.Attach(e);
                context.Remove(e);
                context.SaveChanges();
            }
        }

        internal void Save(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Eventos.Add(e);
            context.SaveChanges();
        }

        /* internal eventoDTO RetrieveDTO()
         {
             return null;
             //Devuelve todos los registros
             //MySqlConnection con = Connect();
             //MySqlCommand command = con.CreateCommand();
             //command.CommandText = "Select * from partido";

                // con.Open();
                // MySqlDataReader res = command.ExecuteReader();

                 //eventoDTO e = null;


                 //Devolver objeto evento. Se devolvera un registro
                /* if (res.Read())
                 {
                     e = new eventoDTO(res.GetString(0), res.GetString(1));
                 }

                 con.Close();
                 return e;


         }*/
    }
}