using System;
using System.Collections.Generic;
using System.Linq;

namespace _03 {
    class Program {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  //O(n)
            List<int> sortedList = list;                                                //O(n)
            sortedList.Sort();                                                          //O(n^2)
            int num = int.Parse(Console.ReadLine());


            bool isContained = false;                                                   //O(1)
            foreach (var item in list)                                                  //O(n)                        
            {
                if (item == num)                                                        //O(1)
                {
                    Console.WriteLine("{0} Exists in List", item);                      //O(1)
                    isContained = true;                                                 //O(1)
                    break;                                                              //O(1)
                }
            }

            if (isContained == false)                                                    //O(1)
                Console.WriteLine("{0} Not exist in List", num);                         //O(1)

            //Complexity of algorithm is O(n^2)
        }
    }

}
