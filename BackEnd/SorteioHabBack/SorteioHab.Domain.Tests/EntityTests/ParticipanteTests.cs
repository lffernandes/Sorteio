using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Tests.EntityTests
{
    [TestClass]
    public class ParticipanteTests
    {
        private readonly Participante _validparticipante = new Participante("Luiz Felipe", "229.111.111-98", DateTime.Parse("01-05-1991"), decimal.Parse("4200.50"), TipoCota.Geral, "");

        [TestMethod]
        public void Dado_um_novo_participante_o_mesmo_nao_pode_ser_salvo()
        {
            Assert.AreEqual(_validparticipante.Cpf.Length, 14);

        }

    }
}