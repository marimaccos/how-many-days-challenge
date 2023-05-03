// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Solution to Programming Challenge for "How Many Days?"

string input = "";
DateTime today = DateTime.Now;

Console.WriteLine("Welcome to 'How Many Days?'");

do 
{
    Console.WriteLine("Which date? (or type 'exit' to quit)");
    input = Console.ReadLine();

    // if the user enters the term 'exit' then leave the app
    if (input.Equals("exit")) 
    {
        break;
    }

    DateTime parseDate;
    TimeSpan timeSpan;

    // try to parse the date
    if (DateTime.TryParse(input, out parseDate)) 
    {
        // if the date already went by, indicate how many days ago it was
        if (parseDate < today)
        {
            timeSpan = today - parseDate;
            Console.WriteLine($"That date went by {timeSpan.Days} days ago!");
        }
        // if the date hasn't yet happened, indicate how many days until it does
        else if (parseDate > today)
        {
            timeSpan = parseDate - today;
            Console.WriteLine($"That date will be in {timeSpan.Days} days!");
        }
        else
        {
            Console.WriteLine($"That date is today!");
        }

    // If the user didn't enter a valid date, then print an error message
    } 
    else
    {
       Console.WriteLine("Invalid date!"); 
    }

} while (input != "exit");



