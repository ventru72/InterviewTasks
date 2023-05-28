using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Task2__
    {
        static int m = 0;
        static int n = 0;
        static int LenghtM = 0;
        static int LenghtN = 0;
        static int count = 0;
        static int x = 0;
        static int y = 0;
        static int iS = 0;
        static int iD = 0;
        static int jS = 0;
        static int jE = 0;
        static int end = 0;
        static int iLength = 0;
        static int jLength = 0;
        static int size = 0;
        static int sizeY = 0;


        static StringBuilder result = new StringBuilder();
        static List<int> listResult = new List<int>();
        public static List<int> DecomposeMatrix(int[,] arr)
        {

           
            int sizeArr = arr.GetLength(0) * arr.GetLength(1);
            int rMin = 0;
            int rMax = arr.GetLength(0) - 1;
            int cMin = 0;
            int cMax = arr.GetLength(1) - 1;
            int count = 1;
            int stop = sizeArr;
            int delta = Math.Abs(rMax - cMax);

            while (stop > 0)
            {
                //вниз

                for (int i = rMin; stop <= sizeArr && i <= cMax; i++)
                {
                    listResult.Add(arr[i, cMin]);
                    stop--;
                }
                //вправо


                cMin++;
                for (int i = cMin; stop <= sizeArr && i <= cMax; i++)
                {
                    listResult.Add(arr[rMax, i]);
                    stop--;
                }

                cMax--;
                //вверх
                for (int i = cMax; stop <= sizeArr && i >= rMin; i--)
                {
                    listResult.Add(arr[i, rMax]);
                    stop--;
                }

                //влево
                rMax--;
                for (int j = cMax; stop <= sizeArr && j >= cMin; j--)
                {
                    listResult.Add(arr[rMin, j]);
                    stop--;
                }
                rMin++;

            }


            return listResult;



        }

    }
}
