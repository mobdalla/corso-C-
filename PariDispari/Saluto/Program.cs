// Visualizzare uno dei seguenti messaggi:
// Buongiorno, Buon pomeriggio, Buona sera Buona notte 
//6-14, 14 -18,18-22 , 22-6 
using Microsoft.VisualBasic;

//input dati
Console.Write("INserisci la componente ora: ");
int n = int.Parse(Console.ReadLine());

//controllo
if (n < 0 || n > 23)
    Console.WriteLine("Errore");
else if (n >= 6 && n < 14)
    Console.WriteLine("Buongiorno");
else if (n >= 14 && n < 18)
    Console.WriteLine("Buon Pomeriggio");
else if (n >= 18 && n < 22)
    Console.WriteLine("Buona sera");
else 
    Console.WriteLine("Buona notte");