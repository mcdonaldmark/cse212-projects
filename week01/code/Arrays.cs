public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
  
    /// Step 1: Pass on the double array "results" to be an array that goes by "length" for the size of the multiples. 
    /// Step 2: Create the condition with a starting value of 1 that increments until it reaches the array length (length being specified by the user). We won't start with 0 in the multiple list.
    /// Step 3: With the iterator set at 1, I cannot use the results[1] as that will indicate the incorrect position so I needed to do result[i - 1] so that the array starts at index 0.
    /// Step 4: Set the results[i - 1] (index) to equal the number used for the multiple and multiply it by the iterator (i)
    /// Step 5: Return the result of the multiple array.
    public static double[] MultiplesOf(double number, int length)
    {
        double[] results = new double[length];

        for (int i = 1; i <= length; i++)
        {
            results[i - 1] = (number * i);
        }
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>

    /// Step 1: First I will do a split where we count the data that's inside the list and then subtract how far we move the data to the right. 
    /// Step 2: Get the range of the split (index) portion that is on the right of the data being split. This will create a new list with only that data that is on the right.
    /// Step 3: Get the range of the remaining portion by starting at index 0 up to the split location. This will create a new list with only that data that is on the left.
    /// Step 4: From there, clear the original list, add the right range first (since we are rotating to the right), and then add the left range. 
    public static void RotateListRight(List<int> data, int amount)
    {
        int split = data.Count - amount;

        List<int> right = data.GetRange(split, amount);
        List<int> left = data.GetRange(0, split);

        data.Clear();
        data.AddRange(right);
        data.AddRange(left);
    }
}
