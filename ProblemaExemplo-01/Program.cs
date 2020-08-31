using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ProblemaExemplo_01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("PROBLEMA EXEMPLO 01");

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CI);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine();

            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CI)}");
        }
    }
}
