string readResult;
bool valid = false;

Console.WriteLine("Enter your role name (Administrator, Manager, Or User)");
do
{
    readResult = Console.ReadLine().Trim().ToLower();

    switch (readResult)
    {
        case "administrator":
            valid = true;
            break;
        case "manager":
            valid = true;
            break;
        case "user":
            valid = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, Or User)");
            break;
    }

} while (valid == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");