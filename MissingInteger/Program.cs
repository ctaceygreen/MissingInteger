using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        HashSet<int> numbersInA = new HashSet<int>();
        foreach(var item in A)
        {
            numbersInA.Add(item);
        }

        int number = 1;
        bool found = false;
        while(!found)
        {
            if(!numbersInA.Contains(number))
            {
                return number;
            }
            number++;
        }
        return 0;
    }
}