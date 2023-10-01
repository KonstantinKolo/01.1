using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();     //O(n)
            inputList.Sort();                                                                   //O(n^2)
            int num = int.Parse(Console.ReadLine());                                            //O(1)

            List<int> finalList = new List<int>();                                              //O(1)

            for (int i = 0; i < inputList.Count; i++) {

            }

            foreach (var item in inputList) {                                                   //O(n)
                if(num < item) {                                                                //O(1)
                    finalList.Add(num);                                                         //O(1)
                }

                finalList.Add(item);                                                            //O(1)
            }

            Console.WriteLine(string.Join(" ",finalList));                                      //O(n)

            //Complexity of algorithm is O(n^2)
        }
    }
}
