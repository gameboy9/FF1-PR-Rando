using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Common
{
	static class Common
	{
        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static bool AreAnyDuplicates<T>(this IEnumerable<T> list)
        {
            var hashset = new HashSet<T>();
            return list.Any(e => !hashset.Add(e));
        }

        public static double statAdjust(Random r1, double minimum, double middle, double maximum, int numRolls)
        {
            if (minimum == middle && middle == maximum) return middle;

            int direction = (minimum == middle) ? 1 : (maximum == middle) ? 0 : r1.Next() % 2;

            long sumRolls = 0;
            // Each "roll" will be from 0 to 2^32-1.  Think of it as a d(2^32)
            for (int i = 0; i < numRolls; i++)
                sumRolls += r1.Next();
            long avgRolls = sumRolls / numRolls;

            if (direction == 0)
                return middle - ((middle - minimum) * ((double)Math.Abs(avgRolls - (int.MaxValue / 2)) / (int.MaxValue / 2)));
            else
                return middle + ((maximum - middle) * ((double)Math.Abs(avgRolls - (int.MaxValue / 2)) / (int.MaxValue / 2)));
        }

        public static int range(int value, int min = int.MinValue, int max = int.MaxValue)
		{
            if (min > max) throw new Exception("min is higher than max");
            if (value < min) return min;
            if (value > max) return max;
            return value;
		}
    }
}
