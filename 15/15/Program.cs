using System.Globalization;

Console.WriteLine("Enter Number of passengers: " );
int passengers = int.Parse( Console.ReadLine() );

double[] weights = new double[passengers]; 

for ( int i = 0;i < passengers; i++)
{
    Console.WriteLine("Enter Baggage Weights "  + (i + 1) + " :");
    weights[i] = double.Parse(Console.ReadLine());
}

foreach(var weight in weights)
{
    if(weight <= 23)
    {
        Console.WriteLine("No Excess Baggage");
    }
    else if(weight > 23)
    {
        Console.WriteLine( " Excess Baggage Found. You will be charged " + ((weight - 23) * 15) + " Dollars");
    }
}

for (int i = 0; i < passengers; i++)
{
    for (int j = i + 1; j < passengers; j++)
    {
        if (weights[i] > weights[j])
        {
            double sort = weights[i];
            weights[i] = weights[j];
            weights[j] = sort;
        }
    }
}

foreach(var weight in weights)
{
    Console.WriteLine("Weights are: " + weight);
}