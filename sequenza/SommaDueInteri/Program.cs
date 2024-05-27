//somma di due numeri interi dati in input

//input
//operazione da eseguire
//output
Console.WriteLine("somma di  due numeri interi  a, b:");
int a, b;
Console.Write("inserisci un a:");
string tmp=Console.ReadLine(); //"9"
a =  int.Parse(tmp);
Console.WriteLine("inserisci un b:");
tmp = Console.ReadLine(); //"9"
b = int.Parse(tmp);

int somma = a + b;


Console.WriteLine("Somma: " + somma);
Console.WriteLine("Somma: {0}", somma);
Console.WriteLine(a + "" + b + "=" + somma);
Console.WriteLine("{0}+{1}={2}", a, b,somma);
Console.WriteLine($"{a}+{b}={somma}");
//Console.WriteLine("Hello, World!");
