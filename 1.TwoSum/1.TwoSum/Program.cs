using System;
using System.Collections.Generic;

namespace TwoSumProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi kaç elemanlı giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aranan toplamı giriniz:");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine($"Dizinin {i}. elemanını giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] sonuc = TwoSum(dizi, target);

            if (sonuc.Length == 2)
            {
                Console.WriteLine($"Sonuç: [{sonuc[0]}, {sonuc[1]}]");
            }
            else
            {
                Console.WriteLine("İstenen toplamı sağlayan iki eleman bulunamadı.");
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            return new int[0];
        }
    }
}
