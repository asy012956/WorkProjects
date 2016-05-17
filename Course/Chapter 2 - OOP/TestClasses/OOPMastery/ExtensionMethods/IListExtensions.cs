using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections; 
using System.Collections.ObjectModel;


namespace OOPMastery.ExtensionMethods
{
    public static class IListExtensions
    {
        public static T Max<T>(this IList<T> list)
            where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new Exception("The list is empty! There is no max element!");
            }

            var max = list[0];

            foreach (var item in list)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            List<T> newList = new List<T>();

            foreach (var item in list)
            {
                if (filter(item))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
