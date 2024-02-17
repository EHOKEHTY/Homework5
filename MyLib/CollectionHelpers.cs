using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    static public class CollectionHelpers
    {
        public static IEnumerable<TSource> MySkip<TSource>(this IEnumerable<TSource> source, int count)
        {
            int index = 0;
            foreach (TSource item in source)
            {
                if (index >= count)
                {
                    yield return item;
                }
                index++;
            }
        }
        
        public static IEnumerable<TSource> MySkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            bool skipping = true;
            foreach (TSource item in source)
            {
                if (!skipping || !predicate(item))
                {
                    skipping = false;
                    yield return item;
                }
            }
        }

        public static IEnumerable<TSource> MyTake<TSource>(this IEnumerable<TSource> source, int count)
        {
            int index = 0;
            foreach (TSource item in source)
            {
                if (index >= count)
                {
                    yield break;
                }
                yield return item;
                index++;
            }
        }

        public static IEnumerable<TSource> MyTakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (!predicate(item))
                {
                    yield break;
                }
                yield return item;
            }
        }

        public static TSource MyFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            throw new InvalidOperationException("Sequence contains no matching element");
        }

        public static TSource MyFirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(TSource);
        }

        public static TSource MyLast<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            TSource lastMatch = default(TSource);
            bool found = false;
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    lastMatch = item;
                    found = true;
                }
            }
            if (!found)
            {
                throw new InvalidOperationException("Sequence contains no matching element");
            }
            return lastMatch;
        }

        public static TSource MyLastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            TSource lastMatch = default(TSource);
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    lastMatch = item;
                }
            }
            return lastMatch;
        }

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (TSource item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TResult> MySelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            foreach (TSource item in source)
            {
                foreach (TResult subItem in selector(item))
                {
                    yield return subItem;
                }
            }
        }

        public static bool MyAll<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool MyAny<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
