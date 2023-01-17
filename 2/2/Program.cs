Console.WriteLine("Enter the Flight Fare");
int fare = Convert.ToInt32(Console.ReadLine());

TimeOnly bookingTime;
Console.WriteLine("Enter booking time");
TimeOnly.TryParse(Console.ReadLine(), out bookingTime) ;

int hours = bookingTime.Hour;

if (hours >= 6 && hours < 9){
    Console.WriteLine("Your Booking timd is: " + bookingTime);
    Console.WriteLine("Your Fare for the Flight is " +(fare*1.1));
}

else if (hours >= 9 && hours < 17)
{
    Console.WriteLine("Your Booking timd is: " + bookingTime);
    Console.WriteLine("Your Fare for the Flight is " + (fare * 1.2));
}

else if (hours >= 17 && hours < 23)
{
    Console.WriteLine("Your Booking timd is: " + bookingTime);
    Console.WriteLine("Your Fare for the Flight is " + (fare * 1.07));
}

else if (hours >= 23 && hours < 6)
{
    Console.WriteLine("Your Booking timd is: " + bookingTime);
    Console.WriteLine("Your Fare for the Flight is " + (fare * 1.05));
}
