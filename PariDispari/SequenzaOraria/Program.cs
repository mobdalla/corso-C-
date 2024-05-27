// See https://aka.ms/new-console-template for more
// dati input ora , minuti e secondi
// restituire  output uno dei seguenti messaggi
// Errore | hh:mm:ss
//Console.WriteLine("Hello, World!");

Console.Write("Sequenza oraria");
Console.Write("inserisci la ora :");
int h =int.Parse(Console.ReadLine());
Console.Write("inserisci i minuti :");
int M=int.Parse(Console.ReadLine());
Console.Write("inserisci i secondi: ");
int Sec = int.Parse(Console.ReadLine());

string msg="";
// controllo
if (h > 23 || h < 0 || M > 59 || M < 0 || Sec > 59 || Sec < 0)
    Console.WriteLine("Errore");
else
{        //operatori ternario ?:
         msg = $"" +
            (h < 10 ? "0" : "") + $"{h}:" +
            (M < 10 ? "0" : "") + $"{M}:" +
            (Sec < 10 ? "0" : "") + $"{Sec}";
}
Console.WriteLine(msg);