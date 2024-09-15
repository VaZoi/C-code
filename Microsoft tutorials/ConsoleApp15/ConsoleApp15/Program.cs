//double total = 0;
//double minimumSpend = 30.00;

//double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

//for (int i = 0; i < items.Length; i++)
//{
//    total += GetDiscountedPrice(i);
//}
//if (TotalMeetsMinimum())
//{
//    total -= 5.00;
//}

//Console.WriteLine($"Total: ${FormatDecimal(total)}");

//double GetDiscountedPrice(int itemIndex)
//{
//    // Calculate the discounted price of the item
//    return items[itemIndex] * (1 - discounts[itemIndex]); ;
//}

//bool TotalMeetsMinimum()
//{
//    // Check if the total meets the minimum
//    return total >= minimumSpend;
//}

//string FormatDecimal(double input)
//{
//    // Format the double so only 2 decimal places are displayed
//    return input.ToString().Substring(0, 5);
//}



//double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD = ${vnd} VND");
//Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

//int UsdToVnd(double usd)
//{
//    int rate = 23500;
//    return (int)(rate * usd);
//}

//double VndToUsd(int vnd)
//{
//    double rate = 23500;
//    return vnd / rate;
//}



//string input = "snake";
//string input2 = "there are snakes at the zoo";

//Console.WriteLine(input);
//Console.WriteLine(ReverseWord(input));
//Console.WriteLine(input2);
//Console.WriteLine(ReverseSentence(input2));

//string ReverseWord(string word)
//{
//    string result = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}

//string ReverseSentence(string input)
//{
//    string result = "";
//    string[] words = input.Split(" ");

//    foreach (string word in words)
//    {
//        result += ReverseWord(word) + " ";
//    }
//    return result.Trim();
//}


//string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

//Console.WriteLine("Is it a palindrome?");
//foreach (string word in words)
//{
//    Console.WriteLine($"{word}: {IsPalindrome(word)}");
//}

//bool IsPalindrome(string word)
//{
//    int start = 0;
//    int end = word.Length -1;

//    while (start < end)
//    {
//        if (word[start] != word[end])
//        {
//            return false;
//        }
//        start++;
//        end--;
//    }

//    return true;
//}


//int target = 80;
//int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
//int[,] result = TwoCoins(coins, target);

//if (result.Length == 0 )
//{
//    Console.WriteLine("No two coins make change");
//}
//else
//{
//    Console.WriteLine($"Change found at positions:");
//    for (int i = 0; i < result.GetLength(0); i++ )
//    {
//        if (result[i, 0] == -1)
//        {
//            break;
//        }
//        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//    }
//}

//int[,] TwoCoins(int[] coins, int target)
//{
//    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//    int count = 0;
//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                result[count, 0] = curr;
//                result[count, 1] = next;
//                count++;
//            }
//            if (count == result.GetLength(0))
//            {
//                return result;
//            }
//        }
//    }
//    return (count == 0) ? new int[0, 0] : result;
//}


//Random random = new Random();

//Console.WriteLine("Would you like to play? (Y/N)");
//string? answer = Console.ReadLine().Trim();
//if (ShouldPlay(answer))
//{
//    PlayGame();
//}

//bool ShouldPlay(string answer)
//{
//    if (answer == "Y")
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//void PlayGame()
//{
//    var play = true;

//    while (play)
//    {
//        var target = random.Next(1, 6);
//        var roll = random.Next(1, 7);

//        Console.WriteLine($"Roll a number greater than {target} to win!");
//        Console.WriteLine($"You rolled a {roll}");
//        Console.WriteLine(WinOrLose(target, roll));
//        Console.WriteLine("\nPlay again? (Y/N)");
//        answer = Console.ReadLine().Trim();
//        play = ShouldPlay(answer);
//    }
//}

//string WinOrLose(int target, int roll)
//{
//    if (roll > target)
//    {
//        return "You win!";
//    }
//    else
//    {
//        return "You lose!";
//    }
//}



//string[] pettingZoo =
//{
//    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
//};

//PlanSchoolVisit("School A");
//PlanSchoolVisit("School B", 3);
//PlanSchoolVisit("School C", 2);

//void PlanSchoolVisit(string schoolName, int groups = 6)
//{
//    RandomizeAnimals();
//    string[,] group = AssignGroup(groups);
//    Console.WriteLine(schoolName);
//    PrintGroup(group);
//}
//void RandomizeAnimals()
//{
//    Random random = new Random();
//    for (int i = 0; i < pettingZoo.Length; i++)
//    {
//        int r = random.Next(i, pettingZoo.Length);

//        string temp = pettingZoo[i];
//        pettingZoo[i] = pettingZoo[r];
//        pettingZoo[r] = temp;
//    }

//}

//string[,] AssignGroup(int groups = 6)
//{
//    string[,] result = new string[groups, pettingZoo.Length/groups];
//    int start = 0;

//    for (int i = 0; i < groups; i++)
//    {
//        for (int j = 0; j < result.GetLength(1); j++)
//        {
//            result[i, j] = pettingZoo[start++];
//        }
//    }

//    return result;
//}

//void PrintGroup(string[,] group)
//{
//    for (int i = 0; i < group.GetLength(0); i++)
//    {
//        Console.Write($"Group {i + 1}: ");
//        for(int j = 0;j < group.GetLength(1); j++)
//        {
//            Console.Write($"{group[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}



using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit)
{
    if (TerminalResized())
    {
        Console.Clear();
        Console.Write("Console was resized. Program exiting.");
        shouldExit = true;
    }
    else
    {
        if (PlayerIsFaster())
        {
            Move(1, false);
        }
        else if (PlayerIsSick())
        {
            FreezePlayer();
        }
        else
        {
            Move(otherKeysExit: false);
        }
        if (GotFood())
        {
            ChangePlayer();
            ShowFood();
        }
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Returns true if the player location matches the food location
bool GotFood()
{
    return playerY == foodY && playerX == foodX;
}

// Returns true if the player appearance represents a sick state
bool PlayerIsSick()
{
    return player.Equals(states[2]);
}

// Returns true if the player appearance represents a fast state
bool PlayerIsFaster()
{
    return player.Equals(states[1]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false)
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX -= speed;
            break;
        case ConsoleKey.RightArrow:
            playerX += speed;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
        default:
            // Exit if any other keys are pressed
            shouldExit = otherKeysExit;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}