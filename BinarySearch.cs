// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        while(left <= right)
        {
            int mid = (left + right) / 2;
            //check if x is present at mid 
            if(arr[mid] == x)
            {
                return mid;
            }
            
            //if x greater , ignore left half
            if(arr[mid] < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,10,40};
        int x = 100;
        int result = BinarySearch(arr,x);
        if(result != -1)
        {
            Console.WriteLine ($"Item Index {result}");
        }
        else
        {
            Console.WriteLine ("Item Not found");
        }
       
    }
}
