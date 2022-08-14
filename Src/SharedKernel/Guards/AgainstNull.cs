namespace SharedKernel.Guards;

public static partial class Guard
{
    public static void AgainstNull(object argument, string argumentName)
    {
        if (argument == null)
        {
            throw new ArgumentNullException(argumentName);
        }
    }
}