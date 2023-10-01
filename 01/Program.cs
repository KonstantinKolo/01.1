using System;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();      //O(n)
            int num = int.Parse(Console.ReadLine());                                    //O(1)

            bool isContained = false;                                                   //O(1)
            foreach(var item in arr)                                                    //O(n)                        
            {
                if (item == num)                                                        //O(1)
                {
                    Console.WriteLine("{0} Exists in List",item);                       //O(1)
                    isContained = true;                                                 //O(1)
                    break;                                                              //O(1)
                }
            }

            if(isContained == false)                                                    //O(1)
                Console.WriteLine("{0} Not exist in List",num);                         //O(1)

            //Complexity of program is O(n)
        }
    }
}
