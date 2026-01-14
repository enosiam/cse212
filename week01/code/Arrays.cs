using System;
using System.Collections.Generic;

public static class Arrays
{
    // ===============================
    // Part 1: MultiplesOf
    // ===============================
    // This function generates an array of multiples of a starting number.
    // Inputs:
    //   start - the base number to multiply
    //   count - how many multiples to generate
    // Output:
    //   A double array containing the multiples
    public static double[] MultiplesOf(double start, int count)
    {
        // Step 1: Create an array to hold the multiples
        double[] multiples = new double[count];

        // Step 2: Loop from 0 to count-1
        for (int i = 0; i < count; i++)
        {
            // Step 3: Each element is the start multiplied by (i+1)
            multiples[i] = start * (i + 1);
        }

        // Step 4: Return the completed array
        return multiples;
    }

    // ===============================
    // Part 2: RotateListRight
    // ===============================
    // This function rotates a list to the right by the given amount.
    // Inputs:
    //   data   - list of integers to rotate
    //   amount - how many positions to rotate to the right
    // Output:
    //   None (the list is modified in-place)
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: If the list is null or empty, do nothing
        if (data == null || data.Count == 0)
            return;

        // Step 2: Reduce amount using modulo
        amount %= data.Count;
        if (amount == 0)
            return;

        // Step 3: Copy the last 'amount' elements
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 4: Remove them from the end
        data.RemoveRange(data.Count - amount, amount);

        // Step 5: Insert them at the beginning
        data.InsertRange(0, tail);
    }
}
