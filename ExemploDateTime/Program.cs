using System;
using System.Globalization;
namespace ExemploDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1); //formato de data/hora extraído do ticks
            Console.WriteLine(d1.Ticks); //qtd de ticks desde o dia 01-jan da era atual
            Console.WriteLine("----------------------------");

            DateTime d2 = new DateTime(2020, 02, 24);
            Console.WriteLine(d2);
            Console.WriteLine("----------------------------");

            DateTime d3 = new DateTime(2020, 02, 24, 13, 30, 03);
            Console.WriteLine(d3);
            Console.WriteLine("----------------------------");

            DateTime d4 = new DateTime(2020, 02, 24, 13, 30, 03, 500);
            Console.WriteLine(d4);
            Console.WriteLine("----------------------------");

            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);
            Console.WriteLine("----------------------------");

            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);
            Console.WriteLine("----------------------------");

            DateTime d7 = DateTime.UtcNow; //considera com horário GMT
            Console.WriteLine(d7);
            Console.WriteLine("----------------------------");

            //usando parse padrao usado normalmente em banco de dados
            DateTime d8 = DateTime.Parse("2020-02-24"); 
            Console.WriteLine(d8);
            Console.WriteLine("----------------------------");

            //usando parse padrao usado normalmente em banco de dados com data/hora
            DateTime d9 = DateTime.Parse("2020-02-24 13:40:08");
            Console.WriteLine(d9);
            Console.WriteLine("----------------------------");

            //usando parse utilizanco formato BR para datas
            DateTime d10 = DateTime.Parse("24/02/2020");
            Console.WriteLine(d10);
            Console.WriteLine("----------------------------");

            //usando parse utilizanco formato BR para datas com data/hora
            DateTime d11 = DateTime.Parse("24/02/2020 13:41:20");
            Console.WriteLine(d11);
            Console.WriteLine("----------------------------");

            //usando parse usando mascara de dada
            DateTime d12 = DateTime.ParseExact("2020-02-24","yyyy-mm-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);
            Console.WriteLine("----------------------------");

            //usando parse usando mascara de dada/hora
            DateTime d13 = DateTime.ParseExact("24/02/2020 13:45:40", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d13);
            Console.WriteLine("----------------------------");

        }
    }
}
