using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.ArrayAndLists
{
    partial class EntryPoint
    {
        public class User
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Gender { get; set; }

            public Vitz1999[] vitzCars { get; set; }

            public User()
            {
                vitzCars = new Vitz1999[5];
            }
        }


        public static void Main()
        {
            User[] users = new User[10];

            for (int i = 0; i < 10; i++)
            {
                users[i] = new User() { Name = string.Format("user{0}", i), Address = "Karachi", Gender = "Male" };
                Console.WriteLine("[{3}] User Name: {0}, Address: {1}, Gender: {2}", users[i].Name, users[i].Address, users[i].Gender, i);

                for (int j = 0; j < 5; j++)
                {
                    users[i].vitzCars[j] = new Vitz1999();

                    Console.WriteLine("[{3},{4}]=Engine: {0}, Steering: {1}, Brakes: {2}", users[i].vitzCars[j].engine, users[i].vitzCars[j].steering, users[i].vitzCars[j].brakes, i, j);
                }

            }

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

            int t = arr[2]; //Accessing third variable of an array in a single clock cycle

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

            //Assignments:
            // make single dimensional array of 10 elements and take input from user and print all taken values to screen.
            // make two dimensional array of 10 elements and take input from user and print all taken values to screen.

            #region Addition/Delete in arrays
            //It must not be coded
            //Addition at the end/start of an array (Append)
            /*
            int[] arr1 = new int[100000];
            int[] arr2 = new int[100000 + 10];

            for (int i = 0; i < 100000; i++)
            {
                arr2[i] = arr1[i];
            }

            arr1 = null;
            arr2[100000] = 54;

            //Deletion at the end of an array
            int[] arr3 = new int[100000];
            int[] arr4 = new int[100000 - 10];

            for (int i = 0; i < 100000 - 10; i++)
            {
                arr4[i] = arr3[i];
            }

            arr3 = null;

            //Addition at the 50th position of an array (Append)
            int[] arr5 = new int[100];
            int[] arr6 = new int[101];

            for (int i = 0; i < 50; i++)
            {
                arr6[i] = arr5[i];
            }

            arr6[50] = 21; //new element

            for (int i = 50; i < 100; i++)
            {
                arr6[i + 1] = arr5[i];
            }

            //Deletion at the 50th position of an array (Append)
            int[] arr7 = new int[100];
            int[] arr8 = new int[99];

            for (int i = 0; i < 50; i++)
            {
                arr8[i] = arr7[i];
            }

            for (int i = 51; i < 100; i++)
            {
                arr8[i] = arr7[i];
            }

            arr7 = null;
            Console.ReadLine();
            */
            #endregion

            #region Link List
            /*
            LList list = new LList();
            //Link List
            int nodeCounter = 0;
            while (list.node.next != null)
            {
                Node node = list.node;

                if (nodeCounter == 3)
                {
                    //Third Node's next pointer is pointeed towards new node
                    Node newNode = new Node() { data = 69 };

                    //newNode.next = thirdNode.next.next;
                    newNode.next = node.next.next; // 4th node
                    node.next = newNode;
                    break;
                }

                node = node.next;

                nodeCounter++;
            }


            //get particular at particular position in list
            nodeCounter = 0;
            while (list.node.next != null)
            {
                Node node = list.node;
                if (nodeCounter < 50000)
                {
                    Console.WriteLine(node.data);
                    break;
                }

                node = node.next;
            }

            Console.WriteLine(arr1[50000]);
            */
            #endregion

            //In case of Arrays addition/deletion is costly but reading/getting is efficient
            //Where as in case of list addition/deletion is effecient but reading/getting is costly
        }

        class Node
        {
            public object data { get; set; }
            public Node next { get; set; }
        }

        class LList
        {
            public Node node { get; set; }
        }
    }
}