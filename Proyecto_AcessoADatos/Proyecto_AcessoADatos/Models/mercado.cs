﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{

    public class Mercado
    {
        public Mercado(string tipo_mercado, decimal Cuota_over, decimal Cuota_under, int id, float Dinero_over, float Dinero_under, int IDEvento)
        {
            this.tipo_mercado = tipo_mercado;
            this.Cuota_over = Cuota_over;
            this.Cuota_under = Cuota_under;
            this.id = id;
            this.Dinero_over = Dinero_over;
            this.Dinero_under = Dinero_under;
            this.IDEvento = IDEvento;
        }

        public string tipo_mercado { get; set; }
        public decimal Cuota_over { get; set; }
        public decimal Cuota_under { get; set; }
        public int id { get; set; }
        public float Dinero_over { get; set; }
        public float Dinero_under { get; set; }
        public int IDEvento { get; set; }
        public Evento evento { get; set; }
        public List<Apuestas> Apuestas { get; set; }
    }

    public class MercadosDTO
    {
        public MercadosDTO(string Tipo_mercado, decimal Cuota_over, decimal Cuota_under)
        {
            this.Tipo_mercado = Tipo_mercado;
            this.Cuota_over = Cuota_over;
            this.Cuota_under = Cuota_under;
        }

        public string Tipo_mercado { get; set; }
        public decimal Cuota_over { get; set; }
        public decimal Cuota_under { get; set; }
    }
}