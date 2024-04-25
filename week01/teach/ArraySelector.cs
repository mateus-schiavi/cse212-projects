public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    public static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int index1 = 0;
        int index2 = 0;
        int resultIndex = 0;

        int[] result = new int[list1.Length + list2.Length];

        foreach (int selector in select)
        {
            if (selector == 1)
            {
                result[resultIndex++] = list1[index1++];
            }
            else if (selector == 2)
            {
                result[resultIndex++] = list2[index2++];
            }
            else
            {
                throw new ArgumentException("Selector array should only contain 1s and 2s");
            }
        }
        return result;
    }

    public static char[] ListSelector(char[] list1, char[] list2, int[] select)
{
    // Initialize variables to track current index in each array and result array
    int index1 = 0;
    int index2 = 0;
    int resultIndex = 0;

    // Create a new array to store the result
    char[] result = new char[list1.Length + list2.Length];

    // Iterate through the selector array
    foreach (int selector in select)
    {
        // If selector is 1, select the next character from list1
        if (selector == 1)
        {
            // Add the character from list1 at index index1 to the result array
            result[resultIndex++] = list1[index1++];
        }
        // If selector is 2, select the next character from list2
        else if (selector == 2)
        {
            // Add the character from list2 at index index2 to the result array
            result[resultIndex++] = list2[index2++];
        }
        // If selector is neither 1 nor 2, it's an invalid input
        else
        {
            throw new ArgumentException("Selector array should only contain 1s and 2s.");
        }
    }

    // Return the result array
    return result;
}

}