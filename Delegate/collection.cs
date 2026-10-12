using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Collection
    {
        public static void Main()
        {
            // crreating an object of collection
            ArrayList obj = new ArrayList();
            //Adding element into collertion
            obj.Add("rku");
            obj.Add(110);
            obj.Add(152.85);
            obj.Add('x');
            obj.Add(true);
            //fetching the number of element into a collection 
            Console.WriteLine("number of element:" + obj.Count);
            //removing an element by value from a colletion 
            obj.Remove("rku");
            //traversing a collection element by element 
            foreach (object str in obj)
                Console.WriteLine(str + "  ");
            Console.ReadKey();
        }
    }
}