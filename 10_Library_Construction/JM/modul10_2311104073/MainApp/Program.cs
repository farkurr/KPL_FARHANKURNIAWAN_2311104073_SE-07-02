using System;
using MatematikaLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("FPB dari 60 dan 45: " + mtk.FPB(60, 45));
            Console.WriteLine("KPK dari 12 dan 8: " + mtk.KPK(12, 8));

            int[] turunanInput = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan dari x^3 + 4x^2 - 12x + 9: " + mtk.Turunan(turunanInput));

            int[] integralInput = { 4, 6, -12, 9 };
            Console.WriteLine("Integral dari 4x^3 + 6x^2 - 12x + 9: " + mtk.Integral(integralInput));

            Console.ReadLine();
        }
    }
}
