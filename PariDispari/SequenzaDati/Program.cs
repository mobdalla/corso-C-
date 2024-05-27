// See https://aka.ms/new-console-template for more
// Dati in input giorno , mese , anno
// Restituire uno dei sguenit messagi:
// Erorre| gg/mm/aaaa
using Microsoft.VisualBasic;

Console.WriteLine("----------Sequenza Dati-----------");

Console.WriteLine("inserisci il giorno :");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il mese: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il anno: ");
int y=int.Parse(Console.ReadLine());
string msg = "";
if (d < 1 || d > 31 || m < 1 || m > 12 || y < 1582)
    msg = "Errore";
else if ((m == 4 || m == 6 || m == 9 || m == 11) && d > 31)
    msg = "Errore";
else if (m == 2 && d > 29)
    msg = "Errore";
else if (m==2 && y%100==0 && y%400!=0 && d==29)
        msg = "Errore";
else if (m == 2 && y % 4 != 0 && d == 29)
    msg = "Errore";
else
{        //operatori ternario ?:
    msg = $"" +
       (d < 10 ? "0" : "") + $"{d}:" +
       (m < 10 ? "0" : "") + $"{m}:" +
       (y < 10 ? "0" : "") + $"{y}";
}
Console.WriteLine(msg);