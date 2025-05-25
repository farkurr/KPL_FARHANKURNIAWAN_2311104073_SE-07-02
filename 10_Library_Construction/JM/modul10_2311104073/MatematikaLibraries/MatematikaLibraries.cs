using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * (derajat - i);
                int pangkat = derajat - i - 1;

                if (koef == 0) continue;

                if (result.Length > 0 && koef > 0) result.Append(" + ");
                else if (koef < 0) result.Append(" - ");

                result.Append(Math.Abs(koef));
                if (pangkat > 0) result.Append("x");
                if (pangkat > 1) result.Append(pangkat);
            }

            return result.ToString();
        }

        public string Integral(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkatBaru = derajat - i + 1;
                double koef = (double)persamaan[i] / pangkatBaru


                if (koef == 0) continue;

                if (result.Length > 0 && koef > 0) result.Append(" + ");
                else if (koef < 0) result.Append(" - ");

                result.Append(Math.Abs(koef));
                if (pangkatBaru > 0) result.Append("x");
                if (pangkatBaru > 1) result.Append(pangkatBaru);
            }

            result.Append(" + C");
            return result.ToString();
        }
    }
}
