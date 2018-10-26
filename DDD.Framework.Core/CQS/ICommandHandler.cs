namespace DDD.Framework.Core.CQS
{
    public interface ICommandHandler<TCommand,TEvent> 
        where TCommand : ICommand
        where TEvent: IEvent
    {
        ICommandDomainResult<TEvent> Handle(TCommand command);
    }
}
