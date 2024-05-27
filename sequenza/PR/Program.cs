// See https://aka.ms/new-console-template for more information
/*
 * dati in input prezzo , la quantita e la percentuale di sconto di un prodotto
 * calc il tot non scontato , lo sconto effettuato e il tot scontato
 * visualizza tutto
 */



int quantita, pcs;
double prezzo;
Console.Write("inserisci la quantita del prodotto");
string ins = Console.ReadLine();
quantita = int.Parse(ins);
Console.Write("inserisci il costo del prodotto:");
ins = Console.ReadLine();
prezzo = double.Parse(ins);
Console.Write("inserisci percentale di sconto ");
ins = Console.ReadLine();
pcs = int.Parse(ins);
double tot = quantita * prezzo;
double sconto = tot * pcs / 100 ;
double tots = tot - sconto;
string msg = $"Risultati" +
    $"\ntotale: {tot:#.##}" +
    $"\nSconto effettuato  : {sconto:#.##}" +
    $"\ntotale scontato:  {tots:#.##}";

Console.WriteLine(msg);
//Console.WriteLine("Hello, World!");

//
