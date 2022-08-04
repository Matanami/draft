using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int fine = 0 ;
        int[] acReturnDate = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToArray();
        int[] exReturnDate = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToArray();
        int[] dif = { acReturnDate[0] - exReturnDate[0], acReturnDate[1] - exReturnDate[1], acReturnDate[2] - exReturnDate[2] };
        // not in the same year
        if (dif[2] > 0)
        {
            fine = 10000;
        }
        //in the same year but not in the same monthe
        else if (dif[1] > 0 && dif[2] == 0)
        {
            fine += dif[1] * 500;
        }
        //same monthe
        else if (dif[1] == 0 && dif[0] > 0)
        {
            fine += dif[0] * 15;
        }
        //befor time

        Console.WriteLine(fine);



    }
}