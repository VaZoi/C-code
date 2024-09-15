String? readResult;
int number;
bool valid = false;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();
    bool validNumber = Int32.TryParse(readResult, out number);
    if (validNumber == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    } 
    else if (number <= 5 || number >= 10)
    {
        Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
    }
    else
    {
        valid = true;
    }

} while (valid == false);

Console.WriteLine($"Your input value ({number}) has been accepted.");