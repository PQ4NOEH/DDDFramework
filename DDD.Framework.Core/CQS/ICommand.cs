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
}
