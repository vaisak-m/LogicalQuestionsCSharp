
//DateTime passDob = new DateTime();
DateTime[] dobList = new DateTime[2];
DateTime now= DateTime.Now;


for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Enter DoB of Passenger " + (i + 1) + " : ");
    dobList[i] = DateTime.Parse(Console.ReadLine());
}



foreach(DateTime dob in dobList)
{
    int age = now.Year - dob.Year;
    if (age < 10)
    {
        Console.WriteLine("Passenger is a Kid");
    }
    else if (age > 10 && age <= 30)
    {
        Console.WriteLine("Passenger is a Youth");
    }
    else if (age > 30 && age <= 60)
    {
        Console.WriteLine("Passenger is a Adult");
    }
    else if (age > 60)
    {
        Console.WriteLine("Passenger is Older");
    }
}