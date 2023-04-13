DateTime cas = DateTime.Now;
int CisloMesice = cas.Month;
string[] mesíce = { "Leden", "Unor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Záři", "Řijen", "Listopad", "Prosinec" };
Console.WriteLine(cas);
foreach (string s in mesíce)
{
    Console.WriteLine(s);
}
int kdy = Convert.ToInt32(Console.ReadLine());

if (kdy == 12)
{
    Console.WriteLine($"Tento měsíc je {mesíce[12]}\nMinulý měsíc byl {mesíce[11]}\nNadcházející měsíc je {mesíce[12]}");
}
else if (kdy == 12)
{
    Console.WriteLine($"Tento měsíc je {mesíce[11]}\nMinulý měsíc byl {mesíce[10]}\nNadcházející měsíc je {mesíce[11]}");
}
else
{
    Console.WriteLine($"Tento měsíc je {mesíce[kdy - 2]}\nMinulý měsíc byl {mesíce[kdy - 1]}\nNadcházející měsíc je {mesíce[kdy]}");
}