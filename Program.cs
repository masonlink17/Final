Console.WriteLine("Enter birthday below:");
string dateInput = Console.ReadLine();
var parsedDate = DateTime.Parse(dateInput);
Console.WriteLine(parsedDate);

var age = DateTime.Now - parsedDate;
Console.WriteLine("You are " + Math.Truncate(age.TotalDays) + " days alive");


/*
if (parsedDate != int)
{
    Console.WriteLine("Invalid date, please try again");
}
*/