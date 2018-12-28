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

  
        public static List<int> Find(List<int> full, int F)
        {
            List<int> res = new List<int>();
            Queue<int> q = new Queue<int>();
            int bestDiff = int.MaxValue, curSum = 0;
            foreach (int x in full)
            {
                q.Enqueue(x);
                curSum += x;
                if (Math.Abs(F - curSum) < bestDiff)
                {
                    res.Clear();
                    res.AddRange(q);
                    bestDiff = Math.Abs(F - curSum);
                    //no any reasons to continue
                    if (bestDiff == 0) return res;
                }
                //cleaning queue
                while (curSum > F && q.Count > 1)
                {
                    try {
                        curSum -= q.Dequeue();
                        if (Math.Abs(F - curSum) < bestDiff)
                        {
                            res.Clear();
                            res.AddRange(q);
                            bestDiff = Math.Abs(F - curSum);
                            //no any reasons to continue
                            if (bestDiff == 0) return res;
                        }
                    }
                    catch (InvalidOperationException) {break; }
                }
            }
            return res;
        }
    }
}
