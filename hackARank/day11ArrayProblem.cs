using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.IO.Pipes;

namespace hackARank
{


    class day11ArrayProblem
    {
        public static int maxHourGlassSum(int[][] arr, int startRow, int startCol)
        {
            int maxMidValue = arr[startRow + 1][startCol];
            int sumOfHourGlass = 0;
            for (int count = 0; count < 3; count++)
            {
                sumOfHourGlass += arr[startRow][startCol + count];
                if (maxMidValue < arr[startRow + 1][startCol + count])
                {
                    maxMidValue = arr[startRow + 1][startCol + count];
                }
                sumOfHourGlass += arr[startRow + 2][startCol + count];
            }

            return (maxMidValue + sumOfHourGlass);
        }


        public static void solution()
        {
            int[][] arr = new int[6][];


            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int maxValue = maxHourGlassSum(arr, 0, 0);

            for (int row = 0; row < arr.Length - 2; row++)
            {
                for (int col = 0; col < arr[row].Length - 2; col++)
                {
                    //maxValue = maxHourGlassSum(arr, row,col); 
                    if (maxValue < maxHourGlassSum(arr, row, col))
                    {
                        maxValue = maxHourGlassSum(arr, row, col);
                    }


                }
            }

            System.Console.WriteLine(maxValue);

            //System.Console.Read();






        }
    }



}

