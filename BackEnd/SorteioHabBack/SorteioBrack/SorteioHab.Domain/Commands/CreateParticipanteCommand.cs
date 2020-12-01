using System;
using Flunt.Notifications;
using Flunt.Validations;
using SorteioHab.Domain.Helpers;
using SorteioHab.Domain.Commands.Contracts;

namespace SorteioHab.Domain.Commands

{
    public class CreateParticipanteCommand : Notifiable, ICommand
    {
        public CreateParticipanteCommand() { }

        public CreateParticipanteCommand(string nome, string cpf, DateTime dt_nascimento, decimal renda, TipoCota cota, string cid)
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

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Nome, 3, "Nome", "Nome Inválido!")
            //.HasLen(CPF, 14, "CPF", "CPF inválido!")
            );
        }
    }
}
