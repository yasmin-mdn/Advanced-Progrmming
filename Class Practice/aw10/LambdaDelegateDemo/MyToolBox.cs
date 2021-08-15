using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDelegateDemo
{
    public class MyToolBox : IToolBox
    {
        public IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> source, IToolBox.MapperFunc<T1, T2> func)
        {
            foreach (var v in source)
                yield return func(v);
        }

        public IEnumerable<T1> Filter<T1>(IEnumerable<T1> source, Predicate<T1> predicate)
        {
            foreach (var v in source)
                if (predicate(v))
                    yield return v;
        }

        public IEnumerable<T2> FlatMap<T1, T2>(IEnumerable<IEnumerable<T1>> source, Func<T1, T2> func)
        {
            foreach(var v in source)
            foreach(var t in v)
            yield return func(t);
           
        }

        public IEnumerable<T> Aggregate<T>(IEnumerable<T> source, T seed, Func<T, T, T> func)
        { List<T> tmp = new List<T>();
             for(int i = 0; i < source.Count(); i++)
            {
                if(i == 0)
                    tmp.Add( func(seed, source.ElementAt(i)));
                else
                    tmp.Add(func(tmp.ElementAt(i-1), source.ElementAt(i)));
            }
            foreach(var val in tmp)
                yield return val;
        }


    }
}