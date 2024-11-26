using Bobakk_Doga_20241126;
using System.Linq;

List<varos> varosok = [];

var sr = new StreamReader(@"..\..\..\src\varosok.csv");
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    varosok.Add(new varos(sr.ReadLine()));
}
sr.Close();

//Console.WriteLine( $"{varosok.Count}");

//1. feladat
var f1 = varosok.Where(x => x.orszagNeve == "Kína").Sum(y => y.nepsegMillioFoben);
Console.WriteLine($"{Math.Round(f1,2)} millio fő él Kinai nagyvarosokban.");


//2. feladat
var f2 = varosok.Where(x => x.orszagNeve == "India").Average(y=>y.nepsegMillioFoben);
Console.WriteLine($"{Math.Round(f2, 2)} millio az atlag lelekszam Indiai nagyvarosokban");

//3. feladat
var f3 = varosok.MaxBy(x => x.nepsegMillioFoben);
Console.WriteLine($"{f3.varosNeve} a legnepesebb nagyvaros.");

//4. feladat
var f4 = varosok.Where(x => x.nepsegMillioFoben > 20.00).ToList().OrderByDescending(c => c.nepsegMillioFoben);
foreach (var item in f4)
{
    Console.WriteLine(item);
}


//5. feladat
var f5 = varosok.GroupBy(x => x.orszagNeve).Where(y => y.Count() > 1).Count();
Console.WriteLine($"{f5} orszagban szerepel tobb nagyvarossal is.");


//6. feladat
var f6 = varosok.GroupBy(x => x.varosNeve[0]).MaxBy(y => y.Count());
Console.WriteLine($"{f6.Key} kezdődik a legtöbb nagyváros neve.");

Console.ReadKey();