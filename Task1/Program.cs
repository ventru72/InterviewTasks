using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "aaabbccdddde";
            string compres = Task1.Compress(str);
            string decompres = Task1.Decompress(compres);

            int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6,7,8 }, {9,10,11,12 },  { 13, 14, 15, 16 } };
            int[,] arr3 = new int[5, 5] { { 1, 2, 3, 4 ,5 }, {  6,7,8, 9, 10 }, {11,12,13,14,15 },  {16, 17,18,19,20 }, { 21, 22, 23, 24, 25 } };
            int[,] arr4 = new int[4, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }  };
            List<int> resultDecompressMatrix = Task2__.DecomposeMatrix(arr3);
             Task2.Spiral(arr2);
        }
    }
}





