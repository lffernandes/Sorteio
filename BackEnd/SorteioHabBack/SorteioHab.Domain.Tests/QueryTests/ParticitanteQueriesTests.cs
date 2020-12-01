using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;
using SorteioHab.Domain.Queries;

namespace SorteioHab.Domain.Tests.EntityTests
{
    [TestClass]

    public class ParticipanteQueryTests
    {
        private List<Participante> _participantes;

        public ParticipanteQueryTests()
        {
            _participantes = new List<Participante>();
            _participantes.Add(new Participante("Luiz Felipe", "229.111.111-98", DateTime.Parse("5/10/2007"), decimal.Parse("4200.50"), TipoCota.Geral, ""));
            _participantes.Add(new Participante("Oliver Ricardo Ribeiro", "925.091.645-03", DateTime.Parse("24/03/1980"), decimal.Parse("2000.00"), TipoCota.Geral, ""));
            _participantes.Add(new Participante("Lavínia Mariah Jennifer dos Santos", "843.831.525-97", DateTime.Parse("5/10/2005"), decimal.Parse("3000.00"), TipoCota.PcD, ""));
            _participantes.Add(new Participante("Ana Brenda Esther Ramos", "840.216.806-56", DateTime.Parse("23/08/1982"), decimal.Parse("1000.99"), TipoCota.Geral, "H90"));
            _participantes.Add(new Participante("Severino Igor Mário Barros", "958.617.790-40", DateTime.Today, decimal.Parse("4000.00"), TipoCota.PcD, "H90"));
            _participantes.Add(new Participante("Bruno Levi Dias", "053.246.187-80", DateTime.Parse("13/09/1941"), decimal.Parse("2500.00"), TipoCota.Idoso, ""));
            _participantes.Add(new Participante("Letícia Rita Ferreira", "025.500.928-39", DateTime.Parse("13/03/1956"), decimal.Parse("3675.64"), TipoCota.Idoso, ""));

        }

        [TestMethod]
        public void Deve_retornar_participantes_da_cota_geral_e_validos()
        {
            var result = _participantes.AsQueryable().Where(ParticipanteQueries.GetAllGeral(TipoCota.Geral));
            Assert.AreEqual(1, result.Count());

        }
    }
}