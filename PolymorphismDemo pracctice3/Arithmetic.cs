using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo_pracctice3
{
    internal class Arithmetic
    {
        public void Add()
        {
            Console.WriteLine("method with 0 argrument");
        }
        public void Add(int num1)
        {
            Console.WriteLine("Methods with 1 parameter");
        }
        public void Add(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two integers types value= " + result);
        }
        public void Add(float num1,float num2) 
        { 
           float result = num1 + num2;
            Console.WriteLine("Addition of two float types value=" + result);
        }
        public void Add(float num1,int num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one float value and one integers value=" + result);
        }
        public void Add(int num1 , float num2)
        {
           float result = num1 + num2;
            Console.WriteLine("Additio of one integer value and one float value=" + result);

        }
    }
}
