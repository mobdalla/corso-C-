/*
 * Dati in input 2 numeri interi,
 * calcolare il quoziente intero,
 * il resto e il quozinete reale
 * 
 * visualizzare i risultati
 */
//input 
Console.WriteLine("somma di  due numeri interi  a, b:");
int a, b;
Console.Write("inserisci un a:");
string tmp = Console.ReadLine(); //"9"
a = int.Parse(tmp);
Console.WriteLine("inserisci un b:");
tmp = Console.ReadLine(); //"9"
b = int.Parse(tmp);

//eseguere operazione
int quozieneti_reale = a / b;
int resto = a % b;
double qr = (double)a / b;
/*Console.WriteLine("il quozienti e " + quozieneti_reale);
Console.WriteLine("il resto e " + resto);
Console.WriteLine("il resto e " + qr);*/
//Console.WriteLine("Hello, World!");
string msg = $"Risultati" +
    $"\nQuoziente intero: {quozieneti_reale}" +
    $"\nResto : {resto}" +
    $"\nQuoziente reale:  {qr}";

Console.WriteLine(msg); 