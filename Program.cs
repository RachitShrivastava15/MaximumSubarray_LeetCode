 namespace MaximumSubarray
 {
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
            int result = MaxSubArray(nums);
            Console.WriteLine(result);
        }

        public static int MaxSubArray(int[] nums) {
            int size = nums.Length;
            int max = 0,
                max_ending = 0;
            
            for (int i =0; i < size; i++)
            {
                max_ending = max_ending + nums[i];
                if(max < max_ending)
                    max = max_ending;
                if(max_ending < 0)
                    max_ending = 0;
            }
            return max;
        }
    }
 }