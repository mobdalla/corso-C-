// See https://aka.ms/new-console-template for more information

/* in supermercato 
 * costo e qty
 * il totale da pagare
 */

int  quantita;
double prezzo;
Console.Write("inserisci la quantita del prodotto");
string ins = Console.ReadLine();
quantita = int.Parse(ins);
Console.Write("inserisci il costo del prodotto:");
ins = Console.ReadLine();
prezzo = double.Parse(ins);


double tot = quantita * prezzo;
Console.WriteLine($" il quantita : {quantita} il prezzo :{prezzo}  il totale = {tot} ");



//Console.WriteLine("Hello, World!");
