// See https://aka.ms/new-console-template for more information
// Generare un array di numeri interi casuali a dimensione con le seguenti ipotesi
//riempimento  dell'array :[inf,sup]
// dimensione dell'array: [inf1,sup1]
// 1.posizione
using System.Text.RegularExpressions;
using System.Xml.Schema;

Console.WriteLine("Hello, World!");
Random r = new Random();
void StampaArray(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        Console.WriteLine($"{i}:{x[i]}");
    }
}
bool IsPrimo(int num)
{   if (num <=1)
    { return false; }
    for(int i = 0; i < num; i++)
    {
        if(num % i == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

Console.WriteLine("inserisci il range del array  :");
int n= int.Parse(Console.ReadLine());
int n2 =int.Parse(Console.ReadLine());


Console.WriteLine("inserisci il range del array  :");
int n1 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int dim = r.Next(n, n2);
int[] a = new int[dim];

for (int i = 0; i < a.Length ; i++)
{ 
    int b1 = r.Next(n1, n3);
    a[i] = b1;
}
Console.WriteLine("Array di numeri casuali generato");
String msg = "Scegli una tra le seguenti operazioni" +
    "1.posizione e valore dei numeri multipli di mn con m dato in input" +
    "2." +
    "3." +
    "0." +
    "\n\n la scelta >";
int sc;
do
{
    Console.WriteLine(msg);
    sc = int.Parse(Console.ReadLine());
    switch (sc)
    {
        case 1:
            {
                Console.Write("inseisci il valore di cui cercare i multitipli:");
                int m = int.Parse(Console.ReadLine());
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % m == 0)
                    {
                        Console.WriteLine($"{i}: {a[i]}");
                    }
                }
            }
            break;
        case 2:
            {
                Console.WriteLine($"\n Stampa dei numeri primi generati:");
                for (int i = 0; i < a.Length; i++)
                {
                    if (IsPrimo(a[i]))
                        Console.WriteLine($"{i}: {a[i]}");
                }
            }
            break;
        case 3: 
            break;
        case 4: 
            StampaArray(a);
            break;
        default:
            break;
    }
} while (sc != 0);

