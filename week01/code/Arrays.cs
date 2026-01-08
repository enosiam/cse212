using System;
using System.Collections.Generic;

namespace Week01
{
    public class Arrays
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
        //   A new list of integers rotated as requested
        public static List<int> RotateListRight(List<int> data, int amount)
        {
            // Step 1: Create a new list to hold the rotated result
            List<int> rotated = new List<int>();

            // Step 2: Calculate the starting index for rotation
            // If data.Count = 9 and amount = 5, startIndex = 9 - 5 = 4
            int startIndex = data.Count - amount;

            // Step 3: Add the "end portion" first (the part that wraps around)
            rotated.AddRange(data.GetRange(startIndex, amount));

            // Step 4: Add the "beginning portion" next
            rotated.AddRange(data.GetRange(0, startIndex));

            // Step 5: Return the rotated list
            return rotated;
        }
    }
}
