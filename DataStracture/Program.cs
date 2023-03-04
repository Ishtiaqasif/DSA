namespace DataStracture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 1, 2, 3, 1 };

            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (keyValues.ContainsKey(num))
                {
                    keyValues[num]++;

                    if(keyValues[num]>1)
                        Console.WriteLine(true);
                }
                else
                {
                    keyValues.Add(num, 0);
                }
            }
        }
    }
}