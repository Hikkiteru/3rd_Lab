﻿using System;

namespace Laboratory_A2
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] array_a = new int[]{1, 2, 3, 4};
            int[] array_b = new int[]{10, 20, 30, 40, 50, 60, 70};
            int length_a = array_a.Length, length_b = array_b.Length;
            int k = 0, j = 0;
            int[] array_ans = new int[length_a + length_b];
            int i = 0;
            while (i != array_ans.Length)
            {
                if (k < length_a && j < length_b)
                {
                    array_ans[i] = array_a[k];
                    array_ans[i+1] = array_b[j];
                    i += 2;
                    k++;
                    j++;
                }
                else if (k < length_a)
                {
                    array_ans[i] = array_a[k];
                    i++;
                    k++;
                }
                else
                {
                    array_ans[i] = array_b[j];
                    i++;
                    j++;
                }
            }

            for (i = 0; i < array_ans.Length; i++)
            {
                Console.Write($"{array_ans[i]} ");
            }
            return 0;
        }
    }
}