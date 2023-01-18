Console.WriteLine("Enter number of fares and destination: ");
int n = int.Parse(Console.ReadLine());

double[] fare= new double[n+1];
string[] destination = new string[n+1];
int search= 0;

Console.WriteLine("Enter the fares: ", n);
for (int i = 1;i <= n; i++)
{
    fare[i] = double.Parse(Console.ReadLine());
}



Console.WriteLine("Enter the destinations: ");
for(int i = 1;i <= n; i++)
{
    destination[i] = Console.ReadLine();
}

Console.WriteLine("Enter Index number to search: ");
search = int.Parse(Console.ReadLine());

Console.WriteLine("Fare at index " + search + " is " + fare[search]);

Console.WriteLine("Destination at index " + search + " is " + destination[search]);