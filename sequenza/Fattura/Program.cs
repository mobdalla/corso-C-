// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

Console.WriteLine("inserisci il imponibile : ");
int Impo=int.Parse(Console.ReadLine());
int ps = 22;
double totiva = Impo * ps / 100;
double ritenuta = Impo * 20 / 100;
double totalenetto = Impo + totiva - ritenuta;

string msg = $"Risultati" +
    $"\nImponibile: {Impo:#.##}" +
    $"\nritenuta d'acconto: {ritenuta:#.##}"+
    $"\nIva   : {totiva:#.##}({ps}%)" +
    $"\ntotale Netto :  {totalenetto:#.##}";

Console.WriteLine(msg);
//Console.WriteLine("Hello, World!");
