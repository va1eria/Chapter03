﻿using static System.Console;

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        WriteLine("Buzz");
    }
    else
    {
        WriteLine(i);
    }
}