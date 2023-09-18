public static class Extensions
{
    public static Func<T, TReturn2> Compose<T, TReturn1, TReturn2>(this Func<T, TReturn1> func1, Func<TReturn1, TReturn2> func2)
    {
        return x => func2(func1(x));
    }
}
