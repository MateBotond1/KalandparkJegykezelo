using KalandparkJegykezelo;
List<Jegyvasarlas> adatok=new List<Jegyvasarlas>();
foreach(string sor in File.ReadAllLines("jegyek.txt"))
{
    adatok.Add(new Jegyvasarlas(sor));
}
Console.WriteLine("Napi jegyvásárlások:");
foreach (Jegyvasarlas aktualis in adatok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("");
Console.WriteLine("Statisztika: ");
Console.WriteLine($"Kalandpark teljes napi bevétele: {adatok.Sum(x => x.FizetendoOsszeg())} Ft");
Jegyvasarlas legjobb = adatok.MaxBy(x => x.FizetendoOsszeg());
Console.WriteLine($"Legtöbbet fizető látogató: {legjobb.LatogatoNev} ({legjobb.FizetendoOsszeg()} Ft)");