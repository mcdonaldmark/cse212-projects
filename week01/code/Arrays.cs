public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //return type of the method is array of double data type, so we are declaring the return variable with double[] datatype.
        double[] results = new double[length];

        for (int i = 1; i <= length; i++)
        {
            //instead of mod operation, you need to multiply the number and add to array.
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
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 2: Calculate the split point for the rotation.
        int splitIndex = data.Count - amount;

        // Step 3: Use GetRange to extract the two parts:
        List<int> rightPart = data.GetRange(splitIndex, amount); // last 'amount' elements
        List<int> leftPart = data.GetRange(0, splitIndex);       // the rest

        // Step 4: Clear the original list and add the two parts back in rotated order.
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);

        // Step 5: The original list is now rotated in-place.
    }
}
