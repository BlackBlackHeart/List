﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> testList = new MyList<string>();

            testList.Add("one");
            testList.Add("two");
            testList.Add("three");
            testList.Add("four");
            testList.Add("five");
            testList.Add("six");
            testList.Add("seven");
            testList.Add("eight");

           // testList.PrintContents();

            testList.Remove("six");
            //testList.PrintContents();

            
            foreach (var s in testList)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
