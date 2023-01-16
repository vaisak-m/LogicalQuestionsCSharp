string?[] passName = new string[5];

for(int i = 0;i < 5; i++)
{
    Console.WriteLine("Enter the names of passengers:- ");
    passName[i] = Console.ReadLine();
}
// Alphabetic Order

Array.Sort(passName);

Console.WriteLine("Passenger names in Alphabetic Order");

foreach (var name in passName){
    Console.WriteLine(name);
}

//Reverse Order.

Array.Reverse(passName);

Console.WriteLine("Passenger names in Reverse Order");

foreach (var name in passName) {
    Console.WriteLine(name); 
}

// Input a name and search.

Console.WriteLine("Enter a name to search:-");
var search = Console.ReadLine();
var count = 0;
string? found = " found";
for (var j = 0; j < passName.Length; j++)
{
    if (search == passName[j])
    {
        count++;
        found = passName[j];
        break;
    }
}
if (count != 0)
{
    Console.WriteLine("Passenger Found: " + found);
}
else
{
    Console.WriteLine("Passenger not Found");
}

// length of elements of array.

foreach (var findLength in passName)
{
    Console.WriteLine(findLength.Length);
}

// split elements at space.

foreach (var split in passName)
{
    var array = split.Split(" ");

    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

// to find duplicates.

var index = 0;
string dupli = "dupli";

for (var i = 0;i < passName.Length; i++)
{
    for( var j = i; j < passName.Length; j++)
    {
        if (passName[i] == passName[j]) 
        {
            index++;
            dupli = passName[j];
        }
    }
}
if(index != 0)
{
    Console.WriteLine("Duplicate Found :" + dupli);
}
else
{
    Console.WriteLine("No Duplicates");
}