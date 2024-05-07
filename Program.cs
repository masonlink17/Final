
using System.Net;

while (true)
{
    if (DateTime TryParse(response, out ValueType birthday))
    {
        var response = Console.ReadLine();
        string dateInput = response;
        var parsedDate = DateTime.Parse(dateInput);
        Console.WriteLine(parsedDate);
        break;
    }
    else
    {
        continue;
    }

}