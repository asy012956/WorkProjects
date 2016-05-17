using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OOPMastery.ExtensionMethods
{
    public static class MListExtensionMethods
    {
        public static T Max<T>(this MList<T> list)
            where T : IComparable<T>
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }

        public static T Max<T>(this MList<T> list, Predicate<T> condition)
            where T : IComparable<T>
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            MList<T> newList = new MList<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (condition(list[i]) == true)
                {
                    newList.Add(list[i]);
                }
            }

            T max = newList[0];
            for (int i = 1; i < newList.Count; i++)
            {
                if (newList[i].CompareTo(max) > 0)
                {
                    max = newList[i];
                }
            }

            return max;
        }

        public static T Min<T>(this MList<T> list)
            where T : IComparable<T>
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            T min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public static T First<T>(this MList<T> list, Predicate<T> condition)
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (condition(list[i]) == true)
                {
                    result = i;
                    break;
                }
            }

            return list[result];
        }

        public static T Last<T> (this MList<T> list, Predicate<T> condition)
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            int result = 0;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (condition(list[i]) == true)
                {
                    result = i;
                    break;
                }
            }

            return list[result];
        }

        public static IEnumerable<T> Where<T> (this MList<T> list, Predicate<T> condition)
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            List<T> results = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (condition(list[i]) == true)
                {
                    results.Add(list[i]);
                }
            }

            return results;
        }

        public static T Position<T>(this MList<T> list, Func<T, int, bool> function)
        {
            if (list.Count <= 0)
            {
                throw new Exception("Empty list!");
            }

            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (function(list[i], i) == true)
                {
                    index = i;
                    break;
                }
            }

            return list[index];
        }
    }
}
