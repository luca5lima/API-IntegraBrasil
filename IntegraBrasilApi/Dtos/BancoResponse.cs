﻿using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Dtos
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }

        public string? NomeAbreviado { get; set; }

        public int? Codigo { get; set; }

        public string? NomeCompleto { get; set; }
    }
}
