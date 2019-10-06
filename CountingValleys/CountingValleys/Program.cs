using System.IO;
using System;
class Solution
{
    //// Complete the countingValleys function below.
    //static int CountingValleys(int n, string s)
    //{
    //    int ValleyCount = 0;
    //    int AltitudeCount = 0;
    //    for (int c = 0; c < s.Length; c++)
    //    {
    //        if (s[c] == 'D')
    //        {
    //            AltitudeCount--;
    //        }
    //        else if (s[c] == 'U')
    //        {
    //            AltitudeCount++;
    //        }
    //        Console.WriteLine("Altitude Count: " + AltitudeCount);
    //        if (AltitudeCount == -1 && s[c] + 1 == 'U')
    //        {
    //            ValleyCount++;
    //        }
    //        Console.WriteLine("Valley Count: " + ValleyCount);
    //    }
    //    return ValleyCount;
    //}
    // Complete the countingValleys function below.


    static int CountingValleys(int n, string s)
    {
        int ValleyCount = 0;
        int AltitudeCount = 0;
        for (int c = 0; c < s.Length; c++)
        {
            if (s[c] == 'D')
            {
                AltitudeCount--;
            }
            else if (s[c] == 'U')
            {
                AltitudeCount++;
            }
            //Had to break out of the loop early, so we did not throw an error due to trying to access the not existent c+1 position
            if ((c + 1) == s.Length)
            {
                break;
            }
            //Ended up just checking the ASCII code because thats what I was receving instead of a char
            if (AltitudeCount == -1 && s[c + 1] == 85)
            {
                ValleyCount++;
            }
        }
        return ValleyCount;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Total number of Valleys: " + CountingValleys(8, "UDDDUDUU"));
    }
}