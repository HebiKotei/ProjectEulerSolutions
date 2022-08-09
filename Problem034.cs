using System;
using System.IO;

namespace ProjectEuler {
    class Solution {
        private static readonly int[] fac = Enumerable.Range(0,10).Select(Fac).ToArray();
        private static readonly int max = fac[9] * 7;
        
        public static int Fac(int n) {
            int fac = 1;
            for (int i = 1; i <= n; i++ ) {
                fac *= i;
            }
            return fac;
        }

        public static IEnumerable<int> Digits(int n) {
            while (n > 0) {
                yield return n % 10;
                n /= 10;
            }
        }

        public static bool IsCuriousNo(int n) {
            return n == Digits(n).Select(i => fac[i]).Sum();
        }
        
        public static void Main(string[] args) {
            int sum = 0;
            for (int i = 4; i <= max; i++) {
                if (IsCuriousNo(i)) { sum += i; }
            }

            Console.WriteLine(sum);
        }
    }
}
