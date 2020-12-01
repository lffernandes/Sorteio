using System;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Entities
{
    public class Participante : Entity
    {
        public Participante() { }
        public Participante(string nome, string cpf, DateTime dt_nascimento, decimal renda, TipoCota cota, string cid)
        {
            Nome = nome;
            Cpf = cpf;
            Dt_nascimento = dt_nascimento;
            Renda = renda;
            Cota = cota;
            Cid = cid;
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime Dt_nascimento { get; set; }

        public decimal Renda { get; set; }

        public TipoCota Cota { get; set; }

        public string Cid { get; set; }

    }
}