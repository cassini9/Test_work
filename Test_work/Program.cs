
string[] StringArray = new string[] { "Monday", "Tuesday", "Planet", "Sun", "To", "Sunday", "456" };

void ShowArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine();
    }

}

ShowArray(StringArray);

string[] ThreeCellElements(string[] array)
{
    string[] ArrayNew = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        ArrayNew[i] = array[i];
        else continue;
    }
    Console.WriteLine();
    return ArrayNew;
}

ShowArray(ThreeCellElements(StringArray));
