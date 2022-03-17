using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a = { 1, 2, 3 };
            //int[] b = a;

            //a[0] = 10;

            //Console.WriteLine(a[0]);
            //Console.WriteLine(b[0]);


            //int[] numbers = { 756, 12, 54, 134, 6, 75, 21 };

            //Console.WriteLine(numbers);

            //Bubble(numbers);


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int num1 = 12;
            //int num2;

            //ChangeNum(out num2);

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);


            //string toConvert = Console.ReadLine();
            //int num;

            //if (int.TryParse(toConvert,out num))
            //{
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("Yazdiginiz edede cevrile bilmir.");
            //}

            int[] numbers = { 756, 12, 54, 134, 6, 75, 21 };
            int average;
            Average(numbers, out average);

            Console.WriteLine(average);

        }

        static void Average(int[] mamed, out int mamed2)
        {
            int sum = 0;
            for (int i = 0; i < mamed.Length; i++)
            {
                sum += mamed[i];
            }

            mamed2 = sum / mamed.Length;
        }


        //static void ChangeNum(out int num)
        //{
        //    num = 91;
        //    num += 10;
        //    Console.WriteLine(num);
        //}
        //static void ChangeNum(ref int mamed)
        //{
        //    Console.WriteLine(mamed);
        //}


        //static void Bubble(int[] nums)
        //{
        //    int temp;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = 0; j < nums.Length - 1; j++)
        //        {
        //            if (nums[j] > nums[j + 1])
        //            {
        //                temp = nums[j + 1];
        //                nums[j + 1] = nums[j];
        //                nums[j] = temp;
        //            }
        //        }
        //    }
        //}
    }
}
