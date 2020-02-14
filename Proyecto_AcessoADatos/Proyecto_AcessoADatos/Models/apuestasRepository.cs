using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class ApuestasRepository
    {

        /* private MySqlConnection Connect()
         {
             return null;
             /*string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";*/
        /*MySql.Data.MySqlClient.MySqlConnection con = new MySqlConnection(connString);

    }*/


            internal List<Apuestas> Retrieve()
            {
                List<Apuestas> apuestas = new List<Apuestas>();
                using (PlaceMyBetContext context = new PlaceMyBetContext())
                {
                    apuestas = context.Apuestas.Include(p => p.mercado).ToList();
                    List<ApuestasDTO> apuestasDTO = context.Apuestas.Select(p => ToDTO(p)).ToList();
                }

                return apuestas;
                //Devuelve todos los registros
                //MySqlConnection con = Connect();
                //MySqlCommand command = con.CreateCommand();
                //command.CommandText = "select * from apuestas";

                //con.Open();
                //MySqlDataReader res = command.ExecuteReader();
                
                //apuestas a = null;
                //List<apuestas> apuesta = new List<apuestas>();

                    //Cada vez que ecuentra un objeto lo añade al list
                    //List<apuestas> apuesta = new List<apuestas>();

                    //Devolver objeto apuestas. Se devolvera un registro y lo añadira a la lista
                   /* if (res.Read())
                    {
                        a = new apuestas(res.GetInt32(0), res.GetDecimal(1), res.GetDecimal(2), res.GetString(3), res.GetInt32(4), res.GetInt32(5));
                        apuesta.Add(a);
                    }

                con.Close();
                return apuesta;*/
                


        }

        


        internal Apuestas Retrieve(int id)
        {
            Apuestas apuesta;

            using(PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuestas
                    .Where(a => a.Id == id)
                    .FirstOrDefault();
            }
            return apuesta;
        }


        public ApuestasDTO ToDTO(Apuestas a)
        {
            return new ApuestasDTO(a.Tipo_apuesta, a.Cuota, a.Dinero_apostado, a.ID_MERCADO, a.ID_USUARIOS);
        }

        internal void Save(Apuestas Ap)
        {
            var Mercadorepo = new MercadoRepository();
            Mercado merc;

            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Apuestas.Add(Ap);
            merc = Mercadorepo.Retrieve(Ap.ID_MERCADO);
            if(Ap.Tipo_apuesta.ToLower() == "over")
            {
                merc.Dinero_over += Ap.Dinero_apostado;
            }
            else
            {
                merc.Dinero_under += Ap.Dinero_apostado;
            }
            context.Mercados.Update(merc);
            context.SaveChanges();
        }
        //List<apuestas> Apuestas = context.Apuesta.Include(m => m.mercado).ToList();

       /* private apuestasDTO ToDTO(Apuestas a)
        {
            return new apuestasDTO(a.Tipo_apuesta, a.Cuota, a.Dinero_apostado, a.ID_MERCADO, a.ID_USUARIOS);
        }*/



        /*internal void Save(Apuestas Ap)
        {
            var mercadoRepo = new MercadoRepository();
            Mercado merc;

            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Apuestas.Add(Ap);
            merc = mercadoRepo.Retrieve(Ap.ID_MERCADO);
            if (Ap.Tipo_apuesta.ToLower()== "over")
            {
                merc.Dinero_over += Ap.Dinero_apostado;
            }
            else
            {
                merc.Dinero_under += Ap.Dinero_apostado;
            }
            context.Mercados.Update(merc);
            context.SaveChanges();


        }*/
      /*  internal apuestas Retrieve(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Apuestas = context.Apuestas
                    .Where(m => m.ID == id)
                    .FirstOrDefault();
            }
            return Apuestas;
        }*/


        /*internal apuestasDTO RetrieveDTO()
            {
                return null;
                //Devuelve todos los registros
                //MySqlConnection con = Connect();
                //MySqlCommand command = con.CreateCommand();
                //command.CommandText = "Select(A.Cuota,A.Tipo_apuesta,A.Dinero_apostado,U.Email,M.tipo_mercado) from apuestas A INNER JOIN usuario U INNER JOIN mercado M ON A.ID_MERCADO = M.id AND A.ID_USUARIOS = U.ID; ";


                    //con.Open();
                    //MySqlDataReader res = command.ExecuteReader();

                    //apuestasDTO a = null;

                    //Cada vez que ecuentra un objeto lo añade al list
                    //List<apuestasDTO> apuesta = new List<apuestasDTO>();

                    //Devolver objeto apuestas. Se devolvera un registro y lo añadira a la lista
                    /*if (res.Read())
                    {
                        a = new apuestasDTO(res.GetDecimal(0), res.GetDecimal(1), res.GetString(2));
                    }

                    con.Close();
                    return a;



            }*/

        /* internal void Save(apuestas a)
         {
             //MySqlConnection con = Connect();
             //MySqlCommand command = con.CreateCommand();
             //command.CommandText = "INSERT INTO apuestas(Id,Tipo_apuesta,Cuota,Dinero_apostado,ID_MERCADO,ID_USUARIOS) values ('"+a.Id+"','"+a.Tipo_apuesta+"','"+a.Cuota+"','"+a.Dinero_apostado+"','"+a.ID_MERCADO+"','"+a.ID_USUARIOS+"');";
             ///Debug.WriteLine("comando" + command.CommandText);

             List<mercado> m = Recupera()//modificar aqui


             double Cuota_over; 
             double Cuota_under;
             double prob_over;
             double prob_under;

             prob_over = m.Dinero_over / (m.Dinero_over + m.Dinero_under);
             prob_under = m.Dinero_under / (m.Dinero_over + m.Dinero_under);

             Cuota_over = 1 / prob_over * 0.95;
             Cuota_under = 1 / prob_under * 0.95;

            /* if (a.Tipo_apuesta == "over")
             {
                 command.CommandText = "UPDATE mercado set Dinero_over = Dinero_over" + a.Dinero_apostado + "WHERE id =" + a.ID_MERCADO + ";";
                 Debug.WriteLine("comando" + command.CommandText);
             }
             else if (a.Tipo_apuesta == "under")
             {
                 command.CommandText = "UPDATE mercado set Dinero_under = Dinero_under" + a.Dinero_apostado + "WHERE id =" + a.ID_MERCADO + ";";
                 Debug.WriteLine("comando" + command.CommandText);
             }*/

        /* try
         {
             con.Open();
             command.ExecuteNonQuery();
             con.Close();
         }
         catch (MySqlException e)
         {
             Debug.WriteLine("Se ha producido un error de conexión");
         }


     }*/
       /* private List<mercado> Recupera(int id)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercado WHERE id = "+id+";";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();
                mercado m = null;
                List<mercado> mercados = new List<mercado>();
                if (res.Read())
                {
                    m = new mercado(res.GetString(0), res.GetDecimal(1), res.GetDecimal(2), res.GetInt32(3), res.GetFloat(4), res.GetFloat(5), res.GetInt32(6));
                    mercados.Add(m);
                }
                con.Close();
                return mercados;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Se ha producido un error");
                return null;
            }


        }*/


    }
}