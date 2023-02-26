namespace TwoSum
{
    public class StartUp
    {

        public static void Main()
        {
            int[] nums = new int[3] { 3, 2, 3 };
            int target = 6;
            Console.WriteLine(TwoSum(nums, target)); 
        }

        public static int[] TwoSum(int[] nums, int target)
        {           
            //int saveFirstIndex = 0;
            //int saveSecondIndex = 0;
            int[] output = new int[2];
            bool pairFound = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                       // saveFirstIndex = i;
                       // saveSecondIndex = j;
                        pairFound = true;
                        break;
                    }
                }
                
                if (pairFound)
                {
                    break;
                }
            }

            //Console.WriteLine($"[{output[0]},{output[1]}]");
            return output;
        }
    }
}
        


