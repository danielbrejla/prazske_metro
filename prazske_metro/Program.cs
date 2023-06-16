
using prazske_metro;

string[] poleLinkaA = { "nemocnice motol","petřiny","nadr. veleslavin","bořislavka","dejvická","hradčanská","malostranská","můstek","muzeum","nam. míru","jiřího z poděbrad","flora","želivského","strašnická","skalka","depo hostivař" };
string[] poleLinkaB = { "zlučin", "stodůlky", "luka", "lužiny", "hůrka", "nové butovice", "jinovice", "radlická", "smíchovské nadr.", "anděl", "karlovo nam.", "národní třída", "můstek", "nam. republiky", "florenc", "křižikova", "invalidovna", "palmovka", "českomoravská", "vysočanská", "kolbenova", "hloubětín", "rajská zahrada", "černý most" };
string[] poleLinkaC = { "letnany", "prosek", "střížkov", "ládví", "kobylisy", "nadr. holešovice", "vltavská", "florenc", "hlavní nadraží", "muzeum", "i.p pavlova", "vyšehrad", "pražského povstání", "pankrác", "budějovická", "kačerov", "roztyly", "chodov", "opatov", "háje" };
string[] poleLinkaD = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč", "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" };
Console.WriteLine("zadej linku kterou chceš využít");
string volbaLinky = Console.ReadLine();
if (volbaLinky == "A")
{
    LinkaMetra linkaA = new LinkaMetra() { Nazevlinky = "A", barva = "zelená", aktivni = true, stanice = poleLinkaA };
    linkaA.Nastavlinku();
    Console.WriteLine("chcete vypsat všechny stanice nebo první a poslední ");
    string Volba = Console.ReadLine();
    if(Volba== "1")
    {
        linkaA.vypisVsechnyStanice();
    }
    else if (Volba== "2")
    {
        linkaA.VypisPrvniPosledni();
    }
}
if (volbaLinky == "B")
{
    LinkaMetra linkaB = new LinkaMetra() { Nazevlinky = "B", barva = "žlutá", aktivni = true, stanice = poleLinkaB };
    linkaB.Nastavlinku();
    Console.WriteLine("chcete vypsat všechny stanice nebo první a poslední ");
    string Volba = Console.ReadLine();
    if (Volba == "1")
    {
        linkaB.vypisVsechnyStanice();
    }
    else if (Volba == "2")
    {
        linkaB.VypisPrvniPosledni();
    }
}
if (volbaLinky == "C")
{
    LinkaMetra linkaC = new LinkaMetra() { Nazevlinky = "C", barva = "červená", aktivni = true, stanice = poleLinkaC };
    linkaC.Nastavlinku();
    Console.WriteLine("chcete vypsat všechny stanice nebo první a poslední ");
    string Volba = Console.ReadLine();
    if (Volba == "1")
    {
        linkaC.vypisVsechnyStanice();
    }
    else if (Volba == "2")
    {
        linkaC.VypisPrvniPosledni();
    }
}
if (volbaLinky == "D")
{
    LinkaMetra linkaD = new LinkaMetra() { Nazevlinky = "D", barva = "modrá", aktivni = true, stanice = poleLinkaD };
    linkaD.Nastavlinku();
    Console.WriteLine("chcete vypsat všechny stanice nebo první a poslední ");
    string Volba = Console.ReadLine();
    if (Volba == "1")
    {
        linkaD.vypisVsechnyStanice();
    }
    else if (Volba == "2")
    {
        linkaD.VypisPrvniPosledni();
    }
}