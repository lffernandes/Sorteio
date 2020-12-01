using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Queries
{
    public static class ParticipanteQueries
    {
        public static Expression<Func<Participante, bool>> GetAllIdoso(TipoCota cota)
        {
            return x =>
                x.Cota == cota
                && x.Renda > decimal.Parse("1045.00")
                && x.Renda < decimal.Parse("5225.00")
                && x.Cpf.Length == 14
                && (DateTime.Now.Year - x.Dt_nascimento.Year) > 60;

        }
        public static Expression<Func<Participante, bool>> GetAllPcd(TipoCota cota)
        {
            return x =>
                x.Cota == cota
                && x.Renda > decimal.Parse("1045.00")
                && x.Renda < decimal.Parse("5225.00")
                && x.Cpf.Length == 14
                && (DateTime.Now.Year - x.Dt_nascimento.Year) > 15
                && x.Cid != "";

        }
        public static Expression<Func<Participante, bool>> GetAllGeral(TipoCota cota)
        {
            return x =>
                x.Cota == cota
                && x.Renda > decimal.Parse("1045.00")
                && x.Renda < decimal.Parse("5225.00")
                && x.Cpf.Length == 14
                && (DateTime.Now.Year - x.Dt_nascimento.Year) > 15;

        }

    }
}