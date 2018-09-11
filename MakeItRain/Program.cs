using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace MakeItRain
{
    public static class Program
    {
        private const string Space = "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ";

        public static void Main(string[] args)
        {
            if (args.Length > 0 && (args[0] == "-help" || args[0] == "--help" || args[0] == "/?" || args[0] == "-h"))
            {
                Console.WriteLine("Usage: makeitrain [duration] [num of drops] [delay] [ending text]");
                return;
            }
            var v = args.Length > 0 ? int.Parse(args[0]) : 5;
            var d = args.Length > 1 ? int.Parse(args[1]) : 100;
            var w = args.Length > 2 ? int.Parse(args[2]) : 1;
            var s = args.Length > 3 ? args[3] : "Make it rain!";
            MakeItRain(v, d, w, s);
        }

        private static void MakeItRain(int v, int d, int w, string s)
        {

            const char c = '/';
            var r = new Random();
            for(var i=0;i<v;i++)
            {
                for(var j=0;j<d;j++)
                    Console.WriteLine(" ".Repeat(r.Next(163))+c);

                Thread.Sleep(w*1000);
                Console.Clear();
            }


            Console.WriteLine(Space + s);
        }

        public static string Repeat(this string s, int n)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
                sb.Append(s);
            return sb.ToString();
        }
    }
}