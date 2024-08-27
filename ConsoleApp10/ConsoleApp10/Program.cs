//string message = "Find what is (inside the parentheses)";

//int opeingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(")");

//string message = "What is the value <span>between the tags</span>?";

//const string openSpan = "<span>";
//const string closeSpan = "</span>";

//int openingPosition = message.IndexOf(openSpan);
//int closingPosition = message.IndexOf(closeSpan);

//openingPosition += openSpan.Length;

////Console.WriteLine(opeingPosition);
////Console.WriteLine(closingPosition);

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));


//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    message = message.Substring(closingPosition + 1);
//}


//string message = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {message}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 5;
//int openingPosition = message.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

//openingPosition = message.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");


//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//char[] openSymbols = { '[', '{', '(' };

//int closingPosition = 0;

//while (true)
//{
//    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//    if (openingPosition == -1) break;

//    string currentSymbol = message.Substring(openingPosition, 1);

//    char matchingSymbol = ' ';

//    switch (currentSymbol)
//    {
//        case "[":
//            matchingSymbol = ']';
//            break;
//        case "{":
//            matchingSymbol = '}';
//            break;
//        case "(":
//            matchingSymbol = ')';
//            break;
//    }

//    openingPosition += 1;
//    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//}


//string data = "12345John Smith          5000  3  ";
//string updatedData = data.Remove(5, 20);
//Console.WriteLine(updatedData);


//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closedSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closedPosition = input.IndexOf(closedSpan);

openingPosition += openSpan.Length;
int length = closedPosition - openingPosition;
quantity = input.Substring(openingPosition, length);


Console.WriteLine($"Quantity: {quantity}");

output = input.Remove(0, 5);
output = output.Remove(41, 6);
output = output.Replace("&trade;", "&reg;");
Console.WriteLine($"Output: {output}");