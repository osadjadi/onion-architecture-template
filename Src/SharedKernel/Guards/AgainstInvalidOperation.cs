namespace SharedKernel.Guards;

public static partial class Guard
{
    public static void AgainstInvalidOperation(object operationResult, string entityName, string operationTitle)
    {
        if (operationResult == null)
        {
            throw new InvalidOperationException($"Error {operationTitle} {entityName}");
        }
    }
}