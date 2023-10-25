using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static List<Bolygo> bolygok = new();
        static void Main(string[] args)
        {

            using StreamReader sr = new StreamReader(@"..\..\..\src\solsys.txt",encoding: Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerünkben");

            Console.WriteLine($"3.2: a naprendszerben a bolygóknak átlagosan {bolygok.Average(k=>k.HoldakSzama)} holdja van");

            var f3 = bolygok.MaxBy(k => k.TerfogatArany);
            Console.WriteLine($"3.3 a legnagyobb térfogatú bolygó a {f3.Nev}");

            Console.Write("3.4 Írd be a keresett bolygó nevét: ");
            string be = Console.ReadLine();
            bool van = bolygok.Any(k => k.Nev.ToLower() == be.ToLower());
            Console.WriteLine($"\t{(van?"van":"sajnos nincs")} ilyen bolygó a naprendszerven");

            Console.Write("3.5: Írj be egy egész számot: "  );
            int szam = Convert.ToInt32(Console.ReadLine());
            var f5 = bolygok.Where(k => k.HoldakSzama > szam);

            Console.WriteLine($" \t A következő bolgygóknak van {szam}-nál/nél több holdja:");
            Console.Write("\t");
            foreach (var item in f5)
            {
                Console.Write($"{item.Nev} ");
            }



        }
    }
}