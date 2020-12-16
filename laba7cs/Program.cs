using System;

namespace laba7cs
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, p, q, maxElem;
            int[] arrayFirst, arrayRes;

            Console.WriteLine("Input count of elements of the array (n)...");
            n = getNatural();
            Console.WriteLine("Input denominator (p)...");
            p = getNatural();
            Console.WriteLine("Input remainder (q)...");
            q = getNatural();

            Console.WriteLine($"=================");
            arrayFirst = genArray(n);
            outputArray(arrayFirst);
            maxElem = findMaxElement(arrayFirst);
            Console.WriteLine($"max element is {maxElem}");
            arrayRes = changeElements(arrayFirst, maxElem, p, q);
            outputArray(arrayRes);

            Console.ReadKey();
        }

        static int getNatural()
        {
            int num = int.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("Input a natural number!");
                num = int.Parse(Console.ReadLine());
            }
            return num;
        }

        static int[] genArray(int elemCount)
        {
            int[] newArray = new int[0];
            Random r = new Random();
            for(int i = 0; i<elemCount; i++)
            {
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[i] = r.Next(-5, 5);
            }
            return newArray;
        }

        static int findMaxElement(int[] myArray)
        {
            int maxElement = myArray[0];
            for(int i = 0; i< myArray.Length; i++)
            {
                if(myArray[i]> maxElement)
                {
                    maxElement = myArray[i];
                }
            }
            return maxElement;
        }

        static int powTo2(int num)
        {
            return num*num;
        }

        static int[] changeElements(int[] myArray, int element, int divided, int remainder)
        {
            for (int i = 0; i<myArray.Length; i++)
            {
                if (Math.Abs(myArray[i] % divided) == remainder)
                {
                    myArray[i] = powTo2(element);
                }
            }
            return myArray;
        }

        static void outputArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("====================");
        }
    }
}
