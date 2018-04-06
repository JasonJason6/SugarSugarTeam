using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace SeanStandardScript
{
    public static class SeanListHelpers
    {
        public static T RandomElement<T>(this IList<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        public static T RandomElement<T>(this IList<T> list, AnimationCurve cdfCurve)
        {
            return list[MathSean.CDFRandomIndex(cdfCurve, list.Count)];
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<T> CombineLists<T>(params List<T>[] lists)
        {
            var list = new List<T>();
            foreach (List<T> t in lists)
            {
                list.AddRange(t);
            }
            return list;
        }
    }
}