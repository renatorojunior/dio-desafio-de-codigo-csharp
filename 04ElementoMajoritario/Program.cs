using System;

public class DIO
{
    // Implementando solução para encontrar o elemento mais frequente no array.
    public static void Main(String[] args)
    {
        Console.WriteLine("Quantos elementos compõem o grupo?");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        Console.WriteLine("Quais elemetos pertencem ao grupo?");
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"O elemento mais frequente no grupo é o {elementoMajoritario(nums, n)}.");
    }

    public static int elementoMajoritario(int[] nums, int n)
    {
        int maxcount = 0;
        int major = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }

            if (count > maxcount)
            {
                maxcount = count;
                major = nums[i];
            }
        }

        return major;
    }   
}