using System;

namespace cs
{
    class Program
    {
        static int getNums(int[] nums ){
            int max=nums[0];
            foreach(int i in nums)
            if(i>max)
            max=i;
            return max;
        }
        static void Main(string[] args)
        {int[] nums={23,8,41,4};
            Console.WriteLine(getNums(nums));
        }
    }
}
