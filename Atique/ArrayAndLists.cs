using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.ArrayAndLists
{
    class EntryPoint
    {
        public static void Main()
        {
            /*Array:-
             * 1-We can create many variables of the same type in RAM with one name
             * 2-All the variables are created in contigious memory locations.
             * 3-Because all the variables are in contigous memory locations thats why we can run loop on its index to iterate each variable.
             * 4-Array Notation:- 
             *      int a = arrayname[index]; //reading
             *      arrayname[2] = 10; //writing
             * 5-Data access in single clock cycle of CPU.
             * 6-Array should be used when you have constant number of variables. Means you cannot change the size of an array. Means array cannot grow on runtime.
             * 7-So array should only be used when the data is not growing at runtime and only requirement is to access(read/write) the data at particular index, because you cannot change the size of an array, bcz we are not sure that next location which must be contigous is vacant.
             * 8-So array should be used when data access is the requirement but not growing.. bcz data access in array is performed in one clock cycle.
            */

            int a = 10;
            int b = 5;

            #region 1D Array
            int[] arr = new int[10];// Single Dimensional Array or 1D array

            //Assignment and reading via loop on index
            for (int i = 0; i < 10; i++) //looping on index of an array
            {
                arr[i] = 5; // assigning/writing value to array
                Console.WriteLine("[{0}] = {1}", i, arr[i]); //read array variable via index
            }

            int t = arr[2]; //Accessing third variable of an array

            Vitz1999[] arrVitz = new Vitz1999[10]; // It means we have 10 vitz1999 objects in memory, on contigous locations
            // on compile time it will calculate the size of single object of Vitz1999 and allocate block size of 10 variables in RAM.

            arr[3] = 10; //assigning the value or changing the value of 4th variable of array

            int[] intArray2 = new int[5] { 11, 21, 30, 45, 52 };// Declaration and assignment both
            #endregion

            #region 2D Array
            int[,] d2 = new int[4, 2]; // We have 4 single dimensional arrays and each array has a single dimensional array of 2 elements
            //if 1D means one loop, if 2D means 2 nested loops, if 3D means 3 nested loops, if n dimentions means n nested loops

            int[,] intarray = new int[4, 2] //Declaration and initialization both
            {
                { 56, 45 },
                { 30, 48 },
                { 52, 61 },
                { 73, 98 }
            };


            //d2[0, 0] = 21;
            //d2[0, 1] = 22;

            //d2[1, 0] = 56;
            //d2[1, 1] = 71;

            //Assignment and reading via loop on index
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    d2[i, j] = 51;
                    Console.WriteLine("[{0},{1}] = {2}", i, j, d2[i, j]); //d2[i, j] reading each variable or element of an array
                }
            }
            #endregion

            # region 3D Array
            int[,,] d3 = new int[4, 1, 2]; // It means it has 4 single dimensional arrays each has single dimensional array of 2 elements

            int[,,] intArray3Dd = new int[2, 2, 3]
            { //[0] 
                {
                 //[0]
                    { 1, 2, 3 }, 
                  //{[0],[1],[2]}

                 //[1]
                    { 4, 5, 6 }
                  //{[0],[1],[2]}
                },
                                                  
              //[1] 
                {
                 //[0]
                    { 1, 2, 3 }, 
                  //{[0],[1],[2]}

                 //[1]
                    { 4, 5, 6 }
                  //{[0],[1],[2]}
                },
            };

            //Assignment and reading via loop on index
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("[{0},{1},{2}] = {3}", i, j, k, intArray3Dd[i, j, k]);
                    }
                }
            }

            //d3[0, 0, 0] = 40;
            //d3[0, 0, 1] = 40;


            //Assignment and reading via loop on index
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        d3[i, j, k] = 45;
                        Console.WriteLine("[{0},{1},{2}] = {3}", i, j, k, d3[i, j, k]);
                    }
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
