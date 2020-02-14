using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class MercadoRepository
    {
        /*private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySql.Data.MySqlClient.MySqlConnection con = new MySqlConnection(connString);
            return con;
        }*/
        internal List<Mercado> Retrieve()
        {
            List<Mercado> Mercados = new List<Mercado>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Mercados = context.Mercados.Include(p => p.evento).ToList();
                List<MercadosDTO> mercadosDTO = context.Mercados.Select(p => ToDTO(p)).ToList();

            }

            return Mercados;
            //Devuelve todos los registros
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "Select(A.Cuota,A.Tipo_apuesta,A.Dinero_apostado,U.Email,M.tipo_mercado) from mercado M INNER JOIN usuario U INNER JOIN apuestas A ON A.ID_MERCADO = M.id AND A.ID_USUARIOS = U.ID; from mercado";
            //con.Open();
            //MySqlDataReader res = command.ExecuteReader();

            //mercado m = null;

                //Cada vez que ecuentra un objeto lo añade al list
                //List<mercado> mercados = new List<mercado>();

                ////Devolver objeto mercado. Se devolvera un registro
               /* if (res.Read())
            {
                m = new mercado(res.GetString(0), res.GetDecimal(1), res.GetDecimal(2), res.GetInt32(3), res.GetFloat(4), res.GetFloat(5), res.GetInt32(6));
            }

            con.Close();
            return m;*/
        }

        /*** Ejercicio 2 ***/
        internal void Update(int id, decimal Cuota_over, decimal Cuota_under, float Dinero_over, float Dinero_under)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Mercado mercado = context.Mercados
                    .Where(s => s.id == id)
                    .FirstOrDefault();
                mercado.Cuota_over = Cuota_over;
                mercado.Cuota_under = Cuota_under;
                mercado.Dinero_over = Dinero_over;
                mercado.Dinero_under = Dinero_under;
                context.Update(mercado);
                context.SaveChanges();
            }
        }
        /*** Fin Ejercicio 2 ***/

        internal Mercado Retrieve(int id)
        {
            Mercado mercado;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercado = context.Mercados
                    .Where(m => m.id == id)
                    .SingleOrDefault();
            }
            return mercado;
        }

        public MercadosDTO ToDTO(Mercado m)
        {
            return new MercadosDTO(m.tipo_mercado, m.Cuota_over, m.Cuota_under);
        }

   

        /*internal mercadoDTO RetrieveDTO()
        {
            return null;
            //Devuelve todos los registros
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from mercado";

            //con.Open();
            //MySqlDataReader res = command.ExecuteReader();

            //mercadoDTO m = null;

                //Cada vez que ecuentra un objeto lo añade al list
                //List<mercadoDTO> mercados = new List<mercadoDTO>();

                ////Devolver objeto mercado. Se devolvera un registro
                /*if (res.Read())
                {
                    m = new mercadoDTO(res.GetString(0), res.GetDecimal(1), res.GetDecimal(2));
                }

                con.Close();
                return m;

        }*/

        internal void SaveMercado(Mercado Merc)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Mercados.Add(Merc);
            context.SaveChanges();
        }
    }
}