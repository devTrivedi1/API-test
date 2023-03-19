using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ClassLibrary1
{
    public class API
    {
        public int AddNumbers(int a, int b)
        {
            return new Adder().AddManyNumbers(new int[2]{a, b});
        }

        
    }
    
}


//It's like calling it public for "Internal",
//you can only access it for now in the visual studio project itself, but not in unity