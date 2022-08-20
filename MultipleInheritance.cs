using System;
using System.Collections.Generic;
using System.Text;
using BasicTrainningSamples.IFaces;

namespace BasicTrainningSamples
{
    class MultipleInheritance: Interface1, Interface2
    {
        void Interface1.m1()
        {
            Console.WriteLine("m1 implemented for Interface1");
        }

        void Interface2.m1()
        {
            Console.WriteLine("m1 implemented for Interface2");
        }

        public void m1()
        {
            Console.WriteLine("m1 created for class");
        }
    }
}
