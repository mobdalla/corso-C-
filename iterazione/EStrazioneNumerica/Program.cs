// See https://aka.ms/new-console-template for more information
// numeri casuali  [1,90] , non ordinati
// nota non si possono usare gli array

Console.WriteLine("Estrazione");

Random random = new Random();

int n1, n2, n3, n5;

int n =random.Next(0,90)+1;

do
{
    n1 = random.Next(90) + 1;
} while (n ==n1);
do
{
    n2 = random.Next(90) + 1;
} while (n2 ==n1 || n2 == n );
do
{
    n3 = random.Next(90) + 1;
} while (n3 == n1 || n3 == n2 || n3 ==n);
do
{
    n5 = random.Next(90) + 1;
} while (n5 == n1 || n5 == n2 || n5 == n || n5 == n3);

Console.WriteLine($"{n},{n1},{n2},{n3},{n5}");