int even = 0, odd = 1;
double fare;
Console.WriteLine("Enter total fares: ");
var total = int.Parse(Console.ReadLine());

double[] arrFare = new double[total*2]; 
for (int i = 0; i < total; i++)
{
    Console.WriteLine("Enter Fare: ", i + 1);
    fare = double.Parse(Console.ReadLine());
    if(fare % 2 == 0)
    {
        arrFare[even] = fare;
         even += 2;
    }
    else
    {
        arrFare[odd] = fare;
        odd += 2;
    }
}

foreach(var arr in arrFare)
{
    Console.WriteLine("Order of Fares is : " + arr);
}