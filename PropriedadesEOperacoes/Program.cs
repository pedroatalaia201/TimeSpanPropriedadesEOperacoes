using System;

namespace PropriedadesEOperacoes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("TimeSpan: Propriedades & Operações\n");

            Console.WriteLine("Propriedades:");
            TimeSpan t1 = TimeSpan.MaxValue;//Maior valor possivel;
            TimeSpan t2 = TimeSpan.MinValue;//Menor valor possivel(é negativo);
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3 + "\n\n");


            Console.WriteLine("Operações:");
            TimeSpan time = new TimeSpan(2, 3, 5, 7, 11);

            //numeros inteiros
            Console.WriteLine("Days: " + time.Days);
            Console.WriteLine("Hours: " + time.Hours);
            Console.WriteLine("Minutes: " + time.Minutes);
            Console.WriteLine("Seconds: " + time.Seconds);
            Console.WriteLine("Milleseconds: " + time.Milliseconds);
            Console.WriteLine("Ticks: " + time.Ticks);

            //numeros fracionados
            Console.WriteLine("\nTotal Days: " + time.TotalDays);
            Console.WriteLine("Total Hours: " + time.TotalHours);
            Console.WriteLine("Total Minutes: " + time.TotalMinutes);
            Console.WriteLine("Total Seconds: " + time.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + time.TotalMilliseconds);

            Console.WriteLine("\nAdição, subtração, divisão, multiplicação:");

            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts1.Add(ts2);
            TimeSpan dif = ts1.Subtract(ts2);
            TimeSpan mult = ts2.Multiply(2.0);
            TimeSpan div = ts2.Divide(2.0);

            Console.WriteLine(ts1); 
            Console.WriteLine(ts2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
