﻿using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                stack.Push(c);
            }
            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}
            Console.WriteLine(String.Join("",stack));
        }
    }
}
