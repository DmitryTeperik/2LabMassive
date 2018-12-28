using System;
using System.Collections.Generic;

namespace CA1
{
    class Help
    {
        /// <summary>
        /// Splitting string and converting it to list of int numbers.
        /// </summary>
        /// <param name="resourse">Input string</param>
        /// <returns></returns>
        public static List<int> StringToIntList(string resourse)
        {
            List<int> list = new List<int>();
            foreach (var num in resourse.Split(' '))
            {
                if (int.TryParse(num, out int tmp))
                    list.Add(tmp);
            }
            return list;
        }


        /// <summary>
        /// Core function.
        /// </summary>
        /// <param name="full">Input list</param>
        /// <param name="F">F</param>
        /// <returns></returns>
        public static List<int> Find(List<int> full, int F)
        {
            const int INIT_SUM = 0, INIT_DIFF = 0;
            List<int> res = new List<int>();
            int bestdiff = int.MaxValue, sum = INIT_SUM, diff = INIT_DIFF;
            for (int i = 0; i < full.Count; i++)
            {
                sum = 0;
                for (int j = i; j < full.Count; j++)
                {
                    sum += full[j];
                    diff = Math.Abs(sum - F);
                    if (diff < bestdiff)
                    {
                        res.Clear();
                        res.AddRange(full.GetRange(i, j - i + 1));
                        bestdiff = diff;
                        if (bestdiff == 0) return res;
                    }
                }
            }
            return res;
        }
    }
}
