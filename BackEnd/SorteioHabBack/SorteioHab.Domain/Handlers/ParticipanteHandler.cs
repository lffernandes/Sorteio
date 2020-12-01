using Flunt.Notifications;
using SorteioHab.Domain.Commands;
using SorteioHab.Domain.Commands.Contracts;
using SorteioHab.Domain.Entities;
using SorteioHab.Domain.Repositories;
using SorteioHab.Domain.Handlers.Contracts;
using System;
using SorteioHab.Domain.Helpers;

namespace SorteioHab.Domain.Handlers
{
    public class ParticipanteHandler :
        Notifiable,
        IHandler<CreateParticipanteCommand>
    {
        private readonly ISorteioRepository _repository;

        public ParticipanteHandler(ISorteioRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateParticipanteCommand command)
        {
            //Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que O seu participante está inválido.", command.Notifications);
            //Gerar o Participante
            var participante = new Participante(command.Nome, command.Cpf, command.Dt_nascimento, command.Renda, command.Cota, command.Cid); 

            //Salva no banco
            _repository.Create(participante);

            return new GenericCommandResult(true, "Participante salvo", participante);
        }
    }
}