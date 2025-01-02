namespace Name
{
    class Linq
    {
        static void Where()
        {
            int[] nums = {1,2,3,4,5,6,7,8,9,10};

            var numsImpar = nums.Where(n => n % 2 != 0);

            foreach (var item in numsImpar)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}