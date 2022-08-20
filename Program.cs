﻿using j = java.lang;
using System;
using System.Text;
using BasicTrainningSamples.IFaces;

namespace BasicTrainningSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 2147483647;

            Console.WriteLine(num1);
            Console.WriteLine("Hello World!");

            String s1 = "Geeks";
            s1 = concat1(s1); // s1 is not changed
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Geeks");
            concat2(s2); // s2 is changed
            Console.WriteLine("Using StringBuilder Class: " + s2);

            // :: :: StringBuilderVSStringBuffer :: :: //
            StringBuilderVSStringBuffer();

            // Constructor
            // If a class has a ctor that takes in params
            // we can not create object for that class without passing params.
            //class1 obj1 = new class1(); it thoows error as the parameter ctor is not available 

            class1 obj1 = new class1(1);


            // :: :: Multile inheritance using Interfaces :: :: //
            Interface1 Io1 = new MultipleInheritance();
            Interface2 Io2 = new MultipleInheritance();
            MultipleInheritance mulInherObj = new MultipleInheritance();

            Io1.m1();
            Io1.m2();
            Io2.m1();
            mulInherObj.m1();

            Console.WriteLine("Hello World!");
        }


        // :: ::  String VS StringBuilder :: :: //
        public static string concat1(String s1)
        {

            // taking a string which
            // is to be Concatenate
            String st = "forGeeks";

            // using String.Concat method
            // you can also replace it with
            // s1 = s1 + "forgeeks";
            s1 = String.Concat(s1, st);
            return s1;
        }

        // Concatenates to StringBuilder
        public static void concat2(StringBuilder s2)
        {

            // using Append method
            // of StringBuilder class
            s2.Append("forGeeks");
        }

        // :: :: String Builder VS String Buffer :: :: //

        public static void StringBuilderVSStringBuffer() {
            long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond; 
            j.StringBuffer strbuff = new j.StringBuffer("Dark");
            for (int i = 0; i < 10000; i++)
            {
                strbuff.append("Night");
            }
            Console.WriteLine("Time taken by StringBuffer: " + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - startTime) + "ms");
            startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            StringBuilder strbuild = new StringBuilder("Dark");
            for (int i = 0; i < 10000; i++)
            {
                strbuild.Append("Night");
            }
            Console.WriteLine("Time taken by StringBuilder: " + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - startTime) + "ms");
        }


    }

    class class1
    {
        public class1(int a)
        {
        }
    }
}
