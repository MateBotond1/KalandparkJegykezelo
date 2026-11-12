using KalandparkJegykezelo;
List<Jegyvasarlas> adatok=new List<Jegyvasarlas>();
foreach(string sor in File.ReadAllLines("jegyek.txt"))
{
    adatok.Add(new Jegyvasarlas(sor));
}
