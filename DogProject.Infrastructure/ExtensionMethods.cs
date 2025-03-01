namespace DogProject;

public static class ExtensionMethods
{
    public static List<string> BubbleSortByNameAndLength(this List<string> listOfDogNames)
    {
        List<string> list = listOfDogNames;
        int n = list.Count;
        bool swapped;
        for (int i = 0; i < n; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((list[j][0].CompareTo( list[j + 1][0]) > 0) || 
                    list[j][0].CompareTo( list[j + 1][0]) == 0 && 
                    list[j].Length > list[j + 1].Length)
                {
                    string temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                    swapped = true;
                }
            }
        }

        return list;
    }
}