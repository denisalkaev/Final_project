Console.Clear();

string[] CreateArray(string text)
{
    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
    string[] result = text.Split(delimiterChars);
    result = result.Where(x => x.Length <= 3).ToArray();

    return result;
}

Console.Write("Input text: ");
string N = Console.ReadLine()!;
string[] res = CreateArray(N);
Console.WriteLine($"Result: {string.Join(", ", res)}");