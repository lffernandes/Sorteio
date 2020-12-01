using SorteioHab.Domain.Commands.Contracts;

namespace SorteioHab.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}