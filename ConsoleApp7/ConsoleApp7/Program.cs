string pangram = "The quick brown fox jumps over the lazy dog";

char[] strings = pangram.ToCharArray();

Array.Reverse(strings);

string result = String.Join("", strings);
string[] items = result.Split(' ');

Array.Reverse(items);

string final = String.Join(' ', items);

Console.WriteLine(final);