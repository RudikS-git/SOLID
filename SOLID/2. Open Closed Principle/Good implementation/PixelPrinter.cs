﻿using System;

namespace SOLID._2._Open_Closed_Principle.Good_implementation
{
    public class PixelPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Pixel - {text}");
        }
    }
}
