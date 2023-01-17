DateTime birthDate = new DateTime();

Console.WriteLine("Enter your Date of Birth(yyyy-mm-dd): ");

DateTime.TryParse(Console.ReadLine(), out birthDate);

DateTime now = DateTime.Now;
TimeSpan time = now - birthDate;

double hours = time.TotalHours;
Console.WriteLine("Hours Lived= " + hours);

double days = time.TotalDays;
Console.WriteLine("Days Lived = " + days);

double weeks = days/ 7;
Console.WriteLine("Weeks Lived = " + weeks);

double months = days/ 30;
Console.WriteLine("Months Lived = " + months);

double years = days/ 365;
Console.WriteLine("Years Lived = " + years);

if((birthDate.Year) % 4 == 0)
{
    Console.WriteLine(" Birth Year is Leap Year");
}
else
{
    Console.WriteLine("Birth Year not a leap year");
}
