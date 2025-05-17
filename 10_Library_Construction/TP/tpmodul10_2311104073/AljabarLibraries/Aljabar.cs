using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi untuk mencari akar-akar dari persamaan kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
                return new double[] { }; // tidak ada akar real

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);
            return new double[] { akar1, akar2 };
        }

        // Fungsi untuk mendapatkan hasil kuadrat dari persamaan berpangkat 1
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double hasilA = a * a;
            double hasilB = 2 * a * b;
            double hasilC = b * b;

            return new double[] { hasilA, hasilB, hasilC };
        }
    }
}
