﻿namespace challengeAPI.Models
{
    public partial class ViaCep
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public long Ibge { get; set; }
        public long Gia { get; set; }
        public long Ddd { get; set; }
        public long Siafi { get; set; }
    }
}
