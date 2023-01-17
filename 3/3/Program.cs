double[] fare= new double[5];

// Storing Flight fares.
for (int i = 0; i < 5; i++)
{
    //Console.WriteLine("Enter fare " + i+1 );
    Console.Write($"Enter fare {i + 1} : ");
    fare[i] = Double.Parse(Console.ReadLine());
}

// fares in ascending order.

Array.Sort(fare);

Console.WriteLine("Fares in Ascending Order: ");

foreach (var sorted in fare)
{
    Console.WriteLine(sorted);
}

//fares on descending order.

Array.Reverse(fare);

Console.WriteLine("Fares in Descending Order: ");

foreach (var sorted in fare)
{
    Console.WriteLine(sorted);
}

Console.WriteLine("Minimun Fare: " + fare[fare.Length -1]);
Console.WriteLine("Maximum Fare: " + fare[0]);

// Input a fare and search.

Console.WriteLine("Enter a fare to search:-");
Double search = Double.Parse(Console.ReadLine());
int count = 0;
double found = 0;
for (var j = 0; j < fare.Length; j++)
{
    if (search == fare[j])
    {
        count++;
        found = fare[j];
    }
}
if (count != 0)
{
    Console.WriteLine("Fare Found: " + found);
}
else
{
    Console.WriteLine("Fare not Found");
}

// find duplicate.

bool found1 = false;

for (int i = 0; i < fare.Length; i++)
{
    for (int j = i + 1; j < fare.Length; j++)
    {
        if (fare[i] == fare[j])
        {
            found1 = true;
            Console.WriteLine("Duplicates Found are:");
            Console.WriteLine(fare[j]);
        }
    }
}
//if (index != 0)
//{
//    Console.WriteLine("Duplicate Found :");

//    foreach (var duplicate in list)
//    {
//        Console.WriteLine(duplicate);
//    }
//}
if(!found1)
{
    Console.WriteLine("No Duplicates");
}