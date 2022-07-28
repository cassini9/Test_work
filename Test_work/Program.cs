string[] StringArray = new string[] { "Monday", "Tuesday", "Planet", "Sun", "To", "Sunday", "456" };

void ShowArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

ShowArray(StringArray);

string[] ThreeCellElements(string[] array)
{
    string[] ArrayNew = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            ArrayNew[j] = array[i];
            j++;
        }
        else continue;

    }
    Console.WriteLine();
    return ArrayNew;
}

ShowArray(ThreeCellElements(StringArray));