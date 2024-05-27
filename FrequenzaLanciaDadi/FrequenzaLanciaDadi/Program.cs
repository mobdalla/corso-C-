// See https://aka.ms/new-console-template for more information
// calcolare la frequenza delle uscite (in percentuale)
// Non usa gli array
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Random random = new Random();
int n;
do
{
    Console.Write("inserisci numero di lanci");
    n = int.Parse(Console.ReadLine());
    if (n <= 0)
        Console.WriteLine("Dato inserito non corretto");
} while (n <= 0);

int l, ls=0,lsw=0,ms=0,msa=0,Ss=0, Ms=0;
for (int i = 0;i< n; i++)
{
    l = random.Next(0, 6) + 1;
    if (l == 1)
        ls++;
    else if (l == 2)
        lsw++;
    else if (l == 3)
        ms += 1;
    else if (l == 4)
        msa += 1;
    else if (l == 5)
        Ms +=1;
    else
        Ss +=1;
}
string msg = "";
msg = $"" +
    $"la percentuale 1 > {(double)ls * 100 / n:0.##} %\n" +
    $"la percentuale 2 > {(double)lsw * 100 / n:0.##} %\n" +
    $"la percentuale 3 > {(double)ms * 100 / n:0.##} %\n" +
    $"la percentuale 4 > {(double)msa * 100 / n:0.##} %\n" +
    $"la percentuale 5 > {(double)Ms * 100 / n:0.##} %\n" +
    $"la percentuale 6 > {(double)Ss * 100 / n:0.##} %\n";
Console.WriteLine(msg);
