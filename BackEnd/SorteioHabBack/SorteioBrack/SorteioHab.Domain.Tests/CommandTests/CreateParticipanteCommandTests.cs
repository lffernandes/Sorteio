using System;
using Flunt.Notifications;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SorteioHab.Domain.Commands;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateParticipanteCommandTests
    {
        private readonly CreateParticipanteCommand _invalidCommand = new CreateParticipanteCommand(" ", " ", DateTime.Today, decimal.Parse("4200.50"), TipoCota.Geral, " ");
        private readonly CreateParticipanteCommand _validCommand = new CreateParticipanteCommand("Luiz Felipe", "229.111.111-98", DateTime.Today, decimal.Parse("4200.50"), TipoCota.Geral, "");

        public CreateParticipanteCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }
        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
