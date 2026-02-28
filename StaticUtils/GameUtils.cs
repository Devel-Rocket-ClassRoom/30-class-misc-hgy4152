using System;
using System.Collections.Generic;
using System.Text;

static class GameUtils
{

    public static int Clamp(int value, int min, int max)
    {
        return value > max ? max : value < min ? min : value;
    }

    public static string GetPercentage(int current, int max)
    {
        return $"{(current/(double)max) * 100:n0}%";    

    }

    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}