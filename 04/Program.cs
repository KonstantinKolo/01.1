using System;
using System.Collections.Generic;
using System.Linq;

namespace _04 {
    class Program {
        static void Main(string[] args)
        {
            try {
                List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  //O(n)

                int sum = 0;                                                                //O(1)
                foreach (var item in list) {                                                //O(n)
                    sum += item;                                                            //O(1)
                }

                double average = Convert.ToDouble(sum) / Convert.ToDouble(list.Count);      //O(1)

                Console.WriteLine("Sum={0}; Average={1:F2}", sum, average);                 //O(1)
            }
            catch {
                Console.WriteLine("Sum=0; Average=0.00");                                   //O(1)
            }

            //Complexity of algorithm is O(n)
        }
    }
}
