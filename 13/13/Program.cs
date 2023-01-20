using System.Collections;
using System.Threading.Channels;

ArrayList flightNumbers = new ArrayList();

int index = 0;
int count = 0;

while (count == 0)
{
    Console.WriteLine("Press 1 to Enter");
    Console.WriteLine("Press 2 to Quit");
    int userResponse = int.Parse(Console.ReadLine()!);

    switch (userResponse)
    {
        case 1:
            Console.WriteLine("Enter Flight Number: ");
            int flightNumber = int.Parse(Console.ReadLine()!);
            flightNumbers.Add(flightNumber);
            index++;
            break;

        case 2:
            count = 1;
            break;
    }
}

//int i = 1;
//foreach(int flightNumber in flightNumbers)
//{
//    Console.WriteLine(i++  +". Flight Numbers are: " + flightNumber);
//}

for(int i = 0;i < flightNumbers.Count; i++)
{
    Console.Write(flightNumbers[i]+ " ");
}

