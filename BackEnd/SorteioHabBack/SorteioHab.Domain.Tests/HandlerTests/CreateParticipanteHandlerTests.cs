
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SorteioHab.Domain.Commands;
using SorteioHab.Domain.Handlers;
using SorteioHab.Domain.Helpers;
using Todo.Domain.Tests.Repositories;

namespace SorteioHab.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateParticipanteHandlerTests
    {
        private readonly CreateParticipanteCommand _invalidCommand = new CreateParticipanteCommand(" ", " ", DateTime.Today, decimal.Parse("4200.50"), TipoCota.Geral, " ");
        private readonly CreateParticipanteCommand _validCommand = new CreateParticipanteCommand("Luiz Felipe", "229.111.111-98", DateTime.Today, decimal.Parse("4200.50"), TipoCota.Geral, "");
        private readonly ParticipanteHandler _handler = new ParticipanteHandler(new FakeSorteioRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_o_participante()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
