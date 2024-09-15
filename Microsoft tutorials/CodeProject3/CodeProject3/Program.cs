string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string mystring = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    mystring = myStrings[i];
    periodLocation = mystring.IndexOf('.');

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = mystring.Remove(periodLocation);
        mystring = mystring.Substring(periodLocation + 1).TrimStart();
        periodLocation = mystring.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = mystring.Trim();
    Console.WriteLine(mySentence);
}