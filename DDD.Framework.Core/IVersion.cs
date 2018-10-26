namespace DDD.Framework.Core
{
    public interface IVersion
    {
        int MajorNumber { get; }
        int MinorNumber { get; }
        int PatchNumber { get; }
        string Version { get; }
    }
}