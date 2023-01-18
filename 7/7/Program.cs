Console.WriteLine("Enter your Name: ");
var passName = Console.ReadLine();

Console.WriteLine("Enter total miles travelled: ");
double passMiles = double.Parse(Console.ReadLine());

if(passMiles >= 10000 && passMiles < 20000)
{
    Console.WriteLine("Hello " + passName + ", You've been awarded 10 Flyer Miles");
}
else if(passMiles >= 20000 && passMiles < 50000)
{
    Console.WriteLine("Hello " + passName + ", You've been awarded 20 Flyer Miles");
}
else if (passMiles >= 50000 && passMiles < 100000)
{
    Console.WriteLine("Hello " + passName + ", You've been awarded 30 Flyer Miles");
}
else if (passMiles >= 10000)
{
    Console.WriteLine("Hello " + passName + ", You've been awarded 50 Flyer Miles");
}