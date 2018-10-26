using System;

namespace DDD.Framework.Core.CQS
{
    public interface ICommand
    {
        string Id { get; }
        IVersion Version { get; }
        IUser RequestedBy { get; }
        DateTime RequestedOn { get; }
        DateTime CommitedOn { get; }
        string Name { get; }
    }

    public interface ICommand<T> : ICommand
    {
        T Payload { get; }
    }

    public class BaseCommand: ICommand
    {
        public string Id { get; set; }
        public IVersion Version { get; set; }
        public IUser RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime CommitedOn { get; set; }
        public string Name { get; set; }
    }

    public class BaseCommand<T>: BaseCommand, ICommand<T>
    {
        public T Payload { get; set; }
    }
}
