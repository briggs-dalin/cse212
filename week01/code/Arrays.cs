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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // There are a double and int as parameters
        // Create an array for multiples

        double[] mult = new double[length];

        // With a for bucle interate the length for the multiples
        for (int i = 0; i < length; i++)
        {
            // Set the operation of multiples by the length
            mult[i] = number * (i + 1);
         }

        // Return result
        return mult; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // There are a List<int> and int
        // First calculate the rotate amount is the correct amount
        int rotateAmount = amount % data.Count;


        // Create a list for the rotate
        List<int> rotate = new List<int>(data.Count);

        // Add the element after the rotation into the List rotate and then the new one, using AddRange and GetRange
        rotate.AddRange(data.GetRange(data.Count - rotateAmount, rotateAmount));
        rotate.AddRange(data.GetRange(0, data.Count - rotateAmount));

        // In the list of data change it with the rotate List
        data.Clear();
        data.AddRange(rotate);

    }
}
