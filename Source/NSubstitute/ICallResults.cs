namespace NSubstitute
{
    public interface ICallResults
    {
        void SetResult<T>(IInvocation invocation, T valueToReturn);
        object GetResult(IInvocation invocation);
    }
}