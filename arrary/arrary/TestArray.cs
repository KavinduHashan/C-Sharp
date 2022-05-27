using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class TestArray
    {
        public void MyArray()
        {
            //declaration
            int[] array = new int[10];
            int i;

            //input
            for (i = 0; i < 10; i++)
            {
                Console.Write("Enter value for array ({0} index) : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
