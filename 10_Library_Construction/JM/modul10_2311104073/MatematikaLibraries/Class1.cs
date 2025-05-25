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

        public string Turunan(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int n = koefisien.Length - 1;
            for (int i = 0; i < n; i++)
            {
                int pangkat = n - i;
                int koef = koefisien[i] * pangkat;
                if (koef == 0) continue;

                if (hasil.Length > 0 && koef > 0)
                    hasil.Append(" + ");
                else if (koef < 0)
                    hasil.Append(" - ");

                hasil.Append(Math.Abs(koef));
                if (pangkat - 1 > 0)
                {
                    hasil.Append("x");
                    if (pangkat - 1 > 1)
                        hasil.Append(pangkat - 1);
                }
            }
            return hasil.ToString();
        }

        public string Integral(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int n = koefisien.Length;
            for (int i = 0; i < n; i++)
            {
                int pangkat = n - i - 1;
                double koef = (double)koefisien[i] / (pangkat + 1);

                if (koef == 0) continue;

                if (hasil.Length > 0 && koef > 0)
                    hasil.Append(" + ");
                else if (koef < 0)
                    hasil.Append(" - ");

                hasil.Append(Math.Abs(koef));
                hasil.Append("x");
                if (pangkat + 1 > 1)
                    hasil.Append(pangkat + 1);
            }
            hasil.Append(" + C");
            return hasil.ToString();
        }
    }
}
