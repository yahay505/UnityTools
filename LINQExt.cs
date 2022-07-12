using System;
using System.Collections.Generic;

namespace UnityTools
{
    public static class LINQExt
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        public static IEnumerable<TOut> Times<TOut>(this int count, Func<int, TOut> generator)
        {
            for (int i = 0; i < count; i++)
            {
                yield return generator(i);
            }
        }
        public static IEnumerable<TOut> Times<TOut>(this int count, Func<TOut> generator)
        {
            for (int i = 0; i < count; i++)
            {
                yield return generator();
            }
        }
    }
}