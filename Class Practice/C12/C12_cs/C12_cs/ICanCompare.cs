namespace c12cs
{
    internal interface ICanCompare<_Type>
    {
        bool IsGreaterThan(_Type other);
    }
}