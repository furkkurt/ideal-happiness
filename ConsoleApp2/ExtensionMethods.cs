using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T2> Map<T, T2>(this IEnumerable<T> c, Func<T, T2> f)
        {
            List<T2> list = new List<T2>();
            foreach (var i in c)
                list.Add(f(i));

            return list;
        }

        public static void Show<T>(this IEnumerable<T> c)
        {
            foreach (var i in c)
                Console.WriteLine(i);
        }

        public static T Find<T>(this IEnumerable<T> c, Predicate<T> predicate)
        {
            foreach (var i in c)
            {
                if (predicate(i))
                    return i;
            }
            return default(T);
        }

        public static List<T> Filter<T>(this IEnumerable<T> c, Predicate<T> predicate)
        {
            List<T> res = new List<T>();
            foreach (var i in c)
            {
                if (predicate(i))
                    res.Add(i);
            }
            return res;
        }

        public static T2 Reduce<T, T2>(this IEnumerable<T> c, Predicate<T> predicate) {
            foreach (var i in c)
            {
                if (predicate(i))
                {
                    //
                }
            }
            return default(T2);
        }
    }
}
