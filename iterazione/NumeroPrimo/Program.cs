// verificare se un numero intero è un numero primo

Console.Write("Inserisci un numero");
int n =int.Parse(Console.ReadLine());


//uso del ciclo For
bool ePrimo = true;
for (int i = 2; i < n; i++)
    if (n % i == 0) { 
        ePrimo = false;
           break;
    }
if (ePrimo)

    Console.WriteLine($"{n} numero e primo");
else
    Console.WriteLine($"{n} numero non primo");
