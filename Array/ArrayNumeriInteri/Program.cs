// See https://aka.ms/new-console-template for more information
// inserire e visualizzare un elenco di numeri interi
// usare gli array
Console.WriteLine("Hello, World!");



Console.Write("numeri interi da inserire: ");
int n = int.Parse(Console.ReadLine());

//dichiarazione
int[] num = new int[n]; 



//input
for (int i = 0; i < num.Length; i++)
{
    Console.Write("inserisci un numero intero");
    num[i] = int.Parse(Console.ReadLine());
}





//output
Console.WriteLine("Stampa dei valori memorizzati");
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"{i}: {num[i]}\n");
}